using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unstable
{
    public partial class Test : Form
    {
        bool up;
        bool down;
        bool left;
        bool right;

        bool attack;

        int stopMoving = 0; //ALPHA

        Launcher daneLauncher;

        public Test()
        {
            InitializeComponent();

            aktualizatorGracz.Enabled = true;
            aktualizatorMob.Enabled = true;
            aktualizatorAtak.Enabled = true;
        }

        private void Test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) up = true;
            if (e.KeyCode == Keys.Down) down = true;
            if (e.KeyCode == Keys.Left) left = true;
            if (e.KeyCode == Keys.Right) right = true;

            if (e.KeyCode == Keys.Space) attack = true;

            if(e.KeyCode==Keys.Escape)
            {
                MenuGlowne formaMenuGlowne = new MenuGlowne(daneLauncher);

                this.Close();
                formaMenuGlowne.Show();
            }
        }

        private void Test_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) up = false;
            if (e.KeyCode == Keys.Down) down = false;
            if (e.KeyCode == Keys.Left) left = false;
            if (e.KeyCode == Keys.Right) right = false;
        }

        private void Test_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void aktualizatorGracz_Tick(object sender, EventArgs e)
        {
            if (up == true) if (gracz.Top > poleGry.Top) gracz.Top -= 10; 
            if (down == true) if (gracz.Bottom < poleGry.Bottom) gracz.Top += 10; 
            if (left == true) if(gracz.Left > poleGry.Left) gracz.Left -= 10;
            if (right == true) if (gracz.Right < poleGry.Right) gracz.Left += 10;
        }
        private void aktualizatorMob_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int mobek = random.Next(0, 5);

            if (mobek == 1) if (mob.Top > poleGry.Top) mob.Top -= 10;
            if (mobek == 2) if (mob.Bottom < poleGry.Bottom) mob.Top += 10;
            if (mobek == 3) if (mob.Left > poleGry.Left) mob.Left -= 10;
            if (mobek == 4) if (mob.Right < poleGry.Right) mob.Left += 10;

        }

        private void aktualizatorAtak_Tick(object sender, EventArgs e)
        {
            if(attack==true)
            {
                aktualizatorGracz.Enabled = false;
                stopMoving++;
                if (stopMoving == 10)
                {
                   



                    aktualizatorGracz.Enabled = true; ;
                    attack = false;                        //ALPHA
                    stopMoving = 0;
                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void zbroja_Click(object sender, EventArgs e)
        {
   
        }

        
    }
}
