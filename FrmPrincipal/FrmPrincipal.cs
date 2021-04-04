using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using ProyectoBimestral;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.ShowDialog();
        }

        private void btnConsultarEstado_Click(object sender, EventArgs e)
        {
            FrmConsultarEstado frmConsultarEstado = new FrmConsultarEstado();
            frmConsultarEstado.ShowDialog();
        }

        private void btnContinuarExistente_Click(object sender, EventArgs e)
        {
            FrmContinuarProceso frmContinuarProceso = new FrmContinuarProceso();
            frmContinuarProceso.ShowDialog();
        }

        private void btnNuevoProceso_Click(object sender, EventArgs e)
        {
            FrmNuevoProceso frmNuevoProceso = new FrmNuevoProceso();
            frmNuevoProceso.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }        
    }
}
