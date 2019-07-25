using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SomewhatClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atributes.Level = 1;
            Atributes.Dexterity = 1;
            Atributes.Charisma = 1;
            Atributes.Constitution = 1;
            Atributes.AbilityPoints = 3;
          
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            //load from txt
            if (File.Exists("SAVEDGAME.txt"))
            {
                using (StreamReader save = new StreamReader("SAVEDGAME.txt"))
                {
                    Atributes.Level = int.Parse(save.ReadLine());
                    Atributes.Dexterity = int.Parse(save.ReadLine());
                    Atributes.Charisma = int.Parse(save.ReadLine());
                    Atributes.Constitution = int.Parse(save.ReadLine());
                    Atributes.Damage = int.Parse(save.ReadLine());
                    Atributes.MaxHP = int.Parse(save.ReadLine());
                    Atributes.AbilityPoints = int.Parse(save.ReadLine());
                    Atributes.CriticalChance = int.Parse(save.ReadLine());
                }
                this.Hide();
                Form f2 = new Form2(this);
                f2.Show();
            }
            else
            {
                Form Error = new ErrorForm();
                Error.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
