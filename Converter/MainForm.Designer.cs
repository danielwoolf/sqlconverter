namespace Converter
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSqlAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQLitePath = new System.Windows.Forms.TextBox();
            this.btnBrowseSQLitePath = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDatabases = new System.Windows.Forms.ComboBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxEncrypt = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbxIntegrated = new System.Windows.Forms.CheckBox();
            this.txtUserDB = new System.Windows.Forms.TextBox();
            this.txtPassDB = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbxTriggers = new System.Windows.Forms.CheckBox();
            this.cbxCreateViews = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Server Address:";
            // 
            // txtSqlAddress
            // 
            this.txtSqlAddress.Location = new System.Drawing.Point(154, 17);
            this.txtSqlAddress.Name = "txtSqlAddress";
            this.txtSqlAddress.Size = new System.Drawing.Size(465, 20);
            this.txtSqlAddress.TabIndex = 1;
            this.txtSqlAddress.TextChanged += new System.EventHandler(this.txtSqlAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SQLite Database File Path:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSQLitePath
            // 
            this.txtSQLitePath.Location = new System.Drawing.Point(151, 161);
            this.txtSQLitePath.Name = "txtSQLitePath";
            this.txtSQLitePath.Size = new System.Drawing.Size(468, 20);
            this.txtSQLitePath.TabIndex = 7;
            this.txtSQLitePath.TextChanged += new System.EventHandler(this.txtSQLitePath_TextChanged);
            // 
            // btnBrowseSQLitePath
            // 
            this.btnBrowseSQLitePath.Location = new System.Drawing.Point(624, 159);
            this.btnBrowseSQLitePath.Name = "btnBrowseSQLitePath";
            this.btnBrowseSQLitePath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSQLitePath.TabIndex = 8;
            this.btnBrowseSQLitePath.Text = "Browse...";
            this.btnBrowseSQLitePath.UseVisualStyleBackColor = true;
            this.btnBrowseSQLitePath.Click += new System.EventHandler(this.btnBrowseSQLitePath_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(248, 327);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 37);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start The Conversion Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "db";
            this.saveFileDialog1.Filter = "SQLite Files|*.db|All Files|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Database:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboDatabases
            // 
            this.cboDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabases.Enabled = false;
            this.cboDatabases.FormattingEnabled = true;
            this.cboDatabases.Location = new System.Drawing.Point(154, 108);
            this.cboDatabases.Name = "cboDatabases";
            this.cboDatabases.Size = new System.Drawing.Size(465, 21);
            this.cboDatabases.TabIndex = 6;
            this.cboDatabases.SelectedIndexChanged += new System.EventHandler(this.cboDatabases_SelectedIndexChanged);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(508, 70);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(111, 23);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Connect";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // pbrProgress
            // 
            this.pbrProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbrProgress.Location = new System.Drawing.Point(15, 300);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(687, 18);
            this.pbrProgress.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.Location = new System.Drawing.Point(90, 284);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(529, 13);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(604, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 37);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxEncrypt
            // 
            this.cbxEncrypt.AutoSize = true;
            this.cbxEncrypt.Location = new System.Drawing.Point(12, 190);
            this.cbxEncrypt.Name = "cbxEncrypt";
            this.cbxEncrypt.Size = new System.Drawing.Size(127, 17);
            this.cbxEncrypt.TabIndex = 9;
            this.cbxEncrypt.Text = "Encryption password:";
            this.cbxEncrypt.UseVisualStyleBackColor = true;
            this.cbxEncrypt.CheckedChanged += new System.EventHandler(this.cbxEncrypt_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(317, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbxIntegrated
            // 
            this.cbxIntegrated.Location = new System.Drawing.Point(499, 43);
            this.cbxIntegrated.Name = "cbxIntegrated";
            this.cbxIntegrated.Size = new System.Drawing.Size(120, 21);
            this.cbxIntegrated.TabIndex = 4;
            this.cbxIntegrated.Text = "Integrated security";
            this.cbxIntegrated.UseVisualStyleBackColor = true;
            this.cbxIntegrated.CheckedChanged += new System.EventHandler(this.ChkIntegratedCheckedChanged);
            // 
            // txtUserDB
            // 
            this.txtUserDB.Location = new System.Drawing.Point(191, 43);
            this.txtUserDB.Name = "txtUserDB";
            this.txtUserDB.Size = new System.Drawing.Size(100, 20);
            this.txtUserDB.TabIndex = 2;
            // 
            // txtPassDB
            // 
            this.txtPassDB.Location = new System.Drawing.Point(356, 43);
            this.txtPassDB.Name = "txtPassDB";
            this.txtPassDB.PasswordChar = '*';
            this.txtPassDB.Size = new System.Drawing.Size(113, 20);
            this.txtPassDB.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(153, 46);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(297, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // cbxTriggers
            // 
            this.cbxTriggers.AutoSize = true;
            this.cbxTriggers.Location = new System.Drawing.Point(12, 214);
            this.cbxTriggers.Name = "cbxTriggers";
            this.cbxTriggers.Size = new System.Drawing.Size(201, 17);
            this.cbxTriggers.TabIndex = 11;
            this.cbxTriggers.Text = "Create triggers enforcing foreign keys";
            this.cbxTriggers.UseVisualStyleBackColor = true;
            this.cbxTriggers.CheckedChanged += new System.EventHandler(this.cbxTriggers_CheckedChanged);
            // 
            // cbxCreateViews
            // 
            this.cbxCreateViews.AutoSize = true;
            this.cbxCreateViews.Location = new System.Drawing.Point(219, 214);
            this.cbxCreateViews.Name = "cbxCreateViews";
            this.cbxCreateViews.Size = new System.Drawing.Size(249, 17);
            this.cbxCreateViews.TabIndex = 12;
            this.cbxCreateViews.Text = "Try to create views (works only in simple cases)";
            this.cbxCreateViews.UseVisualStyleBackColor = true;
            this.cbxCreateViews.CheckedChanged += new System.EventHandler(this.cbxCreateViews_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 376);
            this.Controls.Add(this.cbxCreateViews);
            this.Controls.Add(this.cbxTriggers);
            this.Controls.Add(this.txtPassDB);
            this.Controls.Add(this.txtUserDB);
            this.Controls.Add(this.cbxIntegrated);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbxEncrypt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbrProgress);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.cboDatabases);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseSQLitePath);
            this.Controls.Add(this.txtSQLitePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSqlAddress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SQL Server To SQLite DB Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassDB;
        private System.Windows.Forms.TextBox txtUserDB;
        private System.Windows.Forms.CheckBox cbxIntegrated;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSqlAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQLitePath;
        private System.Windows.Forms.Button btnBrowseSQLitePath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDatabases;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxEncrypt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxTriggers;
        private System.Windows.Forms.CheckBox cbxCreateViews;
    }
}

