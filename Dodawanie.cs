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
    public partial class Dodawanie : Form
    {
        public Dodawanie()
        {
            InitializeComponent();
        }

        public void Dodaj()
        {
            string mojePolaczenie = //"server=localhost;user id=admin;pwd=1qazxsw2;database=pracownicy;persistsecurityinfo=True;";
                           "SERVER=localhost;" +
                           "DATABASE=Pracownicy;" +
                           "UID=" + Rejestracja_AdminApp.Form1.login + ";" +
                           "PASSWORD=" + Rejestracja_AdminApp.Form1.haslo + ";";




            string sql2 = "INSERT into pracownicy (ID,Imie,Nazwisko,Dzial) VALUES (''" + ",'" + Dod_imie.Text + "','" + Dod_nazwisko.Text + "','" + Dod_dzial.Text +"')";

            MySqlConnection polaczenie = new MySqlConnection(mojePolaczenie);
            try
            {
                //Otwarcie polaczenia z baza danych
                polaczenie.Open();

                //wykonaj polecenie jezyka SQL na danym polaczeniu
                using (MySqlCommand cmdSel = new MySqlCommand(sql2, polaczenie))
                {
                    DataTable dt = new DataTable();
                    //pobierz dan i zapisz w strukturze DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    //wypisz dane do pola 
                    //dataGridView1.DataSource = dt.DefaultView;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dodaj();
        }
    }
    
}
