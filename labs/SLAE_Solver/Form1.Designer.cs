namespace SLAE_Solver
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.labelA = new System.Windows.Forms.Label();
            this.dataGridViewVector = new System.Windows.Forms.DataGridView();
            this.labelb = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.labelx = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.labelGauss = new System.Windows.Forms.Label();
            this.buttonGauss = new System.Windows.Forms.Button();
            this.buttonCramer = new System.Windows.Forms.Button();
            this.labelCramer = new System.Windows.Forms.Label();
            this.buttonSeidel = new System.Windows.Forms.Button();
            this.labelSeidel = new System.Windows.Forms.Label();
            this.buttonIterative = new System.Windows.Forms.Button();
            this.labelIterative = new System.Windows.Forms.Label();
            this.buttonRelaxation = new System.Windows.Forms.Button();
            this.labelRelaxation = new System.Windows.Forms.Label();
            this.buttonLU = new System.Windows.Forms.Button();
            this.labelLU = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelGaussTime = new System.Windows.Forms.Label();
            this.labelCramerTime = new System.Windows.Forms.Label();
            this.labelSeidelTime = new System.Windows.Forms.Label();
            this.labelIterativeTime = new System.Windows.Forms.Label();
            this.labelRelaxationTime = new System.Windows.Forms.Label();
            this.labelLUTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewMatrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.RowHeadersWidth = 40;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(560, 476);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSize.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBoxSize.Location = new System.Drawing.Point(870, 40);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(58, 39);
            this.comboBoxSize.TabIndex = 2;
            this.comboBoxSize.Text = "2";
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(278, 9);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(30, 32);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "A";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewVector
            // 
            this.dataGridViewVector.AllowUserToAddRows = false;
            this.dataGridViewVector.AllowUserToResizeColumns = false;
            this.dataGridViewVector.AllowUserToResizeRows = false;
            this.dataGridViewVector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVector.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVector.ColumnHeadersVisible = false;
            this.dataGridViewVector.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewVector.Location = new System.Drawing.Point(704, 40);
            this.dataGridViewVector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVector.Name = "dataGridViewVector";
            this.dataGridViewVector.RowHeadersVisible = false;
            this.dataGridViewVector.RowHeadersWidth = 40;
            this.dataGridViewVector.RowTemplate.Height = 24;
            this.dataGridViewVector.Size = new System.Drawing.Size(64, 476);
            this.dataGridViewVector.TabIndex = 1;
            // 
            // labelb
            // 
            this.labelb.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelb.Location = new System.Drawing.Point(718, 9);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(28, 29);
            this.labelb.TabIndex = 4;
            this.labelb.Text = "b";
            this.labelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.ColumnHeadersVisible = false;
            this.dataGridViewResult.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewResult.Location = new System.Drawing.Point(600, 40);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 40;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(64, 476);
            this.dataGridViewResult.TabIndex = 13;
            // 
            // labelx
            // 
            this.labelx.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelx.Location = new System.Drawing.Point(614, 9);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(28, 29);
            this.labelx.TabIndex = 6;
            this.labelx.Text = "x";
            this.labelx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSize
            // 
            this.labelSize.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(806, 43);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(68, 29);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "Size: ";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.Location = new System.Drawing.Point(1119, 467);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(266, 49);
            this.buttonSolve.TabIndex = 12;
            this.buttonSolve.Text = "Solve by all methods";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(971, 467);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 49);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandom.Location = new System.Drawing.Point(808, 467);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(157, 49);
            this.buttonRandom.TabIndex = 10;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // labelGauss
            // 
            this.labelGauss.AutoSize = true;
            this.labelGauss.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGauss.Location = new System.Drawing.Point(1068, 97);
            this.labelGauss.Name = "labelGauss";
            this.labelGauss.Size = new System.Drawing.Size(181, 32);
            this.labelGauss.TabIndex = 11;
            this.labelGauss.Text = "Gauss Method: ";
            // 
            // buttonGauss
            // 
            this.buttonGauss.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGauss.Location = new System.Drawing.Point(807, 89);
            this.buttonGauss.Name = "buttonGauss";
            this.buttonGauss.Size = new System.Drawing.Size(121, 47);
            this.buttonGauss.TabIndex = 4;
            this.buttonGauss.Text = "Solve ->";
            this.buttonGauss.UseVisualStyleBackColor = true;
            this.buttonGauss.Click += new System.EventHandler(this.buttonGauss_Click);
            // 
            // buttonCramer
            // 
            this.buttonCramer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCramer.Location = new System.Drawing.Point(807, 151);
            this.buttonCramer.Name = "buttonCramer";
            this.buttonCramer.Size = new System.Drawing.Size(121, 47);
            this.buttonCramer.TabIndex = 5;
            this.buttonCramer.Text = "Solve ->";
            this.buttonCramer.UseVisualStyleBackColor = true;
            this.buttonCramer.Click += new System.EventHandler(this.buttonCramer_Click);
            // 
            // labelCramer
            // 
            this.labelCramer.AutoSize = true;
            this.labelCramer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCramer.Location = new System.Drawing.Point(1053, 159);
            this.labelCramer.Name = "labelCramer";
            this.labelCramer.Size = new System.Drawing.Size(196, 32);
            this.labelCramer.TabIndex = 13;
            this.labelCramer.Text = "Cramer Method: ";
            // 
            // buttonSeidel
            // 
            this.buttonSeidel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeidel.Location = new System.Drawing.Point(807, 213);
            this.buttonSeidel.Name = "buttonSeidel";
            this.buttonSeidel.Size = new System.Drawing.Size(121, 47);
            this.buttonSeidel.TabIndex = 6;
            this.buttonSeidel.Text = "Solve ->";
            this.buttonSeidel.UseVisualStyleBackColor = true;
            this.buttonSeidel.Click += new System.EventHandler(this.buttonSeidel_Click);
            // 
            // labelSeidel
            // 
            this.labelSeidel.AutoSize = true;
            this.labelSeidel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeidel.Location = new System.Drawing.Point(1065, 221);
            this.labelSeidel.Name = "labelSeidel";
            this.labelSeidel.Size = new System.Drawing.Size(184, 32);
            this.labelSeidel.TabIndex = 15;
            this.labelSeidel.Text = "Seidel Method: ";
            // 
            // buttonIterative
            // 
            this.buttonIterative.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIterative.Location = new System.Drawing.Point(807, 275);
            this.buttonIterative.Name = "buttonIterative";
            this.buttonIterative.Size = new System.Drawing.Size(121, 47);
            this.buttonIterative.TabIndex = 7;
            this.buttonIterative.Text = "Solve ->";
            this.buttonIterative.UseVisualStyleBackColor = true;
            this.buttonIterative.Click += new System.EventHandler(this.buttonIterative_Click);
            // 
            // labelIterative
            // 
            this.labelIterative.AutoSize = true;
            this.labelIterative.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIterative.Location = new System.Drawing.Point(961, 283);
            this.labelIterative.Name = "labelIterative";
            this.labelIterative.Size = new System.Drawing.Size(288, 32);
            this.labelIterative.TabIndex = 17;
            this.labelIterative.Text = "Simple Iteration Method: ";
            // 
            // buttonRelaxation
            // 
            this.buttonRelaxation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRelaxation.Location = new System.Drawing.Point(807, 337);
            this.buttonRelaxation.Name = "buttonRelaxation";
            this.buttonRelaxation.Size = new System.Drawing.Size(121, 47);
            this.buttonRelaxation.TabIndex = 8;
            this.buttonRelaxation.Text = "Solve ->";
            this.buttonRelaxation.UseVisualStyleBackColor = true;
            this.buttonRelaxation.Click += new System.EventHandler(this.buttonRelaxation_Click);
            // 
            // labelRelaxation
            // 
            this.labelRelaxation.AutoSize = true;
            this.labelRelaxation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRelaxation.Location = new System.Drawing.Point(949, 345);
            this.labelRelaxation.Name = "labelRelaxation";
            this.labelRelaxation.Size = new System.Drawing.Size(300, 32);
            this.labelRelaxation.TabIndex = 19;
            this.labelRelaxation.Text = "Upper Relaxation Method: ";
            // 
            // buttonLU
            // 
            this.buttonLU.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLU.Location = new System.Drawing.Point(807, 399);
            this.buttonLU.Name = "buttonLU";
            this.buttonLU.Size = new System.Drawing.Size(121, 47);
            this.buttonLU.TabIndex = 9;
            this.buttonLU.Text = "Solve ->";
            this.buttonLU.UseVisualStyleBackColor = true;
            this.buttonLU.Click += new System.EventHandler(this.buttonLU_Click);
            // 
            // labelLU
            // 
            this.labelLU.AutoSize = true;
            this.labelLU.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLU.Location = new System.Drawing.Point(934, 407);
            this.labelLU.Name = "labelLU";
            this.labelLU.Size = new System.Drawing.Size(315, 32);
            this.labelLU.TabIndex = 21;
            this.labelLU.Text = "LU Decomposition Method: ";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(1247, 40);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(73, 32);
            this.labelTime.TabIndex = 23;
            this.labelTime.Text = "Time:";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGaussTime
            // 
            this.labelGaussTime.AutoSize = true;
            this.labelGaussTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGaussTime.Location = new System.Drawing.Point(1248, 99);
            this.labelGaussTime.Name = "labelGaussTime";
            this.labelGaussTime.Size = new System.Drawing.Size(26, 29);
            this.labelGaussTime.TabIndex = 24;
            this.labelGaussTime.Text = "0";
            // 
            // labelCramerTime
            // 
            this.labelCramerTime.AutoSize = true;
            this.labelCramerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCramerTime.Location = new System.Drawing.Point(1248, 161);
            this.labelCramerTime.Name = "labelCramerTime";
            this.labelCramerTime.Size = new System.Drawing.Size(26, 29);
            this.labelCramerTime.TabIndex = 25;
            this.labelCramerTime.Text = "0";
            // 
            // labelSeidelTime
            // 
            this.labelSeidelTime.AutoSize = true;
            this.labelSeidelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeidelTime.Location = new System.Drawing.Point(1248, 223);
            this.labelSeidelTime.Name = "labelSeidelTime";
            this.labelSeidelTime.Size = new System.Drawing.Size(26, 29);
            this.labelSeidelTime.TabIndex = 26;
            this.labelSeidelTime.Text = "0";
            // 
            // labelIterativeTime
            // 
            this.labelIterativeTime.AutoSize = true;
            this.labelIterativeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIterativeTime.Location = new System.Drawing.Point(1248, 285);
            this.labelIterativeTime.Name = "labelIterativeTime";
            this.labelIterativeTime.Size = new System.Drawing.Size(26, 29);
            this.labelIterativeTime.TabIndex = 27;
            this.labelIterativeTime.Text = "0";
            // 
            // labelRelaxationTime
            // 
            this.labelRelaxationTime.AutoSize = true;
            this.labelRelaxationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRelaxationTime.Location = new System.Drawing.Point(1248, 347);
            this.labelRelaxationTime.Name = "labelRelaxationTime";
            this.labelRelaxationTime.Size = new System.Drawing.Size(26, 29);
            this.labelRelaxationTime.TabIndex = 28;
            this.labelRelaxationTime.Text = "0";
            // 
            // labelLUTime
            // 
            this.labelLUTime.AutoSize = true;
            this.labelLUTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLUTime.Location = new System.Drawing.Point(1248, 409);
            this.labelLUTime.Name = "labelLUTime";
            this.labelLUTime.Size = new System.Drawing.Size(26, 29);
            this.labelLUTime.TabIndex = 29;
            this.labelLUTime.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1407, 532);
            this.Controls.Add(this.labelLUTime);
            this.Controls.Add(this.labelRelaxationTime);
            this.Controls.Add(this.labelIterativeTime);
            this.Controls.Add(this.labelSeidelTime);
            this.Controls.Add(this.labelCramerTime);
            this.Controls.Add(this.labelGaussTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonLU);
            this.Controls.Add(this.labelLU);
            this.Controls.Add(this.buttonRelaxation);
            this.Controls.Add(this.labelRelaxation);
            this.Controls.Add(this.buttonIterative);
            this.Controls.Add(this.labelIterative);
            this.Controls.Add(this.buttonSeidel);
            this.Controls.Add(this.labelSeidel);
            this.Controls.Add(this.buttonCramer);
            this.Controls.Add(this.labelCramer);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridViewVector);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.buttonGauss);
            this.Controls.Add(this.labelGauss);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.labelA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SLAE_Solver";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.DataGridView dataGridViewVector;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label labelGauss;
        private System.Windows.Forms.Button buttonGauss;
        private System.Windows.Forms.Button buttonCramer;
        private System.Windows.Forms.Label labelCramer;
        private System.Windows.Forms.Button buttonSeidel;
        private System.Windows.Forms.Label labelSeidel;
        private System.Windows.Forms.Button buttonIterative;
        private System.Windows.Forms.Label labelIterative;
        private System.Windows.Forms.Button buttonRelaxation;
        private System.Windows.Forms.Label labelRelaxation;
        private System.Windows.Forms.Button buttonLU;
        private System.Windows.Forms.Label labelLU;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelGaussTime;
        private System.Windows.Forms.Label labelCramerTime;
        private System.Windows.Forms.Label labelSeidelTime;
        private System.Windows.Forms.Label labelIterativeTime;
        private System.Windows.Forms.Label labelRelaxationTime;
        private System.Windows.Forms.Label labelLUTime;
    }
}

