
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
            this.btn_aanpassen = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_aanpassen
            // 
            this.btn_aanpassen.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aanpassen.Location = new System.Drawing.Point(660, 77);
            this.btn_aanpassen.Name = "btn_aanpassen";
            this.btn_aanpassen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_aanpassen.Size = new System.Drawing.Size(128, 29);
            this.btn_aanpassen.TabIndex = 0;
            this.btn_aanpassen.Text = "Aanpassen";
            this.btn_aanpassen.UseVisualStyleBackColor = true;
            this.btn_aanpassen.Click += new System.EventHandler(this.btn_toevoegen1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_aanpassen);
            this.Name = "Form1";
            this.Text = "Bibliotheek Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aanpassen;
        private System.Windows.Forms.Button btn_logOut;
    }
}

