using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bezpieczna_jazda
{
    public partial class Gra : Form
    {
        // Zmienne pozwalające na wykrycie, w którą stronę poruszamy pojazdem.
        bool moveleft, moveright, moveup, movedown;

        // Podstawowa prędkość poruszania się.
        int speed = 5;


        Stopwatch stopwatch = new Stopwatch();


        public Gra()
        {
            InitializeComponent();
            PrzyciskPlansza1();
        }


        private void CzasMierz(object sender, EventArgs e)
        {
            // Uruchamiamy pomiar czasu, a następnie wyświetlamy w etykiecie.
            stopwatch.Start();
            long sekundy = stopwatch.ElapsedMilliseconds / 1000;
            Stoperek.Text = "Czas: " + sekundy;

            // Sprawdzenie statusu odblokowania plansz w zależności od Program.res.
            // Program.res = 1 oznacza np. odblokowanie planszy 2, Program.res = 2 -> odblokowanie 3, itd.
            if (Program.res < 2)
            {
                P3D.BackColor = Color.Red;
            }
            else
            {
                P3D.BackColor = Color.Green;
            }

            if (Program.res >= 1)
            {
                P2D.BackColor = Color.Green;
            }
            else
            {
                P2D.BackColor = Color.Red;
            }

            // Po przekroczeniu 20 sekund wyświetlamy "Koniec" w etykiecie.
            if (sekundy > 20)
            {
                Stoperek.Text = "Koniec";

                // Jeśli czas przekroczy 22 sekundy – uznajemy, że gracz nie zdążył dojechać.
                if (sekundy > 22)
                {
                    stopwatch.Stop();

                    // W zależności od numeru aktualnej planszy (1, 2 lub 3) resetujemy ją
                    // i naliczamy przegrany przejazd (Z_ile++).
                    if (Program.nr == 1)
                    {
                        Program.Z_ile++;
                        ResetPlansz1();
                        stopwatch.Reset();
                    }
                    else if (Program.nr == 2)
                    {
                        Program.Z_ile++;
                        ResetPlansz2();
                        stopwatch.Reset();
                    }
                    else if (Program.nr == 3)
                    {
                        Program.Z_ile++;
                        ResetPlansz3();
                        stopwatch.Reset();
                    }
                }
            }
        }

        private void ruszanie(object sender, EventArgs e)
        {
            if (moveleft && Kierowca.Left > 0)
            {
                Kierowca.Left -= speed;
            }
            if (moveright && Kierowca.Left < 650)
            {
                Kierowca.Left += speed;
            }
            if (moveup && Kierowca.Top > 0)
            {
                Kierowca.Top -= speed;
            }
            if (movedown && Kierowca.Top < 400)
            {
                Kierowca.Top += speed;
            }

            // Sprawdzamy kolizje z obiektami.
            foreach (Control x in this.Controls)
            {
                // Jeśli kontrolka ma Tag = "Kolizja" i wystąpiła kolizja z Kierowcą:
                if (x is PictureBox && (string)x.Tag == "Kolizja")
                {
                    if (Kierowca.Bounds.IntersectsWith(x.Bounds))
                    {
                        stopwatch.Stop();
                        // Przy kolizji zwiększamy licznik nieudanych prób, resetujemy planszę i stoper.
                        if (Program.nr == 1)
                        {
                            Program.Z_ile++;
                            ResetPlansz1();
                            stopwatch.Reset();
                        }
                        else if (Program.nr == 2)
                        {
                            Program.Z_ile++;
                            ResetPlansz2();
                            stopwatch.Reset();
                        }
                        else if (Program.nr == 3)
                        {
                            Program.Z_ile++;
                            ResetPlansz3();
                            stopwatch.Reset();
                        }
                    }
                }

                // Metatag w PictureBox oznacza metę na danej planszy.
                if (x is PictureBox && (string)x.Tag == "Meta_Tag")
                {
                    if (Kierowca.Bounds.IntersectsWith(x.Bounds))
                    {
                        long czasAktualny = stopwatch.ElapsedMilliseconds / 1000;

                        // PLAN1: aby przejść, potrzebujemy powyżej 8 sekund.
                        if (Program.nr == 1 && czasAktualny > 8)
                        {
                            if (Program.res == 0) Program.res++;
                            P2D.BackColor = Color.Green;
                            stopwatch.Stop();
                            Stoperek.Text = "Koniec";
                            Program.Z_ile--;
                            ResetPlansz1();
                            stopwatch.Reset();
                        }
                        else if (Program.nr == 1 && czasAktualny <= 8)
                        {
                            Program.Z_ile++;
                            ResetPlansz1();
                            stopwatch.Reset();
                        }

                        // PLAN2: przejście wymaga powyżej 7 sekund.
                        if (Program.nr == 2 && czasAktualny > 7)
                        {
                            if (Program.res == 1) Program.res++;
                            P3D.BackColor = Color.Green;
                            stopwatch.Stop();
                            Stoperek.Text = "Koniec";
                            Program.Z_ile--;
                            ResetPlansz2();
                            stopwatch.Reset();
                        }
                        else if (Program.nr == 2 && czasAktualny <= 7)
                        {
                            Program.Z_ile++;
                            ResetPlansz2();
                            stopwatch.Reset();
                        }

                        // PLAN3: przejście wymaga powyżej 8 sekund, inaczej przegrywamy.
                        if (Program.nr == 3 && czasAktualny > 8)
                        {
                            stopwatch.Stop();
                            Koniec form2 = new Koniec();
                            form2.Show();
                            this.Hide();
                            Program.nr = 1;
                        }
                        else if (Program.nr == 3 && czasAktualny <= 8)
                        {
                            Program.Z_ile++;
                            ResetPlansz3();
                            stopwatch.Reset();
                        }
                    }
                }
            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                movedown = true;
            }
        }

        /// <summary>
        /// Sprawdzamy stan klawiszy podczas puszczenia.
        /// </summary>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                movedown = false;
            }
        }

        /// <summary>
        /// Kliknięcie na przycisk „Plansza 1”.
        /// </summary>
        private void P1_Click(object sender, EventArgs e)
        {
            if (P1D.BackColor == Color.Green)
            {
                stopwatch.Stop();
                Stoperek.Text = "Koniec";
                PrzyciskPlansza1();
                stopwatch.Reset();
            }
        }

        /// <summary>
        /// Kliknięcie na przycisk „Plansza 2”.
        /// </summary>
        private void P2_Click(object sender, EventArgs e)
        {
            if (P2D.BackColor == Color.Green)
            {
                stopwatch.Stop();
                Stoperek.Text = "Koniec";
                PrzyciskPlansza2();
                stopwatch.Reset();
            }
        }

        /// <summary>
        /// Kliknięcie na przycisk „Plansza 3”.
        /// </summary>
        private void P3_Click(object sender, EventArgs e)
        {
            if (P3D.BackColor == Color.Green)
            {
                stopwatch.Stop();
                Stoperek.Text = "Koniec";
                PrzyciskPlansza3();
                stopwatch.Reset();
            }
        }

        /// <summary>
        /// Przycisk „Menu” – powrót do głównego menu gry.
        /// </summary>
        private void Menu_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

        /// <summary>
        /// Obsługa zamykania okna gry – zamknięcie aplikacji.
        /// </summary>
        private void Gra_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ruch dla niebieskiego pojazdu AI, zależnie od numeru planszy.
        /// </summary>
        private void Sam_Niebieski_Sterowanie(object sender, EventArgs e)
        {
            if (Program.nr == 1)
            {
                Sam_Niebieski.Left -= 1;
            }
            else if (Program.nr == 2)
            {
                Sam_Niebieski.Top += 1;
            }
            else if (Program.nr == 3)
            {
                Sam_Niebieski.Top -= 1;
            }
        }
    }
}
