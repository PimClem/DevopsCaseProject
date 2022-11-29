
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
            this.btn_toevoegen1 = new System.Windows.Forms.Button();
            this.btn_verwijderen1 = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_toevoegen1
            // 
            this.btn_toevoegen1.Location = new System.Drawing.Point(660, 77);
            this.btn_toevoegen1.Name = "btn_toevoegen1";
            this.btn_toevoegen1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_toevoegen1.Size = new System.Drawing.Size(103, 29);
            this.btn_toevoegen1.TabIndex = 0;
            this.btn_toevoegen1.Text = "Toevoegen";
            this.btn_toevoegen1.UseVisualStyleBackColor = true;
            this.btn_toevoegen1.Click += new System.EventHandler(this.btn_toevoegen1_Click);
            // 
            // btn_verwijderen1
            // 
            this.btn_verwijderen1.Location = new System.Drawing.Point(660, 112);
            this.btn_verwijderen1.Name = "btn_verwijderen1";
            this.btn_verwijderen1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_verwijderen1.Size = new System.Drawing.Size(103, 29);
            this.btn_verwijderen1.TabIndex = 1;
            this.btn_verwijderen1.Text = "Verwijderen";
            this.btn_verwijderen1.UseVisualStyleBackColor = true;
            this.btn_verwijderen1.Click += new System.EventHandler(this.btn_verwijderen1_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(685, 12);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_logOut.Size = new System.Drawing.Size(103, 29);
            this.btn_logOut.TabIndex = 2;
            this.btn_logOut.Text = "Uitloggen";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_verwijderen1);
            this.Controls.Add(this.btn_toevoegen1);
            this.Name = "Form1";
            this.Text = "Bibliotheek Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_toevoegen1;
        private System.Windows.Forms.Button btn_verwijderen1;
        private System.Windows.Forms.Button btn_logOut;
    }
}

