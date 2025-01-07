using System.Drawing;
using System.Windows.Forms;

namespace Bezpieczna_jazda
{
    partial class Gra
    {
        //int Z_ile=0;
        // int nr = 1;
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// Główna funkcja inicjalizacji, zawiera początkowe ustawienie planszy, deklaracje wszYstkich elementów
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gra));
            this.LicznikRuchu = new System.Windows.Forms.Timer(this.components);
            this.Sam_Niebieski_Ruch = new System.Windows.Forms.Timer(this.components);
            this.Czas = new System.Windows.Forms.Timer(this.components);
            this.Tlo = new System.Windows.Forms.PictureBox();
            this.Trawa_L_G = new System.Windows.Forms.PictureBox();
            this.Pas_L = new System.Windows.Forms.PictureBox();
            this.Trawa_L_D = new System.Windows.Forms.PictureBox();
            this.meta = new System.Windows.Forms.PictureBox();
            this.Pas_G = new System.Windows.Forms.PictureBox();
            this.Trawa_P_G = new System.Windows.Forms.PictureBox();
            this.Sam_Niebieski = new System.Windows.Forms.PictureBox();
            this.Pas_D = new System.Windows.Forms.PictureBox();
            this.Trawa_P_D = new System.Windows.Forms.PictureBox();
            this.Pas_P = new System.Windows.Forms.PictureBox();
            this.Kierowca = new System.Windows.Forms.PictureBox();
            this.Trawa_P_S = new System.Windows.Forms.PictureBox();
            this.MenuBoczne = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.P3 = new System.Windows.Forms.PictureBox();
            this.P1D = new System.Windows.Forms.PictureBox();
            this.P2D = new System.Windows.Forms.PictureBox();
            this.P3D = new System.Windows.Forms.PictureBox();
            this.Ile = new System.Windows.Forms.Label();
            this.Stoperek = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_L_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pas_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_L_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pas_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_P_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sam_Niebieski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pas_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_P_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pas_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kierowca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_P_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBoczne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // LicznikRuchu
            // 
            this.LicznikRuchu.Enabled = true;
            this.LicznikRuchu.Interval = 20;
            this.LicznikRuchu.Tick += new System.EventHandler(this.ruszanie);
            // 
            // Sam_Niebieski_Ruch
            // 
            this.Sam_Niebieski_Ruch.Enabled = true;
            this.Sam_Niebieski_Ruch.Interval = 20;
            this.Sam_Niebieski_Ruch.Tick += new System.EventHandler(this.Sam_Niebieski_Sterowanie);
            // 
            // Czas
            // 
            this.Czas.Enabled = true;
            this.Czas.Interval = 10;
            this.Czas.Tick += new System.EventHandler(this.CzasMierz);
            // 
            // Tlo
            // 
            this.Tlo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Tlo.Location = new System.Drawing.Point(1, 1);
            this.Tlo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tlo.Name = "Tlo";
            this.Tlo.Size = new System.Drawing.Size(960, 551);
            this.Tlo.TabIndex = 24;
            this.Tlo.TabStop = false;
            this.Tlo.Tag = "Tlo";
            // 
            // Trawa_L_G
            // 
            this.Trawa_L_G.BackColor = System.Drawing.Color.Green;
            this.Trawa_L_G.Location = new System.Drawing.Point(1, 2);
            this.Trawa_L_G.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trawa_L_G.Name = "Trawa_L_G";
            this.Trawa_L_G.Size = new System.Drawing.Size(383, 202);
            this.Trawa_L_G.TabIndex = 25;
            this.Trawa_L_G.TabStop = false;
            this.Trawa_L_G.Tag = "Kolizja";
            // 
            // Pas_L
            // 
            this.Pas_L.BackColor = System.Drawing.Color.White;
            this.Pas_L.Location = new System.Drawing.Point(1, 267);
            this.Pas_L.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pas_L.Name = "Pas_L";
            this.Pas_L.Size = new System.Drawing.Size(383, 17);
            this.Pas_L.TabIndex = 26;
            this.Pas_L.TabStop = false;
            this.Pas_L.Tag = "Kolizja";
            // 
            // Trawa_L_D
            // 
            this.Trawa_L_D.BackColor = System.Drawing.Color.Green;
            this.Trawa_L_D.Location = new System.Drawing.Point(1, 361);
            this.Trawa_L_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trawa_L_D.Name = "Trawa_L_D";
            this.Trawa_L_D.Size = new System.Drawing.Size(383, 193);
            this.Trawa_L_D.TabIndex = 27;
            this.Trawa_L_D.TabStop = false;
            this.Trawa_L_D.Tag = "Kolizja";
            // 
            // meta
            // 
            this.meta.BackColor = System.Drawing.Color.Gold;
            this.meta.Location = new System.Drawing.Point(880, 310);
            this.meta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.meta.Name = "meta";
            this.meta.Size = new System.Drawing.Size(24, 21);
            this.meta.TabIndex = 28;
            this.meta.TabStop = false;
            this.meta.Tag = "Meta_Tag";
            // 
            // Pas_G
            // 
            this.Pas_G.BackColor = System.Drawing.Color.White;
            this.Pas_G.Location = new System.Drawing.Point(481, 2);
            this.Pas_G.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pas_G.Name = "Pas_G";
            this.Pas_G.Size = new System.Drawing.Size(19, 202);
            this.Pas_G.TabIndex = 29;
            this.Pas_G.TabStop = false;
            this.Pas_G.Tag = "Kolizja";
            // 
            // Trawa_P_G
            // 
            this.Trawa_P_G.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_G.Location = new System.Drawing.Point(585, 1);
            this.Trawa_P_G.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trawa_P_G.Name = "Trawa_P_G";
            this.Trawa_P_G.Size = new System.Drawing.Size(376, 202);
            this.Trawa_P_G.TabIndex = 30;
            this.Trawa_P_G.TabStop = false;
            this.Trawa_P_G.Tag = "Kolizja";
            // 
            // Sam_Niebieski
            // 
            this.Sam_Niebieski.BackColor = System.Drawing.Color.Blue;
            this.Sam_Niebieski.Location = new System.Drawing.Point(518, 492);
            this.Sam_Niebieski.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sam_Niebieski.Name = "Sam_Niebieski";
            this.Sam_Niebieski.Size = new System.Drawing.Size(51, 50);
            this.Sam_Niebieski.TabIndex = 31;
            this.Sam_Niebieski.TabStop = false;
            this.Sam_Niebieski.Tag = "Kolizja";
            // 
            // Pas_D
            // 
            this.Pas_D.BackColor = System.Drawing.Color.White;
            this.Pas_D.Location = new System.Drawing.Point(481, 361);
            this.Pas_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pas_D.Name = "Pas_D";
            this.Pas_D.Size = new System.Drawing.Size(19, 193);
            this.Pas_D.TabIndex = 32;
            this.Pas_D.TabStop = false;
            this.Pas_D.Tag = "Kolizja";
            // 
            // Trawa_P_D
            // 
            this.Trawa_P_D.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_D.Location = new System.Drawing.Point(585, 359);
            this.Trawa_P_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trawa_P_D.Name = "Trawa_P_D";
            this.Trawa_P_D.Size = new System.Drawing.Size(376, 192);
            this.Trawa_P_D.TabIndex = 33;
            this.Trawa_P_D.TabStop = false;
            this.Trawa_P_D.Tag = "Kolizja";
            // 
            // Pas_P
            // 
            this.Pas_P.BackColor = System.Drawing.Color.White;
            this.Pas_P.Location = new System.Drawing.Point(586, 267);
            this.Pas_P.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pas_P.Name = "Pas_P";
            this.Pas_P.Size = new System.Drawing.Size(376, 17);
            this.Pas_P.TabIndex = 34;
            this.Pas_P.TabStop = false;
            this.Pas_P.Tag = "Kolizja";
            // 
            // Kierowca
            // 
            this.Kierowca.BackColor = System.Drawing.Color.Red;
            this.Kierowca.Location = new System.Drawing.Point(407, 14);
            this.Kierowca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kierowca.Name = "Kierowca";
            this.Kierowca.Size = new System.Drawing.Size(51, 50);
            this.Kierowca.TabIndex = 35;
            this.Kierowca.TabStop = false;
            this.Kierowca.Tag = "Kierowca";
            // 
            // Trawa_P_S
            // 
            this.Trawa_P_S.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_S.Location = new System.Drawing.Point(1919, 188);
            this.Trawa_P_S.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trawa_P_S.Name = "Trawa_P_S";
            this.Trawa_P_S.Size = new System.Drawing.Size(376, 202);
            this.Trawa_P_S.TabIndex = 36;
            this.Trawa_P_S.TabStop = false;
            this.Trawa_P_S.Tag = "Kolizja";
            // 
            // MenuBoczne
            // 
            this.MenuBoczne.BackColor = System.Drawing.Color.Gray;
            this.MenuBoczne.Location = new System.Drawing.Point(961, 2);
            this.MenuBoczne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuBoczne.Name = "MenuBoczne";
            this.MenuBoczne.Size = new System.Drawing.Size(276, 553);
            this.MenuBoczne.TabIndex = 37;
            this.MenuBoczne.TabStop = false;
            // 
            // P1
            // 
            this.P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P1.Image = ((System.Drawing.Image)(resources.GetObject("P1.Image")));
            this.P1.Location = new System.Drawing.Point(968, 14);
            this.P1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(117, 50);
            this.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P1.TabIndex = 39;
            this.P1.TabStop = false;
            this.P1.Click += new System.EventHandler(this.P1_Click);
            // 
            // P2
            // 
            this.P2.Image = ((System.Drawing.Image)(resources.GetObject("P2.Image")));
            this.P2.Location = new System.Drawing.Point(968, 86);
            this.P2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(119, 50);
            this.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P2.TabIndex = 40;
            this.P2.TabStop = false;
            this.P2.Click += new System.EventHandler(this.P2_Click);
            // 
            // P3
            // 
            this.P3.Image = ((System.Drawing.Image)(resources.GetObject("P3.Image")));
            this.P3.Location = new System.Drawing.Point(968, 154);
            this.P3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(119, 50);
            this.P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P3.TabIndex = 47;
            this.P3.TabStop = false;
            this.P3.Click += new System.EventHandler(this.P3_Click);
            // 
            // P1D
            // 
            this.P1D.BackColor = System.Drawing.Color.Green;
            this.P1D.Location = new System.Drawing.Point(1120, 15);
            this.P1D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.P1D.Name = "P1D";
            this.P1D.Size = new System.Drawing.Size(24, 25);
            this.P1D.TabIndex = 48;
            this.P1D.TabStop = false;
            // 
            // P2D
            // 
            this.P2D.BackColor = System.Drawing.Color.Red;
            this.P2D.Location = new System.Drawing.Point(1120, 86);
            this.P2D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.P2D.Name = "P2D";
            this.P2D.Size = new System.Drawing.Size(24, 25);
            this.P2D.TabIndex = 49;
            this.P2D.TabStop = false;
            this.P2D.Tag = "P2D_Tag";
            // 
            // P3D
            // 
            this.P3D.BackColor = System.Drawing.Color.Red;
            this.P3D.Location = new System.Drawing.Point(1120, 154);
            this.P3D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.P3D.Name = "P3D";
            this.P3D.Size = new System.Drawing.Size(24, 25);
            this.P3D.TabIndex = 50;
            this.P3D.TabStop = false;
            // 
            // Ile
            // 
            this.Ile.AutoSize = true;
            this.Ile.BackColor = System.Drawing.Color.Gray;
            this.Ile.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ile.Location = new System.Drawing.Point(968, 225);
            this.Ile.Name = "Ile";
            this.Ile.Size = new System.Drawing.Size(152, 48);
            this.Ile.TabIndex = 51;
            this.Ile.Text = "Próby: ";
            // 
            // Stoperek
            // 
            this.Stoperek.AutoSize = true;
            this.Stoperek.BackColor = System.Drawing.Color.Gray;
            this.Stoperek.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stoperek.Location = new System.Drawing.Point(968, 295);
            this.Stoperek.Name = "Stoperek";
            this.Stoperek.Size = new System.Drawing.Size(171, 48);
            this.Stoperek.TabIndex = 52;
            this.Stoperek.Text = "Czas:    ";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Gray;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(995, 422);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(149, 68);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu.TabIndex = 42;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Stoperek);
            this.Controls.Add(this.Ile);
            this.Controls.Add(this.P3D);
            this.Controls.Add(this.P2D);
            this.Controls.Add(this.P1D);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Trawa_P_S);
            this.Controls.Add(this.Kierowca);
            this.Controls.Add(this.Pas_P);
            this.Controls.Add(this.Trawa_P_D);
            this.Controls.Add(this.Pas_D);
            this.Controls.Add(this.Sam_Niebieski);
            this.Controls.Add(this.Trawa_P_G);
            this.Controls.Add(this.Pas_G);
            this.Controls.Add(this.meta);
            this.Controls.Add(this.MenuBoczne);
            this.Controls.Add(this.Trawa_L_D);
            this.Controls.Add(this.Pas_L);
            this.Controls.Add(this.Trawa_L_G);
            this.Controls.Add(this.Tlo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gra";
            this.Text = "Bezpieczna_jazda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gra_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Tlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_L_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pas_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_L_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pas_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_P_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sam_Niebieski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pas_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_P_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pas_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kierowca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trawa_P_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBoczne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// Funkcja Resetująca plansze pierwszą po złamaniu przez kierowce przepisów
        /// </summary>
        private void ResetPlansz1()
        {
            //Liczenie Prób
            this.Ile.Text = "Próby: " + Program.Z_ile;
            //Reset Niebieskeigo Auta
            this.Sam_Niebieski.Location = new System.Drawing.Point(638, 171);
            this.Sam_Niebieski.Size = new System.Drawing.Size(38, 41);
            this.Sam_Niebieski.BackColor = System.Drawing.Color.Blue;
            //Reset Auta Kierowcy
            this.Kierowca.Location = new System.Drawing.Point(386, 397);
            this.Kierowca.Size = new System.Drawing.Size(38, 41);

        }
        /// <summary>
        /// Funkcja Resetująca plansze drugą po złamaniu przez kierowce przepisów
        /// </summary>
        private void ResetPlansz2()
        {
            //Liczenie Prób
            this.Ile.Text = "Próby: " + Program.Z_ile;
            //Trawa Prawa Środek
            this.Trawa_P_S.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_S.Location = new System.Drawing.Point(439, 153);
            this.Trawa_P_S.Name = "Trawa_P_S";
            this.Trawa_P_S.Size = new System.Drawing.Size(282, 164);
            this.Trawa_P_S.TabIndex = 36;
            this.Trawa_P_S.TabStop = false;
            this.Trawa_P_S.Tag = "Kolizja";
            // Meta
            this.meta.Location = new System.Drawing.Point(23, 183);
            //Niebieski
            this.Sam_Niebieski.Location = new System.Drawing.Point(305, 22);
            // Kierowca
            this.Kierowca.Location = new System.Drawing.Point(386, 397);
            this.Kierowca.Size = new System.Drawing.Size(38, 41);


        }
        /// <summary>
        /// Funkcja Resetująca plansze trzecią po złamaniu przez kierowce przepisów
        /// </summary>
        private void ResetPlansz3()
        {
            //Liczenie Prób
            this.Ile.Text = "Próby: " + Program.Z_ile;
            //Trawa Lewy Środek
            this.Trawa_P_S.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_S.Location = new System.Drawing.Point(1, 149);
            this.Trawa_P_S.Name = "Trawa_L_S";
            this.Trawa_P_S.Size = new System.Drawing.Size(287, 164);
            this.Trawa_P_S.TabIndex = 36;
            this.Trawa_P_S.TabStop = false;
            this.Trawa_P_S.Tag = "Kolizja";
            // Meta
            this.meta.Location = new System.Drawing.Point(660, 252);
            //Niebieski
            this.Sam_Niebieski.Location = new System.Drawing.Point(396, 397);
            //Kierowca
            this.Kierowca.Location = new System.Drawing.Point(305, 11);
        }
        /// <summary>
        /// Funkcją umożliwiającą przełączenie i reset za pomocą przycisku planszy nr 1
        /// </summary>
        private void PrzyciskPlansza1()
        {

            //Ustawienie nr do resetowania odpowiedniej planszy
            Program.nr = 1;
            ///
            //this.Trawa_L_S.BackColor = System.Drawing.Color.LimeGreen;
            // 
            // Sam_Niebieski_Ruch
            // 
            this.Sam_Niebieski_Ruch.Enabled = true;
            this.Sam_Niebieski_Ruch.Interval = 20;
            // 
            // Tlo
            // 
            this.Tlo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Tlo.Location = new System.Drawing.Point(1, 1);
            this.Tlo.Name = "Tlo";
            this.Tlo.Size = new System.Drawing.Size(720, 448);
            this.Tlo.TabIndex = 24;
            this.Tlo.TabStop = false;
            // 
            // Trawa_L_G
            // 
            this.Trawa_L_G.BackColor = System.Drawing.Color.Green;
            this.Trawa_L_G.Location = new System.Drawing.Point(1, 2);
            this.Trawa_L_G.Name = "Trawa_L_G";
            this.Trawa_L_G.Size = new System.Drawing.Size(287, 164);
            this.Trawa_L_G.TabIndex = 25;
            this.Trawa_L_G.TabStop = false;
            this.Trawa_L_G.Tag = "Kolizja";
            // 
            // Pas_L
            // 
            this.Pas_L.BackColor = System.Drawing.Color.White;
            this.Pas_L.Location = new System.Drawing.Point(1, 217);
            this.Pas_L.Name = "Pas_L";
            this.Pas_L.Size = new System.Drawing.Size(287, 14);
            this.Pas_L.TabIndex = 26;
            this.Pas_L.TabStop = false;
            this.Pas_L.Tag = "Kolizja";
            // 
            // Trawa_L_D
            // 
            this.Trawa_L_D.BackColor = System.Drawing.Color.Green;
            this.Trawa_L_D.Location = new System.Drawing.Point(1, 293);
            this.Trawa_L_D.Name = "Trawa_L_D";
            this.Trawa_L_D.Size = new System.Drawing.Size(287, 157);
            this.Trawa_L_D.TabIndex = 27;
            this.Trawa_L_D.TabStop = false;
            this.Trawa_L_D.Tag = "Kolizja";
            // 
            // meta
            // 
            this.meta.BackColor = System.Drawing.Color.Gold;
            this.meta.Location = new System.Drawing.Point(397, 11);
            this.meta.Margin = new System.Windows.Forms.Padding(2);
            this.meta.Name = "meta";
            this.meta.Size = new System.Drawing.Size(18, 17);
            this.meta.TabIndex = 28;
            this.meta.TabStop = false;
            this.meta.Tag = "Meta_Tag";
            // 
            // Pas_G
            // 
            this.Pas_G.BackColor = System.Drawing.Color.White;
            this.Pas_G.Location = new System.Drawing.Point(361, 2);
            this.Pas_G.Name = "Pas_G";
            this.Pas_G.Size = new System.Drawing.Size(14, 164);
            this.Pas_G.TabIndex = 29;
            this.Pas_G.TabStop = false;
            this.Pas_G.Tag = "Kolizja";
            // 
            // Trawa_P_G
            // 
            this.Trawa_P_G.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_G.Location = new System.Drawing.Point(439, 2);
            this.Trawa_P_G.Name = "Trawa_P_G";
            this.Trawa_P_G.Size = new System.Drawing.Size(282, 164);
            this.Trawa_P_G.TabIndex = 30;
            this.Trawa_P_G.TabStop = false;
            this.Trawa_P_G.Tag = "Kolizja";
            // 
            // Sam_Niebieski
            // 
            this.Sam_Niebieski.BackColor = System.Drawing.Color.Blue;
            this.Sam_Niebieski.Location = new System.Drawing.Point(638, 171);
            this.Sam_Niebieski.Margin = new System.Windows.Forms.Padding(2);
            this.Sam_Niebieski.Name = "Sam_Niebieski";
            this.Sam_Niebieski.Size = new System.Drawing.Size(38, 41);
            this.Sam_Niebieski.TabIndex = 31;
            this.Sam_Niebieski.TabStop = false;
            this.Sam_Niebieski.Tag = "Kolizja";
            // 
            // Pas_D
            // 
            this.Pas_D.BackColor = System.Drawing.Color.White;
            this.Pas_D.Location = new System.Drawing.Point(361, 293);
            this.Pas_D.Name = "Pas_D";
            this.Pas_D.Size = new System.Drawing.Size(14, 157);
            this.Pas_D.TabIndex = 32;
            this.Pas_D.TabStop = false;
            this.Pas_D.Tag = "Kolizja";
            // 
            // Trawa_P_D
            // 
            this.Trawa_P_D.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_D.Location = new System.Drawing.Point(439, 292);
            this.Trawa_P_D.Name = "Trawa_P_D";
            this.Trawa_P_D.Size = new System.Drawing.Size(282, 156);
            this.Trawa_P_D.TabIndex = 33;
            this.Trawa_P_D.TabStop = false;
            this.Trawa_P_D.Tag = "Kolizja";
            // 
            // Pas_P
            // 
            this.Pas_P.BackColor = System.Drawing.Color.White;
            this.Pas_P.Location = new System.Drawing.Point(439, 217);
            this.Pas_P.Name = "Pas_P";
            this.Pas_P.Size = new System.Drawing.Size(282, 14);
            this.Pas_P.TabIndex = 34;
            this.Pas_P.TabStop = false;
            this.Pas_P.Tag = "Kolizja";
            // 
            // Kierowca
            // 
            this.Kierowca.BackColor = System.Drawing.Color.Red;
            this.Kierowca.Location = new System.Drawing.Point(386, 397);
            this.Kierowca.Margin = new System.Windows.Forms.Padding(2);
            this.Kierowca.Name = "Kierowca";
            this.Kierowca.Size = new System.Drawing.Size(38, 41);
            this.Kierowca.TabIndex = 35;
            this.Kierowca.TabStop = false;
            this.Kierowca.Tag = "Kierowca";
            //
            //Usuwanie elementów innych plansz
            //
            this.Trawa_P_S.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_S.Location = new System.Drawing.Point(1000, 149);
            this.Trawa_P_S.Name = "Trawa_L_S";
            this.Trawa_P_S.Size = new System.Drawing.Size(287, 164);
            this.Trawa_P_S.TabIndex = 36;
            this.Trawa_P_S.TabStop = false;
            this.Trawa_P_S.Tag = "Kolizja";
            //
            this.Trawa_P_S.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_S.Location = new System.Drawing.Point(1000, 154);
            this.Trawa_P_S.Name = "Trawa_P_S";
            this.Trawa_P_S.Size = new System.Drawing.Size(282, 164);
            this.Trawa_P_S.TabIndex = 36;
            this.Trawa_P_S.TabStop = false;
            this.Trawa_P_S.Tag = "Kolizja";

        }
        /// <summary>
        /// Funkcją umożliwiającą przełączenie i reset za pomocą przycisku planszy nr 2
        /// </summary>
        private void PrzyciskPlansza2()
        {
            //Ustawienie nr do resetowania odpowiedniej planszy
            Program.nr = 2;
            //Trawa Prawa Środek
            this.Trawa_P_S.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_S.Location = new System.Drawing.Point(439, 153);
            this.Trawa_P_S.Name = "Trawa_P_S";
            this.Trawa_P_S.Size = new System.Drawing.Size(282, 164);
            this.Trawa_P_S.TabIndex = 36;
            this.Trawa_P_S.TabStop = false;
            this.Trawa_P_S.Tag = "Kolizja";
            // Meta
            this.meta.Location = new System.Drawing.Point(23, 183);
            //Niebieski
            this.Sam_Niebieski.Location = new System.Drawing.Point(305, 22);
        }
        /// <summary>
        /// Funkcją umożliwiającą przełączenie i reset za pomocą przycisku planszy nr 3
        /// </summary>
        private void PrzyciskPlansza3()
        {
            //Ustawienie nr do resetowania odpowiedniej planszy
            Program.nr = 3;
            this.Trawa_P_S.BackColor = System.Drawing.Color.Green;
            this.Trawa_P_S.Location = new System.Drawing.Point(1, 149);
            this.Trawa_P_S.Name = "Trawa_L_S";
            this.Trawa_P_S.Size = new System.Drawing.Size(287, 164);
            this.Trawa_P_S.TabIndex = 36;
            this.Trawa_P_S.TabStop = false;
            this.Trawa_P_S.Tag = "Kolizja";
            // Meta
            this.meta.Location = new System.Drawing.Point(660, 252);
            //Niebieski
            this.Sam_Niebieski.Location = new System.Drawing.Point(396, 397);
            //Kierowca
            this.Kierowca.Location = new System.Drawing.Point(305, 11);
        }
        /// <summary>
        /// Deklaracje elementów
        /// </summary>
        private System.Windows.Forms.Timer LicznikRuchu;
        private System.Windows.Forms.Timer Sam_Niebieski_Ruch;
        private System.Windows.Forms.Timer Czas;
        private PictureBox Tlo;
        private PictureBox Trawa_L_G;
        private PictureBox Pas_L;
        private PictureBox Trawa_L_D;
        private PictureBox meta;
        private PictureBox Pas_G;
        private PictureBox Trawa_P_G;
        private PictureBox Sam_Niebieski;
        private PictureBox Pas_D;
        private PictureBox Trawa_P_D;
        private PictureBox Pas_P;
        private PictureBox Kierowca;
        private PictureBox Trawa_P_S;
        private PictureBox MenuBoczne;
        private PictureBox P1;
        private PictureBox P2;
        private PictureBox P3;
        private PictureBox P1D;
        private PictureBox P2D;
        private PictureBox P3D;
        private Label Ile;
        private Label Stoperek;
        private new PictureBox Menu;
    }
}

