using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//zpnd48

namespace Unstable
{
    /// <summary> Odpowiada za uruchomienie i działanie programu. Przechowuje większość zmiennych, na których pracuje program. </summary>
    public partial class Launcher : Form
    {
        #region zmienneGracz
        internal PictureBox gracz; // zmienna odpowiadająca za wygląd gracza
        internal PictureBox underGracz; // zmienna niwelująca rozmycie podczas poruszania się gracza

        internal int hpGracz; //
        internal int hpGraczMax; // zmienne odpowiadające za ilość punktów życia gracza

        internal int manaGracz;
        internal int manaGraczMax;

        internal int siłaAtakuGracz = 0; // zmienna odpowiadająca za liczbę obrażeń zadawanych przez gracza

        internal int lvGracz = 1; // zmienna określa poziom doświadczenia gracza
        internal int exp = 0; //
        internal int expMax = 5; // zmienne określają ilość doświadczenia gracza

        internal int siła = 19; //
        internal int zręczność = 1; //
        internal int inteligencja = 1; //
        internal int wytrzymałość = 1; //
        internal int szczęście = 1; //
        internal int obronaGracz = 0; //
        internal int odpornośćGracz = 0; // statystyki gracza
        
        internal bool up = false; //
        internal bool down = false; //
        internal bool left = false; //
        internal bool right = false; // zmienne odpowiadające za ruch gracza
        
        internal bool zmianaKierunkuUpGracz = false; //
        internal bool zmianaKierunkuDownGracz = false; //
        internal bool zmianaKierunkuLeftGracz = false; // 
        internal bool zmianaKierunkuRightGracz = false; // 
        internal bool zmianaKierunkuLeftSkosGracz = false; //
        internal bool zmianaKierunkuRightSkosGracz = false; // zmienne odpowiadające za zmianę grafiki gracza podczas ruchu

        internal bool przeszkodaGracz = false; // zmienna sprawdza, czy na drodze gracza jest przeszkoda

        internal bool attackGracz; // zmienna odpowiadająca za wykonanie ataku przez gracza

        internal bool wykonanoAtakGracz = false; // zmienna odpowiadająca za sprawdzenie, czy atak został wykonany

        internal int stopMovingGracz = 0; // zlicza czas przetrzymania gracza podczas ataku
        #endregion
        #region zmienneMob
        internal Launcher[] daneMob = new Launcher[10]; // tablica przechowująca dane o kilku mobach
        internal PictureBox mob; // zmienna odpowiadająca za wygląd moba
        internal PictureBox underMob; // zmienna niwelująca rozmycie podczas poruszania się moba

        internal bool istniejeMob = false; // zmienna określa, czy mob istnieje

        internal int hpMob; //
        internal int hpMobMax; // zmienne odpowiadające za ilość punktów życia moba

        internal Label labelhpMob;

        internal int lvMob = 1; // zmienna okresla poziom moba

        internal bool upMob = false; //
        internal bool downMob = false; //
        internal bool leftMob = false; //
        internal bool rightMob = false; // zmienne odpowiadające za ruch moba

        internal bool zmianaKierunkuUpMob = false; //
        internal bool zmianaKierunkuDownMob = false; //
        internal bool zmianaKierunkuLeftMob = false; // 
        internal bool zmianaKierunkuRightMob = false; // 
        internal bool zmianaKierunkuLeftSkosMob = false; //
        internal bool zmianaKierunkuRightSkosMob = false; // zmienne odpowiadające za zmianę grafiki moba podczas ruchu

        internal bool attackMob = false; // zmienna odpowiadająca za wykonanie ataku przez moba

        internal bool wykonanoAtakMob = false; // zmienna odpowiadająca za sprawdzenie, czy atak został wykonany

        internal short stopMovingMob = 0; // zlicza czas przetrzymania moba podczas ataku
        #endregion
        #region zmienneWygląduPostaci
        internal PictureBox whiteBrownStand = new PictureBox();
        internal PictureBox whiteBrownMovingUp = new PictureBox();
        internal PictureBox whiteBrownMovingDown = new PictureBox();
        internal PictureBox whiteBrownMovingLeft = new PictureBox();
        internal PictureBox whiteBrownMovingRight = new PictureBox();
        internal PictureBox whiteBrownAttackingUp = new PictureBox();
        internal PictureBox whiteBrownAttackingDown = new PictureBox();
        internal PictureBox whiteBrownAttackingLeft = new PictureBox();
        internal PictureBox whiteBrownAttackingRight = new PictureBox();

        internal PictureBox whiteBlackStand = new PictureBox();
        internal PictureBox whiteBlondeStand = new PictureBox();
        internal PictureBox whiteRedStand = new PictureBox();

        internal PictureBox blackBrownStand = new PictureBox();
        internal PictureBox blackBlackStand = new PictureBox();
        internal PictureBox blackBlondeStand = new PictureBox();
        internal PictureBox blackRedStand = new PictureBox();

        internal PictureBox pinkBrownStand = new PictureBox();
        internal PictureBox pinkBlackStand = new PictureBox();
        internal PictureBox pinkBlondeStand = new PictureBox();
        internal PictureBox pinkRedStand = new PictureBox();

        internal PictureBox yellowBrownStand = new PictureBox();
        internal PictureBox yellowBlackStand = new PictureBox();
        internal PictureBox yellowBlondeStand = new PictureBox();
        internal PictureBox yellowRedStand = new PictureBox();

        internal PictureBox redBrownStand = new PictureBox();
        internal PictureBox redBlackStand = new PictureBox();
        internal PictureBox redBlondeStand = new PictureBox();
        internal PictureBox redRedStand = new PictureBox();

        #endregion
        #region zmienneLauncher
        #endregion
        #region zmiennePozostałe
        internal Panel poleGry; // zmienna odpowiadająca za właściwości pola gry
        internal Label hitLog;

        internal System.Media.SoundPlayer music = new System.Media.SoundPlayer(); // zmienna odpowiadająca za muzykę w tle
        #endregion
        

        public Launcher()
        {
            InitializeComponent();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MenuGlowne formaMenuGlowne = new MenuGlowne(this);

            for (int i=0;i<9;i++)
            {
                daneMob[i] = new Launcher();
                daneMob[i].istniejeMob = false;
            }

            wczytajDaneObrazkiWhiteBrownHuman();
            wczytajDaneObrazkiWhiteBlackHuman();
            wczytajDaneObrazkiWhiteBlondeHuman();
            wczytajDaneObrazkiWhiteRedHuman();
            wczytajDaneObrazkiBlackBrownHuman();
            wczytajDaneObrazkiBlackBlackHuman();
            wczytajDaneObrazkiBlackBlondeHuman();
            wczytajDaneObrazkiBlackRedHuman();
            wczytajDaneObrazkiPinkBrownHuman();
            wczytajDaneObrazkiPinkBlackHuman();
            wczytajDaneObrazkiPinkBlondeHuman();
            wczytajDaneObrazkiPinkRedHuman();
            wczytajDaneObrazkiYellowBrownHuman();
            wczytajDaneObrazkiYellowBlackHuman();
            wczytajDaneObrazkiYellowBlondeHuman();
            wczytajDaneObrazkiYellowRedHuman();
            wczytajDaneObrazkiRedBrownHuman();
            wczytajDaneObrazkiRedBlackHuman();
            wczytajDaneObrazkiRedBlondeHuman();
            wczytajDaneObrazkiRedRedHuman();

            this.Hide();
            formaMenuGlowne.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wczytajDaneObrazkiWhiteBrownHuman()
        {
            whiteBrownStand.Image = global::Unstable.Properties.Resources.whiteBrownStand;
            whiteBrownMovingUp.Image = global::Unstable.Properties.Resources.whiteBrownMovingUp;
            whiteBrownMovingDown.Image = global::Unstable.Properties.Resources.whiteBrownMovingDown;
            whiteBrownMovingLeft.Image = global::Unstable.Properties.Resources.whiteBrownMovingLeft;
            whiteBrownMovingRight.Image = global::Unstable.Properties.Resources.whiteBrownMovingRight;

            whiteBrownStand.Image = global::Unstable.Properties.Resources.whiteBrownStand;
            whiteBrownMovingUp.Image = global::Unstable.Properties.Resources.whiteBrownMovingUp;
            whiteBrownMovingDown.Image = global::Unstable.Properties.Resources.whiteBrownMovingDown;
            whiteBrownMovingLeft.Image = global::Unstable.Properties.Resources.whiteBrownMovingLeft;
            whiteBrownMovingRight.Image = global::Unstable.Properties.Resources.whiteBrownMovingRight;

            whiteBrownAttackingRight.Image = global::Unstable.Properties.Resources.whiteBrownAttackingRight;
            whiteBrownAttackingLeft.Image = global::Unstable.Properties.Resources.whiteBrownAttackingLeft;
        }
        private void wczytajDaneObrazkiWhiteBlackHuman()
        {
            whiteBlackStand.Image = global::Unstable.Properties.Resources.whiteBlackStand;
        }
        private void wczytajDaneObrazkiWhiteBlondeHuman()
        {
            whiteBlondeStand.Image = global::Unstable.Properties.Resources.whiteBlondeStand;
        }
        private void wczytajDaneObrazkiWhiteRedHuman()
        {
            whiteRedStand.Image = global::Unstable.Properties.Resources.whiteRedStand;
        }
        private void wczytajDaneObrazkiBlackBrownHuman()
        {
            blackBrownStand.Image = global::Unstable.Properties.Resources.blackBrownStand;
        }
        private void wczytajDaneObrazkiBlackBlackHuman()
        {
            blackBlackStand.Image = global::Unstable.Properties.Resources.blackBlackStand;
        }
        private void wczytajDaneObrazkiBlackBlondeHuman()
        {
            blackBlondeStand.Image = global::Unstable.Properties.Resources.blackBlondeStand;
        }
        private void wczytajDaneObrazkiBlackRedHuman()
        {
            blackRedStand.Image = global::Unstable.Properties.Resources.blackRedStand;
        }
        private void wczytajDaneObrazkiPinkBrownHuman()
        {
            pinkBrownStand.Image = global::Unstable.Properties.Resources.pinkBrownStand;
        }
        private void wczytajDaneObrazkiPinkBlackHuman()
        {
            pinkBlackStand.Image = global::Unstable.Properties.Resources.pinkBlackStand;
        }
        private void wczytajDaneObrazkiPinkBlondeHuman()
        {
            pinkBlondeStand.Image = global::Unstable.Properties.Resources.pinkBlondeStand;
        }
        private void wczytajDaneObrazkiPinkRedHuman()
        {
            pinkRedStand.Image = global::Unstable.Properties.Resources.pinkRedStand;
        }
        private void wczytajDaneObrazkiYellowBrownHuman()
        {
            yellowBrownStand.Image = global::Unstable.Properties.Resources.yellowBrownStand;
        }
        private void wczytajDaneObrazkiYellowBlackHuman()
        {
            yellowBlackStand.Image = global::Unstable.Properties.Resources.yellowBlackStand;
        }
        private void wczytajDaneObrazkiYellowBlondeHuman()
        {
            yellowBlondeStand.Image = global::Unstable.Properties.Resources.yellowBlondeStand;
        }
        private void wczytajDaneObrazkiYellowRedHuman()
        {
            yellowRedStand.Image = global::Unstable.Properties.Resources.yellowRedStand;
        }
        private void wczytajDaneObrazkiRedBrownHuman()
        {
            redBrownStand.Image = global::Unstable.Properties.Resources.redBrownStand;
        }
        private void wczytajDaneObrazkiRedBlackHuman()
        {
            redBlackStand.Image = global::Unstable.Properties.Resources.redBlackStand;
        }
        private void wczytajDaneObrazkiRedBlondeHuman()
        {
            redBlondeStand.Image = global::Unstable.Properties.Resources.redBlondeStand;
        }
        private void wczytajDaneObrazkiRedRedHuman()
        {
            redRedStand.Image = global::Unstable.Properties.Resources.redRedStand;
        }
    }
}
