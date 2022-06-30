namespace Gestion_Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNomHotel = new System.Windows.Forms.Label();
            this.ajouteChambrelbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adresslbl = new System.Windows.Forms.Label();
            this.tellbl = new System.Windows.Forms.Label();
            this.categorielbl = new System.Windows.Forms.Label();
            this.modifiebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel.Location = new System.Drawing.Point(258, 63);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(448, 342);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // lblNomHotel
            // 
            this.lblNomHotel.AutoSize = true;
            this.lblNomHotel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomHotel.ForeColor = System.Drawing.Color.Yellow;
            this.lblNomHotel.Location = new System.Drawing.Point(462, 19);
            this.lblNomHotel.Name = "lblNomHotel";
            this.lblNomHotel.Size = new System.Drawing.Size(64, 30);
            this.lblNomHotel.TabIndex = 3;
            this.lblNomHotel.Text = "hotel";
            // 
            // ajouteChambrelbtn
            // 
            this.ajouteChambrelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ajouteChambrelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ajouteChambrelbtn.Location = new System.Drawing.Point(613, 24);
            this.ajouteChambrelbtn.Name = "ajouteChambrelbtn";
            this.ajouteChambrelbtn.Size = new System.Drawing.Size(93, 33);
            this.ajouteChambrelbtn.TabIndex = 26;
            this.ajouteChambrelbtn.Text = "Ajoute";
            this.ajouteChambrelbtn.UseVisualStyleBackColor = false;
            this.ajouteChambrelbtn.Click += new System.EventHandler(this.ajouteChambrelbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Hotel.Properties.Resources.Capture_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(28, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // adresslbl
            // 
            this.adresslbl.AutoSize = true;
            this.adresslbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresslbl.ForeColor = System.Drawing.Color.Yellow;
            this.adresslbl.Location = new System.Drawing.Point(108, 20);
            this.adresslbl.Name = "adresslbl";
            this.adresslbl.Size = new System.Drawing.Size(74, 30);
            this.adresslbl.TabIndex = 28;
            this.adresslbl.Text = "adress";
            // 
            // tellbl
            // 
            this.tellbl.AutoSize = true;
            this.tellbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellbl.ForeColor = System.Drawing.Color.Yellow;
            this.tellbl.Location = new System.Drawing.Point(108, 63);
            this.tellbl.Name = "tellbl";
            this.tellbl.Size = new System.Drawing.Size(40, 30);
            this.tellbl.TabIndex = 29;
            this.tellbl.Text = "Tel";
            // 
            // categorielbl
            // 
            this.categorielbl.AutoSize = true;
            this.categorielbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorielbl.ForeColor = System.Drawing.Color.Yellow;
            this.categorielbl.Location = new System.Drawing.Point(145, 93);
            this.categorielbl.Name = "categorielbl";
            this.categorielbl.Size = new System.Drawing.Size(107, 30);
            this.categorielbl.TabIndex = 30;
            this.categorielbl.Text = "Categorie";
            // 
            // modifiebtn
            // 
            this.modifiebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.modifiebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifiebtn.Location = new System.Drawing.Point(258, 22);
            this.modifiebtn.Name = "modifiebtn";
            this.modifiebtn.Size = new System.Drawing.Size(93, 33);
            this.modifiebtn.TabIndex = 31;
            this.modifiebtn.Text = "Modifie";
            this.modifiebtn.UseVisualStyleBackColor = false;
            this.modifiebtn.Click += new System.EventHandler(this.modifiebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "adress : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tel : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "Categorie : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(734, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifiebtn);
            this.Controls.Add(this.categorielbl);
            this.Controls.Add(this.tellbl);
            this.Controls.Add(this.adresslbl);
            this.Controls.Add(this.ajouteChambrelbtn);
            this.Controls.Add(this.lblNomHotel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "Form1";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblNomHotel;
        private System.Windows.Forms.Button ajouteChambrelbtn;
        private System.Windows.Forms.Label adresslbl;
        private System.Windows.Forms.Label tellbl;
        private System.Windows.Forms.Label categorielbl;
        private System.Windows.Forms.Button modifiebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

