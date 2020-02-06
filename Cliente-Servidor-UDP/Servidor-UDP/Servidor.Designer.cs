namespace Servidor_UDP
{
    partial class Servidor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbConexiones = new System.Windows.Forms.ListBox();
            this.lblConexiones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbConexiones
            // 
            this.lsbConexiones.FormattingEnabled = true;
            this.lsbConexiones.Location = new System.Drawing.Point(12, 28);
            this.lsbConexiones.Name = "lsbConexiones";
            this.lsbConexiones.Size = new System.Drawing.Size(561, 121);
            this.lsbConexiones.TabIndex = 0;
            // 
            // lblConexiones
            // 
            this.lblConexiones.AutoSize = true;
            this.lblConexiones.Location = new System.Drawing.Point(13, 9);
            this.lblConexiones.Name = "lblConexiones";
            this.lblConexiones.Size = new System.Drawing.Size(86, 13);
            this.lblConexiones.TabIndex = 1;
            this.lblConexiones.Text = "Clientes y Datos:";
            // 
            // FrmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 172);
            this.Controls.Add(this.lblConexiones);
            this.Controls.Add(this.lsbConexiones);
            this.Name = "FrmServidor";
            this.Text = "Servidor UDP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbConexiones;
        private System.Windows.Forms.Label lblConexiones;
    }
}