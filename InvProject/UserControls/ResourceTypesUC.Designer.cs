
namespace InvProject.UserControls
{
    partial class ResourceTypesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_TipoRecursos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TipoRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(121)))), ((int)(((byte)(189)))));
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Nuevo.Location = new System.Drawing.Point(261, 46);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(123, 71);
            this.Btn_Nuevo.TabIndex = 13;
            this.Btn_Nuevo.Text = "Agregar";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(121)))), ((int)(((byte)(189)))));
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Editar.Location = new System.Drawing.Point(261, 151);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(123, 71);
            this.Btn_Editar.TabIndex = 14;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(121)))), ((int)(((byte)(189)))));
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Borrar.Location = new System.Drawing.Point(261, 263);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(123, 71);
            this.Btn_Borrar.TabIndex = 15;
            this.Btn_Borrar.Text = "Eliminar Registro";
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AmsiPro-Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipos de Recursos";
            // 
            // Dgv_TipoRecursos
            // 
            this.Dgv_TipoRecursos.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_TipoRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TipoRecursos.Location = new System.Drawing.Point(0, 47);
            this.Dgv_TipoRecursos.Name = "Dgv_TipoRecursos";
            this.Dgv_TipoRecursos.Size = new System.Drawing.Size(255, 381);
            this.Dgv_TipoRecursos.TabIndex = 17;
            this.Dgv_TipoRecursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_TipoRecursos_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InvProject.Properties.Resources.back_25px;
            this.pictureBox1.Location = new System.Drawing.Point(19, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ResourceTypesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dgv_TipoRecursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Name = "ResourceTypesUC";
            this.Size = new System.Drawing.Size(783, 469);
            this.Load += new System.EventHandler(this.ResourceTypesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TipoRecursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_TipoRecursos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
