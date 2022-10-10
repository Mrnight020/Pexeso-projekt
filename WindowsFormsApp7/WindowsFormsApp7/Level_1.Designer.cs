namespace WindowsFormsApp7
{
    partial class Level_1
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(212, 11);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(154, 68);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(249, 114);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Match or Mismatch";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(261, 143);
            this.lblTimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(68, 13);
            this.lblTimeLeft.TabIndex = 2;
            this.lblTimeLeft.Text = "Time left : 30";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Level_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 316);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRestart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Level_1";
            this.Text = "Level_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer GameTimer;
    }
}