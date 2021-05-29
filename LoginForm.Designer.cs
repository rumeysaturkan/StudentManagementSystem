namespace SMS.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLog = new System.Windows.Forms.Button();
            this.txtbxLogName = new System.Windows.Forms.TextBox();
            this.lblLogName = new System.Windows.Forms.Label();
            this.txtbxLogPass = new System.Windows.Forms.TextBox();
            this.lblLogPass = new System.Windows.Forms.Label();
            this.gbxLog = new System.Windows.Forms.GroupBox();
            this.buttonEx = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMini = new System.Windows.Forms.Button();
            this.gbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            resources.ApplyResources(this.btnLog, "btnLog");
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Name = "btnLog";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // txtbxLogName
            // 
            resources.ApplyResources(this.txtbxLogName, "txtbxLogName");
            this.txtbxLogName.Name = "txtbxLogName";
            // 
            // lblLogName
            // 
            resources.ApplyResources(this.lblLogName, "lblLogName");
            this.lblLogName.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogName.Name = "lblLogName";
            // 
            // txtbxLogPass
            // 
            resources.ApplyResources(this.txtbxLogPass, "txtbxLogPass");
            this.txtbxLogPass.Name = "txtbxLogPass";
            // 
            // lblLogPass
            // 
            resources.ApplyResources(this.lblLogPass, "lblLogPass");
            this.lblLogPass.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogPass.Name = "lblLogPass";
            // 
            // gbxLog
            // 
            resources.ApplyResources(this.gbxLog, "gbxLog");
            this.gbxLog.Controls.Add(this.btnLog);
            this.gbxLog.Controls.Add(this.txtbxLogName);
            this.gbxLog.Controls.Add(this.txtbxLogPass);
            this.gbxLog.Controls.Add(this.lblLogPass);
            this.gbxLog.Controls.Add(this.lblLogName);
            this.gbxLog.Name = "gbxLog";
            this.gbxLog.TabStop = false;
            // 
            // buttonEx
            // 
            resources.ApplyResources(this.buttonEx, "buttonEx");
            this.buttonEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // buttonMax
            // 
            resources.ApplyResources(this.buttonMax, "buttonMax");
            this.buttonMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMini
            // 
            resources.ApplyResources(this.buttonMini, "buttonMini");
            this.buttonMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.UseVisualStyleBackColor = false;
            this.buttonMini.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.buttonMini);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.gbxLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
  
            this.gbxLog.ResumeLayout(false);
            this.gbxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblLogName;
        private System.Windows.Forms.Label lblLogPass;
        public System.Windows.Forms.TextBox txtbxLogName;
        public System.Windows.Forms.TextBox txtbxLogPass;
        private System.Windows.Forms.GroupBox gbxLog;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMini;
    }
}

