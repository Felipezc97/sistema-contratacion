namespace FrmPrincipal
{
    partial class FrmContinuarProceso
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstadoPersona = new System.Windows.Forms.Label();
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnValidarInformacion = new System.Windows.Forms.Button();
            this.btnEnviarPDF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnContratar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tltInfoContinuar = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(49, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(306, 29);
            this.lblTitulo.TabIndex = 100;
            this.lblTitulo.Text = "CONTINUAR PROCESO";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(70, 56);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(264, 16);
            this.lblDescripcion.TabIndex = 102;
            this.lblDescripcion.Text = "Ingrese el numero de cédula de la persona";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(228, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 23);
            this.btnBuscar.TabIndex = 122;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(108, 81);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(114, 20);
            this.txtBusqueda.TabIndex = 121;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstadoPersona);
            this.groupBox1.Controls.Add(this.lblNombrePersona);
            this.groupBox1.Controls.Add(this.lblDescripcion2);
            this.groupBox1.Controls.Add(this.lblDescripcion1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox1.Location = new System.Drawing.Point(102, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona seleccionada";
            // 
            // lblEstadoPersona
            // 
            this.lblEstadoPersona.AutoSize = true;
            this.lblEstadoPersona.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblEstadoPersona.Location = new System.Drawing.Point(58, 39);
            this.lblEstadoPersona.Name = "lblEstadoPersona";
            this.lblEstadoPersona.Size = new System.Drawing.Size(15, 16);
            this.lblEstadoPersona.TabIndex = 112;
            this.lblEstadoPersona.Text = "e";
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblNombrePersona.Location = new System.Drawing.Point(67, 21);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(16, 16);
            this.lblNombrePersona.TabIndex = 111;
            this.lblNombrePersona.Text = "P";
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion2.Location = new System.Drawing.Point(6, 39);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(57, 16);
            this.lblDescripcion2.TabIndex = 110;
            this.lblDescripcion2.Text = "Estado: ";
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion1.Location = new System.Drawing.Point(6, 21);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(66, 16);
            this.lblDescripcion1.TabIndex = 109;
            this.lblDescripcion1.Text = "Nombre: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnContratar);
            this.groupBox2.Controls.Add(this.btnValidarInformacion);
            this.groupBox2.Controls.Add(this.btnEnviarPDF);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox2.Location = new System.Drawing.Point(52, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 89);
            this.groupBox2.TabIndex = 125;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones Disponibles";
            // 
            // btnValidarInformacion
            // 
            this.btnValidarInformacion.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnValidarInformacion.Location = new System.Drawing.Point(133, 22);
            this.btnValidarInformacion.Name = "btnValidarInformacion";
            this.btnValidarInformacion.Size = new System.Drawing.Size(136, 25);
            this.btnValidarInformacion.TabIndex = 119;
            this.btnValidarInformacion.Text = "Validar Información";
            this.tltInfoContinuar.SetToolTip(this.btnValidarInformacion, "Permite validar la información del solicitante inluyendo el documento PDF");
            this.btnValidarInformacion.UseVisualStyleBackColor = true;
            this.btnValidarInformacion.Click += new System.EventHandler(this.btnValidarInformacion_Click);
            // 
            // btnEnviarPDF
            // 
            this.btnEnviarPDF.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnEnviarPDF.Location = new System.Drawing.Point(26, 22);
            this.btnEnviarPDF.Name = "btnEnviarPDF";
            this.btnEnviarPDF.Size = new System.Drawing.Size(93, 25);
            this.btnEnviarPDF.TabIndex = 118;
            this.btnEnviarPDF.Text = "Enviar PDF";
            this.tltInfoContinuar.SetToolTip(this.btnEnviarPDF, "Permite cargar y enviar el documento PDF con la información del solicitante");
            this.btnEnviarPDF.UseVisualStyleBackColor = true;
            this.btnEnviarPDF.Click += new System.EventHandler(this.btnEnviarPDF_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 10F);
            this.button1.Location = new System.Drawing.Point(112, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 121;
            this.button1.Text = "Contratar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnContratar
            // 
            this.btnContratar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnContratar.Location = new System.Drawing.Point(113, 54);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(77, 25);
            this.btnContratar.TabIndex = 120;
            this.btnContratar.Text = "Contratar";
            this.tltInfoContinuar.SetToolTip(this.btnContratar, "Permite contratar a la persona seleccionada");
            this.btnContratar.UseVisualStyleBackColor = true;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(166, 277);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(77, 25);
            this.btnCerrar.TabIndex = 126;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmContinuarProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 309);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmContinuarProceso";
            this.Text = "Continuar proceso de contratación existente";
            this.Load += new System.EventHandler(this.FrmContinuarProceso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEstadoPersona;
        private System.Windows.Forms.Label lblNombrePersona;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.ToolTip tltInfoContinuar;
        private System.Windows.Forms.Button btnValidarInformacion;
        private System.Windows.Forms.Button btnEnviarPDF;
        private System.Windows.Forms.Button btnCerrar;
    }
}