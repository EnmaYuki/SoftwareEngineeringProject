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
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.btn_addJSONbin = new System.Windows.Forms.Button();
            this.btn_getJSONbin = new System.Windows.Forms.Button();
            this.Bin_name = new System.Windows.Forms.Label();
            this.Bin_data = new System.Windows.Forms.Label();
            this.bin_key = new System.Windows.Forms.Label();
            this.lb_location = new System.Windows.Forms.Label();
            this.lb_subject = new System.Windows.Forms.Label();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.tb_resultKey = new System.Windows.Forms.TextBox();
            this.tb_resultData = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.btn_toSQL = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.lb_userID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(53, 38);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(221, 20);
            this.tb_subject.TabIndex = 30;
            // 
            // btn_addJSONbin
            // 
            this.btn_addJSONbin.Location = new System.Drawing.Point(231, 86);
            this.btn_addJSONbin.Name = "btn_addJSONbin";
            this.btn_addJSONbin.Size = new System.Drawing.Size(117, 25);
            this.btn_addJSONbin.TabIndex = 29;
            this.btn_addJSONbin.Text = "Create JSON Bin";
            this.btn_addJSONbin.UseVisualStyleBackColor = true;
            this.btn_addJSONbin.Click += new System.EventHandler(this.btn_addJSONbin_Click);
            // 
            // btn_getJSONbin
            // 
            this.btn_getJSONbin.Location = new System.Drawing.Point(354, 86);
            this.btn_getJSONbin.Name = "btn_getJSONbin";
            this.btn_getJSONbin.Size = new System.Drawing.Size(117, 25);
            this.btn_getJSONbin.TabIndex = 28;
            this.btn_getJSONbin.Text = "Get JSON collection";
            this.btn_getJSONbin.UseVisualStyleBackColor = true;
            this.btn_getJSONbin.Click += new System.EventHandler(this.btn_getJSONbin_Click);
            // 
            // Bin_name
            // 
            this.Bin_name.AutoSize = true;
            this.Bin_name.Location = new System.Drawing.Point(633, 114);
            this.Bin_name.Name = "Bin_name";
            this.Bin_name.Size = new System.Drawing.Size(53, 13);
            this.Bin_name.TabIndex = 27;
            this.Bin_name.Text = "Bin Name";
            // 
            // Bin_data
            // 
            this.Bin_data.AutoSize = true;
            this.Bin_data.Location = new System.Drawing.Point(389, 114);
            this.Bin_data.Name = "Bin_data";
            this.Bin_data.Size = new System.Drawing.Size(48, 13);
            this.Bin_data.TabIndex = 26;
            this.Bin_data.Text = "Bin Data";
            // 
            // bin_key
            // 
            this.bin_key.AutoSize = true;
            this.bin_key.Location = new System.Drawing.Point(123, 114);
            this.bin_key.Name = "bin_key";
            this.bin_key.Size = new System.Drawing.Size(36, 13);
            this.bin_key.TabIndex = 25;
            this.bin_key.Text = "Bin ID";
            // 
            // lb_location
            // 
            this.lb_location.AutoSize = true;
            this.lb_location.Location = new System.Drawing.Point(313, 41);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(38, 13);
            this.lb_location.TabIndex = 24;
            this.lb_location.Text = "Venue";
            // 
            // lb_subject
            // 
            this.lb_subject.AutoSize = true;
            this.lb_subject.Location = new System.Drawing.Point(11, 41);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(46, 13);
            this.lb_subject.TabIndex = 23;
            this.lb_subject.Text = "Subject:";
            // 
            // tb_userID
            // 
            this.tb_userID.Location = new System.Drawing.Point(643, 38);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(149, 20);
            this.tb_userID.TabIndex = 21;
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(351, 38);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(180, 20);
            this.tb_location.TabIndex = 20;
            // 
            // tb_resultKey
            // 
            this.tb_resultKey.Location = new System.Drawing.Point(12, 130);
            this.tb_resultKey.Multiline = true;
            this.tb_resultKey.Name = "tb_resultKey";
            this.tb_resultKey.Size = new System.Drawing.Size(262, 108);
            this.tb_resultKey.TabIndex = 19;
            // 
            // tb_resultData
            // 
            this.tb_resultData.Location = new System.Drawing.Point(280, 130);
            this.tb_resultData.Multiline = true;
            this.tb_resultData.Name = "tb_resultData";
            this.tb_resultData.Size = new System.Drawing.Size(251, 108);
            this.tb_resultData.TabIndex = 18;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(537, 130);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(251, 108);
            this.tb_result.TabIndex = 17;
            // 
            // btn_toSQL
            // 
            this.btn_toSQL.Location = new System.Drawing.Point(477, 86);
            this.btn_toSQL.Name = "btn_toSQL";
            this.btn_toSQL.Size = new System.Drawing.Size(117, 25);
            this.btn_toSQL.TabIndex = 16;
            this.btn_toSQL.Text = "Insert into SQL";
            this.btn_toSQL.UseVisualStyleBackColor = true;
            this.btn_toSQL.Click += new System.EventHandler(this.btn_toSQL_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(330, 245);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(157, 25);
            this.btn_excel.TabIndex = 31;
            this.btn_excel.Text = "generate Report";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // lb_userID
            // 
            this.lb_userID.AutoSize = true;
            this.lb_userID.Location = new System.Drawing.Point(579, 41);
            this.lb_userID.Name = "lb_userID";
            this.lb_userID.Size = new System.Drawing.Size(61, 13);
            this.lb_userID.TabIndex = 32;
            this.lb_userID.Text = "Student_ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 285);
            this.Controls.Add(this.lb_userID);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.btn_addJSONbin);
            this.Controls.Add(this.btn_getJSONbin);
            this.Controls.Add(this.Bin_name);
            this.Controls.Add(this.Bin_data);
            this.Controls.Add(this.bin_key);
            this.Controls.Add(this.lb_location);
            this.Controls.Add(this.lb_subject);
            this.Controls.Add(this.tb_userID);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_resultKey);
            this.Controls.Add(this.tb_resultData);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_toSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Button btn_addJSONbin;
        private System.Windows.Forms.Button btn_getJSONbin;
        private System.Windows.Forms.Label Bin_name;
        private System.Windows.Forms.Label Bin_data;
        private System.Windows.Forms.Label bin_key;
        private System.Windows.Forms.Label lb_location;
        private System.Windows.Forms.Label lb_subject;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.TextBox tb_resultKey;
        private System.Windows.Forms.TextBox tb_resultData;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button btn_toSQL;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Label lb_userID;
    }
}

