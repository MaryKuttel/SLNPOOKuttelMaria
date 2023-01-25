namespace WindowsEFDatos
{
    partial class FrmAvion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listarAviones = new System.Windows.Forms.Button();
            this.insertarAvion = new System.Windows.Forms.Button();
            this.GridAviones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intCapacidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GridAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // listarAviones
            // 
            this.listarAviones.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarAviones.Location = new System.Drawing.Point(84, 115);
            this.listarAviones.Name = "listarAviones";
            this.listarAviones.Size = new System.Drawing.Size(155, 59);
            this.listarAviones.TabIndex = 0;
            this.listarAviones.Text = "Listar Aviones";
            this.listarAviones.UseVisualStyleBackColor = true;
            // 
            // insertarAvion
            // 
            this.insertarAvion.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertarAvion.Location = new System.Drawing.Point(84, 261);
            this.insertarAvion.Name = "insertarAvion";
            this.insertarAvion.Size = new System.Drawing.Size(155, 59);
            this.insertarAvion.TabIndex = 1;
            this.insertarAvion.Text = "Insertar Avion";
            this.insertarAvion.UseVisualStyleBackColor = true;
            this.insertarAvion.Click += new System.EventHandler(this.insertarAvion_Click);
            // 
            // GridAviones
            // 
            this.GridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAviones.Location = new System.Drawing.Point(264, 115);
            this.GridAviones.Name = "GridAviones";
            this.GridAviones.Size = new System.Drawing.Size(436, 323);
            this.GridAviones.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Denominacion";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(294, 89);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(169, 20);
            this.txtDenominacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capacidad";
            // 
            // intCapacidad
            // 
            this.intCapacidad.Location = new System.Drawing.Point(514, 89);
            this.intCapacidad.Name = "intCapacidad";
            this.intCapacidad.Size = new System.Drawing.Size(157, 20);
            this.intCapacidad.TabIndex = 6;
            // 
            // FrmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.intCapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridAviones);
            this.Controls.Add(this.insertarAvion);
            this.Controls.Add(this.listarAviones);
            this.Name = "FrmAvion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listarAviones;
        private System.Windows.Forms.Button insertarAvion;
        private System.Windows.Forms.DataGridView GridAviones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown intCapacidad;
    }
}

