namespace Gestion_Hotel.myForm
{
    partial class addHotelsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.nomHotelslbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ajouteHotelbtn = new System.Windows.Forms.Button();
            this.lblPrenomCli = new System.Windows.Forms.Label();
            this.categorieHotelcomboBox = new System.Windows.Forms.ComboBox();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.adresslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(73, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(626, 55);
            this.label4.TabIndex = 12;
            this.label4.Text = "Formule de Ajoute un hotel";
            // 
            // nomHotelslbl
            // 
            this.nomHotelslbl.Location = new System.Drawing.Point(361, 149);
            this.nomHotelslbl.Name = "nomHotelslbl";
            this.nomHotelslbl.Size = new System.Drawing.Size(200, 20);
            this.nomHotelslbl.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom de l\'hotel";
            // 
            // ajouteHotelbtn
            // 
            this.ajouteHotelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ajouteHotelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ajouteHotelbtn.Location = new System.Drawing.Point(468, 282);
            this.ajouteHotelbtn.Name = "ajouteHotelbtn";
            this.ajouteHotelbtn.Size = new System.Drawing.Size(93, 33);
            this.ajouteHotelbtn.TabIndex = 19;
            this.ajouteHotelbtn.Text = "Ajoute";
            this.ajouteHotelbtn.UseVisualStyleBackColor = false;
            this.ajouteHotelbtn.Click += new System.EventHandler(this.ajouteHotelbtn_Click);
            // 
            // lblPrenomCli
            // 
            this.lblPrenomCli.AutoSize = true;
            this.lblPrenomCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPrenomCli.Location = new System.Drawing.Point(163, 188);
            this.lblPrenomCli.Name = "lblPrenomCli";
            this.lblPrenomCli.Size = new System.Drawing.Size(81, 18);
            this.lblPrenomCli.TabIndex = 15;
            this.lblPrenomCli.Text = "Categorie";
            // 
            // categorieHotelcomboBox
            // 
            this.categorieHotelcomboBox.FormattingEnabled = true;
            this.categorieHotelcomboBox.Items.AddRange(new object[] {
            "1 étoile",
            "2 étoile",
            "3 étoile",
            "4 étoile",
            "5 étoile"});
            this.categorieHotelcomboBox.Location = new System.Drawing.Point(361, 189);
            this.categorieHotelcomboBox.Name = "categorieHotelcomboBox";
            this.categorieHotelcomboBox.Size = new System.Drawing.Size(200, 21);
            this.categorieHotelcomboBox.TabIndex = 20;
            this.categorieHotelcomboBox.Text = "Selection adr d\'hotel";
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(361, 235);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(200, 20);
            this.adressBox.TabIndex = 21;
            // 
            // adresslbl
            // 
            this.adresslbl.AutoSize = true;
            this.adresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.adresslbl.Location = new System.Drawing.Point(163, 237);
            this.adresslbl.Name = "adresslbl";
            this.adresslbl.Size = new System.Drawing.Size(60, 18);
            this.adresslbl.TabIndex = 22;
            this.adresslbl.Text = "Adress";
            // 
            // addHotelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adresslbl);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.categorieHotelcomboBox);
            this.Controls.Add(this.ajouteHotelbtn);
            this.Controls.Add(this.lblPrenomCli);
            this.Controls.Add(this.nomHotelslbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "addHotelsForm";
            this.Text = "addHotelsForm";
            this.Load += new System.EventHandler(this.addHotelsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomHotelslbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajouteHotelbtn;
        private System.Windows.Forms.Label lblPrenomCli;
        private System.Windows.Forms.ComboBox categorieHotelcomboBox;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.Label adresslbl;
    }
}