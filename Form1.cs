using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Rejestracja_AdminApp
{
    public partial class Form1 : Form
    {
        public static String login;
        public static String haslo;

        public Form1()
        {
            InitializeComponent();
        }

        private void logowanieBtn_Click(object sender, EventArgs e)
        {
            pobierzDane();
            login = Nazwa_uzytkownika.Text;
            haslo = Haslo_uzytkownika.Text;
        }
        public void pobierzDane()
        {

            //pobranie danych do logowania z formularza
            string mojePolaczenie = //"server=localhost;user id=admin;pwd=1qazxsw2;database=pracownicy;persistsecurityinfo=True;";
               "SERVER=localhost;" +
               "DATABASE=Pracownicy;" +
               "UID=" + Nazwa_uzytkownika.Text + ";" +
               "PASSWORD=" + Haslo_uzytkownika.Text + ";";
            
            // server = localhost; user id = root; database = pracownicy


            string sql = "SELECT * FROM pracownicy";

            MySqlConnection polaczenie = new MySqlConnection(mojePolaczenie);
            try
            {
                //Otwarcie polaczenia z baza danych
                polaczenie.Open();
                MessageBox.Show("Połączono");
                //wykonaj polecenie jezyka SQL na danym polaczeniu
                using (MySqlCommand cmdSel = new MySqlCommand(sql, polaczenie))
                {
                    DataTable dt = new DataTable();
                    //pobierz dan i zapisz w strukturze DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    //wypisz dane do pola 
                    dataGridView1.DataSource = dt.DefaultView;
                }
            }
            //Jezeli wystapi wyjatek wyrzuc go i pokaz info
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Blad logowania do bazy danych", "Blad");
            }
            //Zamknij polaczenie po wyswietleniu danych
            polaczenie.Clone();
        }

        private void DodajPopUp_Click(object sender, EventArgs e)
        {
            Rejestracja_AdminApp.Dodawanie d1 = new Rejestracja_AdminApp.Dodawanie();
            d1.Show();
        }
    }
}
