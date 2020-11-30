using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace Cubic_Spline_Interpolation
{
    public partial class MainForm : Form
    {
        static public List<double> x_coords;
        static public List<double> y_coords;

        public MainForm()
        {
            InitializeComponent();
            x_coords = new List<double>();
            y_coords = new List<double>();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void RemoveAllPoints()
        {
            x_coords.Clear();
            y_coords.Clear();
            info_box.Items.Clear();
            info_box.Items.Add("Текущий набор точек: ");
            info_box.Items.Add(" ");
            grid.Series[0].Points.Clear();
            grid.Series[0].Points.AddXY(0.00001, 0);
            grid.Series[0].Points[0].IsEmpty = true;
            int spline_idx = grid.Series.IndexOf("spline");
            if (spline_idx != -1)
                grid.Series.RemoveAt(spline_idx);
            spline.Enabled = false;
        }

        private void AddPoint(double x_coord, double y_coord)
        {
            int idx = x_coords.IndexOf(x_coord);
            if (idx != -1)
            {
                y_coords[idx] = y_coord;
                foreach (var point in grid.Series[0].Points)
                    if (point.XValue == x_coord)
                    {
                        grid.Series[0].Points.Remove(point);
                        break;
                    }
                grid.Series[0].Points.AddXY(x_coord, y_coord);
            }
            else
            {
                bool isAdded = false;
                for (int i = 0; i < x_coords.Count; i++)
                    if (x_coord < x_coords[i])
                    {
                        x_coords.Insert(i, x_coord);
                        y_coords.Insert(i, y_coord);
                        isAdded = true;
                        break;
                    }
                if (!isAdded)
                {
                    x_coords.Add(x_coord);
                    y_coords.Add(y_coord);
                }
                grid.Series[0].Points.AddXY(x_coord, y_coord);
            }
            if (x_coords.Count > 1)
                spline.Enabled = true;
        }

        private void SavingCoefficients(double[,] coeffs, double[] x)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Saving a cubic spline interpolation coefficients",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName != "")
            {
                StreamWriter stream = new StreamWriter(saveFile.FileName, false, System.Text.Encoding.Default);
                stream.WriteLine("\tCUBIC SPLINE INTERPOLATION COEFFICIENTS:\n");
                for (int i = 0; i < x.Length - 1; i++)
                    stream.WriteLine(
                        $"[{x[i]:0.##}..{x[i + 1]:0.##}]:  " +
                        $"(a={coeffs[i, 0]:0.###})  " +
                        $"(b={coeffs[i, 1]:0.###})  " +
                        $"(c={coeffs[i, 2]:0.###})  " +
                        $"(d={coeffs[i, 3]:0.###})"
                    );
                stream.Close();
            }
        }

        private void SavingImage(double[,] coeffs)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Saving an image of cubic spline interpolation",
                Filter = "JPEG (*.jpeg)|*.jpeg" +
                               "|PNG (*.png)|*.png" +
                               "|BMP (*.bmp)|*.bmp" +
                               "|GIF (*.gif)|*.gif" +
                               "|TIFF (*.tiff)|*.tiff"
            };

            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName != "")
            {
                switch (saveFile.FilterIndex)
                {
                    case 1:
                        grid.SaveImage(saveFile.FileName, ChartImageFormat.Jpeg);
                        break;
                    case 2:
                        grid.SaveImage(saveFile.FileName, ChartImageFormat.Png);
                        break;
                    case 3:
                        grid.SaveImage(saveFile.FileName, ChartImageFormat.Bmp);
                        break;
                    case 4:
                        grid.SaveImage(saveFile.FileName, ChartImageFormat.Gif);
                        break;
                    case 5:
                        grid.SaveImage(saveFile.FileName, ChartImageFormat.Tiff);
                        break;
                }
            }
        }

        private void add_point_btn_Click(object sender, EventArgs e)
        {
            double x_coord = Convert.ToDouble(X.Text);
            double y_coord = Convert.ToDouble(Y.Text);
            this.AddPoint(x_coord, y_coord);

            info_box.Items.Clear();
            info_box.Items.Add("Текущий набор точек: ");
            info_box.Items.Add(" ");
            int k = 0;
            foreach (var point in grid.Series[0].Points)
                if (!point.IsEmpty)
                    info_box.Items.Add($"{++k}: ({point.XValue:0.##}; {point.YValues[0]:0.##}) ");
        }

        private void remove_all_points_btn_Click(object sender, EventArgs e)
        {
            this.RemoveAllPoints();
        }

        private void remove_last_point_btn_Click(object sender, EventArgs e)
        {
            if (grid.Series[0].Points.Count > 1)
            {
                var last_point = grid.Series[0].Points.Last();
                grid.Series[0].Points.RemoveAt(grid.Series[0].Points.Count - 1);
                int idx = x_coords.IndexOf(last_point.XValue);
                x_coords.RemoveAt(idx);
                y_coords.RemoveAt(idx);

                info_box.Items.Clear();
                info_box.Items.Add("Текущий набор точек: ");
                info_box.Items.Add(" ");
                int k = 0;
                foreach (var point in grid.Series[0].Points)
                    if (!point.IsEmpty)
                        info_box.Items.Add($"{++k}: ({point.XValue:0.##}; {point.YValues[0]:0.##}) ");
            }
            int spline_idx = grid.Series.IndexOf("spline");
            if (spline_idx != -1)
                grid.Series.RemoveAt(spline_idx);
            if (x_coords.Count < 2)
                spline.Enabled = false;
        }

        private void spline_Click(object sender, EventArgs e)
        {
            /*
            double[] x = { 0, 1, 2, 3, 4 };
            double[] y = { 1, 3, 1, 4, 2 };
            */
            double[] x = x_coords.ToArray();
            double[] y = y_coords.ToArray();

            CubicSpline spline = new CubicSpline(x.Length);
            double[,] coeffs = spline.SetCoefficients(x, y);

            int spline_idx = grid.Series.IndexOf("spline");
            if (spline_idx != -1)
                grid.Series.RemoveAt(spline_idx);

            grid.Series.Add("spline");
            grid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grid.Series[1].MarkerBorderWidth = 2;
            grid.Series[1].MarkerSize = 2;

            for (int i = 0; i < x.Length - 1; i++)
                for (double dx = 0; dx < x[i + 1] - x[i]; dx += 0.01)
                    grid.Series[1].Points.AddXY(x[i] + dx,
                        coeffs[i, 0]
                      + coeffs[i, 1] * dx
                      + coeffs[i, 2] * dx * dx / 2
                      + coeffs[i, 3] * dx * dx * dx / 6);

            if (saving_coeffs.Checked)
            {
                this.SavingCoefficients(coeffs, x);
            }

            if (saving_image.Checked)
            {
                this.SavingImage(coeffs);
            }
        }

        private void set_points_btn_CheckedChanged(object sender, EventArgs e)
        {
            add_point_btn.Enabled = true;
            remove_last_point_btn.Enabled = true;
            this.RemoveAllPoints();
        }

        private void random_points_btn_CheckedChanged(object sender, EventArgs e)
        {
            add_point_btn.Enabled = false;
            remove_last_point_btn.Enabled = false;
            this.RemoveAllPoints();

            int count = 8;
            Random random = new Random();
            for (int i = 0; i < count; i++)
                this.AddPoint(-10 + 20 * random.NextDouble(), -7 + 14 * random.NextDouble());
            
            info_box.Items.Clear();
            info_box.Items.Add("Текущий набор точек: ");
            info_box.Items.Add(" ");
            int k = 0;
            foreach (var point in grid.Series[0].Points)
                if (!point.IsEmpty)
                    info_box.Items.Add($"{++k}: ({point.XValue:0.##}; {point.YValues[0]:0.##}) ");
        }
    }
}
