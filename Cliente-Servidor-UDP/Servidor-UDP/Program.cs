﻿using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;


namespace Servidor_UDP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Servidor());
        }
    }
}