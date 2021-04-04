using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBimestral;
using System.IO;

namespace FrmPrincipal
{
    public partial class FrmActualizacionProceso : Form
    {
        private byte[] arregloPDF = null;
        private Persona persona;
        private bool envioExitoso;
        public Persona Persona { get => persona; set => persona = value; }
        public bool EnvioExitoso { get => envioExitoso; set => envioExitoso = value; }

        public FrmActualizacionProceso()
        {
            InitializeComponent();
        }

        private void btnCargarPDF_Click(object sender, EventArgs e)
        {
            //se abre el buscador para abrir un archivo
            abrirPDF.ShowDialog();
            // el archivo sera mostrado en el formulario
            pdfCargado.src = abrirPDF.FileName;
            //se transforma el archivo pdf a bytes
            arregloPDF = File.ReadAllBytes(abrirPDF.FileName);


            //AQUI SE ENVIA EL ARREGLOPDF AL SERVIDOR


            //ESTO SE HACE EN EL SERVIDOR
            //se crea un string con la ubicacion en donde se quiere guardar el archivo y se guardara con el nombre de la persona
            string ubicacion = "C:\\Users\\mayba\\SERVIDOR\\" + persona + ".pdf";
            //se escriben los bytes obtenidos del cliente y se los escribe en la ruta definida anteriormente
            File.WriteAllBytes(ubicacion, arregloPDF);

            //DESPUES DE QUE EL SERVIDOR GUARDA EL DOCUMENTO SE ENVIA UN 1 SI SE REALIZO CORRECTAMENTE O 0 SI NO
            MessageBox.Show("El estado de la persona ha cambiado a ENTREGA DE DOCUMENTOS!");
        }

        private void FrmActualizacionProceso_Load(object sender, EventArgs e)
        {
            //se muestra el nombre de la pesona en el label
            //lblPersona.Text = persona.ToString();
        }
    }
}
