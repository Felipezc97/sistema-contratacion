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
    public partial class FrmContinuarProceso : Form
    {
        int digitosCedula = 20;
        TcpClient cliente = new TcpClient();
        Stream flujoDatos;
        StreamWriter escritor;
        StreamReader lector;
        Persona personaSeleccionada = new Persona();
        int estado;
        string resultado;

        public FrmContinuarProceso()
        {
            InitializeComponent();
            txtBusqueda.KeyPress += txtBusqueda_KeyPress;
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se valida que la tecla presionada sea un numero
            if (Char.IsNumber(e.KeyChar))
            {
                //valida que unicamente se presione 10 veces una letra, es decir, se ingresan unicamente 10 digitos
                if (digitosCedula > 0)
                {
                    e.Handled = false;
                    //se disminuye el contador para controlar el numero de digitos que ingresa
                    digitosCedula = digitosCedula - 1;
                }
                else
                    e.Handled = true;
            }
            //la tecla borrar tambien es permitida
            else if (e.KeyChar == 8)
            {
                if (digitosCedula < 20)
                {
                    e.Handled = false;
                    //si se presiona la tecla de borrar se restaura la variable de control
                    digitosCedula = digitosCedula + 1;
                }
                else
                    e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FrmContinuarProceso_Load(object sender, EventArgs e)
        {
            btnEnviarPDF.Enabled = false;
            btnValidarInformacion.Enabled = false;
            btnContratar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                IPEndPoint remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
                cliente.Connect(remoto);
                flujoDatos = cliente.GetStream();
                escritor = new StreamWriter(flujoDatos);
                lector = new StreamReader(flujoDatos);

                escritor.WriteLine(3);
                escritor.Flush();

                Thread.Sleep(200);
                escritor.WriteLine(1);
                escritor.Flush();

                Thread.Sleep(200);
                escritor.WriteLine(txtBusqueda.Text);
                escritor.Flush();

                try
                {
                    personaSeleccionada = Codificador.DecodificarPersona(lector.ReadLine());                    
                }
                catch (Exception)
                {

                }
                ActualizarInterfaz();
                lector.Close();
                escritor.Close();
                flujoDatos.Close();
                cliente.Close();

            }
            else
            {
                MessageBox.Show("Debe llenar el campo de búsqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        public void ActualizarInterfaz()
        {
            estado = personaSeleccionada.IdEstado;
            lblNombrePersona.Text = personaSeleccionada.Nombre;
            switch (estado)
            {
                case 1:
                    lblEstadoPersona.Text = "Solicitado";
                    btnEnviarPDF.Enabled = true;
                    btnValidarInformacion.Enabled = false;
                    btnContratar.Enabled = false;
                    break;
                case 2:
                    lblEstadoPersona.Text = "Entregado";
                    btnEnviarPDF.Enabled = false;
                    btnValidarInformacion.Enabled = true;
                    btnContratar.Enabled = true;
                    break;
                case 3:
                    lblEstadoPersona.Text = "Validado";
                    btnEnviarPDF.Enabled = false;
                    btnValidarInformacion.Enabled = false;
                    btnContratar.Enabled = true;
                    break;
                case 4:
                    MessageBox.Show("La persona ya ha sido contratada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnEnviarPDF.Enabled = false;
                    btnValidarInformacion.Enabled = false;
                    btnContratar.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnEnviarPDF_Click(object sender, EventArgs e)
        {
            FrmActualizacionProceso frmActualizacionProceso = new FrmActualizacionProceso();
            frmActualizacionProceso.ShowDialog();
            bool exitoso = frmActualizacionProceso.EnvioExitoso;
            if (exitoso)
                personaSeleccionada.IdEstado = 2;
            ActualizarInterfaz();
        }

        private void btnValidarInformacion_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Al hacer esto el proceso estará en estado 'VALIDADO'.\n" +
                            "Esto no significa que la persona ha sido contratada aún.\n" +
                            "Deberá presionar el botón 'CONTRATAR' para realizar este\n" +
                            "proceso, ¿Desea continuar?","AVISO",MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                IPEndPoint remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
                cliente.Connect(remoto);
                flujoDatos = cliente.GetStream();
                escritor = new StreamWriter(flujoDatos);
                lector = new StreamReader(flujoDatos);

                escritor.WriteLine(3);
                escritor.Flush();

                escritor.WriteLine(2);
                escritor.Flush();

                personaSeleccionada.IdEstado = 3;
                escritor.WriteLine(Codificador.CodificarPersona(personaSeleccionada));
                escritor.Flush();

                try
                {
                    resultado = lector.ReadLine();
                }
                catch (Exception)
                {

                }

                if (resultado == "valido")
                {
                    personaSeleccionada.IdEstado = 3;
                    ActualizarInterfaz();
                }
                else
                {
                    MessageBox.Show("No se ha podido validar los datos","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                lector.Close();
                escritor.Close();
                flujoDatos.Close();
                cliente.Close();
            }
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Al hacer esto la persona quedará CONTRATADA.\n" +
                           "¿Desea continuar?", "AVISO", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                IPEndPoint remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
                cliente.Connect(remoto);
                flujoDatos = cliente.GetStream();
                escritor = new StreamWriter(flujoDatos);
                lector = new StreamReader(flujoDatos);

                escritor.WriteLine(3);
                escritor.Flush();

                escritor.WriteLine(3);
                escritor.Flush();

                escritor.WriteLine(personaSeleccionada.Cedula);
                escritor.Flush();

                try
                {
                    resultado = lector.ReadLine();
                }
                catch (Exception)
                {

                }

                if (resultado == "valido")
                {
                    lblEstadoPersona.Text = "Contratado";
                    btnContratar.Enabled = false;
                    btnEnviarPDF.Enabled = false;
                    btnValidarInformacion.Enabled = false;
                    MessageBox.Show("FELICITACIONES\nLa persona ha sido contratada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarInterfaz();
                }
                else
                {
                    MessageBox.Show("No se ha podido validar los datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lector.Close();
                escritor.Close();
                flujoDatos.Close();
                cliente.Close();
            }
        }
    }
}
