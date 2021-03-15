namespace Cauchy_Problem_Solver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.s3ode = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.s3ode_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.init_conditions_name = new System.Windows.Forms.Label();
            this.init_conditions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exact_sol_name = new System.Windows.Forms.Label();
            this.exact_sol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.interval_name = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.steps_count_name = new System.Windows.Forms.Label();
            this.steps_count = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.x_t = new System.Windows.Forms.RadioButton();
            this.y_t = new System.Windows.Forms.RadioButton();
            this.z_t = new System.Windows.Forms.RadioButton();
            this.t_init_cond = new System.Windows.Forms.TextBox();
            this.x_init_cond = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.y_init_cond = new System.Windows.Forms.TextBox();
            this.z_init_cond = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 11);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersWidth = 40;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.RowTemplate.ReadOnly = true;
            this.dataGridViewResult.Size = new System.Drawing.Size(560, 631);
            this.dataGridViewResult.TabIndex = 1;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.Location = new System.Drawing.Point(591, 541);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(272, 101);
            this.buttonSolve.TabIndex = 2;
            this.buttonSolve.Text = "Решить методом Рунге-Кутты 4-ого порядка";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // s3ode
            // 
            this.s3ode.AutoSize = true;
            this.s3ode.BackColor = System.Drawing.Color.Transparent;
            this.s3ode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s3ode.Location = new System.Drawing.Point(626, 78);
            this.s3ode.Name = "s3ode";
            this.s3ode.Size = new System.Drawing.Size(145, 87);
            this.s3ode.TabIndex = 3;
            this.s3ode.Text = "x\\u0307 = x\r\ny\\u0307 = y\r\nz\\u0307 = z";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Enabled = false;
            this.buttonDraw.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(883, 541);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(201, 101);
            this.buttonDraw.TabIndex = 6;
            this.buttonDraw.Text = "Построить фазовый портрет";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // s3ode_name
            // 
            this.s3ode_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s3ode_name.Location = new System.Drawing.Point(589, 12);
            this.s3ode_name.Name = "s3ode_name";
            this.s3ode_name.Size = new System.Drawing.Size(196, 66);
            this.s3ode_name.TabIndex = 7;
            this.s3ode_name.Text = "Система ОДУ 3-его порядка:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(572, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 131);
            this.label1.TabIndex = 8;
            this.label1.Text = "{";
            // 
            // init_conditions_name
            // 
            this.init_conditions_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.init_conditions_name.Location = new System.Drawing.Point(791, 12);
            this.init_conditions_name.Name = "init_conditions_name";
            this.init_conditions_name.Size = new System.Drawing.Size(262, 66);
            this.init_conditions_name.TabIndex = 9;
            this.init_conditions_name.Text = "Начальные условия (при t=         ):";
            // 
            // init_conditions
            // 
            this.init_conditions.AutoSize = true;
            this.init_conditions.BackColor = System.Drawing.Color.Transparent;
            this.init_conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.init_conditions.Location = new System.Drawing.Point(826, 78);
            this.init_conditions.Name = "init_conditions";
            this.init_conditions.Size = new System.Drawing.Size(55, 87);
            this.init_conditions.TabIndex = 10;
            this.init_conditions.Text = "x = \r\ny = \r\nz = ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(780, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 131);
            this.label2.TabIndex = 11;
            this.label2.Text = "{";
            // 
            // exact_sol_name
            // 
            this.exact_sol_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exact_sol_name.Location = new System.Drawing.Point(589, 180);
            this.exact_sol_name.Name = "exact_sol_name";
            this.exact_sol_name.Size = new System.Drawing.Size(400, 36);
            this.exact_sol_name.TabIndex = 12;
            this.exact_sol_name.Text = "Точное решение задачи Коши:";
            // 
            // exact_sol
            // 
            this.exact_sol.AutoSize = true;
            this.exact_sol.BackColor = System.Drawing.Color.Transparent;
            this.exact_sol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exact_sol.Location = new System.Drawing.Point(603, 216);
            this.exact_sol.Name = "exact_sol";
            this.exact_sol.Size = new System.Drawing.Size(447, 87);
            this.exact_sol.TabIndex = 13;
            this.exact_sol.Text = "x(t) = -2 * e^t * (2 * sin(2t) + cos(2t))\r\ny(t) = e^t * (5 + 2 * cos(2t) - sin(2t" +
    "))\r\nz(t) = e^t * (-5 + 6 * cos(2t) - 3 * sin(2t))";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(557, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 131);
            this.label4.TabIndex = 14;
            this.label4.Text = "{";
            // 
            // interval_name
            // 
            this.interval_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interval_name.Location = new System.Drawing.Point(612, 329);
            this.interval_name.Name = "interval_name";
            this.interval_name.Size = new System.Drawing.Size(174, 39);
            this.interval_name.TabIndex = 15;
            this.interval_name.Text = "Интервал:";
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.GhostWhite;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(854, 329);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(48, 30);
            this.B.TabIndex = 21;
            this.B.Text = "2";
            this.B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.B.Leave += new System.EventHandler(this.B_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(836, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = ";";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(905, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = ")";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(777, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "(";
            // 
            // steps_count_name
            // 
            this.steps_count_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.steps_count_name.Location = new System.Drawing.Point(612, 378);
            this.steps_count_name.Name = "steps_count_name";
            this.steps_count_name.Size = new System.Drawing.Size(198, 39);
            this.steps_count_name.TabIndex = 22;
            this.steps_count_name.Text = "Число шагов:";
            // 
            // steps_count
            // 
            this.steps_count.BackColor = System.Drawing.Color.GhostWhite;
            this.steps_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.steps_count.Location = new System.Drawing.Point(792, 378);
            this.steps_count.Name = "steps_count";
            this.steps_count.Size = new System.Drawing.Size(48, 30);
            this.steps_count.TabIndex = 23;
            this.steps_count.Text = "10";
            this.steps_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.steps_count.Leave += new System.EventHandler(this.steps_count_Leave);
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.LightBlue;
            this.grid.BorderlineColor = System.Drawing.SystemColors.Window;
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
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "rk4";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "exact";
            this.grid.Series.Add(series1);
            this.grid.Series.Add(series2);
            this.grid.Size = new System.Drawing.Size(560, 630);
            this.grid.TabIndex = 0;
            this.grid.Text = "grid";
            this.grid.Visible = false;
            // 
            // x_t
            // 
            this.x_t.AutoSize = true;
            this.x_t.Checked = true;
            this.x_t.Font = new System.Drawing.Font("Segoe UI Symbol", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_t.Location = new System.Drawing.Point(617, 415);
            this.x_t.Name = "x_t";
            this.x_t.Size = new System.Drawing.Size(168, 36);
            this.x_t.TabIndex = 24;
            this.x_t.TabStop = true;
            this.x_t.Text = "График x(t)";
            this.x_t.UseVisualStyleBackColor = true;
            this.x_t.Visible = false;
            this.x_t.CheckedChanged += new System.EventHandler(this.x_t_CheckedChanged);
            // 
            // y_t
            // 
            this.y_t.AutoSize = true;
            this.y_t.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_t.Location = new System.Drawing.Point(617, 457);
            this.y_t.Name = "y_t";
            this.y_t.Size = new System.Drawing.Size(169, 36);
            this.y_t.TabIndex = 25;
            this.y_t.Text = "График y(t)";
            this.y_t.UseVisualStyleBackColor = true;
            this.y_t.Visible = false;
            this.y_t.CheckedChanged += new System.EventHandler(this.y_t_CheckedChanged);
            // 
            // z_t
            // 
            this.z_t.AutoSize = true;
            this.z_t.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z_t.Location = new System.Drawing.Point(617, 494);
            this.z_t.Name = "z_t";
            this.z_t.Size = new System.Drawing.Size(168, 36);
            this.z_t.TabIndex = 26;
            this.z_t.Text = "График z(t)";
            this.z_t.UseVisualStyleBackColor = true;
            this.z_t.Visible = false;
            this.z_t.CheckedChanged += new System.EventHandler(this.z_t_CheckedChanged);
            // 
            // t_init_cond
            // 
            this.t_init_cond.BackColor = System.Drawing.Color.GhostWhite;
            this.t_init_cond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_init_cond.Location = new System.Drawing.Point(887, 41);
            this.t_init_cond.Name = "t_init_cond";
            this.t_init_cond.Size = new System.Drawing.Size(48, 30);
            this.t_init_cond.TabIndex = 27;
            this.t_init_cond.Text = "0";
            this.t_init_cond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_init_cond.TextChanged += new System.EventHandler(this.t_init_cond_TextChanged);
            this.t_init_cond.Leave += new System.EventHandler(this.t_init_cond_Leave);
            // 
            // x_init_cond
            // 
            this.x_init_cond.BackColor = System.Drawing.Color.GhostWhite;
            this.x_init_cond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_init_cond.Location = new System.Drawing.Point(887, 77);
            this.x_init_cond.Name = "x_init_cond";
            this.x_init_cond.Size = new System.Drawing.Size(48, 28);
            this.x_init_cond.TabIndex = 26;
            this.x_init_cond.Text = "-2";
            this.x_init_cond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_init_cond.TextChanged += new System.EventHandler(this.x_init_cond_TextChanged);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.GhostWhite;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(792, 329);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(48, 30);
            this.A.TabIndex = 20;
            this.A.Text = "0";
            this.A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A.Leave += new System.EventHandler(this.A_Leave);
            // 
            // y_init_cond
            // 
            this.y_init_cond.BackColor = System.Drawing.Color.GhostWhite;
            this.y_init_cond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y_init_cond.Location = new System.Drawing.Point(887, 109);
            this.y_init_cond.Name = "y_init_cond";
            this.y_init_cond.Size = new System.Drawing.Size(48, 28);
            this.y_init_cond.TabIndex = 29;
            this.y_init_cond.Text = "7";
            this.y_init_cond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y_init_cond.TextChanged += new System.EventHandler(this.y_init_cond_TextChanged);
            // 
            // z_init_cond
            // 
            this.z_init_cond.BackColor = System.Drawing.Color.GhostWhite;
            this.z_init_cond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z_init_cond.Location = new System.Drawing.Point(887, 140);
            this.z_init_cond.Name = "z_init_cond";
            this.z_init_cond.Size = new System.Drawing.Size(48, 28);
            this.z_init_cond.TabIndex = 30;
            this.z_init_cond.Text = "1";
            this.z_init_cond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.z_init_cond.TextChanged += new System.EventHandler(this.z_init_cond_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1122, 673);
            this.Controls.Add(this.z_init_cond);
            this.Controls.Add(this.y_init_cond);
            this.Controls.Add(this.x_init_cond);
            this.Controls.Add(this.t_init_cond);
            this.Controls.Add(this.z_t);
            this.Controls.Add(this.y_t);
            this.Controls.Add(this.x_t);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.steps_count);
            this.Controls.Add(this.steps_count_name);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exact_sol_name);
            this.Controls.Add(this.init_conditions);
            this.Controls.Add(this.s3ode_name);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.s3ode);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exact_sol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.interval_name);
            this.Controls.Add(this.init_conditions_name);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "[Alibekov M.R.] Lab_03 (RK4Solver)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label s3ode;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label s3ode_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label init_conditions_name;
        private System.Windows.Forms.Label init_conditions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exact_sol_name;
        private System.Windows.Forms.Label exact_sol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label interval_name;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label steps_count_name;
        private System.Windows.Forms.TextBox steps_count;
        private System.Windows.Forms.DataVisualization.Charting.Chart grid;
        private System.Windows.Forms.RadioButton x_t;
        private System.Windows.Forms.RadioButton y_t;
        private System.Windows.Forms.RadioButton z_t;
        private System.Windows.Forms.TextBox t_init_cond;
        private System.Windows.Forms.TextBox x_init_cond;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox y_init_cond;
        private System.Windows.Forms.TextBox z_init_cond;
    }
}

