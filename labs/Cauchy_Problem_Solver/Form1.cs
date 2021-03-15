using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cauchy_Problem_Solver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            s3ode.Text = $"x\u0307 = x - y - z\ny\u0307 = x + y\nz\u0307 = 3x + z";
            init_conditions.Text = $"x\u2080 = -2\ny\u2080 =  7\nz\u2080 =  1";
            exact_sol.Text = $"x(t) = -2 * e^t * (2 * sin(2t) + cos(2t))\n" +
                $"y(t) = e^t * (5 + 2 * cos(2t) - sin(2t))\n" +
                $"z(t) = e^t * (-5 + 6 * cos(2t) - 3 * sin(2t))";
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            grid.Visible = false;
            x_t.Visible = false;
            y_t.Visible = false;
            z_t.Visible = false;
            buttonDraw.Enabled = true;

            dataGridViewResult.Rows.Clear();
            dataGridViewResult.Columns.Clear();
            dataGridViewResult.Visible = true;

            Sample_S3ODE s4 = new Sample_S3ODE();

            double a = Convert.ToDouble(A.Text);
            double b = Convert.ToDouble(B.Text);
            int steps = (int)Convert.ToDouble(steps_count.Text);
            
            var res = RK4Method.Solve(s4, a, b, steps, new double[4] { -2, 7, 1, 0 });

            dataGridViewResult.Columns.Add("№", "№");
            dataGridViewResult.Columns.Add("x", "x");
            dataGridViewResult.Columns.Add("y", "y");
            dataGridViewResult.Columns.Add("z", "z");
            dataGridViewResult.Columns.Add("t", "t");
            dataGridViewResult.Rows.Add(res.Count);
            for (int i = 0; i < res.Count; i++)
            {
                dataGridViewResult.Rows[i].Cells["№"].Value = i + 1;
                dataGridViewResult.Rows[i].Cells["x"].Value = $"{res[i][0]:0.####}";
                dataGridViewResult.Rows[i].Cells["y"].Value = $"{res[i][1]:0.####}";
                dataGridViewResult.Rows[i].Cells["z"].Value = $"{res[i][2]:0.####}";
                dataGridViewResult.Rows[i].Cells["t"].Value = $"{res[i][3]:0.####}";
            }

            buttonDraw.Enabled = true;
        }

        private void A_Leave(object sender, EventArgs e)
        {
            buttonSolve.Enabled = (A.Text != "") && (B.Text != "")
                && (steps_count.Text != "")
                && (Convert.ToDouble(A.Text) < Convert.ToDouble(B.Text))
                && ((int)Convert.ToDouble(steps_count.Text) > 1);
        }

        private void B_Leave(object sender, EventArgs e)
        {
            buttonSolve.Enabled = (A.Text != "") && (B.Text != "")
                && (steps_count.Text != "")
                && (Convert.ToDouble(A.Text) < Convert.ToDouble(B.Text))
                && ((int)Convert.ToDouble(steps_count.Text) > 1);
        }

        private void steps_count_Leave(object sender, EventArgs e)
        {
            buttonSolve.Enabled = (A.Text != "") && (B.Text != "")
                && (steps_count.Text != "")
                && (Convert.ToDouble(A.Text) < Convert.ToDouble(B.Text))
                && ((int)Convert.ToDouble(steps_count.Text) > 1);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            buttonDraw.Enabled = false;
            dataGridViewResult.Visible = false;
            grid.Visible = true;
            x_t.Visible = true;
            y_t.Visible = true;
            z_t.Visible = true;

            String curr_series = "x";
            if (x_t.Checked) curr_series = "x";
            if (y_t.Checked) curr_series = "y";
            if (z_t.Checked) curr_series = "z";

            int size = dataGridViewResult.RowCount;


            /////// rk4 solution ///////
            double[] X = new double[size];
            double[] Y = new double[size];
            double[] Z = new double[size];
            double[] T = new double[size];
            int idx = 0;

            int rk4_idx = grid.Series.IndexOf($"rk4_{curr_series}");
            if (rk4_idx != -1)
                grid.Series.RemoveAt(rk4_idx);

            grid.Series.Add($"rk4_{curr_series}");
            grid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grid.Series[1].Color = Color.Red;
            grid.Series[1].BorderWidth = 2;

            foreach (DataGridViewRow row in dataGridViewResult.Rows)
            {
                X[idx] = Convert.ToDouble(row.Cells[1].Value.ToString());
                Y[idx] = Convert.ToDouble(row.Cells[2].Value.ToString());
                Z[idx] = Convert.ToDouble(row.Cells[3].Value.ToString());
                T[idx] = Convert.ToDouble(row.Cells[4].Value.ToString());
                idx++;
            }


            ////// exact solution //////
            double[] X_exact = new double[size];
            double[] Y_exact = new double[size];
            double[] Z_exact = new double[size];

            int exact_idx = grid.Series.IndexOf($"exact_{curr_series}");
            if (exact_idx != -1)
                grid.Series.RemoveAt(exact_idx);

            grid.Series.Add($"exact_{curr_series}");
            grid.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grid.Series[2].Color = Color.Green;
            grid.Series[2].BorderWidth = 2;

            for (int i = 0; i < size; i++)
            {
                double t = T[i];
                X_exact[i] = Math.Exp(t) * (-4 * Math.Sin(2 * t) - 2 * Math.Cos(2 * t));
                Y_exact[i] = Math.Exp(t) * (5 + 2 * Math.Cos(2 * t) - Math.Sin(2 * t));
                Z_exact[i] = Math.Exp(t) * (-5 + 6 * Math.Cos(2 * t) - 3 * Math.Sin(2 * t));
            }


            if (curr_series == "x")
                for (int i = 0; i < size; i++)
                {
                    grid.Series[1].Points.AddXY(T[i], X[i]);
                    grid.Series[2].Points.AddXY(T[i], X_exact[i]);
                }

            if (curr_series == "y")
                for (int i = 0; i < size; i++)
                {
                    grid.Series[1].Points.AddXY(T[i], Y[i]);
                    grid.Series[2].Points.AddXY(T[i], Y_exact[i]);
                }

            if (curr_series == "z")
                for (int i = 0; i < size; i++)
                {
                    grid.Series[1].Points.AddXY(T[i], Z[i]);
                    grid.Series[2].Points.AddXY(T[i], Z_exact[i]);
                }
        }

        private void x_t_CheckedChanged(object sender, EventArgs e)
        {
            if (x_t.Checked)
            {
                grid.Series.RemoveAt(1);
                grid.Series.RemoveAt(1);
                buttonDraw_Click(sender, e);
            }
        }

        private void y_t_CheckedChanged(object sender, EventArgs e)
        {
            if (y_t.Checked)
            {
                grid.Series.RemoveAt(1);
                grid.Series.RemoveAt(1);
                buttonDraw_Click(sender, e);
            }
        }

        private void z_t_CheckedChanged(object sender, EventArgs e)
        {
            if (z_t.Checked)
            {
                grid.Series.RemoveAt(1);
                grid.Series.RemoveAt(1);
                buttonDraw_Click(sender, e);
            }
        }
    }
}
