namespace Gestion_Hotel
{
    partial class hotelscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hotelscs));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblhotelss = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consommationbtn = new System.Windows.Forms.Button();
            this.addHotelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Yellow;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(424, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(370, 327);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblhotelss
            // 
            this.lblhotelss.AutoSize = true;
            this.lblhotelss.BackColor = System.Drawing.Color.Yellow;
            this.lblhotelss.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotelss.Location = new System.Drawing.Point(578, 36);
            this.lblhotelss.Name = "lblhotelss";
            this.lblhotelss.Size = new System.Drawing.Size(90, 30);
            this.lblhotelss.TabIndex = 1;
            this.lblhotelss.Text = "HOTELS";
            this.lblhotelss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblhotelss.Click += new System.EventHandler(this.lblhotelss_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-36, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 373);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.consommationbtn);
            this.panel1.Controls.Add(this.addHotelbtn);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lblhotelss);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // consommationbtn
            // 
            this.consommationbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.consommationbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consommationbtn.Location = new System.Drawing.Point(424, 77);
            this.consommationbtn.Name = "consommationbtn";
            this.consommationbtn.Size = new System.Drawing.Size(137, 29);
            this.consommationbtn.TabIndex = 6;
            this.consommationbtn.Text = "Consommation";
            this.consommationbtn.UseVisualStyleBackColor = false;
            this.consommationbtn.Click += new System.EventHandler(this.consommationbtn_Click);
            // 
            // addHotelbtn
            // 
            this.addHotelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addHotelbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHotelbtn.Location = new System.Drawing.Point(685, 77);
            this.addHotelbtn.Name = "addHotelbtn";
            this.addHotelbtn.Size = new System.Drawing.Size(109, 29);
            this.addHotelbtn.TabIndex = 5;
            this.addHotelbtn.Text = "Add Hotel";
            this.addHotelbtn.UseVisualStyleBackColor = false;
            this.addHotelbtn.Click += new System.EventHandler(this.addHotelbtn_Click);
            // 
            // hotelscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "hotelscs";
            this.Text = "hotelscs";
            this.Load += new System.EventHandler(this.hotelscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblhotelss;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addHotelbtn;
        private System.Windows.Forms.Button consommationbtn;
    }
}