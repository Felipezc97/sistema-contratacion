namespace FrmPrincipal
{
    partial class FrmConsultarEstado
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
            this.bntBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonaSeleccionada = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbPersonasEncontradas = new System.Windows.Forms.ListBox();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtCedula = new System.Windows.Forms.RadioButton();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bntBuscar
            // 
            this.bntBuscar.Font = new System.Drawing.Font("Cambria", 10F);
            this.bntBuscar.Location = new System.Drawing.Point(152, 393);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(75, 23);
            this.bntBuscar.TabIndex = 145;
            this.bntBuscar.Text = "BUSCAR";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(260, 393);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 23);
            this.btnCerrar.TabIndex = 144;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 143;
            this.label1.Text = "El estado de ";
            // 
            // lblPersonaSeleccionada
            // 
            this.lblPersonaSeleccionada.AutoSize = true;
            this.lblPersonaSeleccionada.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonaSeleccionada.Location = new System.Drawing.Point(151, 348);
            this.lblPersonaSeleccionada.Name = "lblPersonaSeleccionada";
            this.lblPersonaSeleccionada.Size = new System.Drawing.Size(144, 15);
            this.lblPersonaSeleccionada.TabIndex = 142;
            this.lblPersonaSeleccionada.Text = "Persona seleccionada";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(97, 365);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(49, 15);
            this.lblEstado.TabIndex = 141;
            this.lblEstado.Text = "estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 140;
            this.label2.Text = "es:";
            // 
            // lsbPersonasEncontradas
            // 
            this.lsbPersonasEncontradas.Font = new System.Drawing.Font("Cambria", 9F);
            this.lsbPersonasEncontradas.FormattingEnabled = true;
            this.lsbPersonasEncontradas.ItemHeight = 14;
            this.lsbPersonasEncontradas.Location = new System.Drawing.Point(81, 182);
            this.lsbPersonasEncontradas.Name = "lsbPersonasEncontradas";
            this.lsbPersonasEncontradas.Size = new System.Drawing.Size(320, 144);
            this.lsbPersonasEncontradas.TabIndex = 139;
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion2.Location = new System.Drawing.Point(158, 163);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(166, 15);
            this.lblDescripcion2.TabIndex = 138;
            this.lblDescripcion2.Text = "Resultado(s) de la búsqueda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Cambria", 9F);
            this.txtBusqueda.Location = new System.Drawing.Point(170, 135);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(143, 22);
            this.txtBusqueda.TabIndex = 137;
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion1.Location = new System.Drawing.Point(151, 113);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(204, 15);
            this.lblDescripcion1.TabIndex = 136;
            this.lblDescripcion1.Text = "Ingrese un valor para la búsqueda";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(115, 59);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(252, 15);
            this.lblDescripcion.TabIndex = 133;
            this.lblDescripcion.Text = "Seleccione una de las opciones de búsqueda";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(97, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 29);
            this.lblTitulo.TabIndex = 132;
            this.lblTitulo.Text = "CONSULTAR ESTADO";
            // 
            // rbtCedula
            // 
            this.rbtCedula.AutoSize = true;
            this.rbtCedula.Location = new System.Drawing.Point(260, 88);
            this.rbtCedula.Name = "rbtCedula";
            this.rbtCedula.Size = new System.Drawing.Size(76, 17);
            this.rbtCedula.TabIndex = 147;
            this.rbtCedula.TabStop = true;
            this.rbtCedula.Text = "Por cédula";
            this.rbtCedula.UseVisualStyleBackColor = true;
            this.rbtCedula.CheckedChanged += new System.EventHandler(this.rbtCedula_CheckedChanged);
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(150, 88);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(79, 17);
            this.rbtNombre.TabIndex = 146;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Por nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            this.rbtNombre.CheckedChanged += new System.EventHandler(this.rbtNombre_CheckedChanged);
            // 
            // FrmConsultarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 426);
            this.Controls.Add(this.rbtCedula);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPersonaSeleccionada);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbPersonasEncontradas);
            this.Controls.Add(this.lblDescripcion2);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblDescripcion1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmConsultarEstado";
            this.Text = "FrmConsultarEstado";
            this.Load += new System.EventHandler(this.FrmConsultarEstado_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonaSeleccionada;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbPersonasEncontradas;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtCedula;
        private System.Windows.Forms.RadioButton rbtNombre;
    }
}