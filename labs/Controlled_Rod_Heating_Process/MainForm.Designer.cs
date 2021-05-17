namespace Controlled_Rod_Heating_Process
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.b_0_textBox = new System.Windows.Forms.TextBox();
            this.init_conditions = new System.Windows.Forms.Label();
            this.b_1_textBox = new System.Windows.Forms.TextBox();
            this.b_2_textBox = new System.Windows.Forms.TextBox();
            this.phi_2_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phi_1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.partASolution_btn = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.L_textBox = new System.Windows.Forms.TextBox();
            this.T_textBox = new System.Windows.Forms.TextBox();
            this.h_textBox = new System.Windows.Forms.TextBox();
            this.tau_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.time_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // b_0_textBox
            // 
            this.b_0_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.b_0_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_0_textBox.Location = new System.Drawing.Point(789, 9);
            this.b_0_textBox.Name = "b_0_textBox";
            this.b_0_textBox.Size = new System.Drawing.Size(74, 28);
            this.b_0_textBox.TabIndex = 31;
            this.b_0_textBox.Text = "1,2";
            this.b_0_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // init_conditions
            // 
            this.init_conditions.AutoSize = true;
            this.init_conditions.BackColor = System.Drawing.Color.Transparent;
            this.init_conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.init_conditions.Location = new System.Drawing.Point(729, 9);
            this.init_conditions.Name = "init_conditions";
            this.init_conditions.Size = new System.Drawing.Size(68, 93);
            this.init_conditions.TabIndex = 32;
            this.init_conditions.Text = "b₀ = \r\nb₁ = \r\nb₂ = ";
            // 
            // b_1_textBox
            // 
            this.b_1_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.b_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_1_textBox.Location = new System.Drawing.Point(789, 43);
            this.b_1_textBox.Name = "b_1_textBox";
            this.b_1_textBox.Size = new System.Drawing.Size(74, 28);
            this.b_1_textBox.TabIndex = 33;
            this.b_1_textBox.Text = "0,5";
            this.b_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_2_textBox
            // 
            this.b_2_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.b_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_2_textBox.Location = new System.Drawing.Point(789, 77);
            this.b_2_textBox.Name = "b_2_textBox";
            this.b_2_textBox.Size = new System.Drawing.Size(74, 28);
            this.b_2_textBox.TabIndex = 34;
            this.b_2_textBox.Text = "-3";
            this.b_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phi_2_textBox
            // 
            this.phi_2_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.phi_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phi_2_textBox.Location = new System.Drawing.Point(789, 147);
            this.phi_2_textBox.Name = "phi_2_textBox";
            this.phi_2_textBox.Size = new System.Drawing.Size(74, 28);
            this.phi_2_textBox.TabIndex = 37;
            this.phi_2_textBox.Text = "0,3";
            this.phi_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(726, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 62);
            this.label1.TabIndex = 36;
            this.label1.Text = "φ₁ = \r\nφ₂ = \r\n";
            // 
            // phi_1_textBox
            // 
            this.phi_1_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.phi_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phi_1_textBox.Location = new System.Drawing.Point(789, 113);
            this.phi_1_textBox.Name = "phi_1_textBox";
            this.phi_1_textBox.Size = new System.Drawing.Size(74, 28);
            this.phi_1_textBox.TabIndex = 35;
            this.phi_1_textBox.Text = "1,4";
            this.phi_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 70);
            this.label2.TabIndex = 38;
            this.label2.Text = "Начальное распределение температуры:\r\nφ(x) = 1/L + φ₁ cos(πx/L) + φ₂ cos(2πx/L)";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(12, 208);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(388, 43);
            this.buttonDraw.TabIndex = 39;
            this.buttonDraw.Text = "Рассчитать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // partASolution_btn
            // 
            this.partASolution_btn.Enabled = false;
            this.partASolution_btn.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partASolution_btn.Location = new System.Drawing.Point(475, 208);
            this.partASolution_btn.Name = "partASolution_btn";
            this.partASolution_btn.Size = new System.Drawing.Size(388, 43);
            this.partASolution_btn.TabIndex = 40;
            this.partASolution_btn.Text = "Показать решение части А";
            this.partASolution_btn.UseVisualStyleBackColor = true;
            this.partASolution_btn.Click += new System.EventHandler(this.partASolution_btn_Click);
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.LightBlue;
            this.grid.BorderlineColor = System.Drawing.SystemColors.Window;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.grid.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.grid.Legends.Add(legend1);
            this.grid.Location = new System.Drawing.Point(12, 257);
            this.grid.Name = "grid";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Начальное распределние температуры";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Конечное рапределение температуры";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "Legend1";
            series3.Name = "Решение части А";
            this.grid.Series.Add(series1);
            this.grid.Series.Add(series2);
            this.grid.Series.Add(series3);
            this.grid.Size = new System.Drawing.Size(851, 455);
            this.grid.TabIndex = 41;
            this.grid.Text = "grid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(578, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 124);
            this.label3.TabIndex = 42;
            this.label3.Text = "L = \r\nT = \r\nh = \r\nτ = ";
            // 
            // L_textBox
            // 
            this.L_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.L_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_textBox.Location = new System.Drawing.Point(629, 9);
            this.L_textBox.Name = "L_textBox";
            this.L_textBox.Size = new System.Drawing.Size(76, 28);
            this.L_textBox.TabIndex = 43;
            this.L_textBox.Text = "5";
            this.L_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_textBox
            // 
            this.T_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.T_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_textBox.Location = new System.Drawing.Point(629, 43);
            this.T_textBox.Name = "T_textBox";
            this.T_textBox.Size = new System.Drawing.Size(76, 28);
            this.T_textBox.TabIndex = 44;
            this.T_textBox.Text = "3";
            this.T_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // h_textBox
            // 
            this.h_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.h_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_textBox.Location = new System.Drawing.Point(629, 77);
            this.h_textBox.Name = "h_textBox";
            this.h_textBox.Size = new System.Drawing.Size(76, 28);
            this.h_textBox.TabIndex = 45;
            this.h_textBox.Text = "0,2";
            this.h_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tau_textBox
            // 
            this.tau_textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.tau_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tau_textBox.Location = new System.Drawing.Point(629, 111);
            this.tau_textBox.Name = "tau_textBox";
            this.tau_textBox.Size = new System.Drawing.Size(76, 28);
            this.tau_textBox.TabIndex = 46;
            this.tau_textBox.Text = "0,01";
            this.tau_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 70);
            this.label4.TabIndex = 47;
            this.label4.Text = "Управляющая функция:\r\nb(x) = b₀ + b₁ cos(πx/L) + b₂ cos(2πx/L)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 718);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(711, 27);
            this.progressBar1.TabIndex = 48;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_label.Location = new System.Drawing.Point(746, 715);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(82, 28);
            this.time_label.TabIndex = 49;
            this.time_label.Text = "0 s 0 ms\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(875, 758);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tau_textBox);
            this.Controls.Add(this.h_textBox);
            this.Controls.Add(this.T_textBox);
            this.Controls.Add(this.L_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.partASolution_btn);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.phi_2_textBox);
            this.Controls.Add(this.phi_1_textBox);
            this.Controls.Add(this.b_2_textBox);
            this.Controls.Add(this.b_1_textBox);
            this.Controls.Add(this.b_0_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.init_conditions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "[Alibekov M.R.] Lab_04 (CRH Process)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox b_0_textBox;
        private System.Windows.Forms.Label init_conditions;
        private System.Windows.Forms.TextBox b_1_textBox;
        private System.Windows.Forms.TextBox b_2_textBox;
        private System.Windows.Forms.TextBox phi_2_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phi_1_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button partASolution_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox L_textBox;
        private System.Windows.Forms.TextBox T_textBox;
        private System.Windows.Forms.TextBox h_textBox;
        private System.Windows.Forms.TextBox tau_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label time_label;
    }
}

