namespace Yuzhakov_NIkita_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Max_T_H = new System.Windows.Forms.TextBox();
            this.Dop_V_P_M_T = new System.Windows.Forms.TextBox();
            this.Min_Dop_T_H = new System.Windows.Forms.TextBox();
            this.Dop_V_N_M_T = new System.Windows.Forms.TextBox();
            this.T = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Rasschet = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.TextBox();
            this.chas = new System.Windows.Forms.TextBox();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид рыбы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Макс. t хранения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(598, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Допустимое время превышения максимальной температуры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Минимально допустимая температура хранения ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(574, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Допустимое время нарушения минимальной температуры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата/время начала измерения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Температура (от 18 до 54 значений)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Max_T_H
            // 
            this.Max_T_H.Location = new System.Drawing.Point(147, 48);
            this.Max_T_H.Name = "Max_T_H";
            this.Max_T_H.Size = new System.Drawing.Size(100, 20);
            this.Max_T_H.TabIndex = 8;
            this.Max_T_H.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Dop_V_P_M_T
            // 
            this.Dop_V_P_M_T.Location = new System.Drawing.Point(17, 99);
            this.Dop_V_P_M_T.Name = "Dop_V_P_M_T";
            this.Dop_V_P_M_T.Size = new System.Drawing.Size(100, 20);
            this.Dop_V_P_M_T.TabIndex = 9;
            this.Dop_V_P_M_T.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Min_Dop_T_H
            // 
            this.Min_Dop_T_H.Location = new System.Drawing.Point(17, 150);
            this.Min_Dop_T_H.Name = "Min_Dop_T_H";
            this.Min_Dop_T_H.Size = new System.Drawing.Size(100, 20);
            this.Min_Dop_T_H.TabIndex = 10;
            this.Min_Dop_T_H.TextChanged += new System.EventHandler(this.Min_Dop_t_h_TextChanged);
            // 
            // Dop_V_N_M_T
            // 
            this.Dop_V_N_M_T.Location = new System.Drawing.Point(17, 201);
            this.Dop_V_N_M_T.Name = "Dop_V_N_M_T";
            this.Dop_V_N_M_T.Size = new System.Drawing.Size(100, 20);
            this.Dop_V_N_M_T.TabIndex = 11;
            this.Dop_V_N_M_T.TextChanged += new System.EventHandler(this.Dop_v_n_m_t_TextChanged);
            // 
            // T
            // 
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T.Location = new System.Drawing.Point(17, 309);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(580, 26);
            this.T.TabIndex = 13;
            this.T.TextChanged += new System.EventHandler(this.T_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(606, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Сообщение о соблюдении или несоблюдении условий хранения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(457, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Отчет о периодах нарушения условий хранения";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(121, 430);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(348, 30);
            this.textBox8.TabIndex = 16;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(17, 527);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(593, 114);
            this.textBox9.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(253, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "т";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(123, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "ч";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(123, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "т";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(122, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "ч";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(603, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "т";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Rasschet
            // 
            this.Rasschet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rasschet.Location = new System.Drawing.Point(195, 341);
            this.Rasschet.Name = "Rasschet";
            this.Rasschet.Size = new System.Drawing.Size(185, 45);
            this.Rasschet.TabIndex = 23;
            this.Rasschet.Text = "Рассчитать";
            this.Rasschet.UseVisualStyleBackColor = true;
            this.Rasschet.Click += new System.EventHandler(this.button1_Click);
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(72, 252);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(33, 20);
            this.Month.TabIndex = 24;
            this.Month.TextChanged += new System.EventHandler(this.Month_TextChanged);
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(138, 252);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(67, 20);
            this.Year.TabIndex = 25;
            this.Year.TextChanged += new System.EventHandler(this.Year_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(51, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "д";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(111, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "м";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(211, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "г";
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(17, 253);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(33, 20);
            this.Day.TabIndex = 29;
            this.Day.TextChanged += new System.EventHandler(this.Day_TextChanged);
            // 
            // chas
            // 
            this.chas.Location = new System.Drawing.Point(256, 253);
            this.chas.Name = "chas";
            this.chas.Size = new System.Drawing.Size(33, 20);
            this.chas.TabIndex = 30;
            this.chas.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(320, 253);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(33, 20);
            this.Minutes.TabIndex = 31;
            this.Minutes.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(293, 253);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "ч";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(359, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "м";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 653);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.chas);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Rasschet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.T);
            this.Controls.Add(this.Dop_V_N_M_T);
            this.Controls.Add(this.Min_Dop_T_H);
            this.Controls.Add(this.Dop_V_P_M_T);
            this.Controls.Add(this.Max_T_H);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Max_T_H;
        private System.Windows.Forms.TextBox Dop_V_P_M_T;
        private System.Windows.Forms.TextBox Min_Dop_T_H;
        private System.Windows.Forms.TextBox Dop_V_N_M_T;
        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Rasschet;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox chas;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

