namespace Fire_game_Assigment_first
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbGun = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.LoadGun = new System.Windows.Forms.Button();
            this.Sppinroller = new System.Windows.Forms.Button();
            this.shootGun = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.Retry = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGun
            // 
            this.pbGun.Image = global::Fire_game_Assigment_first.Properties.Resources.shot1;
            this.pbGun.Location = new System.Drawing.Point(12, 138);
            this.pbGun.Name = "pbGun";
            this.pbGun.Size = new System.Drawing.Size(931, 321);
            this.pbGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGun.TabIndex = 0;
            this.pbGun.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.Location = new System.Drawing.Point(65, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(39, 130);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LoadGun
            // 
            this.LoadGun.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoadGun.Image = ((System.Drawing.Image)(resources.GetObject("LoadGun.Image")));
            this.LoadGun.Location = new System.Drawing.Point(184, 2);
            this.LoadGun.Name = "LoadGun";
            this.LoadGun.Size = new System.Drawing.Size(39, 130);
            this.LoadGun.TabIndex = 2;
            this.LoadGun.Text = "LOAD";
            this.LoadGun.UseVisualStyleBackColor = true;
            this.LoadGun.Click += new System.EventHandler(this.LoadGun_Click);
            // 
            // Sppinroller
            // 
            this.Sppinroller.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sppinroller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sppinroller.Image = ((System.Drawing.Image)(resources.GetObject("Sppinroller.Image")));
            this.Sppinroller.Location = new System.Drawing.Point(293, 2);
            this.Sppinroller.Name = "Sppinroller";
            this.Sppinroller.Size = new System.Drawing.Size(39, 130);
            this.Sppinroller.TabIndex = 3;
            this.Sppinroller.Text = "SPIN";
            this.Sppinroller.UseVisualStyleBackColor = true;
            this.Sppinroller.Click += new System.EventHandler(this.Sppinroller_Click);
            // 
            // shootGun
            // 
            this.shootGun.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shootGun.Image = ((System.Drawing.Image)(resources.GetObject("shootGun.Image")));
            this.shootGun.Location = new System.Drawing.Point(391, 2);
            this.shootGun.Name = "shootGun";
            this.shootGun.Size = new System.Drawing.Size(96, 130);
            this.shootGun.TabIndex = 4;
            this.shootGun.Text = "SHOOT";
            this.shootGun.UseVisualStyleBackColor = true;
            this.shootGun.Click += new System.EventHandler(this.shootGun_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShootAway.Image = ((System.Drawing.Image)(resources.GetObject("ShootAway.Image")));
            this.ShootAway.Location = new System.Drawing.Point(532, 2);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(100, 130);
            this.ShootAway.TabIndex = 5;
            this.ShootAway.Text = "SHOOT AWAY";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // Retry
            // 
            this.Retry.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Retry.Image = ((System.Drawing.Image)(resources.GetObject("Retry.Image")));
            this.Retry.Location = new System.Drawing.Point(678, 2);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(39, 131);
            this.Retry.TabIndex = 6;
            this.Retry.Text = "REPLAY";
            this.Retry.UseVisualStyleBackColor = true;
            this.Retry.Click += new System.EventHandler(this.Retry_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(798, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(39, 130);
            this.Close.TabIndex = 7;
            this.Close.Text = "EXIT";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(955, 471);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Retry);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.shootGun);
            this.Controls.Add(this.Sppinroller);
            this.Controls.Add(this.LoadGun);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pbGun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGun;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button Sppinroller;
        private System.Windows.Forms.Button shootGun;
        private System.Windows.Forms.Button ShootAway;
        private System.Windows.Forms.Button Retry;
        private System.Windows.Forms.Button Close;
        public System.Windows.Forms.Button LoadGun;
    }
}

