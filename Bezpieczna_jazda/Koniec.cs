﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezpieczna_jazda
{
    public partial class Koniec : Form
    {
        public Koniec()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja odpowiedzialna za zamykanie aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Koniec_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
