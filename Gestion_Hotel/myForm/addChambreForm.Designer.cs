namespace Gestion_Hotel.myForm
{
    partial class addChambreForm
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
            this.categoryChambrecomboBox = new System.Windows.Forms.ComboBox();
            this.ajouteChambrelbtn = new System.Windows.Forms.Button();
            this.categorylbl = new System.Windows.Forms.Label();
            this.numChambrebox = new System.Windows.Forms.TextBox();
            this.numChambrelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prixChambrebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // categoryChambrecomboBox
            // 
            this.categoryChambrecomboBox.FormattingEnabled = true;
            this.categoryChambrecomboBox.Items.AddRange(new object[] {
            "Deluxe",
            "Economique",
            "Classique",
            "Confort",
            "Quadruple Familiale",
            "Quintuple Familiale"});
            this.categoryChambrecomboBox.Location = new System.Drawing.Point(375, 194);
            this.categoryChambrecomboBox.Name = "categoryChambrecomboBox";
            this.categoryChambrecomboBox.Size = new System.Drawing.Size(200, 21);
            this.categoryChambrecomboBox.TabIndex = 26;
            this.categoryChambrecomboBox.Text = "Selection category";
            // 
            // ajouteChambrelbtn
            // 
            this.ajouteChambrelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ajouteChambrelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ajouteChambrelbtn.Location = new System.Drawing.Point(482, 258);
            this.ajouteChambrelbtn.Name = "ajouteChambrelbtn";
            this.ajouteChambrelbtn.Size = new System.Drawing.Size(93, 33);
            this.ajouteChambrelbtn.TabIndex = 25;
            this.ajouteChambrelbtn.Text = "Ajoute";
            this.ajouteChambrelbtn.UseVisualStyleBackColor = false;
            this.ajouteChambrelbtn.Click += new System.EventHandler(this.ajouteChambrelbtn_Click);
            // 
            // categorylbl
            // 
            this.categorylbl.AutoSize = true;
            this.categorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.categorylbl.Location = new System.Drawing.Point(177, 193);
            this.categorylbl.Name = "categorylbl";
            this.categorylbl.Size = new System.Drawing.Size(73, 18);
            this.categorylbl.TabIndex = 24;
            this.categorylbl.Text = "category";
            // 
            // numChambrebox
            // 
            this.numChambrebox.Location = new System.Drawing.Point(375, 153);
            this.numChambrebox.Name = "numChambrebox";
            this.numChambrebox.Size = new System.Drawing.Size(200, 20);
            this.numChambrebox.TabIndex = 23;
            // 
            // numChambrelbl
            // 
            this.numChambrelbl.AutoSize = true;
            this.numChambrelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.numChambrelbl.Location = new System.Drawing.Point(177, 155);
            this.numChambrelbl.Name = "numChambrelbl";
            this.numChambrelbl.Size = new System.Drawing.Size(108, 18);
            this.numChambrelbl.TabIndex = 22;
            this.numChambrelbl.Text = "numChambre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(89, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(723, 55);
            this.label4.TabIndex = 21;
            this.label4.Text = "Formule de Ajoute un Chambre";
            // 
            // prixChambrebox
            // 
            this.prixChambrebox.Location = new System.Drawing.Point(375, 232);
            this.prixChambrebox.Name = "prixChambrebox";
            this.prixChambrebox.Size = new System.Drawing.Size(200, 20);
            this.prixChambrebox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(177, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "prixChambre";
            // 
            // addChambreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prixChambrebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryChambrecomboBox);
            this.Controls.Add(this.ajouteChambrelbtn);
            this.Controls.Add(this.categorylbl);
            this.Controls.Add(this.numChambrebox);
            this.Controls.Add(this.numChambrelbl);
            this.Controls.Add(this.label4);
            this.Name = "addChambreForm";
            this.Text = "addChambreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryChambrecomboBox;
        private System.Windows.Forms.Button ajouteChambrelbtn;
        private System.Windows.Forms.Label categorylbl;
        private System.Windows.Forms.TextBox numChambrebox;
        private System.Windows.Forms.Label numChambrelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prixChambrebox;
        private System.Windows.Forms.Label label1;
    }
}