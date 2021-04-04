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
using System.Net.Sockets;
using ProyectoBimestral;
using System.IO;


namespace FrmPrincipal
{
    public partial class FrmNuevoProceso : Form
    {
        TcpClient cliente = new TcpClient();
        Stream flujoDatos;
        StreamWriter escritor;
        StreamReader lector;
        private int contadorPersonas = 0;
        private List<TipoPersonal> tiposPersonal;
        private List<Departamento> departamentos;
        private int digitosCedula;
        string validez;
        string cadena;

        public FrmNuevoProceso()
        {
            InitializeComponent();
            //Configuración de eventos que escucha con la pulsación de tecla
            txbNombre.KeyPress += txbNombre_KeyPress;
            txbApellido.KeyPress += txbApellido_KeyPress;
            txbCedula.KeyPress += txbCedula_KeyPress;
            txbTitulo.KeyPress += txbTitulo_KeyPress;
            txbCedula.KeyPress += txbCedula_KeyPress;
        }

        private void btnEnviarDatos_Click(object sender, EventArgs e)
        {
            IPEndPoint remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
            cliente.Connect(remoto);
            flujoDatos = cliente.GetStream();
            escritor = new StreamWriter(flujoDatos);
            lector = new StreamReader(flujoDatos);

            escritor.WriteLine(4);
            escritor.Flush();

            Persona personaNueva = new Persona();
            personaNueva.IdPersona = contadorPersonas;
            contadorPersonas++;
            personaNueva.Cedula = txbCedula.Text;
            personaNueva.Nombre = txbNombre.Text + " " + txbApellido.Text;
            personaNueva.Titulo = txbTitulo.Text;
            personaNueva.IdTipoPersonal = ((TipoPersonal)cbxTipoContrato.SelectedItem).IdTipoPersonal;
            personaNueva.IdDepartamento = ((Departamento)cbxDepartamento.SelectedItem).IdDepartamento;
            personaNueva.IdEstado = 1;

            escritor.WriteLine(Codificador.CodificarPersona(personaNueva));
            escritor.Flush();

            
            try
            {
                validez = lector.ReadLine();                        
            }
            catch (Exception)
            {

            }
            if (validez == "valido")
            {
                MessageBox.Show("La persona ha sido registrada exitosamente.\n" + "Se encuentra en estado 'SOLICITADO'", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (validez == "existe")
            {
                MessageBox.Show("La persona ya existe en los registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No se ha podido agregar a la persona'", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lector.Close();
            escritor.Close();
            flujoDatos.Close();
            cliente.Close();
        }

        private void FrmNuevoProceso_Load(object sender, EventArgs e)
        {
            digitosCedula = 20;
            limpiarCampos();
            departamentos = DAO.obtenerListaDepartamento();
            tiposPersonal = DAO.obtenerListaTipoPersonal();
            cbxTipoContrato.Items.Clear();
            cbxDepartamento.Items.Clear();
            foreach (Departamento aux in departamentos)
            {
                cbxDepartamento.Items.Add(aux);
            }
            foreach(TipoPersonal aux in tiposPersonal)
            {
                cbxTipoContrato.Items.Add(aux);
            }

        }

        //metodo que limpiara los textbox y combobox del formulario
        private void limpiarCampos()
        {
            txbTitulo.Clear();
            txbNombre.Clear();
            txbCedula.Clear();
            txbApellido.Clear();
            cbxDepartamento.Text = " ";
            cbxTipoContrato.Text = " ";
        }

        //al presionar el boton se llama la funcion que limpian los campos
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        //metodo que unicamente permite ingresar letras al textbox nombre por medio de eventos
        private void txbNombre_KeyPress (object sender, System.Windows.Forms.KeyPressEventArgs e) 
        {
            //se valida que la tecla presionada sea una letra o la tecla borrar
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        //metodo que unicamente permite ingresar letras al textbox apellido por medio de eventos
        private void txbApellido_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //se valida que la tecla presionada sea una letra o la tecla borrar
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        //metodo que unicamente permite ingresar letras al textbox titulo por medio de eventos
        private void txbTitulo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //se valida que la tecla presionada sea una letra, la tecla borrar o espacio
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar==32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        //metodo que unicamente permite ingresar numeros al textbox cedula por medio de eventos
        private void txbCedula_KeyPress (object sender, System.Windows.Forms.KeyPressEventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
