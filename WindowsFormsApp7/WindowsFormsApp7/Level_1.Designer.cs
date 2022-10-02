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
            this.btnrestart = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lbltimeleft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(628, 12);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(205, 84);
            this.btnrestart.TabIndex = 0;
            this.btnrestart.Text = "button1";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(625, 148);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(118, 16);
            this.lblstatus.TabIndex = 1;
            this.lblstatus.Text = "Match or Mismatch";
            // 
            // lbltimeleft
            // 
            this.lbltimeleft.AutoSize = true;
            this.lbltimeleft.Location = new System.Drawing.Point(625, 201);
            this.lbltimeleft.Name = "lbltimeleft";
            this.lbltimeleft.Size = new System.Drawing.Size(81, 16);
            this.lbltimeleft.TabIndex = 2;
            this.lbltimeleft.Text = "Time left : 30";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Level_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltimeleft);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnrestart);
            this.Name = "Level_1";
            this.Text = "Level_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbltimeleft;
        private System.Windows.Forms.Timer timer1;
    }
}