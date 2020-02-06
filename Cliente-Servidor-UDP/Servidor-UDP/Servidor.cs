using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System;


namespace Servidor_UDP
{
    public partial class Servidor : Form
    {
        private delegate void ActualizarElementos(string texto);

        private delegate void ActualizarInformacion();

        public Servidor()
        {
            InitializeComponent();
        }

        public void Comunicaciones()
        {
            UdpClient servidor = new UdpClient(8080);
            while (true)
            {
                IPEndPoint equipoRemoto = new IPEndPoint(IPAddress.Any, 0);
                Byte[] datosRx = servidor.Receive(ref equipoRemoto);

                string datos = Encoding.ASCII.GetString(datosRx);
                string texto = equipoRemoto.Address.ToString() + ":" + datos.ToString();
                lsbConexiones.Invoke(new ActualizarInformacion(InformarDelCliente));
                lsbConexiones.Invoke(new ActualizarElementos(ActualizarItemsEnlsbConexiones),
                    new object[] { texto });
            }
        }

        public void ActualizarItemsEnlsbConexiones(string texto)
        {
            lsbConexiones.Items.Add(texto);
        }

        public void InformarDelCliente()
        {

            lsbConexiones.Items.Add("Transmisión recibida a las: " + DateTime.Now.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread hiloComunicaciones = new Thread(new ThreadStart(Comunicaciones));
            hiloComunicaciones.Start();
        }

    }
}