namespace JSONandSQL
{
    partial class Form2
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
            this.tb_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_course = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_venue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.btn_sql = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_starttime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_weekdays = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(86, 12);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(100, 22);
            this.tb_year.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "School Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Name";
            // 
            // tb_course
            // 
            this.tb_course.Location = new System.Drawing.Point(86, 40);
            this.tb_course.Name = "tb_course";
            this.tb_course.Size = new System.Drawing.Size(100, 22);
            this.tb_course.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Venue";
            // 
            // tb_venue
            // 
            this.tb_venue.Location = new System.Drawing.Point(86, 68);
            this.tb_venue.Name = "tb_venue";
            this.tb_venue.Size = new System.Drawing.Size(100, 22);
            this.tb_venue.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class size";
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(86, 152);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(100, 22);
            this.tb_size.TabIndex = 8;
            // 
            // btn_sql
            // 
            this.btn_sql.Location = new System.Drawing.Point(20, 192);
            this.btn_sql.Name = "btn_sql";
            this.btn_sql.Size = new System.Drawing.Size(75, 23);
            this.btn_sql.TabIndex = 10;
            this.btn_sql.Text = "store to SQL";
            this.btn_sql.UseVisualStyleBackColor = true;
            this.btn_sql.Click += new System.EventHandler(this.btn_sql_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start Time";
            // 
            // tb_starttime
            // 
            this.tb_starttime.Location = new System.Drawing.Point(86, 124);
            this.tb_starttime.Name = "tb_starttime";
            this.tb_starttime.Size = new System.Drawing.Size(100, 22);
            this.tb_starttime.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Weekdays";
            // 
            // tb_weekdays
            // 
            this.tb_weekdays.Location = new System.Drawing.Point(86, 96);
            this.tb_weekdays.Name = "tb_weekdays";
            this.tb_weekdays.Size = new System.Drawing.Size(100, 22);
            this.tb_weekdays.TabIndex = 13;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(111, 192);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Return";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 262);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_weekdays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_starttime);
            this.Controls.Add(this.btn_sql);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_venue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_course);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_year);
            this.Name = "Form2";
            this.Text = "Add Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_venue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.Button btn_sql;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_starttime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_weekdays;
        private System.Windows.Forms.Button btn_back;
    }
}