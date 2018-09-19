namespace Index
{
    partial class CONSULTAS
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
            this.btnReg = new System.Windows.Forms.Button();
            this.dgvConsID = new System.Windows.Forms.DataGridView();
            this.btnDatos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtEsc = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.btnGral = new System.Windows.Forms.Button();
            this.lblPor = new System.Windows.Forms.Label();
            this.txtValido = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(12, 273);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(84, 37);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // dgvConsID
            // 
            this.dgvConsID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsID.Location = new System.Drawing.Point(178, 95);
            this.dgvConsID.Name = "dgvConsID";
            this.dgvConsID.Size = new System.Drawing.Size(495, 320);
            this.dgvConsID.TabIndex = 3;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(1, 28);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(118, 36);
            this.btnDatos.TabIndex = 4;
            this.btnDatos.Text = "Buscar ID";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Escolaridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Edad";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(230, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(31, 13);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Sexo";
            // 
            // txtEsc
            // 
            this.txtEsc.Location = new System.Drawing.Point(461, 25);
            this.txtEsc.Name = "txtEsc";
            this.txtEsc.ReadOnly = true;
            this.txtEsc.Size = new System.Drawing.Size(100, 20);
            this.txtEsc.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(330, 25);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(195, 28);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 6;
            // 
            // btnGral
            // 
            this.btnGral.Location = new System.Drawing.Point(-2, 95);
            this.btnGral.Name = "btnGral";
            this.btnGral.Size = new System.Drawing.Size(121, 51);
            this.btnGral.TabIndex = 12;
            this.btnGral.Text = "Buscar todos los ID\'S";
            this.btnGral.UseVisualStyleBackColor = true;
            this.btnGral.Click += new System.EventHandler(this.btnGral_Click);
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(230, 69);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(169, 13);
            this.lblPor.TabIndex = 13;
            this.lblPor.Text = "Porcentaje de respuestas  válidas:";
            // 
            // txtValido
            // 
            this.txtValido.Location = new System.Drawing.Point(418, 62);
            this.txtValido.Name = "txtValido";
            this.txtValido.ReadOnly = true;
            this.txtValido.Size = new System.Drawing.Size(100, 20);
            this.txtValido.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.FormattingEnabled = true;
            this.txtID.Location = new System.Drawing.Point(1, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 21);
            this.txtID.TabIndex = 15;
            // 
            // CONSULTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(723, 454);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtValido);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.btnGral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtEsc);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.dgvConsID);
            this.Controls.Add(this.btnReg);
            this.Name = "CONSULTAS";
            this.Text = "CONSULTAS";
            this.Load += new System.EventHandler(this.CONSULTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridView dgvConsID;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtEsc;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Button btnGral;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.TextBox txtValido;
        private System.Windows.Forms.ComboBox txtID;
    }
}