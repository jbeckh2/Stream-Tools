
namespace Stream_Timer
{
    partial class frmStreamTimer
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentCountDown = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.chkDisplayMessage = new System.Windows.Forms.CheckBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "End Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy ";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(7, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(98, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "MM/dd/yyyy ";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(137, 32);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(98, 20);
            this.dtpTime.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(136, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "End Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.chkDisplayMessage);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFormat);
            this.groupBox1.Controls.Add(this.lblFormat);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.dtpTime);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 278);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // lblCurrentCountDown
            // 
            this.lblCurrentCountDown.Location = new System.Drawing.Point(6, 16);
            this.lblCurrentCountDown.Name = "lblCurrentCountDown";
            this.lblCurrentCountDown.Size = new System.Drawing.Size(229, 69);
            this.lblCurrentCountDown.TabIndex = 5;
            this.lblCurrentCountDown.Text = "default";
            this.lblCurrentCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(9, 69);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(74, 13);
            this.lblFormat.TabIndex = 4;
            this.lblFormat.Text = "Output Format";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(7, 85);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(226, 20);
            this.txtFormat.TabIndex = 5;
            this.txtFormat.Text = "hh:mm:ss";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(12, 300);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(244, 28);
            this.btnStartStop.TabIndex = 6;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCurrentCountDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 97);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Count Down";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output File";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(7, 140);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(169, 20);
            this.txtFile.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(182, 137);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(53, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // sfdFile
            // 
            this.sfdFile.DefaultExt = "txt";
            this.sfdFile.Filter = "Text Files|*.txt";
            // 
            // chkDisplayMessage
            // 
            this.chkDisplayMessage.AutoSize = true;
            this.chkDisplayMessage.Checked = true;
            this.chkDisplayMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayMessage.Location = new System.Drawing.Point(6, 176);
            this.chkDisplayMessage.Name = "chkDisplayMessage";
            this.chkDisplayMessage.Size = new System.Drawing.Size(147, 17);
            this.chkDisplayMessage.TabIndex = 9;
            this.chkDisplayMessage.Text = "Display Message At End?";
            this.chkDisplayMessage.UseVisualStyleBackColor = true;
            this.chkDisplayMessage.CheckedChanged += new System.EventHandler(this.chkDisplayMessage_CheckedChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(6, 218);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(229, 51);
            this.txtMessage.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Message";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Defaults";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmStreamTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 509);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmStreamTimer";
            this.Text = "Stream Timer";
            this.Load += new System.EventHandler(this.frmStreamTimer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        internal System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblCurrentCountDown;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.CheckBox chkDisplayMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSave;
    }
}

