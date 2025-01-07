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

namespace Bezpieczna_jazda
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// Metoda wywoływana po kliknięciu przycisku „Zasady”.

        private void Zasady_P_Click(object sender, EventArgs e)
        {
            // Ustawiamy nową pozycję kontrolki "Zasady"
            Point nowaPozycja = new Point(234, 187);
            this.Zasady.Location = nowaPozycja;
        }


        /// Metoda odpowiedzialna za zamknięcie aplikacji przy użyciu przycisku „Zamknij”.

        private void Zamknij_Click(object sender, EventArgs e)
        {
            // Kończymy działanie aplikacji
            Application.Exit();
        }


        /// Metoda, która uruchamia nową grę – tworzy formularz gry i chowa bieżące okno.

        private void NowaGra_Click(object sender, EventArgs e)
        {
            // Tworzymy nowy obiekt formularza Gra
            Gra form2 = new Gra();
            // Wyświetlamy okno z grą
            form2.Show();
            // Ukrywamy główne menu
            this.Hide();
        }

        /// Metoda pozwalająca wznowić stan gry od zera – resetuje zmienne i uruchamia nową instancję formularza.

        private void Wznow_Click(object sender, EventArgs e)
        {
            // Resetowanie kluczowych parametrów gry
            Program.res = 0;
            Program.Z_ile = 0;
            Program.nr = 1;

            // Tworzymy obiekt gry i pokazujemy go, ukrywając bieżące okno
            Gra form2 = new Gra();
            form2.Show();
            this.Hide();
        }


        /// Metoda wywoływana w momencie zamykania okna Menu – zamyka całą aplikację.

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Zamykamy aplikację
            Application.Exit();
        }

        private void Tytul_Click(object sender, EventArgs e)
        {

        }
    }
}
