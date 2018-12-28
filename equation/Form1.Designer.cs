namespace equation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.selectPower = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.X_max = new System.Windows.Forms.TextBox();
            this.X_min = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Y_max = new System.Windows.Forms.TextBox();
            this.Y_min = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.autosizeY = new System.Windows.Forms.CheckBox();
            this.autosizeX = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.selectPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Коэфициенты уравнения вида:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "*x+";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // selectPower
            // 
            this.selectPower.Location = new System.Drawing.Point(12, 10);
            this.selectPower.Name = "selectPower";
            this.selectPower.Size = new System.Drawing.Size(83, 20);
            this.selectPower.TabIndex = 6;
            this.selectPower.ValueChanged += new System.EventHandler(this.selectPower_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(21, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "*x^2+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "*x^3+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "*x^4+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "*x^5+";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(21, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(74, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(21, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(21, 20);
            this.textBox6.TabIndex = 14;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 112);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "graf";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(364, 326);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "решить\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // X_max
            // 
            this.X_max.Enabled = false;
            this.X_max.Location = new System.Drawing.Point(275, 478);
            this.X_max.Name = "X_max";
            this.X_max.Size = new System.Drawing.Size(57, 20);
            this.X_max.TabIndex = 37;
            this.X_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_max_KeyPress);
            // 
            // X_min
            // 
            this.X_min.Enabled = false;
            this.X_min.Location = new System.Drawing.Point(74, 478);
            this.X_min.Name = "X_min";
            this.X_min.Size = new System.Drawing.Size(58, 20);
            this.X_min.TabIndex = 36;
            this.X_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_min_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(283, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "X max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(83, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "X min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(138, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Range";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(30, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(380, 93);
            this.label12.TabIndex = 35;
            this.label12.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(302, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Range";
            // 
            // Y_max
            // 
            this.Y_max.Enabled = false;
            this.Y_max.Location = new System.Drawing.Point(305, 224);
            this.Y_max.Name = "Y_max";
            this.Y_max.Size = new System.Drawing.Size(57, 20);
            this.Y_max.TabIndex = 43;
            this.Y_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y_max_KeyPress);
            // 
            // Y_min
            // 
            this.Y_min.Enabled = false;
            this.Y_min.Location = new System.Drawing.Point(305, 357);
            this.Y_min.Name = "Y_min";
            this.Y_min.Size = new System.Drawing.Size(58, 20);
            this.Y_min.TabIndex = 42;
            this.Y_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y_min_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(313, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Y max";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(314, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Y min";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(287, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 284);
            this.label15.TabIndex = 41;
            this.label15.Text = " ";
            // 
            // autosizeY
            // 
            this.autosizeY.AutoSize = true;
            this.autosizeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.autosizeY.Checked = true;
            this.autosizeY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autosizeY.Location = new System.Drawing.Point(314, 152);
            this.autosizeY.Name = "autosizeY";
            this.autosizeY.Size = new System.Drawing.Size(81, 17);
            this.autosizeY.TabIndex = 47;
            this.autosizeY.Text = "Auto Size Y";
            this.autosizeY.UseVisualStyleBackColor = false;
            this.autosizeY.CheckedChanged += new System.EventHandler(this.autosizeY_CheckedChanged);
            // 
            // autosizeX
            // 
            this.autosizeX.AutoSize = true;
            this.autosizeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.autosizeX.Checked = true;
            this.autosizeX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autosizeX.Location = new System.Drawing.Point(208, 430);
            this.autosizeX.Name = "autosizeX";
            this.autosizeX.Size = new System.Drawing.Size(81, 17);
            this.autosizeX.TabIndex = 46;
            this.autosizeX.Text = "Auto Size X";
            this.autosizeX.UseVisualStyleBackColor = false;
            this.autosizeX.CheckedChanged += new System.EventHandler(this.autosizeX_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(419, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(292, 284);
            this.dataGridView1.TabIndex = 48;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 10;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 150;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 10;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 547);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.autosizeY);
            this.Controls.Add(this.autosizeX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Y_max);
            this.Controls.Add(this.Y_min);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.X_max);
            this.Controls.Add(this.X_min);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.selectPower);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.selectPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown selectPower;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox X_max;
        private System.Windows.Forms.TextBox X_min;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Y_max;
        private System.Windows.Forms.TextBox Y_min;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox autosizeY;
        private System.Windows.Forms.CheckBox autosizeX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

