namespace Holiday_Booking_System
{
    partial class HolidayRequestsForm
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
            this.components = new System.ComponentModel.Container();
            this.pending_btn = new System.Windows.Forms.Button();
            this.accepted_btn = new System.Windows.Forms.Button();
            this.rejected_btn = new System.Windows.Forms.Button();
            this.view_all_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reject_btn = new System.Windows.Forms.Button();
            this.accept_btn = new System.Windows.Forms.Button();
            this.employee_filter_comBox = new System.Windows.Forms.ComboBox();
            this.header_panel = new System.Windows.Forms.Panel();
            this.hreq_btn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.filter_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.filter_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.greetinglbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.visualisationComponent1 = new Holiday_Booking_System.VisualisationComponent(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.filter_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pending_btn
            // 
            this.pending_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.pending_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.pending_btn.Location = new System.Drawing.Point(11, 131);
            this.pending_btn.Name = "pending_btn";
            this.pending_btn.Size = new System.Drawing.Size(112, 61);
            this.pending_btn.TabIndex = 0;
            this.pending_btn.Text = "View Outstanding Requests";
            this.pending_btn.UseVisualStyleBackColor = false;
            this.pending_btn.Click += new System.EventHandler(this.Pending_btn_Click);
            // 
            // accepted_btn
            // 
            this.accepted_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.accepted_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accepted_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.accepted_btn.Location = new System.Drawing.Point(12, 207);
            this.accepted_btn.Name = "accepted_btn";
            this.accepted_btn.Size = new System.Drawing.Size(112, 60);
            this.accepted_btn.TabIndex = 1;
            this.accepted_btn.Text = "View Accepted Requests";
            this.accepted_btn.UseVisualStyleBackColor = false;
            this.accepted_btn.Click += new System.EventHandler(this.Accepted_btn_Click);
            // 
            // rejected_btn
            // 
            this.rejected_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.rejected_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejected_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.rejected_btn.Location = new System.Drawing.Point(12, 292);
            this.rejected_btn.Name = "rejected_btn";
            this.rejected_btn.Size = new System.Drawing.Size(112, 60);
            this.rejected_btn.TabIndex = 2;
            this.rejected_btn.Text = "View Rejected Requests";
            this.rejected_btn.UseVisualStyleBackColor = false;
            this.rejected_btn.Click += new System.EventHandler(this.Rejected_btn_Click);
            // 
            // view_all_btn
            // 
            this.view_all_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.view_all_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.view_all_btn.Location = new System.Drawing.Point(11, 56);
            this.view_all_btn.Name = "view_all_btn";
            this.view_all_btn.Size = new System.Drawing.Size(112, 61);
            this.view_all_btn.TabIndex = 3;
            this.view_all_btn.Text = "View All Requests";
            this.view_all_btn.UseVisualStyleBackColor = false;
            this.view_all_btn.Click += new System.EventHandler(this.View_all_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 249);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(130, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 291);
            this.panel1.TabIndex = 5;
            // 
            // reject_btn
            // 
            this.reject_btn.BackColor = System.Drawing.Color.Red;
            this.reject_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.reject_btn.Location = new System.Drawing.Point(487, 249);
            this.reject_btn.Name = "reject_btn";
            this.reject_btn.Size = new System.Drawing.Size(139, 41);
            this.reject_btn.TabIndex = 6;
            this.reject_btn.Text = "Reject";
            this.reject_btn.UseVisualStyleBackColor = false;
            this.reject_btn.Click += new System.EventHandler(this.Reject_btn_Click);
            // 
            // accept_btn
            // 
            this.accept_btn.BackColor = System.Drawing.Color.Green;
            this.accept_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.accept_btn.Location = new System.Drawing.Point(320, 249);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(129, 41);
            this.accept_btn.TabIndex = 6;
            this.accept_btn.Text = "Accept";
            this.accept_btn.UseVisualStyleBackColor = false;
            this.accept_btn.Click += new System.EventHandler(this.Accept_btn_Click);
            // 
            // employee_filter_comBox
            // 
            this.employee_filter_comBox.FormattingEnabled = true;
            this.employee_filter_comBox.Location = new System.Drawing.Point(10, 110);
            this.employee_filter_comBox.Name = "employee_filter_comBox";
            this.employee_filter_comBox.Size = new System.Drawing.Size(178, 21);
            this.employee_filter_comBox.TabIndex = 6;
            this.employee_filter_comBox.SelectionChangeCommitted += new System.EventHandler(this.Employee_filter_comBox_SelectionChangeCommitted);
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.header_panel.Controls.Add(this.hreq_btn);
            this.header_panel.Controls.Add(this.label17);
            this.header_panel.Controls.Add(this.logout_btn);
            this.header_panel.Location = new System.Drawing.Point(0, 2);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(1001, 48);
            this.header_panel.TabIndex = 8;
            // 
            // hreq_btn
            // 
            this.hreq_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hreq_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hreq_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hreq_btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hreq_btn.Location = new System.Drawing.Point(625, 11);
            this.hreq_btn.Name = "hreq_btn";
            this.hreq_btn.Size = new System.Drawing.Size(247, 28);
            this.hreq_btn.TabIndex = 28;
            this.hreq_btn.Text = "View Admin Dashboard";
            this.hreq_btn.UseVisualStyleBackColor = false;
            this.hreq_btn.Click += new System.EventHandler(this.Hreq_btn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(19, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "Holiday Requests";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.Red;
            this.logout_btn.Location = new System.Drawing.Point(899, 11);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(92, 29);
            this.logout_btn.TabIndex = 26;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // filter_dateTimePicker
            // 
            this.filter_dateTimePicker.Location = new System.Drawing.Point(10, 36);
            this.filter_dateTimePicker.Name = "filter_dateTimePicker";
            this.filter_dateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.filter_dateTimePicker.TabIndex = 10;
            this.filter_dateTimePicker.ValueChanged += new System.EventHandler(this.Filter_dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // filter_panel
            // 
            this.filter_panel.Controls.Add(this.visualisationComponent1);
            this.filter_panel.Controls.Add(this.label1);
            this.filter_panel.Controls.Add(this.greetinglbl);
            this.filter_panel.Controls.Add(this.filter_dateTimePicker);
            this.filter_panel.Controls.Add(this.employee_filter_comBox);
            this.filter_panel.Location = new System.Drawing.Point(775, 61);
            this.filter_panel.Name = "filter_panel";
            this.filter_panel.Size = new System.Drawing.Size(226, 493);
            this.filter_panel.TabIndex = 11;
            this.filter_panel.Visible = false;
            this.filter_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Filter_panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter by Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greetinglbl
            // 
            this.greetinglbl.AutoSize = true;
            this.greetinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetinglbl.Location = new System.Drawing.Point(6, 7);
            this.greetinglbl.Name = "greetinglbl";
            this.greetinglbl.Size = new System.Drawing.Size(103, 20);
            this.greetinglbl.TabIndex = 11;
            this.greetinglbl.Text = "Filter by Date";
            this.greetinglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.reject_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.accept_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(130, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 322);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(68, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reject";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 53);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(281, 190);
            this.dataGridView3.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(320, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(306, 190);
            this.dataGridView2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Not Broken Constraints";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Broken Constraints";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // visualisationComponent1
            // 
            this.visualisationComponent1.BoldedDates = null;
            this.visualisationComponent1.Employee = 0;
            this.visualisationComponent1.Location = new System.Drawing.Point(-1, 221);
            this.visualisationComponent1.Name = "visualisationComponent1";
            this.visualisationComponent1.TabIndex = 14;
            // 
            // HolidayRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.filter_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view_all_btn);
            this.Controls.Add(this.rejected_btn);
            this.Controls.Add(this.accepted_btn);
            this.Controls.Add(this.pending_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HolidayRequestsForm";
            this.Text = "HolidayRequestsForm";
            this.Load += new System.EventHandler(this.HolidayRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.filter_panel.ResumeLayout(false);
            this.filter_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pending_btn;
        private System.Windows.Forms.Button accepted_btn;
        private System.Windows.Forms.Button rejected_btn;
        private System.Windows.Forms.Button view_all_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reject_btn;
        private System.Windows.Forms.Button accept_btn;
        private System.Windows.Forms.ComboBox employee_filter_comBox;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker filter_dateTimePicker;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button hreq_btn;
        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label greetinglbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private VisualisationComponent visualisationComponent1;
    }
}