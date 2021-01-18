namespace EmployeeClient
{
    partial class ClientEmployeeLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.username_login_txtBox = new System.Windows.Forms.TextBox();
            this.password_login_txtBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 53);
            this.panel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(84, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee Client App";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.login_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.login_btn.Location = new System.Drawing.Point(120, 293);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(250, 44);
            this.login_btn.TabIndex = 27;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // username_login_txtBox
            // 
            this.username_login_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_login_txtBox.Location = new System.Drawing.Point(111, 113);
            this.username_login_txtBox.Multiline = true;
            this.username_login_txtBox.Name = "username_login_txtBox";
            this.username_login_txtBox.Size = new System.Drawing.Size(250, 44);
            this.username_login_txtBox.TabIndex = 28;
            // 
            // password_login_txtBox
            // 
            this.password_login_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_login_txtBox.Location = new System.Drawing.Point(111, 211);
            this.password_login_txtBox.Multiline = true;
            this.password_login_txtBox.Name = "password_login_txtBox";
            this.password_login_txtBox.PasswordChar = '*';
            this.password_login_txtBox.Size = new System.Drawing.Size(250, 44);
            this.password_login_txtBox.TabIndex = 29;
            // 
            // ClientEmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.password_login_txtBox);
            this.Controls.Add(this.username_login_txtBox);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ClientEmployeeLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientEmployeeLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox username_login_txtBox;
        private System.Windows.Forms.TextBox password_login_txtBox;
    }
}

