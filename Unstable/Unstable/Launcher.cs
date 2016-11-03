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
    public partial class Launcher : Form
    {
        #region zmienneGracz
        internal bool up=false; //
        internal bool down =false; //
        internal bool left =false; //
        internal bool right =false; // zmienne odpowiadające za ruch gracza

        internal bool zmianaKierunkuUpGracz = false; //
        internal bool zmianaKierunkuDownGracz = false; //
        internal bool zmianaKierunkuLeftGracz = false; // 
        internal bool zmianaKierunkuRightGracz = false; // zmienne odpowiadające za zmianę grafiki gracza

        internal bool attack;

        internal int stopMoving = 0; //ALPHA
        #endregion

        System.Media.SoundPlayer music = new System.Media.SoundPlayer();

        public Launcher()
        {
            InitializeComponent();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MenuGlowne FormaMenuGlowne = new MenuGlowne(this);

            music.SoundLocation = "SoundtrackMenu.wav";
            //music.PlayLooping();

            this.Hide();
            FormaMenuGlowne.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
