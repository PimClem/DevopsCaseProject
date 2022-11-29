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
            if (txt_user.Text == "admin" && txt_pass.Text== "test123")
            {
                new Form1().Show();
                this.Hide();
            }
            if (txt_user.Text == "" && txt_pass.Text == "")
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
