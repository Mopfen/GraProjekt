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
        #region zmiennePostaci
        internal Launcher[] daneGracz = new Launcher[1]; // przechowuje informacje o graczu
        internal Launcher[] daneMob = new Launcher[5]; // tablica przechowująca dane o kilku mobach

        internal PictureBox obraz; // zmienna odpowiadająca za wygląd obiektu
        internal PictureBox antyRozmycie; // zmienna niwelująca rozmycie podczas poruszania się obiektu

        internal bool alive = true; // zmienna określa, czy postać żyje lub strzała istnieje

        internal int hp; //
        internal int hpMax; // zmienne odpowiadające za ilość punktów życia postaci

        internal int mana;
        internal int manaMax;

        internal bool rodzajAtaku = true; // zmienna określa tryb walki gracza (true - miecz, false - łuk)

        internal int[] siłaAtakuZwarcie = { 0, 0 }; // zmienna odpowiadająca za liczbę obrażeń zadawanych przez postać podczas walki wręcz
        internal int[] siłaAtakuDystans = { 0, 0 }; // zmienna odpowiadająca za liczbę obrażeń zadawanych przez postać podczas walki strzeleckiej

        internal int lv = 1; // zmienna określa poziom doświadczenia postaci
        internal int exp = 0; //
        internal int expMax = 5; // zmienne określają ilość doświadczenia gracza

        internal int siła = 1; //
        internal int zręczność = 1; //
        internal int inteligencja = 1; //
        internal int wytrzymałość = 1; //
        internal int szczęście = 1; //
        internal int obronaGracz = 0; //
        internal int odpornośćGracz = 0; // statystyki gracza
        
        internal bool up = false; //
        internal bool down = false; //
        internal bool left = false; //
        internal bool right = false; // zmienne odpowiadające za ruch postaci
        
        internal bool zmianaKierunkuUp = false; //
        internal bool zmianaKierunkuDown = false; //
        internal bool zmianaKierunkuLeft = false; // 
        internal bool zmianaKierunkuRight = false; // zmienne odpowiadające za zmianę grafiki postaci podczas ruchu 

        internal bool przeszkoda = false; // zmienna sprawdza, czy na drodze postaci jest przeszkoda

        internal bool attack; // zmienna odpowiadająca za wykonanie ataku przez postać

        internal bool wykonanoAtak = false; // zmienna odpowiadająca za sprawdzenie, czy atak został wykonany

        internal int stopMoving = 0; // zlicza czas przetrzymania postaci podczas ataku

        internal Label labelhp; // pokazuje stan zdrowia moba

        #endregion
        #region zmienneWygląduObiektów
        internal PictureBox whiteBrownStand = new PictureBox();
        internal PictureBox whiteBrownMovingUp = new PictureBox();
        internal PictureBox whiteBrownMovingDown = new PictureBox();
        internal PictureBox whiteBrownMovingLeft = new PictureBox();
        internal PictureBox whiteBrownMovingRight = new PictureBox();
        internal PictureBox whiteBrownAttackingUp = new PictureBox();
        internal PictureBox whiteBrownAttackingDown = new PictureBox();
        internal PictureBox whiteBrownAttackingLeft = new PictureBox();
        internal PictureBox whiteBrownAttackingRight = new PictureBox();
        internal PictureBox whiteBrownShotingLeft = new PictureBox();
        internal PictureBox whiteBrownShotingRight = new PictureBox();

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


        internal PictureBox strzałaLeft = new PictureBox();
        internal PictureBox strzałaRight = new PictureBox();

        #endregion
        #region zmienneLauncher
        #endregion
        #region zmiennePozostałe
        internal Panel poleGry; // zmienna odpowiadająca za właściwości pola gry
        internal Label hitLog;
        internal Launcher[] daneStrzała = new Launcher[2];
        internal Launcher[] danePrzeszkoda = new Launcher[20];

        internal System.Media.SoundPlayer music = new System.Media.SoundPlayer(); // zmienna odpowiadająca za muzykę w tle
        #endregion
        

        public Launcher()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MenuGlowne formaMenuGlowne = new MenuGlowne(this);

            daneGracz[0] = new Launcher();
            daneStrzała[0] = new Launcher(); daneStrzała[0].alive = false;
            daneStrzała[1] = new Launcher(); daneStrzała[1].alive = false;
            for (int i = 0; i < 5; i++)
                {
                daneMob[i] = new Launcher();
                daneMob[i].alive = false;
            }
            for (int i = 0; i < 20; i++)
            {
                danePrzeszkoda[i] = new Launcher();
                danePrzeszkoda[i].alive = false;
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
            wczytajDaneObrazkiInne();

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
            whiteBrownShotingLeft.Image = global::Unstable.Properties.Resources.whiteBrownShotingLeft;
            whiteBrownShotingRight.Image = global::Unstable.Properties.Resources.whiteBrownShotingRight;
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
        private void wczytajDaneObrazkiInne()
        {
            strzałaLeft.Image = global::Unstable.Properties.Resources.StrzałaLeft;
            strzałaRight.Image = global::Unstable.Properties.Resources.StrzałaRight;
        }
    }
}
