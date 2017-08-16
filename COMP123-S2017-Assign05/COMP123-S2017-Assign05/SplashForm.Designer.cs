namespace COMP123_S2017_Assign05
{
    partial class SplashForm
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
            this.GreetingLabel2 = new System.Windows.Forms.Label();
            this.GreeetingLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GreetingLabel2
            // 
            this.GreetingLabel2.AutoSize = true;
            this.GreetingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel2.Location = new System.Drawing.Point(-4, 54);
            this.GreetingLabel2.Name = "GreetingLabel2";
            this.GreetingLabel2.Size = new System.Drawing.Size(308, 25);
            this.GreetingLabel2.TabIndex = 0;
            this.GreetingLabel2.Text = "Bienvenue sur mon calculateur";
            // 
            // GreeetingLabel1
            // 
            this.GreeetingLabel1.AutoSize = true;
            this.GreeetingLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreeetingLabel1.Location = new System.Drawing.Point(27, 21);
            this.GreeetingLabel1.Name = "GreeetingLabel1";
            this.GreeetingLabel1.Size = new System.Drawing.Size(232, 23);
            this.GreeetingLabel1.TabIndex = 1;
            this.GreeetingLabel1.Text = "Welcome to my Calculator";
            this.GreeetingLabel1.Click += new System.EventHandler(this.GreeetingLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2017_Assign05.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(1, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 296);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 2000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(304, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GreeetingLabel1);
            this.Controls.Add(this.GreetingLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreetingLabel2;
        private System.Windows.Forms.Label GreeetingLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer SplashFormTimer;
    }
}