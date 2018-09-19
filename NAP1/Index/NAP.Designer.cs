namespace Index
{
    partial class NAP
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
            this.btnCons = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCons
            // 
            this.btnCons.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCons.Location = new System.Drawing.Point(491, 356);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(229, 74);
            this.btnCons.TabIndex = 0;
            this.btnCons.Text = "CONSULTAR DATOS POR ID";
            this.btnCons.UseVisualStyleBackColor = false;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // btnMed
            // 
            this.btnMed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMed.Location = new System.Drawing.Point(89, 356);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(226, 74);
            this.btnMed.TabIndex = 1;
            this.btnMed.Text = "CONSULTAR MEDIDAS PORCENTUALES";
            this.btnMed.UseVisualStyleBackColor = false;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDownload.Location = new System.Drawing.Point(909, 356);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(270, 74);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "DESCARGAR EXCEL DE MEDIDAS PORCENTUALES";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Index.Properties.Resources.labo;
            this.pictureBox1.Location = new System.Drawing.Point(89, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1056, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Designed by Yosshua Eli Cisneros Villasana\r\ncorreo: yocisneros@outlook.com";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1051, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnCons);
            this.Name = "NAP";
            this.Text = "INDEX";
            this.Load += new System.EventHandler(this.INDEX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCons;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}