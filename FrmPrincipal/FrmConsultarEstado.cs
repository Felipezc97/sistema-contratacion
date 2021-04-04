using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using ProyectoBimestral;

namespace FrmPrincipal
{
    public partial class FrmConsultarEstado : Form
    {

        TcpClient cliente = new TcpClient();
        Stream flujoDatos;
        StreamWriter escritor;
        StreamReader lector;

        List<Persona> personas = new List<Persona>();
        //variable que indica si la busqueda es por nombre=1 o por cedula=2
        private int controlBusqueda;
        //variable que permite controlar el numero de digitos de la cedula
        private int digitosCedula;
        //variable auxiliar de tipo persona que va a permitir guardar la persona seleccionada del listbox
        private Persona personaAuxiliar;

        public FrmConsultarEstado()
        {
            InitializeComponent();
            txtBusqueda.KeyPress += txtBusqueda_KeyPress;
        }

        private void FrmConsultarEstado_Load(object sender, EventArgs e)
        {

        }


        private void bntBuscar_Click(object sender, EventArgs e)
        {
            
        }


        public void ImprimirListaPersonas(List<Persona> lista)
        {
            lsbPersonasEncontradas.Items.Clear();
            foreach (Persona aux in lista)
            {
                lsbPersonasEncontradas.Items.Add(aux);
            }
            lsbPersonasEncontradas.SelectedIndex = 0;
        }

        private void lsbPersonasEncontradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPersonaSeleccionada.Text = ((Persona)lsbPersonasEncontradas.SelectedItem).Nombre;
            int estado = ((Persona)lsbPersonasEncontradas.SelectedItem).IdEstado;
            switch (estado)
            {
                case 1:
                    lblEstado.Text = "Solicitado";
                    break;
                case 2:
                    lblEstado.Text = "Entregado documentos";
                    break;
                case 3:
                    lblEstado.Text = "Validado";
                    break;
                case 4:
                    lblEstado.Text = "Contratado";
                    break;
                default:
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //mediante eventos se controla el ingreso de datos del cliente
        private void txtBusqueda_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //si la busqueda es por nombre solo puede insertar letras, presionar borrar o espacio
            if (controlBusqueda == 1)
            {
                //se valida que la tecla presionada sea una letra o la tecla borrar
                if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            //si la busqueda es por cedula solo puede ingresar numeros
            else if (controlBusqueda == 2)
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
                    if (digitosCedula < 10)
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

        }


        private void FrmConsultarEstado_Load_1(object sender, EventArgs e)
        {
            digitosCedula = 10;
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            controlBusqueda = 1;
        }

        private void rbtCedula_CheckedChanged(object sender, EventArgs e)
        {
           txtBusqueda.Clear();
            controlBusqueda = 2;
        }

        private void bntBuscar_Click_1(object sender, EventArgs e)
        {
            IPEndPoint remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
            cliente.Connect(remoto);
            flujoDatos = cliente.GetStream();
            escritor = new StreamWriter(flujoDatos);
            lector = new StreamReader(flujoDatos);

            escritor.WriteLine(2);
            escritor.Flush();

            if (txtBusqueda.Text != "")
            {
                if (controlBusqueda == 1)
                {
                    escritor.WriteLine(1);
                    escritor.Flush();
                }
                else if (controlBusqueda == 2)
                {
                    escritor.WriteLine(2);
                    escritor.Flush();
                }
                escritor.WriteLine(txtBusqueda.Text);
                escritor.Flush();
                try
                {
                    //Se recibe el numero total de personas que se deben recibir en la lista
                    int totalEncontradas = Convert.ToInt32(lector.ReadLine());
                    int aux = 0;
                    while (aux < totalEncontradas)
                    {
                        string cadena = lector.ReadLine();
                        Persona persona = new Persona();
                        persona = Codificador.DecodificarPersona(cadena);
                        personas.Add(persona);
                        aux++;
                    }
                    lector.Close();
                    escritor.Close();
                    flujoDatos.Close();
                }
                catch (Exception)
                {

                }
                cliente.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresarse datos en el campo de busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
