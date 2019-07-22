using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomewhatClicker
{
    public partial class Form3 : Form
        
    {
        double PlayerHPUnit, MonsterHPUnit;
        int HPBarWidth, HPBarHeight, MonsterHPGone,PlayerHPGone;

        Bitmap Monsterbmp;
        Bitmap Playerbmp;
        Graphics MonsterG;
        Graphics PlayerG;

        Bitmap PlayerReadyImg = Properties.Resources.panacek1;//1
        Bitmap PlayerHitImg = Properties.Resources.panacek2;//2
        Bitmap MonsterReadyImg = Properties.Resources.monstrum1;//3
        Bitmap MonsterHitImg = Properties.Resources.monstrum2;//4

        Form2 _f2;

        public Form3(Form2 f2)
        {
            InitializeComponent();
            if (f2 == null)
            {
                throw new ArgumentNullException("f2");
            }
            _f2 = f2;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            HPBarWidth = PlayerHPBar.Width;
            HPBarHeight = PlayerHPBar.Height;
            MonsterHPUnit = (double)(MonsterHPBar.Width) / Monsters.MonsterHP;
            PlayerHPUnit = (double)(PlayerHPBar.Width) / Atributes.MaxHP;

            Battle.MonsterHPLeft = Monsters.MonsterHP;
            Battle.PlayerHPLeft = Atributes.MaxHP;


            Monsterbmp = new Bitmap(HPBarWidth, HPBarHeight);
            Playerbmp = new Bitmap(HPBarWidth, HPBarHeight);

            PlayerPicture.Image = PlayerReadyImg;
            MonsterPicture.Image = MonsterReadyImg;
           }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PlayerPicture.Image = PlayerReadyImg;
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            MonsterPicture.Image = MonsterReadyImg;
            timer3.Stop();
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            MonsterPicture.Image = MonsterHitImg;
            timer3.Start();

            Battle.PlayerHPLeft -= Battle.ComputeMonsterStrike(Monsters.MonsterDmg, Monsters.MonsterCrit);
            PlayerHPGone = Atributes.MaxHP - Battle.PlayerHPLeft ;


            PlayerG = Graphics.FromImage(Playerbmp); 
            PlayerG.Clear(Color.Red);
            PlayerG.FillRectangle(Brushes.Gray, (Single)(Battle.PlayerHPLeft * PlayerHPUnit), 0, (Single)(PlayerHPGone * PlayerHPUnit), (Single)(HPBarHeight));
            PlayerG.DrawString(Battle.PlayerHPLeft.ToString() + "/" + Atributes.MaxHP.ToString(), new Font("Arial", HPBarHeight / 2), Brushes.Black, new PointF(HPBarWidth / 2 - HPBarHeight, HPBarHeight / 10));
            PlayerHPBar.Image = Playerbmp;

            if(Battle.CheckForDeath(Battle.PlayerHPLeft))
            {
                this.timer1.Stop();

                WinLostForm LostForm = new WinLostForm(this,_f2);
                LostForm.ShowDialog();
                
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PlayerPicture.Image = PlayerHitImg;
            timer2.Start();

            if (Battle.PlayerHPLeft == Atributes.MaxHP)
             {
                 this.timer1.Start();
             }

            Battle.MonsterHPLeft -= Battle.ComputePlayerStrike(Atributes.Damage, Atributes.CriticalChance);
            MonsterHPGone = Monsters.MonsterHP - Battle.MonsterHPLeft;
            

            MonsterG = Graphics.FromImage(Monsterbmp);
            MonsterG.Clear(Color.Red);
            MonsterG.FillRectangle(Brushes.Gray,(Single) (Battle.MonsterHPLeft*MonsterHPUnit), 0,(Single)(MonsterHPGone*MonsterHPUnit),(Single) (HPBarHeight));
            MonsterG.DrawString(Battle.MonsterHPLeft + "/" + Monsters.MonsterHP.ToString(), new Font("Arial", HPBarHeight / 2), Brushes.Black, new PointF(HPBarWidth / 2 - HPBarHeight, HPBarHeight / 10));
            MonsterHPBar.Image = Monsterbmp;

            
           if(Battle.CheckForDeath(Battle.MonsterHPLeft))
            {
                this.timer1.Stop();

                WinLostForm WonForm = new WinLostForm(this,_f2);
                WonForm.ShowDialog();


            }
        }
    }
}
