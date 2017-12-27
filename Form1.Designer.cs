namespace Rejestracja_AdminApp
{
    partial class Form1
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
            this.logowanieBtn = new System.Windows.Forms.Button();
            this.Nazwa_uzytkownika = new System.Windows.Forms.TextBox();
            this.Haslo_uzytkownika = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DodajPopUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logowanieBtn
            // 
            this.logowanieBtn.Location = new System.Drawing.Point(33, 104);
            this.logowanieBtn.Name = "logowanieBtn";
            this.logowanieBtn.Size = new System.Drawing.Size(268, 92);
            this.logowanieBtn.TabIndex = 0;
            this.logowanieBtn.Text = "Zaloguj";
            this.logowanieBtn.UseVisualStyleBackColor = true;
            this.logowanieBtn.Click += new System.EventHandler(this.logowanieBtn_Click);
            // 
            // Nazwa_uzytkownika
            // 
            this.Nazwa_uzytkownika.BackColor = System.Drawing.SystemColors.Window;
            this.Nazwa_uzytkownika.Location = new System.Drawing.Point(127, 42);
            this.Nazwa_uzytkownika.Name = "Nazwa_uzytkownika";
            this.Nazwa_uzytkownika.Size = new System.Drawing.Size(188, 20);
            this.Nazwa_uzytkownika.TabIndex = 3;
            // 
            // Haslo_uzytkownika
            // 
            this.Haslo_uzytkownika.Location = new System.Drawing.Point(127, 68);
            this.Haslo_uzytkownika.Name = "Haslo_uzytkownika";
            this.Haslo_uzytkownika.Size = new System.Drawing.Size(188, 20);
            this.Haslo_uzytkownika.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nazwa użytkownika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasło użytkownika";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1179, 306);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(504, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wyszukaj pracownika";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(74, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Logowanie";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(910, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dodaj pracownika";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DodajPopUp
            // 
            this.DodajPopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajPopUp.Location = new System.Drawing.Point(896, 41);
            this.DodajPopUp.Name = "DodajPopUp";
            this.DodajPopUp.Size = new System.Drawing.Size(161, 47);
            this.DodajPopUp.TabIndex = 13;
            this.DodajPopUp.Text = "Dodaj";
            this.DodajPopUp.UseVisualStyleBackColor = true;
            this.DodajPopUp.Click += new System.EventHandler(this.DodajPopUp_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1208, 615);
            this.Controls.Add(this.DodajPopUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Haslo_uzytkownika);
            this.Controls.Add(this.Nazwa_uzytkownika);
            this.Controls.Add(this.logowanieBtn);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button logowanieBtn;
        private System.Windows.Forms.TextBox Nazwa_uzytkownika;
        private System.Windows.Forms.MaskedTextBox Haslo_uzytkownika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DodajPopUp;
    }
}

