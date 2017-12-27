namespace Rejestracja_AdminApp
{
    partial class Dodawanie
    {
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dod_ID = new System.Windows.Forms.TextBox();
            this.Dod_imie = new System.Windows.Forms.TextBox();
            this.Dod_nazwisko = new System.Windows.Forms.TextBox();
            this.Dod_dzial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pracownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię pracownika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko pracownika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dział";
            // 
            // Dod_ID
            // 
            this.Dod_ID.Location = new System.Drawing.Point(194, 28);
            this.Dod_ID.Name = "Dod_ID";
            this.Dod_ID.Size = new System.Drawing.Size(157, 20);
            this.Dod_ID.TabIndex = 4;
            // 
            // Dod_imie
            // 
            this.Dod_imie.Location = new System.Drawing.Point(194, 65);
            this.Dod_imie.Name = "Dod_imie";
            this.Dod_imie.Size = new System.Drawing.Size(157, 20);
            this.Dod_imie.TabIndex = 5;
            // 
            // Dod_nazwisko
            // 
            this.Dod_nazwisko.Location = new System.Drawing.Point(194, 107);
            this.Dod_nazwisko.Name = "Dod_nazwisko";
            this.Dod_nazwisko.Size = new System.Drawing.Size(157, 20);
            this.Dod_nazwisko.TabIndex = 6;
            // 
            // Dod_dzial
            // 
            this.Dod_dzial.Location = new System.Drawing.Point(194, 155);
            this.Dod_dzial.Name = "Dod_dzial";
            this.Dod_dzial.Size = new System.Drawing.Size(157, 20);
            this.Dod_dzial.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(24, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dodawanie
            // 
            this.ClientSize = new System.Drawing.Size(389, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dod_dzial);
            this.Controls.Add(this.Dod_nazwisko);
            this.Controls.Add(this.Dod_imie);
            this.Controls.Add(this.Dod_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dodawanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dod_ID;
        private System.Windows.Forms.TextBox Dod_imie;
        private System.Windows.Forms.TextBox Dod_nazwisko;
        private System.Windows.Forms.TextBox Dod_dzial;
        private System.Windows.Forms.Button button1;
    }
}

