namespace Holiday_Booking_System
{
    partial class LogReg_form
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
            this.password_login_txtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.Button();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_login_txtBox = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_login_txtBox
            // 
            this.password_login_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_login_txtBox.Location = new System.Drawing.Point(79, 229);
            this.password_login_txtBox.Multiline = true;
            this.password_login_txtBox.Name = "password_login_txtBox";
            this.password_login_txtBox.PasswordChar = '*';
            this.password_login_txtBox.Size = new System.Drawing.Size(250, 44);
            this.password_login_txtBox.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 65);
            this.panel1.TabIndex = 25;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.login_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.login_btn.Location = new System.Drawing.Point(79, 310);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(250, 44);
            this.login_btn.TabIndex = 24;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.Location = new System.Drawing.Point(167, 206);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(78, 20);
            this.pass_lbl.TabIndex = 23;
            this.pass_lbl.Text = "Password";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(162, 117);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(83, 20);
            this.username_lbl.TabIndex = 22;
            this.username_lbl.Text = "Username";
            // 
            // username_login_txtBox
            // 
            this.username_login_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_login_txtBox.Location = new System.Drawing.Point(79, 140);
            this.username_login_txtBox.Multiline = true;
            this.username_login_txtBox.Name = "username_login_txtBox";
            this.username_login_txtBox.Size = new System.Drawing.Size(250, 44);
            this.username_login_txtBox.TabIndex = 21;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit_btn.Location = new System.Drawing.Point(355, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(36, 29);
            this.exit_btn.TabIndex = 27;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // LogReg_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 411);
            this.ControlBox = false;
            this.Controls.Add(this.password_login_txtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.username_login_txtBox);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogReg_form";
            this.Text = "LogReg_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_login_txtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_login_txtBox;
        private System.Windows.Forms.Button exit_btn;
    }
}