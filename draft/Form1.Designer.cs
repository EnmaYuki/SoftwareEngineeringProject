namespace JSONandSQL
{
    partial class Form1
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
            this.btn_addJSONbin = new System.Windows.Forms.Button();
            this.btn_getJSONbin = new System.Windows.Forms.Button();
            this.Bin_name = new System.Windows.Forms.Label();
            this.Bin_data = new System.Windows.Forms.Label();
            this.bin_key = new System.Windows.Forms.Label();
            this.tb_resultKey = new System.Windows.Forms.TextBox();
            this.tb_resultData = new System.Windows.Forms.TextBox();
            this.btn_toSQL = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_courseid = new System.Windows.Forms.ComboBox();
            this.cb_studentyear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.btn_getstudent = new System.Windows.Forms.Button();
            this.cb_hour = new System.Windows.Forms.ComboBox();
            this.lb_hour = new System.Windows.Forms.Label();
            this.cb_minute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentlist = new System.Windows.Forms.CheckedListBox();
            this.cb_lesson = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addJSONbin
            // 
            this.btn_addJSONbin.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addJSONbin.Location = new System.Drawing.Point(50, 240);
            this.btn_addJSONbin.Name = "btn_addJSONbin";
            this.btn_addJSONbin.Size = new System.Drawing.Size(117, 23);
            this.btn_addJSONbin.TabIndex = 29;
            this.btn_addJSONbin.Text = "Create JSON Bin";
            this.btn_addJSONbin.UseVisualStyleBackColor = true;
            this.btn_addJSONbin.Click += new System.EventHandler(this.btn_addJSONbin_Click);
            // 
            // btn_getJSONbin
            // 
            this.btn_getJSONbin.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_getJSONbin.Location = new System.Drawing.Point(267, 240);
            this.btn_getJSONbin.Name = "btn_getJSONbin";
            this.btn_getJSONbin.Size = new System.Drawing.Size(117, 23);
            this.btn_getJSONbin.TabIndex = 28;
            this.btn_getJSONbin.Text = "Get JSON collection";
            this.btn_getJSONbin.UseVisualStyleBackColor = true;
            this.btn_getJSONbin.Click += new System.EventHandler(this.btn_getJSONbin_Click);
            // 
            // Bin_name
            // 
            this.Bin_name.AutoSize = true;
            this.Bin_name.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bin_name.Location = new System.Drawing.Point(559, 266);
            this.Bin_name.Name = "Bin_name";
            this.Bin_name.Size = new System.Drawing.Size(70, 16);
            this.Bin_name.TabIndex = 27;
            this.Bin_name.Text = "Bin Name";
            // 
            // Bin_data
            // 
            this.Bin_data.AutoSize = true;
            this.Bin_data.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bin_data.Location = new System.Drawing.Point(295, 266);
            this.Bin_data.Name = "Bin_data";
            this.Bin_data.Size = new System.Drawing.Size(62, 16);
            this.Bin_data.TabIndex = 26;
            this.Bin_data.Text = "Bin Data";
            // 
            // bin_key
            // 
            this.bin_key.AutoSize = true;
            this.bin_key.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bin_key.Location = new System.Drawing.Point(77, 266);
            this.bin_key.Name = "bin_key";
            this.bin_key.Size = new System.Drawing.Size(49, 16);
            this.bin_key.TabIndex = 25;
            this.bin_key.Text = "Bin ID";
            // 
            // tb_resultKey
            // 
            this.tb_resultKey.Location = new System.Drawing.Point(8, 285);
            this.tb_resultKey.Multiline = true;
            this.tb_resultKey.Name = "tb_resultKey";
            this.tb_resultKey.ReadOnly = true;
            this.tb_resultKey.Size = new System.Drawing.Size(182, 100);
            this.tb_resultKey.TabIndex = 19;
            // 
            // tb_resultData
            // 
            this.tb_resultData.Location = new System.Drawing.Point(196, 285);
            this.tb_resultData.Multiline = true;
            this.tb_resultData.Name = "tb_resultData";
            this.tb_resultData.ReadOnly = true;
            this.tb_resultData.Size = new System.Drawing.Size(251, 100);
            this.tb_resultData.TabIndex = 18;
            // 
            // btn_toSQL
            // 
            this.btn_toSQL.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_toSQL.Location = new System.Drawing.Point(537, 240);
            this.btn_toSQL.Name = "btn_toSQL";
            this.btn_toSQL.Size = new System.Drawing.Size(117, 23);
            this.btn_toSQL.TabIndex = 16;
            this.btn_toSQL.Text = "Insert into SQL";
            this.btn_toSQL.UseVisualStyleBackColor = true;
            this.btn_toSQL.Click += new System.EventHandler(this.btn_toSQL_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_excel.Location = new System.Drawing.Point(710, 308);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(157, 36);
            this.btn_excel.TabIndex = 31;
            this.btn_excel.Text = "generate Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_logout.Location = new System.Drawing.Point(759, 350);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(86, 35);
            this.btn_logout.TabIndex = 32;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(389, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Course Id";
            // 
            // cb_courseid
            // 
            this.cb_courseid.FormatString = "N0";
            this.cb_courseid.FormattingEnabled = true;
            this.cb_courseid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_courseid.Location = new System.Drawing.Point(464, 20);
            this.cb_courseid.Name = "cb_courseid";
            this.cb_courseid.Size = new System.Drawing.Size(121, 20);
            this.cb_courseid.TabIndex = 35;
            // 
            // cb_studentyear
            // 
            this.cb_studentyear.FormattingEnabled = true;
            this.cb_studentyear.Items.AddRange(new object[] {
            "1",
            "2",
            "All"});
            this.cb_studentyear.Location = new System.Drawing.Point(197, 22);
            this.cb_studentyear.Name = "cb_studentyear";
            this.cb_studentyear.Size = new System.Drawing.Size(46, 20);
            this.cb_studentyear.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.label2.Location = new System.Drawing.Point(103, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Student Year";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(453, 285);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(251, 100);
            this.tb_result.TabIndex = 17;
            // 
            // btn_getstudent
            // 
            this.btn_getstudent.Location = new System.Drawing.Point(249, 22);
            this.btn_getstudent.Name = "btn_getstudent";
            this.btn_getstudent.Size = new System.Drawing.Size(75, 23);
            this.btn_getstudent.TabIndex = 42;
            this.btn_getstudent.Text = "get student";
            this.btn_getstudent.UseVisualStyleBackColor = true;
            this.btn_getstudent.Click += new System.EventHandler(this.btn_getstudent_Click);
            // 
            // cb_hour
            // 
            this.cb_hour.FormattingEnabled = true;
            this.cb_hour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.cb_hour.Location = new System.Drawing.Point(464, 59);
            this.cb_hour.Name = "cb_hour";
            this.cb_hour.Size = new System.Drawing.Size(121, 20);
            this.cb_hour.TabIndex = 44;
            // 
            // lb_hour
            // 
            this.lb_hour.AutoSize = true;
            this.lb_hour.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_hour.Location = new System.Drawing.Point(389, 59);
            this.lb_hour.Name = "lb_hour";
            this.lb_hour.Size = new System.Drawing.Size(39, 16);
            this.lb_hour.TabIndex = 43;
            this.lb_hour.Text = "Hour";
            // 
            // cb_minute
            // 
            this.cb_minute.FormattingEnabled = true;
            this.cb_minute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cb_minute.Location = new System.Drawing.Point(648, 57);
            this.cb_minute.Name = "cb_minute";
            this.cb_minute.Size = new System.Drawing.Size(121, 20);
            this.cb_minute.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(591, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Minute";
            // 
            // studentlist
            // 
            this.studentlist.FormattingEnabled = true;
            this.studentlist.Location = new System.Drawing.Point(169, 48);
            this.studentlist.Name = "studentlist";
            this.studentlist.Size = new System.Drawing.Size(103, 174);
            this.studentlist.TabIndex = 51;
            // 
            // cb_lesson
            // 
            this.cb_lesson.FormattingEnabled = true;
            this.cb_lesson.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_lesson.Location = new System.Drawing.Point(648, 20);
            this.cb_lesson.Name = "cb_lesson";
            this.cb_lesson.Size = new System.Drawing.Size(121, 20);
            this.cb_lesson.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(591, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Lesson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 474);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_lesson);
            this.Controls.Add(this.studentlist);
            this.Controls.Add(this.cb_minute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_hour);
            this.Controls.Add(this.lb_hour);
            this.Controls.Add(this.btn_getstudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_studentyear);
            this.Controls.Add(this.cb_courseid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_addJSONbin);
            this.Controls.Add(this.btn_getJSONbin);
            this.Controls.Add(this.Bin_name);
            this.Controls.Add(this.Bin_data);
            this.Controls.Add(this.bin_key);
            this.Controls.Add(this.tb_resultKey);
            this.Controls.Add(this.tb_resultData);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_toSQL);
            this.Name = "Form1";
            this.Text = "Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addJSONbin;
        private System.Windows.Forms.Button btn_getJSONbin;
        private System.Windows.Forms.Label Bin_name;
        private System.Windows.Forms.Label Bin_data;
        private System.Windows.Forms.Label bin_key;
        private System.Windows.Forms.TextBox tb_resultKey;
        private System.Windows.Forms.TextBox tb_resultData;
        private System.Windows.Forms.Button btn_toSQL;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_courseid;
        private System.Windows.Forms.ComboBox cb_studentyear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button btn_getstudent;
        private System.Windows.Forms.ComboBox cb_hour;
        private System.Windows.Forms.Label lb_hour;
        private System.Windows.Forms.ComboBox cb_minute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox studentlist;
        private System.Windows.Forms.ComboBox cb_lesson;
        private System.Windows.Forms.Label label6;
    }
}

