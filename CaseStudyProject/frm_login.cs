using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseStudyProject
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //var for user and password
            string user = "admin";
            string pass = "admin";

            //check for validation
            if (txt_user.Text == user && txt_pass.Text== pass)
            {
                new Form1().Show();
                this.Hide();
            }
            else if (txt_user.Text == "" && txt_pass.Text == "")
            {
                MessageBox.Show("U moet de lege velden invullen.");
            }
            else
            {
                MessageBox.Show("Foute gebruikersnaam of wachtwoord.");
            }
        }
    }
}
