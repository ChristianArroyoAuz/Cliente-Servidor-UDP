namespace Cliente_UDP
{
    partial class Cliente
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblEquipoRemoto = new System.Windows.Forms.Label();
            this.txtEquipoRemoto = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(259, 103);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "&Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblEquipoRemoto
            // 
            this.lblEquipoRemoto.AutoSize = true;
            this.lblEquipoRemoto.Location = new System.Drawing.Point(13, 13);
            this.lblEquipoRemoto.Name = "lblEquipoRemoto";
            this.lblEquipoRemoto.Size = new System.Drawing.Size(83, 13);
            this.lblEquipoRemoto.TabIndex = 1;
            this.lblEquipoRemoto.Text = "Equipo Remoto:";
            // 
            // txtEquipoRemoto
            // 
            this.txtEquipoRemoto.Location = new System.Drawing.Point(99, 6);
            this.txtEquipoRemoto.Name = "txtEquipoRemoto";
            this.txtEquipoRemoto.Size = new System.Drawing.Size(235, 20);
            this.txtEquipoRemoto.TabIndex = 2;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(99, 32);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(235, 65);
            this.txtMensaje.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 39);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(50, 13);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 138);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtEquipoRemoto);
            this.Controls.Add(this.lblEquipoRemoto);
            this.Controls.Add(this.btnEnviar);
            this.Name = "frmCliente";
            this.Text = "Cliente UDP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblEquipoRemoto;
        private System.Windows.Forms.TextBox txtEquipoRemoto;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblMensaje;
    }
}

