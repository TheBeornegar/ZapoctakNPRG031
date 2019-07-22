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
    public partial class Form2 : Form
    {

        Form1 _f1;

        public Form2(Form1 f1)
        {
            InitializeComponent();
            if (f1 == null)
            {
                throw new ArgumentNullException("f1");
            }
            _f1 = f1;
            Atributes.ComputeAllStats();
            RefreshAtributeValues();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e) // PLAY
        {
            Atributes.ComputeAllStats();
            Monsters.ComputeMonsterDmg();
            Monsters.ComputeMonsterHP();
            Monsters.ComputeMonsterCrit();
            Form f3 = new Form3(this);
            f3.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)//DEXTERITY +
        {
            Atributes.StatUp(ref Atributes.Dexterity);
            Atributes.ComputeAllStats();
            RefreshAtributeValues();
        }

        private void button3_Click(object sender, EventArgs e) //CONSTITUTION +
        {
            Atributes.StatUp(ref Atributes.Constitution);
            Atributes.ComputeAllStats();
            RefreshAtributeValues();
        }

        private void button4_Click(object sender, EventArgs e) // CHARISMA +
        {
            Atributes.StatUp(ref Atributes.Charisma);
            Atributes.ComputeAllStats();
            RefreshAtributeValues();

        }

        private void button5_Click(object sender, EventArgs e)// DEXTERITY -
        {
            Atributes.ResetStat(ref Atributes.Dexterity);
            Atributes.ComputeAllStats();
            RefreshAtributeValues();
        }

        private void button6_Click(object sender, EventArgs e)// CONSTITUTION -
        {
            Atributes.ResetStat(ref Atributes.Constitution);
            Atributes.ComputeAllStats();
            RefreshAtributeValues();
        }

        
        private void button7_Click(object sender, EventArgs e) // CHARISMA -
        {
            Atributes.ResetStat(ref Atributes.Charisma);
            Atributes.ComputeAllStats();
            RefreshAtributeValues();
        }

        private void button8_Click(object sender, EventArgs e) //exit
        {
            Close();
            _f1.Close();


        }

        
        public void RefreshAtributeValues()
        {
            LabelLevelNumber.Text = Atributes.Level.ToString();
            LabelAbPointsNumber.Text = Atributes.AbilityPoints.ToString();
            LabelDmgNumber.Text = Atributes.Damage.ToString();
            LabelHPNumber.Text = Atributes.MaxHP.ToString();
            LabelCritNumber.Text = Atributes.CriticalChance.ToString() + "%";
            LabelDexNumber.Text = Atributes.Dexterity.ToString();
            LabelConNumber.Text = Atributes.Constitution.ToString();
            LabelCharNumber.Text = Atributes.Charisma.ToString();
        }

    }
}
