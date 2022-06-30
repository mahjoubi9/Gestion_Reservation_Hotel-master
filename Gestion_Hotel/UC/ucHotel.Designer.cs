namespace Gestion_Hotel.UC
{
    partial class ucHotel
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNomHotel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel.Location = new System.Drawing.Point(240, 99);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(448, 342);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // lblNomHotel
            // 
            this.lblNomHotel.AutoSize = true;
            this.lblNomHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomHotel.ForeColor = System.Drawing.Color.Moccasin;
            this.lblNomHotel.Location = new System.Drawing.Point(328, 28);
            this.lblNomHotel.Name = "lblNomHotel";
            this.lblNomHotel.Size = new System.Drawing.Size(0, 55);
            this.lblNomHotel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Hotel.Properties.Resources.Capture_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(10, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNomHotel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "ucHotel";
            this.Size = new System.Drawing.Size(705, 493);
            this.Load += new System.EventHandler(this.ucHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblNomHotel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
