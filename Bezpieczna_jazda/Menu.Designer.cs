namespace Bezpieczna_jazda
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Wznow = new System.Windows.Forms.Button();
            this.Zamknij = new System.Windows.Forms.Button();
            this.NowaGra = new System.Windows.Forms.Button();
            this.Zasady_P = new System.Windows.Forms.Button();
            this.Tytul = new System.Windows.Forms.Label();
            this.Zasady = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Wznow
            // 
            this.Wznow.Location = new System.Drawing.Point(295, 232);
            this.Wznow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Wznow.Name = "Wznow";
            this.Wznow.Size = new System.Drawing.Size(252, 68);
            this.Wznow.TabIndex = 0;
            this.Wznow.Text = "Nowa Gra";
            this.Wznow.UseVisualStyleBackColor = true;
            this.Wznow.Click += new System.EventHandler(this.Wznow_Click);
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(295, 457);
            this.Zamknij.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(252, 68);
            this.Zamknij.TabIndex = 1;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // NowaGra
            // 
            this.NowaGra.Location = new System.Drawing.Point(295, 307);
            this.NowaGra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(252, 68);
            this.NowaGra.TabIndex = 2;
            this.NowaGra.Text = "Wznów";
            this.NowaGra.UseVisualStyleBackColor = true;
            this.NowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // Zasady_P
            // 
            this.Zasady_P.Location = new System.Drawing.Point(295, 382);
            this.Zasady_P.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zasady_P.Name = "Zasady_P";
            this.Zasady_P.Size = new System.Drawing.Size(252, 68);
            this.Zasady_P.TabIndex = 3;
            this.Zasady_P.Text = "Zasady";
            this.Zasady_P.UseVisualStyleBackColor = true;
            this.Zasady_P.Click += new System.EventHandler(this.Zasady_P_Click);
            // 
            // Tytul
            // 
            this.Tytul.AutoSize = true;
            this.Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tytul.Location = new System.Drawing.Point(77, 75);
            this.Tytul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(665, 102);
            this.Tytul.TabIndex = 4;
            this.Tytul.Text = "Gra - \"Bezpieczna jazda\"\r\nAutor: Patryk Kuszowski s193081";
            this.Tytul.Click += new System.EventHandler(this.Tytul_Click);
            // 
            // Zasady
            // 
            this.Zasady.AutoSize = true;
            this.Zasady.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zasady.Location = new System.Drawing.Point(1645, 230);
            this.Zasady.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Zasady.Name = "Zasady";
            this.Zasady.Size = new System.Drawing.Size(554, 160);
            this.Zasady.TabIndex = 5;
            this.Zasady.Text = resources.GetString("Zasady.Text");
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 556);
            this.Controls.Add(this.Zasady);
            this.Controls.Add(this.Tytul);
            this.Controls.Add(this.Zasady_P);
            this.Controls.Add(this.NowaGra);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.Wznow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wznow;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Button NowaGra;
        private System.Windows.Forms.Button Zasady_P;
        private System.Windows.Forms.Label Tytul;
        private System.Windows.Forms.Label Zasady;
    }
}