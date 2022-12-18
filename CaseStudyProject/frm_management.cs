using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CaseStudyProject
{
    public partial class Form1 : Form
    {
        void fill_cmbbox_genre()
        {
            //connectie met database

            SQLiteConnection conDB = new SQLiteConnection("Data Source=D:\\School_dingen\\Devops\\CaseStudyProjectFolder\\CaseStudyProject\\bin\\db_boek.db");
            //relative path werkt niet?? absoluut path wel

            //command 
            string qrycmd1 = "SELECT b.titel,b.auteur, g.genre " + //select from these 3 records
                "FROM Boek b join Genre g on b.genreId = g.genreId ";


            SQLiteCommand cmdDB = new SQLiteCommand(qrycmd1, conDB);
            //reader
            SQLiteDataReader sqlreader;

            conDB.Open();
            sqlreader = cmdDB.ExecuteReader();

            while (sqlreader.Read())
            {
                //variablen 

                //niet van toepassing hier
                //string bAuteur = sqlreader.GetString("auteur");
                string gGenre = sqlreader.GetString("genre");

                //variabelen koppelen aan form
                cmbox_genre.Items.Add(gGenre); //lijst vullen eenmaal opstart


            }
        }

            void fill_lstbox_boeken()
            {
            //connectie met database

            SQLiteConnection conDB = new SQLiteConnection("Data Source=D:\\School_dingen\\Devops\\CaseStudyProjectFolder\\CaseStudyProject\\bin\\db_boek.db");
            //relative path werkt niet?? absoluut path wel

            //command 
            string qrycmd1 = "SELECT b.titel,b.auteur, g.genre " + //select from these 3 records
                "FROM Boek b join Genre g on b.genreId = g.genreId ";


            SQLiteCommand cmdDB = new SQLiteCommand(qrycmd1, conDB);
            //reader
            SQLiteDataReader sqlreader;

            conDB.Open();
            sqlreader = cmdDB.ExecuteReader();

            while (sqlreader.Read())
                {
                //variablen (
                string bTitel = sqlreader.GetString("titel");

                //niet van toepassing hier
                //string bAuteur = sqlreader.GetString("auteur");
                //string gGenre = sqlreader.GetString("genre");

                //variabelen koppelen aan form
                lstbox_boeken.Items.Add(bTitel); //lijst vullen eenmaal opstart


                }



            }
        public Form1()
        {
            InitializeComponent();
            fill_lstbox_boeken();
            fill_cmbbox_genre();
        }


        private void btn_verwijderen1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            //log out by going back to other form
            new frm_login().Show();
            this.Hide();
        }

        private void lstbox_boeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            //connectie met database

            SQLiteConnection conDB = new SQLiteConnection("Data Source=D:\\School_dingen\\Devops\\CaseStudyProjectFolder\\CaseStudyProject\\bin\\db_boek.db");
            //relative path werkt niet?? absoluut path wel

            //command 
            string qrycmd1 = "SELECT b.titel,b.auteur, g.genre " + //select from these 3 records
                "FROM Boek b join Genre g on b.genreId = g.genreId " +
                "WHERE b.titel='"
                + lstbox_boeken.Text + "' ;";

            SQLiteCommand cmdDB = new SQLiteCommand(qrycmd1, conDB);
            //reader
            SQLiteDataReader sqlreader;
            //try voor het voorkomen dat er een error komt als je tussen records switched
            try
            {
                conDB.Open();
                sqlreader = cmdDB.ExecuteReader();
                while (sqlreader.Read())
                {
                    //variablen (
                    string bTitel = sqlreader.GetString("titel");
                    string bAuteur = sqlreader.GetString("auteur");
                    string gGenre = sqlreader.GetString("genre");

                    //variabelen koppelen aan form
                    txt_titel.Text = bTitel;
                    txt_auteur.Text = bAuteur;
                    cmbox_genre.Text = gGenre;

                }
            }
            catch (Exception ex) // check voor error
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkbox_aanpassen_CheckedChanged(object sender, EventArgs e) //checkbox for toggling edit mode
        {
            if ((chkbox_aanpassen.Checked))
            {
                //edit mode
                txt_titel.ReadOnly = false;
                txt_auteur.ReadOnly = false;
                cmbox_genre.Enabled = true;
                btn_verwijder.Visible = true;
                btn_toevoegen.Visible = true;
                chkbox_aanpassen.Checked = true;
            }
            else
            {
                //read only mode
                txt_titel.ReadOnly = true;
                txt_auteur.ReadOnly = true;
                cmbox_genre.Enabled = false;
                btn_verwijder.Visible = false;
                btn_toevoegen.Visible = false;
                chkbox_aanpassen.Checked = false;
            }
        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
            //connectie met database

            SQLiteConnection conDB = new SQLiteConnection("Data Source=D:\\School_dingen\\Devops\\CaseStudyProjectFolder\\CaseStudyProject\\bin\\db_boek.db");


            //counting primary key
            string nwRcrdCount = lstbox_boeken.Items.Count.ToString() + 1; //following count
            int nwRcrdCountint = Int32.Parse(nwRcrdCount); // convert to int to avoid error(?)
            //command 
            string qrycmd1 = "INSERT into Boek values(" +
                "'"+ nwRcrdCountint +"','"+ txt_titel.Text + "','" + txt_auteur.Text + "','" + cmbox_genre.Text + "');";

            //uitvoeren
            SQLiteCommand cmdDB = new SQLiteCommand(qrycmd1, conDB);
            SQLiteDataReader sqlreader;
            try
            {

                conDB.Open();
                sqlreader = cmdDB.ExecuteReader();
                //verificatie
                MessageBox.Show("Boek is succesvol toegevoegd!");

                conDB.Close();
            }
            catch (Exception ex) //check voor error
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
