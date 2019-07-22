using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SomewhatClicker
{
    public partial class WinLostForm : Form
    {

        Form3 _f3;
        Form2 _f2;

        public WinLostForm(Form3 f3, Form2 f2)
        {
            InitializeComponent();
            if (f3 == null)
            {
                throw new ArgumentNullException("f3");
            }
            _f3 = f3;

            if (f2 == null)
            {
                throw new ArgumentNullException("f2");
            }
            _f2 = f2;


        }

        private void WinLostForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;

            if (Battle.PlayerHPLeft <= 0)
            {
                label1.Text = "You lost.";
                BackgroundImage= Properties.Resources.NO;
                button1.Text = "Exit";

            }
            else
            {
                label1.Text = "You won.";
                BackgroundImage = Properties.Resources.OK;
                button1.Text = "Continue";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atributes.LevelUp();
            Atributes.ComputeAllStats();
            AutoSave();
            _f2.RefreshAtributeValues();            
            Close();
            _f3.Close();
        }

        private void AutoSave()
        {
            using (StreamWriter file = new StreamWriter("SAVEDGAME.txt"))
            {
                file.WriteLine(Atributes.Level.ToString());
                file.WriteLine(Atributes.Dexterity.ToString());
                file.WriteLine(Atributes.Charisma.ToString());
                file.WriteLine(Atributes.Constitution.ToString());
                file.WriteLine(Atributes.Damage.ToString());
                file.WriteLine(Atributes.MaxHP.ToString());
                file.WriteLine(Atributes.AbilityPoints.ToString());
                file.WriteLine(Atributes.CriticalChance.ToString());
            }
        }

        
    }
}
