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
            this.cb_courseid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_addJSONbin = new System.Windows.Forms.Button();
            this.btn_getJSONbin = new System.Windows.Forms.Button();
            this.Bin_name = new System.Windows.Forms.Label();
            this.Bin_data = new System.Windows.Forms.Label();
            this.bin_key = new System.Windows.Forms.Label();
            this.tb_resultKey = new System.Windows.Forms.TextBox();
            this.tb_resultData = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.btn_toSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cb_courseid.Location = new System.Drawing.Point(304, 12);
            this.cb_courseid.Name = "cb_courseid";
            this.cb_courseid.Size = new System.Drawing.Size(121, 20);
            this.cb_courseid.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(229, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Course Id";
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_logout.Location = new System.Drawing.Point(291, 194);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(86, 35);
            this.btn_logout.TabIndex = 66;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_addJSONbin
            // 
            this.btn_addJSONbin.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addJSONbin.Location = new System.Drawing.Point(67, 43);
            this.btn_addJSONbin.Name = "btn_addJSONbin";
            this.btn_addJSONbin.Size = new System.Drawing.Size(117, 23);
            this.btn_addJSONbin.TabIndex = 64;
            this.btn_addJSONbin.Text = "Create JSON Bin";
            this.btn_addJSONbin.UseVisualStyleBackColor = true;
            this.btn_addJSONbin.Click += new System.EventHandler(this.btn_addJSONbin_Click);
            // 
            // btn_getJSONbin
            // 
            this.btn_getJSONbin.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_getJSONbin.Location = new System.Drawing.Point(269, 43);
            this.btn_getJSONbin.Name = "btn_getJSONbin";
            this.btn_getJSONbin.Size = new System.Drawing.Size(117, 23);
            this.btn_getJSONbin.TabIndex = 63;
            this.btn_getJSONbin.Text = "Get JSON collection";
            this.btn_getJSONbin.UseVisualStyleBackColor = true;
            this.btn_getJSONbin.Click += new System.EventHandler(this.btn_getJSONbin_Click);
            // 
            // Bin_name
            // 
            this.Bin_name.AutoSize = true;
            this.Bin_name.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bin_name.Location = new System.Drawing.Point(564, 69);
            this.Bin_name.Name = "Bin_name";
            this.Bin_name.Size = new System.Drawing.Size(70, 16);
            this.Bin_name.TabIndex = 62;
            this.Bin_name.Text = "Bin Name";
            // 
            // Bin_data
            // 
            this.Bin_data.AutoSize = true;
            this.Bin_data.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bin_data.Location = new System.Drawing.Point(297, 69);
            this.Bin_data.Name = "Bin_data";
            this.Bin_data.Size = new System.Drawing.Size(62, 16);
            this.Bin_data.TabIndex = 61;
            this.Bin_data.Text = "Bin Data";
            // 
            // bin_key
            // 
            this.bin_key.AutoSize = true;
            this.bin_key.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bin_key.Location = new System.Drawing.Point(94, 69);
            this.bin_key.Name = "bin_key";
            this.bin_key.Size = new System.Drawing.Size(49, 16);
            this.bin_key.TabIndex = 60;
            this.bin_key.Text = "Bin ID";
            // 
            // tb_resultKey
            // 
            this.tb_resultKey.Location = new System.Drawing.Point(12, 88);
            this.tb_resultKey.Multiline = true;
            this.tb_resultKey.Name = "tb_resultKey";
            this.tb_resultKey.Size = new System.Drawing.Size(195, 101);
            this.tb_resultKey.TabIndex = 59;
            // 
            // tb_resultData
            // 
            this.tb_resultData.Location = new System.Drawing.Point(213, 88);
            this.tb_resultData.Multiline = true;
            this.tb_resultData.Name = "tb_resultData";
            this.tb_resultData.Size = new System.Drawing.Size(251, 101);
            this.tb_resultData.TabIndex = 58;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(470, 88);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(251, 101);
            this.tb_result.TabIndex = 57;
            // 
            // btn_toSQL
            // 
            this.btn_toSQL.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_toSQL.Location = new System.Drawing.Point(538, 43);
            this.btn_toSQL.Name = "btn_toSQL";
            this.btn_toSQL.Size = new System.Drawing.Size(117, 23);
            this.btn_toSQL.TabIndex = 56;
            this.btn_toSQL.Text = "Insert into SQL";
            this.btn_toSQL.UseVisualStyleBackColor = true;
            this.btn_toSQL.Click += new System.EventHandler(this.btn_toSQL_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 248);
            this.Controls.Add(this.cb_courseid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_addJSONbin);
            this.Controls.Add(this.btn_getJSONbin);
            this.Controls.Add(this.Bin_name);
            this.Controls.Add(this.Bin_data);
            this.Controls.Add(this.bin_key);
            this.Controls.Add(this.tb_resultKey);
            this.Controls.Add(this.tb_resultData);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_toSQL);
            this.Name = "Form2";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_courseid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_addJSONbin;
        private System.Windows.Forms.Button btn_getJSONbin;
        private System.Windows.Forms.Label Bin_name;
        private System.Windows.Forms.Label Bin_data;
        private System.Windows.Forms.Label bin_key;
        private System.Windows.Forms.TextBox tb_resultKey;
        private System.Windows.Forms.TextBox tb_resultData;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button btn_toSQL;
    }
}