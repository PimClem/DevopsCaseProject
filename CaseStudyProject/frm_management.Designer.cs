
namespace CaseStudyProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_logOut = new System.Windows.Forms.Button();
            this.lstbox_boeken = new System.Windows.Forms.ListBox();
            this.lbl_boeklijst = new System.Windows.Forms.Label();
            this.lbl_titel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_titel = new System.Windows.Forms.TextBox();
            this.txt_auteur = new System.Windows.Forms.TextBox();
            this.lbl_auteur = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.picbox_cover = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkbx_uitgeleend = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_datumlener = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lenernaam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_verwijder = new System.Windows.Forms.Button();
            this.btn_toevoegen = new System.Windows.Forms.Button();
            this.cmbox_genre = new System.Windows.Forms.ComboBox();
            this.chkbox_aanpassen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logOut
            // 
            this.btn_logOut.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logOut.Location = new System.Drawing.Point(660, 12);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_logOut.Size = new System.Drawing.Size(128, 29);
            this.btn_logOut.TabIndex = 2;
            this.btn_logOut.Text = "Uitloggen";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // lstbox_boeken
            // 
            this.lstbox_boeken.FormattingEnabled = true;
            this.lstbox_boeken.ItemHeight = 20;
            this.lstbox_boeken.Location = new System.Drawing.Point(12, 38);
            this.lstbox_boeken.Name = "lstbox_boeken";
            this.lstbox_boeken.Size = new System.Drawing.Size(241, 244);
            this.lstbox_boeken.TabIndex = 3;
            this.lstbox_boeken.SelectedIndexChanged += new System.EventHandler(this.lstbox_boeken_SelectedIndexChanged);
            // 
            // lbl_boeklijst
            // 
            this.lbl_boeklijst.AutoSize = true;
            this.lbl_boeklijst.Location = new System.Drawing.Point(12, 12);
            this.lbl_boeklijst.Name = "lbl_boeklijst";
            this.lbl_boeklijst.Size = new System.Drawing.Size(58, 20);
            this.lbl_boeklijst.TabIndex = 4;
            this.lbl_boeklijst.Text = "Boeken";
            // 
            // lbl_titel
            // 
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Location = new System.Drawing.Point(259, 38);
            this.lbl_titel.Name = "lbl_titel";
            this.lbl_titel.Size = new System.Drawing.Size(38, 20);
            this.lbl_titel.TabIndex = 5;
            this.lbl_titel.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // txt_titel
            // 
            this.txt_titel.Location = new System.Drawing.Point(318, 35);
            this.txt_titel.Name = "txt_titel";
            this.txt_titel.ReadOnly = true;
            this.txt_titel.Size = new System.Drawing.Size(287, 27);
            this.txt_titel.TabIndex = 9;
            // 
            // txt_auteur
            // 
            this.txt_auteur.Location = new System.Drawing.Point(318, 68);
            this.txt_auteur.Name = "txt_auteur";
            this.txt_auteur.ReadOnly = true;
            this.txt_auteur.Size = new System.Drawing.Size(287, 27);
            this.txt_auteur.TabIndex = 11;
            // 
            // lbl_auteur
            // 
            this.lbl_auteur.AutoSize = true;
            this.lbl_auteur.Location = new System.Drawing.Point(259, 71);
            this.lbl_auteur.Name = "lbl_auteur";
            this.lbl_auteur.Size = new System.Drawing.Size(53, 20);
            this.lbl_auteur.TabIndex = 10;
            this.lbl_auteur.Text = "Auteur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 14;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Location = new System.Drawing.Point(259, 104);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(48, 20);
            this.lbl_genre.TabIndex = 12;
            this.lbl_genre.Text = "Genre";
            // 
            // picbox_cover
            // 
            this.picbox_cover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbox_cover.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cover.Image")));
            this.picbox_cover.Location = new System.Drawing.Point(558, 199);
            this.picbox_cover.Name = "picbox_cover";
            this.picbox_cover.Size = new System.Drawing.Size(230, 239);
            this.picbox_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_cover.TabIndex = 15;
            this.picbox_cover.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Informatie | Boek";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 17;
            // 
            // chkbx_uitgeleend
            // 
            this.chkbx_uitgeleend.AutoSize = true;
            this.chkbx_uitgeleend.Location = new System.Drawing.Point(392, 187);
            this.chkbx_uitgeleend.Name = "chkbx_uitgeleend";
            this.chkbx_uitgeleend.Size = new System.Drawing.Size(104, 24);
            this.chkbx_uitgeleend.TabIndex = 18;
            this.chkbx_uitgeleend.Text = "Uitgeleend";
            this.chkbx_uitgeleend.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkbx_uitgeleend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Informatie | Lening";
            // 
            // txt_datumlener
            // 
            this.txt_datumlener.Location = new System.Drawing.Point(366, 250);
            this.txt_datumlener.Name = "txt_datumlener";
            this.txt_datumlener.Size = new System.Drawing.Size(177, 27);
            this.txt_datumlener.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Datum lening";
            // 
            // txt_lenernaam
            // 
            this.txt_lenernaam.Location = new System.Drawing.Point(366, 217);
            this.txt_lenernaam.Name = "txt_lenernaam";
            this.txt_lenernaam.Size = new System.Drawing.Size(177, 27);
            this.txt_lenernaam.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Naam lener";
            // 
            // btn_verwijder
            // 
            this.btn_verwijder.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verwijder.Location = new System.Drawing.Point(660, 97);
            this.btn_verwijder.Name = "btn_verwijder";
            this.btn_verwijder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_verwijder.Size = new System.Drawing.Size(128, 29);
            this.btn_verwijder.TabIndex = 25;
            this.btn_verwijder.Text = "Verwijderen";
            this.btn_verwijder.UseVisualStyleBackColor = true;
            this.btn_verwijder.Visible = false;
            // 
            // btn_toevoegen
            // 
            this.btn_toevoegen.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_toevoegen.Location = new System.Drawing.Point(660, 132);
            this.btn_toevoegen.Name = "btn_toevoegen";
            this.btn_toevoegen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_toevoegen.Size = new System.Drawing.Size(128, 29);
            this.btn_toevoegen.TabIndex = 26;
            this.btn_toevoegen.Text = "Toevoegen";
            this.btn_toevoegen.UseVisualStyleBackColor = true;
            this.btn_toevoegen.Visible = false;
            this.btn_toevoegen.Click += new System.EventHandler(this.btn_toevoegen_Click);
            // 
            // cmbox_genre
            // 
            this.cmbox_genre.Enabled = false;
            this.cmbox_genre.FormattingEnabled = true;
            this.cmbox_genre.Location = new System.Drawing.Point(318, 100);
            this.cmbox_genre.Name = "cmbox_genre";
            this.cmbox_genre.Size = new System.Drawing.Size(287, 28);
            this.cmbox_genre.TabIndex = 27;
            // 
            // chkbox_aanpassen
            // 
            this.chkbox_aanpassen.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbox_aanpassen.AutoSize = true;
            this.chkbox_aanpassen.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkbox_aanpassen.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbox_aanpassen.Location = new System.Drawing.Point(658, 61);
            this.chkbox_aanpassen.Name = "chkbox_aanpassen";
            this.chkbox_aanpassen.Size = new System.Drawing.Size(130, 30);
            this.chkbox_aanpassen.TabIndex = 28;
            this.chkbox_aanpassen.Text = "  Aanpassen ";
            this.chkbox_aanpassen.UseVisualStyleBackColor = true;
            this.chkbox_aanpassen.CheckedChanged += new System.EventHandler(this.chkbox_aanpassen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkbox_aanpassen);
            this.Controls.Add(this.cmbox_genre);
            this.Controls.Add(this.btn_toevoegen);
            this.Controls.Add(this.btn_verwijder);
            this.Controls.Add(this.txt_datumlener);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_lenernaam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkbx_uitgeleend);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picbox_cover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_genre);
            this.Controls.Add(this.txt_auteur);
            this.Controls.Add(this.lbl_auteur);
            this.Controls.Add(this.txt_titel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_titel);
            this.Controls.Add(this.lbl_boeklijst);
            this.Controls.Add(this.lstbox_boeken);
            this.Controls.Add(this.btn_logOut);
            this.Name = "Form1";
            this.Text = "Bibliotheek Manager";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.ListBox lstbox_boeken;
        private System.Windows.Forms.Label lbl_boeklijst;
        private System.Windows.Forms.Label lbl_titel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_auteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkbx_uitgeleen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_titel;
        private System.Windows.Forms.TextBox txt_auteur;
        private System.Windows.Forms.PictureBox picbox_cover;
        private System.Windows.Forms.CheckBox chkbx_uitgeleend;
        private System.Windows.Forms.TextBox txt_datumlener;
        private System.Windows.Forms.TextBox txt_lenernaam;
        private System.Windows.Forms.Button btn_verwijder;
        private System.Windows.Forms.Button btn_toevoegen;
        private System.Windows.Forms.ComboBox cmbox_genre;
        private System.Windows.Forms.CheckBox chkbox_aanpassen;
    }
}

