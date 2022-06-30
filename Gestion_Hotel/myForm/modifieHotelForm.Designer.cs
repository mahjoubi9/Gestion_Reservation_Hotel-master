namespace Gestion_Hotel.myForm
{
    partial class modifieHotelForm
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
            this.nomHotelsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adresslbl = new System.Windows.Forms.Label();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.categorieHotelcomboBox = new System.Windows.Forms.ComboBox();
            this.modifieHotelbtn = new System.Windows.Forms.Button();
            this.lblPrenomCli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nomHotelsBox
            // 
            this.nomHotelsBox.Location = new System.Drawing.Point(365, 171);
            this.nomHotelsBox.Name = "nomHotelsBox";
            this.nomHotelsBox.Size = new System.Drawing.Size(200, 20);
            this.nomHotelsBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(167, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom de l\'hotel";
            // 
            // adresslbl
            // 
            this.adresslbl.AutoSize = true;
            this.adresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.adresslbl.Location = new System.Drawing.Point(167, 269);
            this.adresslbl.Name = "adresslbl";
            this.adresslbl.Size = new System.Drawing.Size(60, 18);
            this.adresslbl.TabIndex = 27;
            this.adresslbl.Text = "Adress";
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(365, 267);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(200, 20);
            this.adressBox.TabIndex = 26;
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
            this.categorieHotelcomboBox.Location = new System.Drawing.Point(365, 221);
            this.categorieHotelcomboBox.Name = "categorieHotelcomboBox";
            this.categorieHotelcomboBox.Size = new System.Drawing.Size(200, 21);
            this.categorieHotelcomboBox.TabIndex = 25;
            this.categorieHotelcomboBox.Text = "Selection adr d\'hotel";
            // 
            // modifieHotelbtn
            // 
            this.modifieHotelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.modifieHotelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifieHotelbtn.Location = new System.Drawing.Point(472, 336);
            this.modifieHotelbtn.Name = "modifieHotelbtn";
            this.modifieHotelbtn.Size = new System.Drawing.Size(93, 33);
            this.modifieHotelbtn.TabIndex = 24;
            this.modifieHotelbtn.Text = "Modifie";
            this.modifieHotelbtn.UseVisualStyleBackColor = false;
            this.modifieHotelbtn.Click += new System.EventHandler(this.ajouteHotelbtn_Click);
            // 
            // lblPrenomCli
            // 
            this.lblPrenomCli.AutoSize = true;
            this.lblPrenomCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPrenomCli.Location = new System.Drawing.Point(167, 220);
            this.lblPrenomCli.Name = "lblPrenomCli";
            this.lblPrenomCli.Size = new System.Drawing.Size(81, 18);
            this.lblPrenomCli.TabIndex = 23;
            this.lblPrenomCli.Text = "Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(66, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(645, 55);
            this.label4.TabIndex = 28;
            this.label4.Text = "Formule de Modifie un hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(167, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tel";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(365, 304);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(200, 20);
            this.telBox.TabIndex = 30;
            // 
            // modifieHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adresslbl);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.categorieHotelcomboBox);
            this.Controls.Add(this.modifieHotelbtn);
            this.Controls.Add(this.lblPrenomCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomHotelsBox);
            this.Name = "modifieHotelForm";
            this.Text = "modifieHotelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomHotelsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adresslbl;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.ComboBox categorieHotelcomboBox;
        private System.Windows.Forms.Button modifieHotelbtn;
        private System.Windows.Forms.Label lblPrenomCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telBox;
    }
}