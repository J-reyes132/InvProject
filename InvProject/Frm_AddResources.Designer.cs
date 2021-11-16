
namespace InvProject
{
    partial class Frm_AddResources
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddResources));
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Txt_RecibidoPor = new System.Windows.Forms.TextBox();
            this.Txb_serial = new System.Windows.Forms.TextBox();
            this.Txb_Color = new System.Windows.Forms.TextBox();
            this.txb_Descripcion = new System.Windows.Forms.TextBox();
            this.Txb_Modelo = new System.Windows.Forms.TextBox();
            this.Txb_Articulo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorRecursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVPROJECTDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVPROJECTDS = new InvProject.INVPROJECTDS();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.tipoRecursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_RecursoTableAdapter = new InvProject.INVPROJECTDSTableAdapters.Tipo_RecursoTableAdapter();
            this.color_RecursoTableAdapter = new InvProject.INVPROJECTDSTableAdapters.color_RecursoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRecursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVPROJECTDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVPROJECTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRecursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(514, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 71;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(288, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 29);
            this.label8.TabIndex = 70;
            this.label8.Text = "Agregar Recursos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(646, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 69;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(738, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(568, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tipo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(533, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Recibido Por:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(561, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Serial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(561, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(121, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(141, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Modelo:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(99, 112);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(187, 20);
            this.Label1.TabIndex = 61;
            this.Label1.Text = "Nombre del articulo:";
            // 
            // Txt_RecibidoPor
            // 
            this.Txt_RecibidoPor.BackColor = System.Drawing.Color.White;
            this.Txt_RecibidoPor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RecibidoPor.Location = new System.Drawing.Point(438, 313);
            this.Txt_RecibidoPor.Multiline = true;
            this.Txt_RecibidoPor.Name = "Txt_RecibidoPor";
            this.Txt_RecibidoPor.Size = new System.Drawing.Size(321, 24);
            this.Txt_RecibidoPor.TabIndex = 59;
            // 
            // Txb_serial
            // 
            this.Txb_serial.BackColor = System.Drawing.Color.White;
            this.Txb_serial.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_serial.Location = new System.Drawing.Point(438, 231);
            this.Txb_serial.Multiline = true;
            this.Txb_serial.Name = "Txb_serial";
            this.Txb_serial.Size = new System.Drawing.Size(321, 24);
            this.Txb_serial.TabIndex = 58;
            // 
            // Txb_Color
            // 
            this.Txb_Color.BackColor = System.Drawing.Color.White;
            this.Txb_Color.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Color.Location = new System.Drawing.Point(442, 231);
            this.Txb_Color.Multiline = true;
            this.Txb_Color.Name = "Txb_Color";
            this.Txb_Color.Size = new System.Drawing.Size(317, 24);
            this.Txb_Color.TabIndex = 57;
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.BackColor = System.Drawing.Color.White;
            this.txb_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Descripcion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Descripcion.Location = new System.Drawing.Point(37, 313);
            this.txb_Descripcion.Multiline = true;
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(317, 102);
            this.txb_Descripcion.TabIndex = 56;
            // 
            // Txb_Modelo
            // 
            this.Txb_Modelo.BackColor = System.Drawing.Color.White;
            this.Txb_Modelo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Modelo.Location = new System.Drawing.Point(37, 231);
            this.Txb_Modelo.Multiline = true;
            this.Txb_Modelo.Name = "Txb_Modelo";
            this.Txb_Modelo.Size = new System.Drawing.Size(317, 24);
            this.Txb_Modelo.TabIndex = 55;
            // 
            // Txb_Articulo
            // 
            this.Txb_Articulo.BackColor = System.Drawing.Color.White;
            this.Txb_Articulo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Articulo.Location = new System.Drawing.Point(37, 149);
            this.Txb_Articulo.Multiline = true;
            this.Txb_Articulo.Name = "Txb_Articulo";
            this.Txb_Articulo.Size = new System.Drawing.Size(317, 24);
            this.Txb_Articulo.TabIndex = 54;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.colorRecursoBindingSource, "id", true));
            this.comboBox1.DataSource = this.colorRecursoBindingSource;
            this.comboBox1.DisplayMember = "Color";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(442, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 21);
            this.comboBox1.TabIndex = 73;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // colorRecursoBindingSource
            // 
            this.colorRecursoBindingSource.DataMember = "color_Recurso";
            this.colorRecursoBindingSource.DataSource = this.iNVPROJECTDSBindingSource;
            // 
            // iNVPROJECTDSBindingSource
            // 
            this.iNVPROJECTDSBindingSource.DataSource = this.iNVPROJECTDS;
            this.iNVPROJECTDSBindingSource.Position = 0;
            // 
            // iNVPROJECTDS
            // 
            this.iNVPROJECTDS.DataSetName = "INVPROJECTDS";
            this.iNVPROJECTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.BackColor = System.Drawing.Color.White;
            this.cb_Tipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoRecursoBindingSource, "Tipo", true));
            this.cb_Tipo.DataSource = this.tipoRecursoBindingSource;
            this.cb_Tipo.DisplayMember = "Tipo";
            this.cb_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Location = new System.Drawing.Point(438, 394);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(321, 21);
            this.cb_Tipo.TabIndex = 74;
            this.cb_Tipo.ValueMember = "Id";
            this.cb_Tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tipoRecursoBindingSource
            // 
            this.tipoRecursoBindingSource.DataMember = "Tipo_Recurso";
            this.tipoRecursoBindingSource.DataSource = this.iNVPROJECTDSBindingSource;
            // 
            // tipo_RecursoTableAdapter
            // 
            this.tipo_RecursoTableAdapter.ClearBeforeFill = true;
            // 
            // color_RecursoTableAdapter
            // 
            this.color_RecursoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_AddResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 507);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Txt_RecibidoPor);
            this.Controls.Add(this.Txb_serial);
            this.Controls.Add(this.Txb_Color);
            this.Controls.Add(this.txb_Descripcion);
            this.Controls.Add(this.Txb_Modelo);
            this.Controls.Add(this.Txb_Articulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_AddResources";
            this.Load += new System.EventHandler(this.Frm_AddResources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRecursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVPROJECTDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVPROJECTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRecursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Txt_RecibidoPor;
        private System.Windows.Forms.TextBox Txb_serial;
        private System.Windows.Forms.TextBox Txb_Color;
        private System.Windows.Forms.TextBox txb_Descripcion;
        private System.Windows.Forms.TextBox Txb_Modelo;
        private System.Windows.Forms.TextBox Txb_Articulo;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.BindingSource iNVPROJECTDSBindingSource;
        private INVPROJECTDS iNVPROJECTDS;
        private System.Windows.Forms.BindingSource tipoRecursoBindingSource;
        private INVPROJECTDSTableAdapters.Tipo_RecursoTableAdapter tipo_RecursoTableAdapter;
        private System.Windows.Forms.BindingSource colorRecursoBindingSource;
        private INVPROJECTDSTableAdapters.color_RecursoTableAdapter color_RecursoTableAdapter;
    }
}