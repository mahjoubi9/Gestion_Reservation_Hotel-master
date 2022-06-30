namespace Gestion_Hotel.UC
{
    partial class ucRoom
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
            this.components = new System.ComponentModel.Container();
            this.lblNum = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.réserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.Maroon;
            this.lblNum.Location = new System.Drawing.Point(39, 44);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(53, 27);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "124";
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réserverToolStripMenuItem,
            this.libérerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            // 
            // réserverToolStripMenuItem
            // 
            this.réserverToolStripMenuItem.Name = "réserverToolStripMenuItem";
            this.réserverToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.réserverToolStripMenuItem.Text = "Réserver";
            this.réserverToolStripMenuItem.Click += new System.EventHandler(this.réserverToolStripMenuItem_Click);
            // 
            // libérerToolStripMenuItem
            // 
            this.libérerToolStripMenuItem.Name = "libérerToolStripMenuItem";
            this.libérerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.libérerToolStripMenuItem.Text = "Libérer";
            this.libérerToolStripMenuItem.Click += new System.EventHandler(this.libérerToolStripMenuItem_Click);
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::Gestion_Hotel.Properties.Resources.mywin;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblNum);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(131, 114);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem réserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libérerToolStripMenuItem;
    }
}
