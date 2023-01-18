namespace PresentacionVehiculos
{
    partial class Form1
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
            this.crearCamion = new System.Windows.Forms.Button();
            this.crearRemolque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crearCamion
            // 
            this.crearCamion.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearCamion.Location = new System.Drawing.Point(36, 136);
            this.crearCamion.Name = "crearCamion";
            this.crearCamion.Size = new System.Drawing.Size(282, 146);
            this.crearCamion.TabIndex = 0;
            this.crearCamion.Text = "Crear Camion";
            this.crearCamion.UseVisualStyleBackColor = true;
            this.crearCamion.Click += new System.EventHandler(this.crearCamion_Click);
            // 
            // crearRemolque
            // 
            this.crearRemolque.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearRemolque.Location = new System.Drawing.Point(469, 136);
            this.crearRemolque.Name = "crearRemolque";
            this.crearRemolque.Size = new System.Drawing.Size(282, 146);
            this.crearRemolque.TabIndex = 1;
            this.crearRemolque.Text = "Crear Remolque";
            this.crearRemolque.UseVisualStyleBackColor = true;
            this.crearRemolque.Click += new System.EventHandler(this.crearRemolque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crearRemolque);
            this.Controls.Add(this.crearCamion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crearCamion;
        private System.Windows.Forms.Button crearRemolque;
    }
}

