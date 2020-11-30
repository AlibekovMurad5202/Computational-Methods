namespace Cubic_Spline_Interpolation
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
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1E-05D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.set_points_btn = new System.Windows.Forms.RadioButton();
            this.random_points_btn = new System.Windows.Forms.RadioButton();
            this.info_box = new System.Windows.Forms.ListBox();
            this.spline = new System.Windows.Forms.Button();
            this.remove_last_point_btn = new System.Windows.Forms.Button();
            this.add_point_btn = new System.Windows.Forms.Button();
            this.remove_all_points_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.saving_coeffs = new System.Windows.Forms.CheckBox();
            this.saving_image = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.LightBlue;
            this.grid.BorderlineColor = System.Drawing.SystemColors.Window;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = -10D;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            chartArea1.AxisX2.Crossing = 0D;
            chartArea1.AxisX2.Interval = 1D;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.Maximum = 10D;
            chartArea1.AxisX2.Minimum = -10D;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.Maximum = 8D;
            chartArea1.AxisY.Minimum = -8D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            chartArea1.AxisY2.Crossing = 0D;
            chartArea1.AxisY2.Interval = 1D;
            chartArea1.AxisY2.Maximum = 8D;
            chartArea1.AxisY2.Minimum = -8D;
            chartArea1.BackColor = System.Drawing.Color.LightBlue;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.LineWidth = 0;
            chartArea1.CursorX.Position = 0D;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.LineWidth = 0;
            chartArea1.CursorY.Position = 0D;
            chartArea1.Name = "ChartArea1";
            this.grid.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.LightBlue;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.grid.Legends.Add(legend1);
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerBorderWidth = 3;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 6;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "points";
            dataPoint1.IsEmpty = true;
            series1.Points.Add(dataPoint1);
            this.grid.Series.Add(series1);
            this.grid.Size = new System.Drawing.Size(620, 496);
            this.grid.TabIndex = 0;
            this.grid.Text = "grid";
            // 
            // set_points_btn
            // 
            this.set_points_btn.AutoSize = true;
            this.set_points_btn.Checked = true;
            this.set_points_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.set_points_btn.Location = new System.Drawing.Point(658, 6);
            this.set_points_btn.Name = "set_points_btn";
            this.set_points_btn.Size = new System.Drawing.Size(180, 27);
            this.set_points_btn.TabIndex = 1;
            this.set_points_btn.TabStop = true;
            this.set_points_btn.Text = "Ручной ввод точек";
            this.set_points_btn.UseVisualStyleBackColor = true;
            this.set_points_btn.CheckedChanged += new System.EventHandler(this.set_points_btn_CheckedChanged);
            // 
            // random_points_btn
            // 
            this.random_points_btn.AutoSize = true;
            this.random_points_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.random_points_btn.Location = new System.Drawing.Point(658, 33);
            this.random_points_btn.Name = "random_points_btn";
            this.random_points_btn.Size = new System.Drawing.Size(169, 27);
            this.random_points_btn.TabIndex = 2;
            this.random_points_btn.Text = "Случайные точки";
            this.random_points_btn.UseVisualStyleBackColor = true;
            this.random_points_btn.CheckedChanged += new System.EventHandler(this.random_points_btn_CheckedChanged);
            // 
            // info_box
            // 
            this.info_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.info_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_box.ForeColor = System.Drawing.Color.Gray;
            this.info_box.FormattingEnabled = true;
            this.info_box.ItemHeight = 28;
            this.info_box.Items.AddRange(new object[] {
            "Текущий набор точек:",
            " "});
            this.info_box.Location = new System.Drawing.Point(653, 121);
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(277, 368);
            this.info_box.TabIndex = 4;
            // 
            // spline
            // 
            this.spline.Enabled = false;
            this.spline.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spline.Location = new System.Drawing.Point(653, 500);
            this.spline.Name = "spline";
            this.spline.Size = new System.Drawing.Size(277, 84);
            this.spline.TabIndex = 5;
            this.spline.Text = "Построить сплайн";
            this.spline.UseVisualStyleBackColor = true;
            this.spline.Click += new System.EventHandler(this.spline_Click);
            // 
            // remove_last_point_btn
            // 
            this.remove_last_point_btn.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove_last_point_btn.Location = new System.Drawing.Point(12, 500);
            this.remove_last_point_btn.Name = "remove_last_point_btn";
            this.remove_last_point_btn.Size = new System.Drawing.Size(377, 40);
            this.remove_last_point_btn.TabIndex = 6;
            this.remove_last_point_btn.Text = "Удалить последнюю точку";
            this.remove_last_point_btn.UseVisualStyleBackColor = true;
            this.remove_last_point_btn.Click += new System.EventHandler(this.remove_last_point_btn_Click);
            // 
            // add_point_btn
            // 
            this.add_point_btn.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_point_btn.Location = new System.Drawing.Point(448, 544);
            this.add_point_btn.Name = "add_point_btn";
            this.add_point_btn.Size = new System.Drawing.Size(199, 40);
            this.add_point_btn.TabIndex = 7;
            this.add_point_btn.Text = "Добавить точку";
            this.add_point_btn.UseVisualStyleBackColor = true;
            this.add_point_btn.Click += new System.EventHandler(this.add_point_btn_Click);
            // 
            // remove_all_points_btn
            // 
            this.remove_all_points_btn.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove_all_points_btn.Location = new System.Drawing.Point(395, 500);
            this.remove_all_points_btn.Name = "remove_all_points_btn";
            this.remove_all_points_btn.Size = new System.Drawing.Size(252, 40);
            this.remove_all_points_btn.TabIndex = 8;
            this.remove_all_points_btn.Text = "Удалить все точки";
            this.remove_all_points_btn.UseVisualStyleBackColor = true;
            this.remove_all_points_btn.Click += new System.EventHandler(this.remove_all_points_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(7, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите координаты точки:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(299, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "(";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(427, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = ")";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(358, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = ";";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.GhostWhite;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(314, 551);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(48, 30);
            this.X.TabIndex = 13;
            this.X.Text = "0";
            this.X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.Color.GhostWhite;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(376, 551);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(48, 30);
            this.Y.TabIndex = 14;
            this.Y.Text = "0";
            this.Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saving_coeffs
            // 
            this.saving_coeffs.AutoSize = true;
            this.saving_coeffs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saving_coeffs.Location = new System.Drawing.Point(658, 66);
            this.saving_coeffs.Name = "saving_coeffs";
            this.saving_coeffs.Size = new System.Drawing.Size(244, 27);
            this.saving_coeffs.TabIndex = 15;
            this.saving_coeffs.Text = "Сохранить коэффициенты ";
            this.saving_coeffs.UseVisualStyleBackColor = true;
            // 
            // saving_image
            // 
            this.saving_image.AutoSize = true;
            this.saving_image.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saving_image.Location = new System.Drawing.Point(658, 88);
            this.saving_image.Name = "saving_image";
            this.saving_image.Size = new System.Drawing.Size(229, 27);
            this.saving_image.TabIndex = 16;
            this.saving_image.Text = "Сохранить изображение";
            this.saving_image.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.saving_image);
            this.Controls.Add(this.saving_coeffs);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remove_all_points_btn);
            this.Controls.Add(this.add_point_btn);
            this.Controls.Add(this.remove_last_point_btn);
            this.Controls.Add(this.spline);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.random_points_btn);
            this.Controls.Add(this.set_points_btn);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "[Alibekov M.R.] Lab_01 (Cubic Spline Interpolation)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grid;
        private System.Windows.Forms.RadioButton set_points_btn;
        private System.Windows.Forms.RadioButton random_points_btn;
        private System.Windows.Forms.ListBox info_box;
        private System.Windows.Forms.Button spline;
        private System.Windows.Forms.Button remove_last_point_btn;
        private System.Windows.Forms.Button add_point_btn;
        private System.Windows.Forms.Button remove_all_points_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.CheckBox saving_coeffs;
        private System.Windows.Forms.CheckBox saving_image;
    }
}

