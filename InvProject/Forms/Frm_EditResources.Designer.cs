
namespace InvProject.Forms
{
    partial class Frm_EditResources
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Txb_Tipo = new System.Windows.Forms.TextBox();
            this.Txt_RecibidoPor = new System.Windows.Forms.TextBox();
            this.Txb_serial = new System.Windows.Forms.TextBox();
            this.Txb_Color = new System.Windows.Forms.TextBox();
            this.txb_Descripcion = new System.Windows.Forms.TextBox();
            this.Txb_Modelo = new System.Windows.Forms.TextBox();
            this.Txb_Articulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Gris",
            "Rojo",
            "Verde",
            "Negro"});
            this.comboBox1.Location = new System.Drawing.Point(419, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 21);
            this.comboBox1.TabIndex = 91;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(491, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 90;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(265, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 29);
            this.label8.TabIndex = 89;
            this.label8.Text = "Editar Recursos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(623, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 88;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(545, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 87;
            this.label7.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(510, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Recibido Por:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(538, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Serial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(538, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Modelo:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(76, 101);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(187, 20);
            this.Label1.TabIndex = 81;
            this.Label1.Text = "Nombre del articulo:";
            // 
            // Txb_Tipo
            // 
            this.Txb_Tipo.BackColor = System.Drawing.Color.White;
            this.Txb_Tipo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Tipo.Location = new System.Drawing.Point(419, 380);
            this.Txb_Tipo.Multiline = true;
            this.Txb_Tipo.Name = "Txb_Tipo";
            this.Txb_Tipo.Size = new System.Drawing.Size(321, 24);
            this.Txb_Tipo.TabIndex = 80;
            // 
            // Txt_RecibidoPor
            // 
            this.Txt_RecibidoPor.BackColor = System.Drawing.Color.White;
            this.Txt_RecibidoPor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RecibidoPor.Location = new System.Drawing.Point(419, 301);
            this.Txt_RecibidoPor.Multiline = true;
            this.Txt_RecibidoPor.Name = "Txt_RecibidoPor";
            this.Txt_RecibidoPor.Size = new System.Drawing.Size(321, 24);
            this.Txt_RecibidoPor.TabIndex = 79;
            // 
            // Txb_serial
            // 
            this.Txb_serial.BackColor = System.Drawing.Color.White;
            this.Txb_serial.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_serial.Location = new System.Drawing.Point(418, 220);
            this.Txb_serial.Multiline = true;
            this.Txb_serial.Name = "Txb_serial";
            this.Txb_serial.Size = new System.Drawing.Size(321, 24);
            this.Txb_serial.TabIndex = 78;
            // 
            // Txb_Color
            // 
            this.Txb_Color.BackColor = System.Drawing.Color.White;
            this.Txb_Color.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Color.Location = new System.Drawing.Point(419, 220);
            this.Txb_Color.Multiline = true;
            this.Txb_Color.Name = "Txb_Color";
            this.Txb_Color.Size = new System.Drawing.Size(317, 24);
            this.Txb_Color.TabIndex = 77;
            this.Txb_Color.Visible = false;
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.BackColor = System.Drawing.Color.White;
            this.txb_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Descripcion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Descripcion.Location = new System.Drawing.Point(14, 302);
            this.txb_Descripcion.Multiline = true;
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(317, 102);
            this.txb_Descripcion.TabIndex = 76;
            // 
            // Txb_Modelo
            // 
            this.Txb_Modelo.BackColor = System.Drawing.Color.White;
            this.Txb_Modelo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Modelo.Location = new System.Drawing.Point(14, 220);
            this.Txb_Modelo.Multiline = true;
            this.Txb_Modelo.Name = "Txb_Modelo";
            this.Txb_Modelo.Size = new System.Drawing.Size(317, 24);
            this.Txb_Modelo.TabIndex = 75;
            // 
            // Txb_Articulo
            // 
            this.Txb_Articulo.BackColor = System.Drawing.Color.White;
            this.Txb_Articulo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Articulo.Location = new System.Drawing.Point(14, 138);
            this.Txb_Articulo.Multiline = true;
            this.Txb_Articulo.Name = "Txb_Articulo";
            this.Txb_Articulo.Size = new System.Drawing.Size(317, 24);
            this.Txb_Articulo.TabIndex = 74;
            this.Txb_Articulo.TextChanged += new System.EventHandler(this.Txb_Articulo_TextChanged);
            // 
            // Frm_EditResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 494);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Txb_Tipo);
            this.Controls.Add(this.Txt_RecibidoPor);
            this.Controls.Add(this.Txb_serial);
            this.Controls.Add(this.Txb_Color);
            this.Controls.Add(this.txb_Descripcion);
            this.Controls.Add(this.Txb_Modelo);
            this.Controls.Add(this.Txb_Articulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_EditResources";
            this.Text = "Frm_EditResources";
            this.Load += new System.EventHandler(this.Frm_EditResources_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Txb_Color;
        public System.Windows.Forms.TextBox Txb_Tipo;
        public System.Windows.Forms.TextBox Txt_RecibidoPor;
        public System.Windows.Forms.TextBox Txb_serial;
        public System.Windows.Forms.TextBox txb_Descripcion;
        public System.Windows.Forms.TextBox Txb_Modelo;
        public System.Windows.Forms.TextBox Txb_Articulo;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}