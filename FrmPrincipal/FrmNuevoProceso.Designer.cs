namespace FrmPrincipal
{
    partial class FrmNuevoProceso
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
            this.cbxTipoContrato = new System.Windows.Forms.ComboBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblTituloPersona = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEnviarDatos = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxTipoContrato
            // 
            this.cbxTipoContrato.FormattingEnabled = true;
            this.cbxTipoContrato.Location = new System.Drawing.Point(184, 190);
            this.cbxTipoContrato.Name = "cbxTipoContrato";
            this.cbxTipoContrato.Size = new System.Drawing.Size(126, 21);
            this.cbxTipoContrato.TabIndex = 110;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(184, 163);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(126, 21);
            this.cbxDepartamento.TabIndex = 109;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(142, 139);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(168, 20);
            this.txbTitulo.TabIndex = 108;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(142, 87);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(168, 20);
            this.txbNombre.TabIndex = 106;
            // 
            // txbCedula
            // 
            this.txbCedula.Location = new System.Drawing.Point(142, 63);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(168, 20);
            this.txbCedula.TabIndex = 105;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoContrato.Location = new System.Drawing.Point(85, 192);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(88, 15);
            this.lblTipoContrato.TabIndex = 104;
            this.lblTipoContrato.Text = "Tipo contrato:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(85, 165);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(95, 15);
            this.lblDepartamento.TabIndex = 103;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblTituloPersona
            // 
            this.lblTituloPersona.AutoSize = true;
            this.lblTituloPersona.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPersona.Location = new System.Drawing.Point(85, 141);
            this.lblTituloPersona.Name = "lblTituloPersona";
            this.lblTituloPersona.Size = new System.Drawing.Size(46, 15);
            this.lblTituloPersona.TabIndex = 102;
            this.lblTituloPersona.Text = "Titulo:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(85, 65);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(51, 15);
            this.lblCedula.TabIndex = 100;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(85, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 99;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(83, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 29);
            this.lblTitulo.TabIndex = 98;
            this.lblTitulo.Text = "NUEVO PROCESO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(258, 230);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(73, 29);
            this.btnCerrar.TabIndex = 116;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEnviarDatos
            // 
            this.btnEnviarDatos.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnEnviarDatos.Location = new System.Drawing.Point(168, 230);
            this.btnEnviarDatos.Name = "btnEnviarDatos";
            this.btnEnviarDatos.Size = new System.Drawing.Size(74, 29);
            this.btnEnviarDatos.TabIndex = 115;
            this.btnEnviarDatos.Text = "ENVIAR";
            this.btnEnviarDatos.UseVisualStyleBackColor = true;
            this.btnEnviarDatos.Click += new System.EventHandler(this.btnEnviarDatos_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnLimpiarCampos.Location = new System.Drawing.Point(76, 224);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 40);
            this.btnLimpiarCampos.TabIndex = 114;
            this.btnLimpiarCampos.Text = "LIMPIAR CAMPOS";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(85, 116);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 15);
            this.lblApellido.TabIndex = 101;
            this.lblApellido.Text = "Apellido:";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(142, 114);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(168, 20);
            this.txbApellido.TabIndex = 107;
            // 
            // FrmNuevoProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 280);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEnviarDatos);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.cbxTipoContrato);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCedula);
            this.Controls.Add(this.lblTipoContrato);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblTituloPersona);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmNuevoProceso";
            this.Text = "Registro de un nuevo proceso de contración";
            this.Load += new System.EventHandler(this.FrmNuevoProceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoContrato;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblTituloPersona;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEnviarDatos;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txbApellido;
    }
}