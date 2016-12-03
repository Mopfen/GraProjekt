using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Unstable
{
    /// <summary> Odpowiada za uruchomienie i działanie programu. Przechowuje większość zmiennych, na których pracuje program. </summary>
    public partial class Launcher : MetodyOgraniczonegoDostępu
    {
        /// <summary>
        /// Klasa przechowuje zmienne, na których opiera się każda postać
        /// </summary>
        internal class ZmiennePostaci
        {
            internal PictureBox obraz; // zmienna odpowiadająca za wygląd postaci
            internal PictureBox antyRozmycie; // zmienna niwelująca rozmycie podczas poruszania się obiektu

            internal bool exists = false; // zmienna określa, czy postać żyje

            internal int hp=25; //
            internal int hpMax=25; // zmienne odpowiadające za ilość punktów życia postaci

            internal int mana=25; //
            internal int manaMax=25; // zmienne odpowiadają za ilość punktów many postaci

            internal short szansaKryta=0; // zmienna opowiada za procentową szansę na krytyczne uderzenie postaci

            internal bool posiadaMiecz = false; // zmienna określa, czy postać posiada miecz
            internal bool posiadaŁuk = false; // zmienna określa, czy postać posiada łuk

            internal bool rodzajAtaku = true; // zmienna określa tryb walki gracza (true - miecz, false - łuk)

            internal int[] siłaAtakuZwarcie = { 0, 0 }; // zmienna odpowiadająca za liczbę obrażeń zadawanych przez postać podczas walki wręcz
            internal int[] siłaAtakuDystans = { 0, 0 }; // zmienna odpowiadająca za liczbę obrażeń zadawanych przez postać podczas walki strzeleckiej

            internal int lv = 1; // zmienna określa poziom doświadczenia postaci
            internal int exp = 0; //
            internal int expMax = 5; // zmienne określają ilość doświadczenia gracza
            internal int statystykiDoRozdania = 0; // zmienna określa ilość punktów statystyk do rozdania

            internal int siła = 1; //
            internal int zręczność = 1; //
            internal int inteligencja = 1; //
            internal int wytrzymałość = 1; //
            internal int szczęście = 1; //
            internal int obrona = 0; //
            internal int odporność = 0; // statystyki postaci

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

            internal bool[] dotartoDoX = new bool[10]; //
            internal bool[] dotartoDoY = new bool[10]; // zmienne określają, czy potać dotarła do danego punktu

            internal Label labelhp; // pokazuje stan zdrowia postaci
        }
        /// <summary>
        /// Klasa przechowuje zmienne, na których opiera się każdy obiekt
        /// </summary>
        internal class ZmienneObiektów
        {
            internal ZmienneObiektów() { }
            internal ZmienneObiektów(bool exists, bool ściana, PictureBox obraz, int numerMapy, int numerLokacji, int numerObiektu)
            {
                this.exists = exists;
                this.ściana = ściana;
                this.obraz = obraz;
                this.numerMapy = numerMapy;
                this.numerLokacji = numerLokacji;
                this.numerObiektu = numerObiektu;
            }

            internal PictureBox obraz; // zmienna odpowiadająca za wygląd obiektu

            internal int numerMapy = 0; // zmienna określa, na jakiej mapie znajduje się obiekt
            internal int numerLokacji = 0; // zmienna określa, w której częsci mapy znajduję się obiekt
            internal int numerObiektu = 0; // zmienna okresla, jaki numer ma obiekt na mapie

            internal bool ściana = false; // zmienna określa, czy obiekt jest ścianą

            internal bool exists = false; // zmienna określa, czy obiekt istnieje
        }
        /// <summary>
        /// Klasa przechowuje zmienne, na których opiera się każdy przedmiot
        /// </summary>
        internal class ZmienneEkwipunku
        {
            internal PictureBox obraz; // zmienna odpowiadająca za wygląd przedmiotu

            internal bool exists = false; // zmienna określa, czy przedmiot istnieje

            internal bool naWyposażeniu = false;

            internal Point Lokacja = new Point(0, 0); // zmienna określa pozycję przedmiotu w ekwipunku

            internal bool hełm = false; //
            internal bool zbroja = false; //
            internal bool spodnie = false; //
            internal bool buty = false; //
            internal bool miecz = false; //
            internal bool łuk = false; // zmienne sprawdzające, czy przedmiot jest daną rzeczą

            internal int[] dmgZwarcie = { 0, 0 }; // tablica przechowuje dane o statystyce przedmiotu: Obrażenia w zwarciu
            internal int[] dmgDystans = { 0, 0 }; // tablica przechowuje dane o statystyce przedmiotu: Obrażenia na dystans
            internal int obrona = 0; // zmienna przechowuje dane o statystyce przedmiotu: Obrona
            internal int hp = 0; // zmienna przechowuje dane o statystyce przedmiotu: Punkty Życia
            internal int mana = 0; // zmienna przechowuje dane o statystyce przedmiotu: Punkty Many
            internal short szansaKryta = 0; // zmienna przechowuje dane o statystyce przedmiotu: Szansa na krytyczne uderzenie

            internal short id = 0; // określa id przedmiotu

            internal int numerLokacji = 0; // określa numer lokacji, w której znajduje się przedmiot
        }
        /// <summary>
        /// Klasa przechowuje zmienne, na których opierają się bonusy postaci
        /// </summary>
        internal class ZmienneBonusów
        {
            internal int[] dmgZwarcie = { 0, 0 }; // zmienna przechowujące dane o bonusie: Obrażenia w zwarciu
            internal int[] dmgDystans = { 0, 0 }; // tablica przechowuje dane o bonusie: Obrażenia na dystans
            internal int obrona = 0; // zmienna przechowuje dane o bonusie: Obrona
            internal int hp = 0; // zmienna przechowuje dane o bonusie: Punkty Życia
            internal int mana = 0; // zmienna przechowuje dane o bonusie: Punkty Many
            internal short szansaKryta = 0; // zmienna przechowuje dane o bonusie: Szansa na krytyczne uderzenie
        }
        /// <summary>
        /// Klasa przechowuje zmienne, na których opierają się misje
        /// </summary>
        internal class ZmienneMisji
        {
            /// <summary>
            /// Zmienna określa stan misji. 0 - nieaktywna, 1 - aktywna, 2 - zakończona sukcesem, 3 - zakończona niepowodzeniem
            /// </summary>
            internal short stan = 0;
            internal short etap = 0; // zmienna określa etap, na którym znajduje się misja
            internal string []opisEtapu = new string[10]; // tablica przechowująca opisy etapów poszczególnych misji

            internal string nazwa; // zmienna przechowująca nazwę misji

            internal int exp = 0; // zmienna określa, ile punktów doświadczenia dostaje się za pomyślne ukończenie misji
            internal int gold = 0; // zmienna określa, ile złota dostaje się za pomyślne ukończenie misji
        }
        /// <summary>
        /// Klasa przechowuje zmienne, które określają szczegóły na temat mapy, na której się obecnie znajduje gracz
        /// </summary>
        internal class ZmienneMap
        {
            internal bool[] częśćMapyOdwiedzona = new bool[20]; // tablica przechowuje informacje o tym, czy dana część mapy została już odwiedzona
            internal short numerLokacji = 0; // zmienna określa, w której częsci mapy gracz aktualnie się znajduje
            internal short gdzieOstatnio = 0; // zmienna określa, w której częsci mapy gracz był ostatnio
        }

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

        internal PictureBox BrakItemu = new PictureBox();
        internal PictureBox ZardzewiałyMiecz = new PictureBox();
        internal PictureBox ZbutwiałyŁuk = new PictureBox();
        internal PictureBox MieczSquadaka = new PictureBox();
        internal PictureBox ŁukSquadaka = new PictureBox();

        #endregion
        #region zmiennePozostałe
        internal string gameVersion = "Unstable1.2"; // zmienna przechowuje informacje o wersji gry

        internal Panel poleGry; // zmienna odpowiadająca za właściwości pola gry
        internal Label hitLog; // zmienna odpowiadająca za wyświetlanie informacji przez hitLog
        internal Label statystykiPrzedmiotu; // zmienna odpowiadająca za wyświetlanie informacji o statystykach przedmiotów
        internal PictureBox rozdajStatystyki; // zmienna odpowiadająca za przechowywanie ilości statystyk do rozdania

        internal bool statystykiPokazywane = false; // zmienna odpowiadająca za sprawdzenie, czy statystyki przedmiotu w ekwipunku są aktualnie wyświetlane

        internal System.Windows.Forms.Timer timerStatystyki; // zmienna odpowiadająca za działanie timera

        internal string komenda = ""; // zmienna przechowująca dane komendy
        internal bool komendaOK = true; // zmienna sprawdza, czy iżytkownik podaje poprawny ciąg znaków komendy

        internal int numerMapy = 0; // zmienna określa na jakiej mapie znajduje się gracz

        internal bool muzykaMenu = false; // zmienna sprawdza, czy muzka w menu jest odtwarzana

        internal bool danoOdpowiedź1 = false; //
        internal bool danoOdpowiedź2 = false; //
        internal bool danoOdpowiedź3 = false; // zmiene sprawdzają, której odpowiedzi dokonał gracz

        internal Thread wątekMuzyka; // zmienna umozliwia wykonywanie wątku odtwarzającego muzykę w tle
        
        #endregion

        internal ZmiennePostaci daneGracz = new ZmiennePostaci(); // obiekt przechowująca informacje o graczu
        internal ZmiennePostaci []daneMob = new ZmiennePostaci[5]; // tablica obiektów przechowujących informacje o mobach
        internal ZmiennePostaci[] daneNPC = new ZmiennePostaci[5]; // tablica obiektów przechowujących informacje o NPC
        internal List<ZmienneObiektów> danePrzeszkoda = new List<ZmienneObiektów>(); // tablica obiektów przechowujących informacje o przeszkodach
        internal ZmienneObiektów []daneStrzała = new ZmienneObiektów[2]; // tablica obiekótw przechowujących informacje o strzałach wystrzelonych przez postać
        internal ZmienneEkwipunku []danePlecakSlot = new ZmienneEkwipunku[47]; // tablica obiektów przechowujących informacje o przedmiocie na danym slocie w ekwipunku
        internal ZmienneEkwipunku[] daneDrop = new ZmienneEkwipunku[5]; // tablica obiektów przechowujących infromacje o przedmiocie do podniesienia
        internal ZmienneEkwipunku daneDropKomenda = new ZmienneEkwipunku(); // obiekt przechowuje informacje o przedmiocie wygenerowanym przez komendę
        internal ZmienneBonusów daneBonusyGracz = new ZmienneBonusów(); // obiekt przechowujący informacje o bonusach gracza
        internal ZmienneBonusów []daneBonusyMob = new ZmienneBonusów[5]; // tablica obiektów przechowujących informacje o bonusach mobów
        internal ZmienneMisji[]daneQuest = new ZmienneMisji[100]; // tablica obiektów przechowujących informacje na temat misji
        internal ZmienneMap []daneMapa = new ZmienneMap[100]; // tablica obiektów przechowujących szczegóły o mapie, na której znajduje się obecnie gracz

        public Launcher()
        {
            InitializeComponent();

            DoubleBuffered = true;

            this.Text = "TerrorOfDragons - "+gameVersion;

            music.settings.setMode("loop", true);
            music.Ctlcontrols.play();
            soundGracz.Ctlcontrols.play();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MenuGlowne formaMenuGlowne = new MenuGlowne(this);
            OkienkoInformacji formaOkienkoInformacji = new OkienkoInformacji();
            WczytajDaneOdNowa(this);

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
            formaOkienkoInformacji.ShowDialog();
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

            BrakItemu.Image = global::Unstable.Properties.Resources.BrakItemu;
            ZardzewiałyMiecz.Image = global::Unstable.Properties.Resources.ZardzewiałyMiecz;
            ZbutwiałyŁuk.Image = global::Unstable.Properties.Resources.ZbutwiałyŁuk;
            MieczSquadaka.Image = global::Unstable.Properties.Resources.MieczSquadaka;
            ŁukSquadaka.Image = global::Unstable.Properties.Resources.ŁukSquadaka;
        }


    }
}
