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
            this.tb_st_name = new System.Windows.Forms.TextBox();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.tb_hostelID = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_addStudents = new System.Windows.Forms.Button();
            this.bt_showInfo = new System.Windows.Forms.Button();
            this.gb_CreatingStudent = new System.Windows.Forms.GroupBox();
            this.tb_st_sex = new System.Windows.Forms.TextBox();
            this.tb_st_ID = new System.Windows.Forms.TextBox();
            this.tb_st_course = new System.Windows.Forms.TextBox();
            this.tb_st_group = new System.Windows.Forms.TextBox();
            this.tb_st_faculty = new System.Windows.Forms.TextBox();
            this.tb_st_patronymic = new System.Windows.Forms.TextBox();
            this.tb_st_surname = new System.Windows.Forms.TextBox();
            this.gb_workerManager = new System.Windows.Forms.GroupBox();
            this.gb_radioPosition = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.bt_delStuff = new System.Windows.Forms.Button();
            this.rb_year = new System.Windows.Forms.RadioButton();
            this.gb_calcProfits = new System.Windows.Forms.GroupBox();
            this.bt_calcProfit = new System.Windows.Forms.Button();
            this.rb_month = new System.Windows.Forms.RadioButton();
            this.rb_6month = new System.Windows.Forms.RadioButton();
            this.gb_studentManager = new System.Windows.Forms.GroupBox();
            this.bt_st_relocate = new System.Windows.Forms.Button();
            this.tb_Room_num_2 = new System.Windows.Forms.TextBox();
            this.tb_Room_num_1 = new System.Windows.Forms.TextBox();
            this.tb_Record_ID = new System.Windows.Forms.TextBox();
            this.bt_st_del = new System.Windows.Forms.Button();
            this.bt_st_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            this.gb_CreatingStudent.SuspendLayout();
            this.gb_workerManager.SuspendLayout();
            this.gb_radioPosition.SuspendLayout();
            this.gb_calcProfits.SuspendLayout();
            this.gb_studentManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управління кампусом";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_st_name
            // 
            this.tb_st_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_name.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_name.Location = new System.Drawing.Point(6, 33);
            this.tb_st_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_st_name.Multiline = true;
            this.tb_st_name.Name = "tb_st_name";
            this.tb_st_name.PlaceholderText = "Ім\'я";
            this.tb_st_name.Size = new System.Drawing.Size(250, 30);
            this.tb_st_name.TabIndex = 12;
            // 
            // pb_1
            // 
            this.pb_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_1.Image")));
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
            this.bt_Cancel.Location = new System.Drawing.Point(559, 631);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(232, 59);
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
            // gb_CreatingStudent
            // 
            this.gb_CreatingStudent.Controls.Add(this.tb_st_sex);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_ID);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_course);
            this.gb_CreatingStudent.Controls.Add(this.bt_addStudents);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_group);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_faculty);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_patronymic);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_surname);
            this.gb_CreatingStudent.Controls.Add(this.tb_st_name);
            this.gb_CreatingStudent.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_CreatingStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_CreatingStudent.Location = new System.Drawing.Point(23, 50);
            this.gb_CreatingStudent.Name = "gb_CreatingStudent";
            this.gb_CreatingStudent.Size = new System.Drawing.Size(782, 175);
            this.gb_CreatingStudent.TabIndex = 25;
            this.gb_CreatingStudent.TabStop = false;
            this.gb_CreatingStudent.Text = "Створити студента";
            // 
            // tb_st_sex
            // 
            this.tb_st_sex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_sex.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_sex.Location = new System.Drawing.Point(418, 129);
            this.tb_st_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_st_sex.Multiline = true;
            this.tb_st_sex.Name = "tb_st_sex";
            this.tb_st_sex.PlaceholderText = "Стать (Ч,Ж)";
            this.tb_st_sex.Size = new System.Drawing.Size(200, 30);
            this.tb_st_sex.TabIndex = 19;
            // 
            // tb_st_ID
            // 
            this.tb_st_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_ID.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_ID.Location = new System.Drawing.Point(6, 129);
            this.tb_st_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_st_ID.Multiline = true;
            this.tb_st_ID.Name = "tb_st_ID";
            this.tb_st_ID.PlaceholderText = "Ідентифікатор залікової книжки (опціонально)";
            this.tb_st_ID.Size = new System.Drawing.Size(406, 30);
            this.tb_st_ID.TabIndex = 18;
            // 
            // tb_st_course
            // 
            this.tb_st_course.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_course.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_course.Location = new System.Drawing.Point(418, 81);
            this.tb_st_course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_st_course.Multiline = true;
            this.tb_st_course.Name = "tb_st_course";
            this.tb_st_course.PlaceholderText = "Курс (цифрою)";
            this.tb_st_course.Size = new System.Drawing.Size(200, 30);
            this.tb_st_course.TabIndex = 17;
            // 
            // tb_st_group
            // 
            this.tb_st_group.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_group.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_group.Location = new System.Drawing.Point(212, 81);
            this.tb_st_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_st_group.Multiline = true;
            this.tb_st_group.Name = "tb_st_group";
            this.tb_st_group.PlaceholderText = "Група";
            this.tb_st_group.Size = new System.Drawing.Size(200, 30);
            this.tb_st_group.TabIndex = 16;
            // 
            // tb_st_faculty
            // 
            this.tb_st_faculty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_faculty.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_faculty.Location = new System.Drawing.Point(6, 81);
            this.tb_st_faculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_st_faculty.Multiline = true;
            this.tb_st_faculty.Name = "tb_st_faculty";
            this.tb_st_faculty.PlaceholderText = "Факультет";
            this.tb_st_faculty.Size = new System.Drawing.Size(200, 30);
            this.tb_st_faculty.TabIndex = 15;
            // 
            // tb_st_patronymic
            // 
            this.tb_st_patronymic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_patronymic.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_patronymic.Location = new System.Drawing.Point(518, 33);
            this.tb_st_patronymic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_st_patronymic.Multiline = true;
            this.tb_st_patronymic.Name = "tb_st_patronymic";
            this.tb_st_patronymic.PlaceholderText = "По батькові";
            this.tb_st_patronymic.Size = new System.Drawing.Size(250, 30);
            this.tb_st_patronymic.TabIndex = 14;
            // 
            // tb_st_surname
            // 
            this.tb_st_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_st_surname.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_st_surname.Location = new System.Drawing.Point(262, 33);
            this.tb_st_surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_st_surname.Multiline = true;
            this.tb_st_surname.Name = "tb_st_surname";
            this.tb_st_surname.PlaceholderText = "Прізвище";
            this.tb_st_surname.Size = new System.Drawing.Size(250, 30);
            this.tb_st_surname.TabIndex = 13;
            // 
            // gb_workerManager
            // 
            this.gb_workerManager.Controls.Add(this.gb_radioPosition);
            this.gb_workerManager.Controls.Add(this.textBox13);
            this.gb_workerManager.Controls.Add(this.textBox11);
            this.gb_workerManager.Controls.Add(this.textBox12);
            this.gb_workerManager.Controls.Add(this.bt_delStuff);
            this.gb_workerManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_workerManager.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_workerManager.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_workerManager.Location = new System.Drawing.Point(23, 442);
            this.gb_workerManager.Name = "gb_workerManager";
            this.gb_workerManager.Size = new System.Drawing.Size(782, 170);
            this.gb_workerManager.TabIndex = 27;
            this.gb_workerManager.TabStop = false;
            this.gb_workerManager.Text = "Управління робітниками";
            // 
            // gb_radioPosition
            // 
            this.gb_radioPosition.Controls.Add(this.radioButton3);
            this.gb_radioPosition.Controls.Add(this.radioButton4);
            this.gb_radioPosition.Controls.Add(this.radioButton1);
            this.gb_radioPosition.Controls.Add(this.radioButton2);
            this.gb_radioPosition.Location = new System.Drawing.Point(262, 30);
            this.gb_radioPosition.Name = "gb_radioPosition";
            this.gb_radioPosition.Size = new System.Drawing.Size(303, 85);
            this.gb_radioPosition.TabIndex = 25;
            this.gb_radioPosition.TabStop = false;
            this.gb_radioPosition.Text = "Посада";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(6, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 30);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Завгосп";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(143, 52);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(160, 30);
            this.radioButton4.TabIndex = 24;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Прибиральник";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(6, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 30);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Комендант";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(143, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 30);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Охоронець";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox13.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox13.Location = new System.Drawing.Point(6, 120);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.PlaceholderText = "Індивідуальний податковий номер (опціонально)";
            this.textBox13.Size = new System.Drawing.Size(506, 30);
            this.textBox13.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox11.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox11.Location = new System.Drawing.Point(6, 82);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.PlaceholderText = "Прізвище";
            this.textBox11.Size = new System.Drawing.Size(250, 30);
            this.textBox11.TabIndex = 19;
            // 
            // textBox12
            // 
            this.textBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox12.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox12.Location = new System.Drawing.Point(6, 48);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.PlaceholderText = "Ім\'я";
            this.textBox12.Size = new System.Drawing.Size(250, 30);
            this.textBox12.TabIndex = 18;
            // 
            // bt_delStuff
            // 
            this.bt_delStuff.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_delStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delStuff.FlatAppearance.BorderSize = 0;
            this.bt_delStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_delStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_delStuff.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delStuff.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_delStuff.Location = new System.Drawing.Point(571, 39);
            this.bt_delStuff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delStuff.Name = "bt_delStuff";
            this.bt_delStuff.Size = new System.Drawing.Size(197, 111);
            this.bt_delStuff.TabIndex = 17;
            this.bt_delStuff.Text = "Додати робітника";
            this.bt_delStuff.UseVisualStyleBackColor = false;
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
            this.gb_calcProfits.Location = new System.Drawing.Point(23, 618);
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
            // gb_studentManager
            // 
            this.gb_studentManager.Controls.Add(this.bt_st_relocate);
            this.gb_studentManager.Controls.Add(this.tb_Room_num_2);
            this.gb_studentManager.Controls.Add(this.tb_Room_num_1);
            this.gb_studentManager.Controls.Add(this.tb_Record_ID);
            this.gb_studentManager.Controls.Add(this.bt_st_del);
            this.gb_studentManager.Controls.Add(this.bt_st_add);
            this.gb_studentManager.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_studentManager.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_studentManager.Location = new System.Drawing.Point(22, 269);
            this.gb_studentManager.Name = "gb_studentManager";
            this.gb_studentManager.Size = new System.Drawing.Size(783, 167);
            this.gb_studentManager.TabIndex = 26;
            this.gb_studentManager.TabStop = false;
            this.gb_studentManager.Text = "Управління студентами";
            // 
            // bt_st_relocate
            // 
            this.bt_st_relocate.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_st_relocate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_st_relocate.FlatAppearance.BorderSize = 0;
            this.bt_st_relocate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_st_relocate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_st_relocate.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_st_relocate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_st_relocate.Location = new System.Drawing.Point(419, 118);
            this.bt_st_relocate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_st_relocate.Name = "bt_st_relocate";
            this.bt_st_relocate.Size = new System.Drawing.Size(350, 34);
            this.bt_st_relocate.TabIndex = 24;
            this.bt_st_relocate.Text = "Переселити студента";
            this.bt_st_relocate.UseVisualStyleBackColor = false;
            this.bt_st_relocate.Click += new System.EventHandler(this.bt_st_relocate_Click);
            // 
            // tb_Room_num_2
            // 
            this.tb_Room_num_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Room_num_2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Room_num_2.Location = new System.Drawing.Point(7, 118);
            this.tb_Room_num_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Room_num_2.Multiline = true;
            this.tb_Room_num_2.Name = "tb_Room_num_2";
            this.tb_Room_num_2.PlaceholderText = "Номер кімнати для переселення";
            this.tb_Room_num_2.Size = new System.Drawing.Size(406, 34);
            this.tb_Room_num_2.TabIndex = 21;
            // 
            // tb_Room_num_1
            // 
            this.tb_Room_num_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Room_num_1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Room_num_1.Location = new System.Drawing.Point(7, 71);
            this.tb_Room_num_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Room_num_1.Multiline = true;
            this.tb_Room_num_1.Name = "tb_Room_num_1";
            this.tb_Room_num_1.PlaceholderText = "Номер кімнати для поселення/переселення";
            this.tb_Room_num_1.Size = new System.Drawing.Size(406, 34);
            this.tb_Room_num_1.TabIndex = 20;
            // 
            // tb_Record_ID
            // 
            this.tb_Record_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Record_ID.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Record_ID.Location = new System.Drawing.Point(7, 33);
            this.tb_Record_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Record_ID.Multiline = true;
            this.tb_Record_ID.Name = "tb_Record_ID";
            this.tb_Record_ID.PlaceholderText = "Ідентифікатор залікової книжки";
            this.tb_Record_ID.Size = new System.Drawing.Size(406, 34);
            this.tb_Record_ID.TabIndex = 19;
            // 
            // bt_st_del
            // 
            this.bt_st_del.BackColor = System.Drawing.Color.Tomato;
            this.bt_st_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_st_del.FlatAppearance.BorderSize = 0;
            this.bt_st_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bt_st_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_st_del.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_st_del.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_st_del.Location = new System.Drawing.Point(601, 33);
            this.bt_st_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_st_del.Name = "bt_st_del";
            this.bt_st_del.Size = new System.Drawing.Size(168, 72);
            this.bt_st_del.TabIndex = 17;
            this.bt_st_del.Text = "Видалити студента";
            this.bt_st_del.UseVisualStyleBackColor = false;
            this.bt_st_del.Click += new System.EventHandler(this.bt_st_del_Click);
            // 
            // bt_st_add
            // 
            this.bt_st_add.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_st_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_st_add.FlatAppearance.BorderSize = 0;
            this.bt_st_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_st_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_st_add.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_st_add.Location = new System.Drawing.Point(419, 33);
            this.bt_st_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_st_add.Name = "bt_st_add";
            this.bt_st_add.Size = new System.Drawing.Size(176, 72);
            this.bt_st_add.TabIndex = 15;
            this.bt_st_add.Text = "Додати студента";
            this.bt_st_add.UseVisualStyleBackColor = false;
            this.bt_st_add.Click += new System.EventHandler(this.bt_st_add_Click);
            // 
            // CampusManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(814, 711);
            this.Controls.Add(this.gb_studentManager);
            this.Controls.Add(this.gb_calcProfits);
            this.Controls.Add(this.gb_workerManager);
            this.Controls.Add(this.gb_CreatingStudent);
            this.Controls.Add(this.bt_showInfo);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.tb_hostelID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(834, 754);
            this.MinimumSize = new System.Drawing.Size(834, 754);
            this.Name = "CampusManagement";
            this.Text = "ManageStudents";
            this.Load += new System.EventHandler(this.ManageHostels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            this.gb_CreatingStudent.ResumeLayout(false);
            this.gb_CreatingStudent.PerformLayout();
            this.gb_workerManager.ResumeLayout(false);
            this.gb_workerManager.PerformLayout();
            this.gb_radioPosition.ResumeLayout(false);
            this.gb_radioPosition.PerformLayout();
            this.gb_calcProfits.ResumeLayout(false);
            this.gb_calcProfits.PerformLayout();
            this.gb_studentManager.ResumeLayout(false);
            this.gb_studentManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_st_name;
        private PictureBox pb_1;
        private TextBox tb_hostelID;
        private Button bt_Cancel;
        private Button bt_addStudents;
        private Button bt_showInfo;
        private GroupBox gb_CreatingStudent;
        private GroupBox gb_workerManager;
        private Button bt_delStuff;
        private RadioButton radioButton1;
        private GroupBox gb_calcProfits;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton rb_year;
        private Button bt_calcProfit;
        private RadioButton rb_month;
        private RadioButton rb_6month;
        private GroupBox gb_studentManager;
        private Button bt_st_del;
        private Button bt_st_add;
        private TextBox tb_st_sex;
        private TextBox tb_st_ID;
        private TextBox tb_st_course;
        private TextBox tb_st_group;
        private TextBox tb_st_faculty;
        private TextBox tb_st_patronymic;
        private TextBox tb_st_surname;
        private Button bt_st_relocate;
        private TextBox tb_Room_num_2;
        private TextBox tb_Room_num_1;
        private TextBox tb_Record_ID;
        private TextBox textBox11;
        private TextBox textBox12;
        private GroupBox gb_radioPosition;
        private RadioButton radioButton4;
        private TextBox textBox13;
    }
}