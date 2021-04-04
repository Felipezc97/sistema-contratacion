namespace FrmPrincipal
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnConsultarEstado = new System.Windows.Forms.Button();
            this.btnNuevoProceso = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tltInfoPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.btnContinuarExistente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(97, 52);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(298, 15);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Elija una de las siguientes opciones para continuar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(46, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 29);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "PROCESO DE CONTRATACIÓN";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnEstadisticas.Location = new System.Drawing.Point(177, 88);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(139, 23);
            this.btnEstadisticas.TabIndex = 16;
            this.btnEstadisticas.Text = "VER ESTADÍSTICAS";
            this.tltInfoPrincipal.SetToolTip(this.btnEstadisticas, "Permite observar el número de personas de cada tipo de contrato");
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnConsultarEstado
            // 
            this.btnConsultarEstado.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnConsultarEstado.Location = new System.Drawing.Point(121, 125);
            this.btnConsultarEstado.Name = "btnConsultarEstado";
            this.btnConsultarEstado.Size = new System.Drawing.Size(250, 23);
            this.btnConsultarEstado.TabIndex = 17;
            this.btnConsultarEstado.Text = "CONSULTAR ESTADO DE UN PROCESO";
            this.tltInfoPrincipal.SetToolTip(this.btnConsultarEstado, "Permite consultar el estado en el que se encuentra el proceso de una persona. La " +
        "búsqueda se puede realizar por cédula o nombre");
            this.btnConsultarEstado.UseVisualStyleBackColor = true;
            this.btnConsultarEstado.Click += new System.EventHandler(this.btnConsultarEstado_Click);
            // 
            // btnNuevoProceso
            // 
            this.btnNuevoProceso.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnNuevoProceso.Location = new System.Drawing.Point(157, 201);
            this.btnNuevoProceso.Name = "btnNuevoProceso";
            this.btnNuevoProceso.Size = new System.Drawing.Size(178, 23);
            this.btnNuevoProceso.TabIndex = 18;
            this.btnNuevoProceso.Text = "INICIAR NUEVO PROCESO";
            this.tltInfoPrincipal.SetToolTip(this.btnNuevoProceso, "Permite generar un nuevo proceso de contratación. Se deben ingresar los datos per" +
        "sonales del solicitante");
            this.btnNuevoProceso.UseVisualStyleBackColor = true;
            this.btnNuevoProceso.Click += new System.EventHandler(this.btnNuevoProceso_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(209, 239);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "CERRAR";
            this.tltInfoPrincipal.SetToolTip(this.btnCerrar, "Salir de la aplicación");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnContinuarExistente
            // 
            this.btnContinuarExistente.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnContinuarExistente.Location = new System.Drawing.Point(127, 165);
            this.btnContinuarExistente.Name = "btnContinuarExistente";
            this.btnContinuarExistente.Size = new System.Drawing.Size(238, 23);
            this.btnContinuarExistente.TabIndex = 21;
            this.btnContinuarExistente.Text = "CONTINUAR PROCESO EXISTENTE";
            this.tltInfoPrincipal.SetToolTip(this.btnContinuarExistente, "Permite generar un nuevo proceso de contratación. Se deben ingresar los datos per" +
        "sonales del solicitante");
            this.btnContinuarExistente.UseVisualStyleBackColor = true;
            this.btnContinuarExistente.Click += new System.EventHandler(this.btnContinuarExistente_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 279);
            this.Controls.Add(this.btnContinuarExistente);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevoProceso);
            this.Controls.Add(this.btnConsultarEstado);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de proceso de contratación";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnConsultarEstado;
        private System.Windows.Forms.Button btnNuevoProceso;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolTip tltInfoPrincipal;
        private System.Windows.Forms.Button btnContinuarExistente;
    }
}

