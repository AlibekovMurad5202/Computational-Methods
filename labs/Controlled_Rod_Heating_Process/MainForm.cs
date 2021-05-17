using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controlled_Rod_Heating_Process
{
    public partial class MainForm : Form
    {
        bool isPartAVisible = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            grid.Series[0].Points.Clear();
            grid.Series[1].Points.Clear();
            grid.Series[2].Points.Clear();

            double L = Convert.ToDouble(L_textBox.Text);
            double T = Convert.ToDouble(T_textBox.Text);
            double h = Convert.ToDouble(h_textBox.Text);
            double tau = Convert.ToDouble(tau_textBox.Text);
            
            int x_steps_count = Convert.ToInt32(L / h) + 1;
            int t_steps_count = Convert.ToInt32(T / tau) + 1;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = x_steps_count + t_steps_count * (2 * x_steps_count);
            progressBar1.Step = 1;
            
            Functions.L = L;
            Functions.b_0 = Convert.ToDouble(b_0_textBox.Text);
            Functions.b_1 = Convert.ToDouble(b_1_textBox.Text);
            Functions.b_2 = Convert.ToDouble(b_2_textBox.Text);
            Functions.phi_1 = Convert.ToDouble(phi_1_textBox.Text);
            Functions.phi_2 = Convert.ToDouble(phi_2_textBox.Text);

            
            Stopwatch time = new Stopwatch();
            time.Start();
            double[,] heatGridB = HeatGrid.CalcB(L, T, h, tau, Functions.phi, Functions.b, ref progressBar1);
            time.Stop();
            
            double heatGridB_time = time.Elapsed.TotalMilliseconds;

            time_label.Text = $"{heatGridB_time / 1000:0} s " +
                $" {heatGridB_time % 1000:000} ms";
            

            grid.ChartAreas[0].AxisX.Minimum = 0;
            grid.ChartAreas[0].AxisX.Maximum = L;
            for (int i = 0; i < x_steps_count; i++)
            {
                grid.Series[0].Points.AddXY(i * h, heatGridB[i, 0]);
            }
            
            for (int i = 0; i < x_steps_count; i++)
            {
                grid.Series[1].Points.AddXY(i * h, heatGridB[i, t_steps_count - 1]);
            }

            partASolution_btn.Enabled = true;
        }

        private void partASolution_btn_Click(object sender, EventArgs e)
        {
            if (isPartAVisible == false)
            {
                isPartAVisible = true;
                partASolution_btn.Text = "Скрыть решение части А";

                double L = Convert.ToDouble(L_textBox.Text);
                double T = Convert.ToDouble(T_textBox.Text);
                double h = Convert.ToDouble(h_textBox.Text);
                double tau = Convert.ToDouble(tau_textBox.Text);

                Stopwatch time = new Stopwatch();
                time.Start();
                double[,] heatGridA = HeatGrid.CalcA(L, T, h, tau, Functions.phi, Functions.b, ref progressBar1);
                time.Stop();

                double heatGridA_time = time.Elapsed.TotalMilliseconds;

                time_label.Text = $"{heatGridA_time / 1000:0} s " +
                    $" {heatGridA_time % 1000:000} ms";
                
                int x_steps_count = Convert.ToInt32(L / h) + 1;
                int t_steps_count = Convert.ToInt32(T / tau) + 1;
                for (int i = 0; i < x_steps_count; i++)
                {
                    grid.Series[2].Points.AddXY(i * h, heatGridA[i, t_steps_count - 1]);
                }
            }
            else
            {
                isPartAVisible = false;
                partASolution_btn.Text = "Показать решение части А";
                grid.Series[2].Points.Clear();
            }
        }
    }
}
