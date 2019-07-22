namespace SomewhatClicker
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.LabelLevelNumber = new System.Windows.Forms.Label();
            this.LabelHP = new System.Windows.Forms.Label();
            this.LabelHPNumber = new System.Windows.Forms.Label();
            this.LabelDex = new System.Windows.Forms.Label();
            this.LabelDexNumber = new System.Windows.Forms.Label();
            this.LabelCon = new System.Windows.Forms.Label();
            this.LabelConNumber = new System.Windows.Forms.Label();
            this.LabelChar = new System.Windows.Forms.Label();
            this.LabelCharNumber = new System.Windows.Forms.Label();
            this.LabelDmg = new System.Windows.Forms.Label();
            this.LabelDmgNumber = new System.Windows.Forms.Label();
            this.LabelCrit = new System.Windows.Forms.Label();
            this.LabelCritNumber = new System.Windows.Forms.Label();
            this.LabelAbPoints = new System.Windows.Forms.Label();
            this.LabelAbPointsNumber = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(368, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(378, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(378, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(378, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(896, 520);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 46);
            this.button8.TabIndex = 7;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLevel.Location = new System.Drawing.Point(30, 184);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(85, 43);
            this.LabelLevel.TabIndex = 8;
            this.LabelLevel.Text = "Level:";
            // 
            // LabelLevelNumber
            // 
            this.LabelLevelNumber.AutoSize = true;
            this.LabelLevelNumber.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLevelNumber.Location = new System.Drawing.Point(268, 191);
            this.LabelLevelNumber.Name = "LabelLevelNumber";
            this.LabelLevelNumber.Size = new System.Drawing.Size(30, 32);
            this.LabelLevelNumber.TabIndex = 9;
            this.LabelLevelNumber.Text = "1";
            // 
            // LabelHP
            // 
            this.LabelHP.AutoSize = true;
            this.LabelHP.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHP.Location = new System.Drawing.Point(32, 236);
            this.LabelHP.Name = "LabelHP";
            this.LabelHP.Size = new System.Drawing.Size(45, 35);
            this.LabelHP.TabIndex = 10;
            this.LabelHP.Text = "HP";
            // 
            // LabelHPNumber
            // 
            this.LabelHPNumber.AutoSize = true;
            this.LabelHPNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHPNumber.Location = new System.Drawing.Point(268, 236);
            this.LabelHPNumber.Name = "LabelHPNumber";
            this.LabelHPNumber.Size = new System.Drawing.Size(45, 35);
            this.LabelHPNumber.TabIndex = 11;
            this.LabelHPNumber.Text = "50";
            // 
            // LabelDex
            // 
            this.LabelDex.AutoSize = true;
            this.LabelDex.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDex.Location = new System.Drawing.Point(32, 286);
            this.LabelDex.Name = "LabelDex";
            this.LabelDex.Size = new System.Drawing.Size(108, 35);
            this.LabelDex.TabIndex = 12;
            this.LabelDex.Text = "Dexterity";
            // 
            // LabelDexNumber
            // 
            this.LabelDexNumber.AutoSize = true;
            this.LabelDexNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDexNumber.Location = new System.Drawing.Point(268, 286);
            this.LabelDexNumber.Name = "LabelDexNumber";
            this.LabelDexNumber.Size = new System.Drawing.Size(30, 35);
            this.LabelDexNumber.TabIndex = 13;
            this.LabelDexNumber.Text = "1";
            // 
            // LabelCon
            // 
            this.LabelCon.AutoSize = true;
            this.LabelCon.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCon.Location = new System.Drawing.Point(32, 352);
            this.LabelCon.Name = "LabelCon";
            this.LabelCon.Size = new System.Drawing.Size(136, 35);
            this.LabelCon.TabIndex = 14;
            this.LabelCon.Text = "Constitution";
            // 
            // LabelConNumber
            // 
            this.LabelConNumber.AutoSize = true;
            this.LabelConNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConNumber.Location = new System.Drawing.Point(268, 352);
            this.LabelConNumber.Name = "LabelConNumber";
            this.LabelConNumber.Size = new System.Drawing.Size(30, 35);
            this.LabelConNumber.TabIndex = 15;
            this.LabelConNumber.Text = "1";
            // 
            // LabelChar
            // 
            this.LabelChar.AutoSize = true;
            this.LabelChar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChar.Location = new System.Drawing.Point(32, 421);
            this.LabelChar.Name = "LabelChar";
            this.LabelChar.Size = new System.Drawing.Size(111, 35);
            this.LabelChar.TabIndex = 16;
            this.LabelChar.Text = "Charisma";
            // 
            // LabelCharNumber
            // 
            this.LabelCharNumber.AutoSize = true;
            this.LabelCharNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCharNumber.Location = new System.Drawing.Point(268, 418);
            this.LabelCharNumber.Name = "LabelCharNumber";
            this.LabelCharNumber.Size = new System.Drawing.Size(30, 35);
            this.LabelCharNumber.TabIndex = 17;
            this.LabelCharNumber.Text = "1";
            // 
            // LabelDmg
            // 
            this.LabelDmg.AutoSize = true;
            this.LabelDmg.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDmg.Location = new System.Drawing.Point(32, 476);
            this.LabelDmg.Name = "LabelDmg";
            this.LabelDmg.Size = new System.Drawing.Size(97, 35);
            this.LabelDmg.TabIndex = 18;
            this.LabelDmg.Text = "Damage";
            // 
            // LabelDmgNumber
            // 
            this.LabelDmgNumber.AutoSize = true;
            this.LabelDmgNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDmgNumber.Location = new System.Drawing.Point(268, 476);
            this.LabelDmgNumber.Name = "LabelDmgNumber";
            this.LabelDmgNumber.Size = new System.Drawing.Size(30, 35);
            this.LabelDmgNumber.TabIndex = 19;
            this.LabelDmgNumber.Text = "5";
            // 
            // LabelCrit
            // 
            this.LabelCrit.AutoSize = true;
            this.LabelCrit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCrit.Location = new System.Drawing.Point(32, 531);
            this.LabelCrit.Name = "LabelCrit";
            this.LabelCrit.Size = new System.Drawing.Size(207, 35);
            this.LabelCrit.TabIndex = 20;
            this.LabelCrit.Text = "Critical Hit Chance";
            // 
            // LabelCritNumber
            // 
            this.LabelCritNumber.AutoSize = true;
            this.LabelCritNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCritNumber.Location = new System.Drawing.Point(268, 531);
            this.LabelCritNumber.Name = "LabelCritNumber";
            this.LabelCritNumber.Size = new System.Drawing.Size(45, 35);
            this.LabelCritNumber.TabIndex = 21;
            this.LabelCritNumber.Text = "0%";
            // 
            // LabelAbPoints
            // 
            this.LabelAbPoints.AutoSize = true;
            this.LabelAbPoints.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAbPoints.Location = new System.Drawing.Point(35, 94);
            this.LabelAbPoints.Name = "LabelAbPoints";
            this.LabelAbPoints.Size = new System.Drawing.Size(196, 35);
            this.LabelAbPoints.TabIndex = 22;
            this.LabelAbPoints.Text = "Ability points left:";
            // 
            // LabelAbPointsNumber
            // 
            this.LabelAbPointsNumber.AutoSize = true;
            this.LabelAbPointsNumber.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAbPointsNumber.Location = new System.Drawing.Point(268, 94);
            this.LabelAbPointsNumber.Name = "LabelAbPointsNumber";
            this.LabelAbPointsNumber.Size = new System.Drawing.Size(30, 35);
            this.LabelAbPointsNumber.TabIndex = 23;
            this.LabelAbPointsNumber.Text = "3";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(476, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 48);
            this.button5.TabIndex = 24;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(476, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 51);
            this.button6.TabIndex = 25;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(476, 405);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 51);
            this.button7.TabIndex = 26;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1030, 593);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.LabelAbPointsNumber);
            this.Controls.Add(this.LabelAbPoints);
            this.Controls.Add(this.LabelCritNumber);
            this.Controls.Add(this.LabelCrit);
            this.Controls.Add(this.LabelDmgNumber);
            this.Controls.Add(this.LabelDmg);
            this.Controls.Add(this.LabelCharNumber);
            this.Controls.Add(this.LabelChar);
            this.Controls.Add(this.LabelConNumber);
            this.Controls.Add(this.LabelCon);
            this.Controls.Add(this.LabelDexNumber);
            this.Controls.Add(this.LabelDex);
            this.Controls.Add(this.LabelHPNumber);
            this.Controls.Add(this.LabelHP);
            this.Controls.Add(this.LabelLevelNumber);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label LabelLevel;
        private System.Windows.Forms.Label LabelLevelNumber;
        private System.Windows.Forms.Label LabelHP;
        private System.Windows.Forms.Label LabelHPNumber;
        private System.Windows.Forms.Label LabelDex;
        private System.Windows.Forms.Label LabelDexNumber;
        private System.Windows.Forms.Label LabelCon;
        private System.Windows.Forms.Label LabelConNumber;
        private System.Windows.Forms.Label LabelChar;
        private System.Windows.Forms.Label LabelCharNumber;
        private System.Windows.Forms.Label LabelDmg;
        private System.Windows.Forms.Label LabelDmgNumber;
        private System.Windows.Forms.Label LabelCrit;
        private System.Windows.Forms.Label LabelCritNumber;
        private System.Windows.Forms.Label LabelAbPoints;
        private System.Windows.Forms.Label LabelAbPointsNumber;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}