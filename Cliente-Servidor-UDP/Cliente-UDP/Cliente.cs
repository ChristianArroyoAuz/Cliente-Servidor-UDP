using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System;


namespace Cliente_UDP
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            UdpClient cliente = new UdpClient();
            cliente.Connect(txtEquipoRemoto.Text, 8080);

            Byte[] datosTx = Encoding.ASCII.GetBytes(txtMensaje.Text);
            cliente.Send(datosTx, datosTx.Length);
        }
    }
}