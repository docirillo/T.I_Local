namespace T.I_Local
{
    partial class frmServidores
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
            this.lblServ1 = new System.Windows.Forms.Label();
            this.tbPingReply = new System.Windows.Forms.TextBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblServ1
            // 
            this.lblServ1.AutoSize = true;
            this.lblServ1.Location = new System.Drawing.Point(12, 9);
            this.lblServ1.Name = "lblServ1";
            this.lblServ1.Size = new System.Drawing.Size(27, 13);
            this.lblServ1.TabIndex = 0;
            this.lblServ1.Text = "OFF";
            // 
            // tbPingReply
            // 
            this.tbPingReply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPingReply.Location = new System.Drawing.Point(15, 33);
            this.tbPingReply.Multiline = true;
            this.tbPingReply.Name = "tbPingReply";
            this.tbPingReply.ReadOnly = true;
            this.tbPingReply.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPingReply.Size = new System.Drawing.Size(606, 232);
            this.tbPingReply.TabIndex = 6;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // frmServidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 277);
            this.Controls.Add(this.tbPingReply);
            this.Controls.Add(this.lblServ1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmServidores";
            this.Text = "Servidores";
            this.Load += new System.EventHandler(this.frmServidores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServ1;
        private System.Windows.Forms.TextBox tbPingReply;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}