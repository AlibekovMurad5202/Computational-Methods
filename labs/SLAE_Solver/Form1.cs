using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SLAE_Solver
{
    public partial class Form1 : Form
    {
        int size = 2;
        double[,] matrix;
        double[] b;
        double[] x;
        
        public Form1()
        {
            InitializeComponent();

            dataGridViewMatrix.RowCount = size;
            dataGridViewMatrix.ColumnCount = size;

            dataGridViewVector.RowCount = size;
            dataGridViewResult.RowCount = size;

            foreach (DataGridViewColumn column in dataGridViewMatrix.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn column in dataGridViewVector.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn column in dataGridViewResult.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int oldSize = size;
            if (comboBoxSize.SelectedIndex + 2 < oldSize)
            {
                for (int i = 0; i < oldSize - comboBoxSize.SelectedIndex - 2; ++i, size--)
                {
                    dataGridViewMatrix.Rows.RemoveAt(size - 1);
                    dataGridViewMatrix.Columns.RemoveAt(size - 1);

                    dataGridViewVector.Rows.RemoveAt(size - 1);
                    dataGridViewResult.Rows.RemoveAt(size - 1);
                }
            }
            else if (comboBoxSize.SelectedIndex + 2 > oldSize)
            {
                for (int i = 0; i < comboBoxSize.SelectedIndex - oldSize + 2; ++i, size++)
                {
                    dataGridViewMatrix.Rows.Add();
                    dataGridViewMatrix.Columns.Add("", "");

                    dataGridViewVector.Rows.Add();
                    dataGridViewResult.Rows.Add();
                }
            }
            
            for (int i = 0; i < size; i++)
                dataGridViewResult.Rows[i].Cells[0].Value = "";

            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";
        }

        private double SLAETime(double[,] matrix, double[] b, SLAESolvingMethod method)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            double[] solution = method.Solve(matrix, b);
            time.Stop();

            for (int i = 0; i < size; i++)
                dataGridViewResult.Rows[i].Cells[0].Value = solution[i];

            return time.Elapsed.TotalSeconds;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    dataGridViewMatrix.Rows[i].Cells[j].Value = "";

                dataGridViewVector.Rows[i].Cells[0].Value = "";
                dataGridViewResult.Rows[i].Cells[0].Value = "";
            }

            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";
        }

        private void buttonGauss_Click(object sender, EventArgs e)
        {
            matrix = new double[size, size];
            b = new double[size];
            x = new double[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }
            
            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";
            
            try
            {
                int length = matrix.GetLength(0);
                double[,] newMatrix = new double[length, length];
                Array.Copy(matrix, newMatrix, length * length);
                if (SLAESolvingMethod.Determinant(newMatrix) == 0)
                    throw new Exception("Matrix A doesn't satisfy the conditions!");
                labelGaussTime.Text = SLAETime(matrix, b, new GaussMethod()).ToString("F8");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCramer_Click(object sender, EventArgs e)
        {
            matrix = new double[size, size];
            b = new double[size];
            x = new double[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";

            try
            {
                int length = matrix.GetLength(0);
                double[,] newMatrix = new double[length, length];
                Array.Copy(matrix, newMatrix, length * length);
                if (SLAESolvingMethod.Determinant(newMatrix) == 0)
                    throw new Exception("Matrix A doesn't satisfy the conditions!");
                labelCramerTime.Text = SLAETime(matrix, b, new CramerMethod()).ToString("F8");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSeidel_Click(object sender, EventArgs e)
        {
            matrix = new double[size, size];
            b = new double[size];
            x = new double[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";

            try
            {
                if (SLAESolvingMethod.IsDiagonalityDominance(ref matrix) == false)
                    throw new Exception("Matrix A doesn't satisfy the conditions!");
                labelSeidelTime.Text = SLAETime(matrix, b, new SeidelMethod()).ToString("F8");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonIterative_Click(object sender, EventArgs e)
        {
            matrix = new double[size, size];
            b = new double[size];
            x = new double[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";

            try
            {
                if (SLAESolvingMethod.IsDiagonalityDominance(ref matrix) == false)
                    throw new Exception("Matrix A doesn't satisfy the conditions!");
                labelIterativeTime.Text = SLAETime(matrix, b, new SimpleIterationMethod()).ToString("F8");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRelaxation_Click(object sender, EventArgs e)
        {
            matrix = new double[size, size];
            b = new double[size];
            x = new double[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";

            try
            {
                if (SLAESolvingMethod.IsDiagonalityDominance(ref matrix) == false)
                    throw new Exception("Matrix A doesn't satisfy the conditions!");
                labelRelaxationTime.Text = SLAETime(matrix, b, new UpperRelaxationMethod()).ToString("F8");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonLU_Click(object sender, EventArgs e)
        {
            matrix = new double[size, size];
            b = new double[size];
            x = new double[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }
            
            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";

            try
            {
                int length = matrix.GetLength(0);
                double[,] newMatrix = new double[length, length];
                Array.Copy(matrix, newMatrix, length * length);
                if (SLAESolvingMethod.Determinant(newMatrix) == 0)
                    throw new Exception("Matrix A doesn't satisfy the conditions!");
                labelLUTime.Text = SLAETime(matrix, b, new LUDecompositionMethod()).ToString("F8");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            matrix = new double[size, size];
            b = new double[size];
            x = new double[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            try
            {
                int length = matrix.GetLength(0);
                double[,] newMatrix = new double[length, length];
                Array.Copy(matrix, newMatrix, length * length);
                if ((SLAESolvingMethod.IsDiagonalityDominance(ref matrix) == false) || 
                    (SLAESolvingMethod.Determinant(newMatrix) == 0))
                    throw new Exception("Matrix A doesn't satisfy the conditions!");

                labelLUTime.Text = SLAETime(matrix, b, new LUDecompositionMethod()).ToString("F8");
                labelRelaxationTime.Text = SLAETime(matrix, b, new UpperRelaxationMethod()).ToString("F8");
                labelIterativeTime.Text = SLAETime(matrix, b, new SimpleIterationMethod()).ToString("F8");
                labelSeidelTime.Text = SLAETime(matrix, b, new SeidelMethod()).ToString("F8");
                labelCramerTime.Text = SLAETime(matrix, b, new CramerMethod()).ToString("F8");
                labelGaussTime.Text = SLAETime(matrix, b, new GaussMethod()).ToString("F8");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            matrix = new double[size, size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                double new_value = 0.0;
                for (int j = 0; j < size; j++)
                {
                    new_value = random.Next(-10, 10);
                    dataGridViewMatrix.Rows[i].Cells[j].Value = new_value;
                    matrix[i, j] = new_value;
                }
                
                new_value = 10 * size + random.Next(1, 10);
                dataGridViewMatrix.Rows[i].Cells[i].Value = new_value;
                matrix[i, i] = new_value;
            }
            
            double[] b = new double[size];
            for (int i = 0; i < size; i++)
            {
                dataGridViewVector.Rows[i].Cells[0].Value = random.Next(-10, 10);
                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }
            
            for (int i = 0; i < size; i++)
                dataGridViewResult.Rows[i].Cells[0].Value = "";

            labelGaussTime.Text = "0";
            labelCramerTime.Text = "0";
            labelSeidelTime.Text = "0";
            labelIterativeTime.Text = "0";
            labelRelaxationTime.Text = "0";
            labelLUTime.Text = "0";
        }
    }
}
