namespace FrmPrincipal
{
    partial class FrmActualizacionProceso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizacionProceso));
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCargarPDF = new System.Windows.Forms.Button();
            this.pdfCargado = new AxAcroPDFLib.AxAcroPDF();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.abrirPDF = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pdfCargado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lblPersona.Location = new System.Drawing.Point(12, 71);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(59, 16);
            this.lblPersona.TabIndex = 12;
            this.lblPersona.Text = "Persona";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(12, 47);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(158, 16);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "La persona ingresada es:";
            // 
            // btnCargarPDF
            // 
            this.btnCargarPDF.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCargarPDF.Location = new System.Drawing.Point(29, 130);
            this.btnCargarPDF.Margin = new System.Windows.Forms.Padding(1);
            this.btnCargarPDF.Name = "btnCargarPDF";
            this.btnCargarPDF.Size = new System.Drawing.Size(106, 26);
            this.btnCargarPDF.TabIndex = 10;
            this.btnCargarPDF.Text = "CARGAR PDF";
            this.btnCargarPDF.UseVisualStyleBackColor = true;
            this.btnCargarPDF.Click += new System.EventHandler(this.btnCargarPDF_Click);
            // 
            // pdfCargado
            // 
            this.pdfCargado.Dock = System.Windows.Forms.DockStyle.Right;
            this.pdfCargado.Enabled = true;
            this.pdfCargado.Location = new System.Drawing.Point(174, 0);
            this.pdfCargado.Margin = new System.Windows.Forms.Padding(1);
            this.pdfCargado.Name = "pdfCargado";
            this.pdfCargado.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfCargado.OcxState")));
            this.pdfCargado.Size = new System.Drawing.Size(545, 426);
            this.pdfCargado.TabIndex = 13;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(29, 173);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 25);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // abrirPDF
            // 
            this.abrirPDF.FileName = "documentoEnvio";
            // 
            // FrmActualizacionProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 426);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pdfCargado);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCargarPDF);
            this.Name = "FrmActualizacionProceso";
            this.Text = "Envío de documento PDF";
            this.Load += new System.EventHandler(this.FrmActualizacionProceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfCargado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCargarPDF;
        private AxAcroPDFLib.AxAcroPDF pdfCargado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.OpenFileDialog abrirPDF;
    }
}