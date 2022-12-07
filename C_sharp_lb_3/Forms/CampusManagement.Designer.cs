namespace C_sharp_lb_2.Forms
{
    partial class CampusManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampusManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_studNumber = new System.Windows.Forms.TextBox();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.tb_hostelID = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_addStudents = new System.Windows.Forms.Button();
            this.bt_showInfo = new System.Windows.Forms.Button();
            this.gb_studNumber = new System.Windows.Forms.GroupBox();
            this.gb_stuffNumber = new System.Windows.Forms.GroupBox();
            this.tb_stuffNumber = new System.Windows.Forms.TextBox();
            this.bt_delStuff = new System.Windows.Forms.Button();
            this.bt_addStuff = new System.Windows.Forms.Button();
            this.rb_year = new System.Windows.Forms.RadioButton();
            this.gb_calcProfits = new System.Windows.Forms.GroupBox();
            this.bt_calcProfit = new System.Windows.Forms.Button();
            this.rb_month = new System.Windows.Forms.RadioButton();
            this.rb_6month = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            this.gb_studNumber.SuspendLayout();
            this.gb_stuffNumber.SuspendLayout();
            this.gb_calcProfits.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1130, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управління кампусом";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_studNumber
            // 
            this.tb_studNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_studNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_studNumber.Location = new System.Drawing.Point(6, 33);
            this.tb_studNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_studNumber.Multiline = true;
            this.tb_studNumber.Name = "tb_studNumber";
            this.tb_studNumber.PlaceholderText = "Ім\'я";
            this.tb_studNumber.Size = new System.Drawing.Size(250, 30);
            this.tb_studNumber.TabIndex = 12;
            this.tb_studNumber.TextChanged += new System.EventHandler(this.tb_studNumber_TextChanged);
            // 
            // pb_1
            // 
            this.pb_1.Location = new System.Drawing.Point(22, 230);
            this.pb_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(34, 34);
            this.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_1.TabIndex = 10;
            this.pb_1.TabStop = false;
            // 
            // tb_hostelID
            // 
            this.tb_hostelID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hostelID.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_hostelID.Location = new System.Drawing.Point(62, 230);
            this.tb_hostelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_hostelID.Multiline = true;
            this.tb_hostelID.Name = "tb_hostelID";
            this.tb_hostelID.Size = new System.Drawing.Size(373, 34);
            this.tb_hostelID.TabIndex = 9;
            this.tb_hostelID.TextChanged += new System.EventHandler(this.tb_hostelID_TextChanged);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancel.FlatAppearance.BorderSize = 0;
            this.bt_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_Cancel.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.Location = new System.Drawing.Point(680, 755);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(280, 60);
            this.bt_Cancel.TabIndex = 16;
            this.bt_Cancel.Text = "Відміна";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_addStudents
            // 
            this.bt_addStudents.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_addStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStudents.FlatAppearance.BorderSize = 0;
            this.bt_addStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addStudents.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStudents.Location = new System.Drawing.Point(624, 81);
            this.bt_addStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addStudents.Name = "bt_addStudents";
            this.bt_addStudents.Size = new System.Drawing.Size(144, 78);
            this.bt_addStudents.TabIndex = 15;
            this.bt_addStudents.Text = "Додати студента";
            this.bt_addStudents.UseVisualStyleBackColor = false;
            this.bt_addStudents.Click += new System.EventHandler(this.bt_addStudents_Click);
            // 
            // bt_showInfo
            // 
            this.bt_showInfo.BackColor = System.Drawing.Color.Yellow;
            this.bt_showInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_showInfo.FlatAppearance.BorderSize = 0;
            this.bt_showInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_showInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_showInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_showInfo.Location = new System.Drawing.Point(441, 230);
            this.bt_showInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_showInfo.Name = "bt_showInfo";
            this.bt_showInfo.Size = new System.Drawing.Size(364, 34);
            this.bt_showInfo.TabIndex = 23;
            this.bt_showInfo.Text = "Вивести інформацію про гуртожиток";
            this.bt_showInfo.UseVisualStyleBackColor = false;
            this.bt_showInfo.Click += new System.EventHandler(this.bt_showInfo_Click);
            // 
            // gb_studNumber
            // 
            this.gb_studNumber.Controls.Add(this.textBox8);
            this.gb_studNumber.Controls.Add(this.textBox7);
            this.gb_studNumber.Controls.Add(this.textBox6);
            this.gb_studNumber.Controls.Add(this.bt_addStudents);
            this.gb_studNumber.Controls.Add(this.textBox5);
            this.gb_studNumber.Controls.Add(this.textBox4);
            this.gb_studNumber.Controls.Add(this.textBox3);
            this.gb_studNumber.Controls.Add(this.textBox2);
            this.gb_studNumber.Controls.Add(this.tb_studNumber);
            this.gb_studNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_studNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_studNumber.Location = new System.Drawing.Point(23, 50);
            this.gb_studNumber.Name = "gb_studNumber";
            this.gb_studNumber.Size = new System.Drawing.Size(782, 175);
            this.gb_studNumber.TabIndex = 25;
            this.gb_studNumber.TabStop = false;
            this.gb_studNumber.Text = "Створити студента";
            // 
            // gb_stuffNumber
            // 
            this.gb_stuffNumber.Controls.Add(this.tb_stuffNumber);
            this.gb_stuffNumber.Controls.Add(this.bt_delStuff);
            this.gb_stuffNumber.Controls.Add(this.bt_addStuff);
            this.gb_stuffNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_stuffNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_stuffNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_stuffNumber.Location = new System.Drawing.Point(23, 442);
            this.gb_stuffNumber.Name = "gb_stuffNumber";
            this.gb_stuffNumber.Size = new System.Drawing.Size(1106, 116);
            this.gb_stuffNumber.TabIndex = 27;
            this.gb_stuffNumber.TabStop = false;
            this.gb_stuffNumber.Text = "Кількість робітників";
            // 
            // tb_stuffNumber
            // 
            this.tb_stuffNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_stuffNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_stuffNumber.Location = new System.Drawing.Point(12, 33);
            this.tb_stuffNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuffNumber.Multiline = true;
            this.tb_stuffNumber.Name = "tb_stuffNumber";
            this.tb_stuffNumber.Size = new System.Drawing.Size(400, 65);
            this.tb_stuffNumber.TabIndex = 12;
            this.tb_stuffNumber.TextChanged += new System.EventHandler(this.tb_stuffNumber_TextChanged);
            // 
            // bt_delStuff
            // 
            this.bt_delStuff.BackColor = System.Drawing.Color.Tomato;
            this.bt_delStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delStuff.FlatAppearance.BorderSize = 0;
            this.bt_delStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_delStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_delStuff.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delStuff.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_delStuff.Location = new System.Drawing.Point(811, 33);
            this.bt_delStuff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delStuff.Name = "bt_delStuff";
            this.bt_delStuff.Size = new System.Drawing.Size(280, 60);
            this.bt_delStuff.TabIndex = 17;
            this.bt_delStuff.Text = "Видалити робітників";
            this.bt_delStuff.UseVisualStyleBackColor = false;
            this.bt_delStuff.Click += new System.EventHandler(this.bt_delStuff_Click);
            // 
            // bt_addStuff
            // 
            this.bt_addStuff.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_addStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_addStuff.FlatAppearance.BorderSize = 0;
            this.bt_addStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_addStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_addStuff.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_addStuff.Location = new System.Drawing.Point(514, 33);
            this.bt_addStuff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addStuff.Name = "bt_addStuff";
            this.bt_addStuff.Size = new System.Drawing.Size(280, 60);
            this.bt_addStuff.TabIndex = 15;
            this.bt_addStuff.Text = "Додати робітників";
            this.bt_addStuff.UseVisualStyleBackColor = false;
            this.bt_addStuff.Click += new System.EventHandler(this.bt_addStuff_Click);
            // 
            // rb_year
            // 
            this.rb_year.AutoSize = true;
            this.rb_year.Location = new System.Drawing.Point(12, 34);
            this.rb_year.Name = "rb_year";
            this.rb_year.Size = new System.Drawing.Size(64, 32);
            this.rb_year.TabIndex = 28;
            this.rb_year.TabStop = true;
            this.rb_year.Text = "Рік";
            this.rb_year.UseVisualStyleBackColor = true;
            // 
            // gb_calcProfits
            // 
            this.gb_calcProfits.BackColor = System.Drawing.Color.Khaki;
            this.gb_calcProfits.Controls.Add(this.bt_calcProfit);
            this.gb_calcProfits.Controls.Add(this.rb_month);
            this.gb_calcProfits.Controls.Add(this.rb_6month);
            this.gb_calcProfits.Controls.Add(this.rb_year);
            this.gb_calcProfits.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_calcProfits.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_calcProfits.Location = new System.Drawing.Point(11, 736);
            this.gb_calcProfits.Name = "gb_calcProfits";
            this.gb_calcProfits.Size = new System.Drawing.Size(530, 82);
            this.gb_calcProfits.TabIndex = 29;
            this.gb_calcProfits.TabStop = false;
            this.gb_calcProfits.Text = "Порахувати доходи";
            // 
            // bt_calcProfit
            // 
            this.bt_calcProfit.BackColor = System.Drawing.Color.DarkKhaki;
            this.bt_calcProfit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_calcProfit.FlatAppearance.BorderSize = 0;
            this.bt_calcProfit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_calcProfit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_calcProfit.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_calcProfit.Location = new System.Drawing.Point(320, 27);
            this.bt_calcProfit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_calcProfit.Name = "bt_calcProfit";
            this.bt_calcProfit.Size = new System.Drawing.Size(200, 45);
            this.bt_calcProfit.TabIndex = 31;
            this.bt_calcProfit.Text = "Порахувати";
            this.bt_calcProfit.UseVisualStyleBackColor = false;
            this.bt_calcProfit.Click += new System.EventHandler(this.bt_calcProfit_Click);
            // 
            // rb_month
            // 
            this.rb_month.AutoSize = true;
            this.rb_month.Location = new System.Drawing.Point(208, 34);
            this.rb_month.Name = "rb_month";
            this.rb_month.Size = new System.Drawing.Size(106, 32);
            this.rb_month.TabIndex = 30;
            this.rb_month.TabStop = true;
            this.rb_month.Text = "Місяць";
            this.rb_month.UseVisualStyleBackColor = true;
            // 
            // rb_6month
            // 
            this.rb_6month.AutoSize = true;
            this.rb_6month.Location = new System.Drawing.Point(85, 34);
            this.rb_6month.Name = "rb_6month";
            this.rb_6month.Size = new System.Drawing.Size(117, 32);
            this.rb_6month.TabIndex = 29;
            this.rb_6month.TabStop = true;
            this.rb_6month.Text = "Півроку";
            this.rb_6month.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(22, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 167);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управління студентами";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(601, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 64);
            this.button1.TabIndex = 17;
            this.button1.Text = "Видалити студента";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(419, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 64);
            this.button2.TabIndex = 15;
            this.button2.Text = "Додати студента";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(262, 33);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Прізвище";
            this.textBox2.Size = new System.Drawing.Size(250, 30);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(518, 33);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "По батькові";
            this.textBox3.Size = new System.Drawing.Size(250, 30);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(6, 81);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Факультет";
            this.textBox4.Size = new System.Drawing.Size(200, 30);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(212, 81);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Група";
            this.textBox5.Size = new System.Drawing.Size(200, 30);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(418, 81);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Курс (цифрою)";
            this.textBox6.Size = new System.Drawing.Size(200, 30);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(6, 129);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "Ідентифікатор залікової книжки";
            this.textBox7.Size = new System.Drawing.Size(406, 30);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(418, 129);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.PlaceholderText = "Стать (М,Ж)";
            this.textBox8.Size = new System.Drawing.Size(200, 30);
            this.textBox8.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(7, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ідентифікатор залікової книжки";
            this.textBox1.Size = new System.Drawing.Size(406, 30);
            this.textBox1.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(7, 67);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.PlaceholderText = "Номер кімнати для поселення/переселення";
            this.textBox9.Size = new System.Drawing.Size(406, 30);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(7, 118);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.PlaceholderText = "Номер кімнати для переселення";
            this.textBox10.Size = new System.Drawing.Size(406, 34);
            this.textBox10.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(419, 118);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "Переселити студента";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // CampusManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1130, 837);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_calcProfits);
            this.Controls.Add(this.gb_stuffNumber);
            this.Controls.Add(this.gb_studNumber);
            this.Controls.Add(this.bt_showInfo);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.tb_hostelID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CampusManagement";
            this.Text = "ManageStudents";
            this.Load += new System.EventHandler(this.ManageHostels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            this.gb_studNumber.ResumeLayout(false);
            this.gb_studNumber.PerformLayout();
            this.gb_stuffNumber.ResumeLayout(false);
            this.gb_stuffNumber.PerformLayout();
            this.gb_calcProfits.ResumeLayout(false);
            this.gb_calcProfits.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_studNumber;
        private PictureBox pb_1;
        private TextBox tb_hostelID;
        private Button bt_Cancel;
        private Button bt_addStudents;
        private Button bt_showInfo;
        private GroupBox gb_studNumber;
        private GroupBox gb_stuffNumber;
        private TextBox tb_stuffNumber;
        private Button bt_delStuff;
        private Button bt_addStuff;
        private RadioButton radioButton1;
        private GroupBox gb_calcProfits;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton rb_year;
        private Button bt_calcProfit;
        private RadioButton rb_month;
        private RadioButton rb_6month;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox1;
    }
}