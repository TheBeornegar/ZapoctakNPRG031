namespace SomewhatClicker
{
    partial class Form3
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayerPicture = new System.Windows.Forms.PictureBox();
            this.PlayerHPBar = new System.Windows.Forms.PictureBox();
            this.MonsterHPBar = new System.Windows.Forms.PictureBox();
            this.MonsterPicture = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHPBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterHPBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayerPicture
            // 
            this.PlayerPicture.BackColor = System.Drawing.Color.White;
            this.PlayerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerPicture.Image = global::SomewhatClicker.Properties.Resources.panacek1;
            this.PlayerPicture.Location = new System.Drawing.Point(102, 174);
            this.PlayerPicture.Name = "PlayerPicture";
            this.PlayerPicture.Size = new System.Drawing.Size(200, 200);
            this.PlayerPicture.TabIndex = 3;
            this.PlayerPicture.TabStop = false;
            this.PlayerPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PlayerHPBar
            // 
            this.PlayerHPBar.BackColor = System.Drawing.Color.Red;
            this.PlayerHPBar.Location = new System.Drawing.Point(43, 70);
            this.PlayerHPBar.Name = "PlayerHPBar";
            this.PlayerHPBar.Size = new System.Drawing.Size(298, 36);
            this.PlayerHPBar.TabIndex = 4;
            this.PlayerHPBar.TabStop = false;
            // 
            // MonsterHPBar
            // 
            this.MonsterHPBar.BackColor = System.Drawing.Color.Red;
            this.MonsterHPBar.Location = new System.Drawing.Point(692, 70);
            this.MonsterHPBar.Name = "MonsterHPBar";
            this.MonsterHPBar.Size = new System.Drawing.Size(298, 36);
            this.MonsterHPBar.TabIndex = 5;
            this.MonsterHPBar.TabStop = false;
            // 
            // MonsterPicture
            // 
            this.MonsterPicture.BackColor = System.Drawing.Color.White;
            this.MonsterPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MonsterPicture.Image = global::SomewhatClicker.Properties.Resources.monstrum1;
            this.MonsterPicture.Location = new System.Drawing.Point(740, 174);
            this.MonsterPicture.Name = "MonsterPicture";
            this.MonsterPicture.Size = new System.Drawing.Size(200, 200);
            this.MonsterPicture.TabIndex = 6;
            this.MonsterPicture.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(903, 458);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 39);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 593);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MonsterPicture);
            this.Controls.Add(this.MonsterHPBar);
            this.Controls.Add(this.PlayerHPBar);
            this.Controls.Add(this.PlayerPicture);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHPBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterHPBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PlayerPicture;
        private System.Windows.Forms.PictureBox PlayerHPBar;
        private System.Windows.Forms.PictureBox MonsterHPBar;
        private System.Windows.Forms.PictureBox MonsterPicture;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}