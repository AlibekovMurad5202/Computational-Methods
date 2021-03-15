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
            init_conditions.Text = $"x\u2080 = \ny\u2080 = \nz\u2080 = ";
            exact_sol.Text = $"x(t) = e^t * (-4 * sin(2t) - 2 * cos(2t))\n" +
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

            double t_0 = Convert.ToDouble(t_init_cond.Text);
            double x_0 = Convert.ToDouble(x_init_cond.Text);
            double y_0 = Convert.ToDouble(y_init_cond.Text);
            double z_0 = Convert.ToDouble(z_init_cond.Text);

            Sample_S3ODE s4 = new Sample_S3ODE();

            double a = Convert.ToDouble(A.Text);
            double b = Convert.ToDouble(B.Text);
            int steps = (int)Convert.ToDouble(steps_count.Text);
            
            var res = RK4Method.Solve(s4, a, b, steps, new double[4] { x_0, y_0, z_0, t_0 });

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
            
            double t_0 = Convert.ToDouble(t_init_cond.Text);
            double x_0 = Convert.ToDouble(x_init_cond.Text);
            double y_0 = Convert.ToDouble(y_init_cond.Text);
            double z_0 = Convert.ToDouble(z_init_cond.Text);

            double C_1 = Math.Exp(-t_0) / 4 * (3 * y_0 - z_0);
            double C_2 = Math.Exp(-t_0) / 4 * ((z_0 + y_0) * Math.Cos(2 * t_0) - 2 * x_0 * Math.Sin(2 * t_0));
            double C_3 = Math.Exp(-t_0) / 4 * ((z_0 + y_0) * Math.Sin(2 * t_0) + 2 * x_0 * Math.Cos(2 * t_0));

            for (int i = 0; i < size; i++)
            {
                double t = T[i];
                X_exact[i] = Math.Exp(t) * (-2 * C_2 * Math.Sin(2 * t) + 2 * C_3 * Math.Cos(2 * t));
                Y_exact[i] = Math.Exp(t) * (C_1 + C_2 * Math.Cos(2 * t) + C_3 * Math.Sin(2 * t));
                Z_exact[i] = Math.Exp(t) * (-C_1 + 3 * C_2 * Math.Cos(2 * t) + 3 * C_3 * Math.Sin(2 * t));
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

        private void t_init_cond_TextChanged(object sender, EventArgs e)
        {
            rename_exact_solution();
        }

        private void rename_exact_solution()
        {
            if ((t_init_cond.Text != "") && (x_init_cond.Text != "")
                && (y_init_cond.Text != "") && (z_init_cond.Text != ""))
            {
                double t_0 = Convert.ToDouble(t_init_cond.Text);
                double x_0 = Convert.ToDouble(x_init_cond.Text);
                double y_0 = Convert.ToDouble(y_init_cond.Text);
                double z_0 = Convert.ToDouble(z_init_cond.Text);

                double C_1 = Math.Exp(-t_0) / 4 * (3 * y_0 - z_0);
                double C_2 = Math.Exp(-t_0) / 4 * ((z_0 + y_0) * Math.Cos(2 * t_0) - 2 * x_0 * Math.Sin(2 * t_0));
                double C_3 = Math.Exp(-t_0) / 4 * ((z_0 + y_0) * Math.Sin(2 * t_0) + 2 * x_0 * Math.Cos(2 * t_0));

                String x_t = $"x(t) = e^t * ({-2 * C_2:0.#} * sin(2t) "
                    + (Math.Sign(2 * C_3) == 1 ? $"+ {Math.Abs(2 * C_3):0.#} "
                    : (Math.Sign(2 * C_3) == -1 ? $"- {Math.Abs(2 * C_3):0.#} " : " "))
                    + $"* cos(2t))\n";

                String y_t = $"y(t) = e^t * ({C_1:0.#} "
                    + (Math.Sign(C_2) == 1 ? $"+ {Math.Abs(C_2):0.#} * cos(2t) "
                    : (Math.Sign(C_2) == -1 ? $"- {Math.Abs(C_2):0.#} * cos(2t) " : ""))
                    + (Math.Sign(C_3) == 1 ? $"+ {Math.Abs(C_3):0.#} * sin(2t))\n"
                    : (Math.Sign(C_3) == -1 ? $"- {Math.Abs(C_3):0.#} * sin(2t))\n" : "\n"));


                String z_t = $"z(t) = e^t * ({-C_1:.#} "
                    + (Math.Sign(3 * C_2) == 1 ? $"+ {Math.Abs(3 * C_2):0.#} * cos(2t) "
                    : (Math.Sign(3 * C_2) == -1 ? $"- {Math.Abs(3 * C_2):0.#} * cos(2t) " : ""))
                    + (Math.Sign(3 * C_3) == 1 ? $"+ {Math.Abs(3 * C_3):0.#} * sin(2t))\n"
                    : (Math.Sign(3 * C_3) == -1 ? $"- {Math.Abs(3 * C_3):0.#} * sin(2t))\n" : "\n"));

                exact_sol.Text = x_t + y_t + z_t;
            }
        }

        private void x_init_cond_TextChanged(object sender, EventArgs e)
        {
            rename_exact_solution();
        }

        private void y_init_cond_TextChanged(object sender, EventArgs e)
        {
            rename_exact_solution();
        }

        private void z_init_cond_TextChanged(object sender, EventArgs e)
        {
            rename_exact_solution();
        }

        private void t_init_cond_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(t_init_cond.Text) > Convert.ToDouble(A.Text))
                buttonSolve.Enabled = false;
            else buttonSolve.Enabled = true;
        }
    }
}
