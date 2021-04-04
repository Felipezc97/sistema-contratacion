using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Net.Sockets;
using ProyectoBimestral;

namespace FrmPrincipal
{
    public partial class FrmEstadisticas : Form
    {
        TcpClient cliente = new TcpClient();
        Stream flujoDatos;
        StreamWriter escritor;
        StreamReader lector;

        List<int> estadisticas = new List<int>();
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {

            IPEndPoint remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
            cliente.Connect(remoto);
            flujoDatos = cliente.GetStream();
            escritor = new StreamWriter(flujoDatos);
            lector = new StreamReader(flujoDatos);

            escritor.WriteLine(1);
            escritor.Flush();

            int contador = 0;
            int aux = 0;
            while (contador < 5)
            {
                aux = Convert.ToInt32(lector.ReadLine());
                Console.WriteLine(aux.ToString());
                estadisticas.Add(aux);
                contador++;
            }
            lblOcasional.Text = Convert.ToString(estadisticas[0]);
            lblTitular.Text = Convert.ToString(estadisticas[1]);
            lblInvitado.Text = Convert.ToString(estadisticas[2]);
            lblHonorario.Text = Convert.ToString(estadisticas[3]);
            lblAyudante.Text = Convert.ToString(estadisticas[4]);
            lector.Close();
            escritor.Close();
            flujoDatos.Close();
            cliente.Close();
        }
    }
}
