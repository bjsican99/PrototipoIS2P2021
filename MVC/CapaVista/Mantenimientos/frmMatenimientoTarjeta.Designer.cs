
namespace CapaVista
{
    partial class frmMantenmientoTarjeta
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
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.CUI = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtIdTarjeta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtFechanacimiento = new System.Windows.Forms.TextBox();
            this.txtCui = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dgvTarjeta = new System.Windows.Forms.DataGridView();
            this.rbHabilitado = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(8, 9);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 92);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(93, 133);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(64, 16);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID Tarjeta";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(58, 168);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(99, 16);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre Cliente";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.BackColor = System.Drawing.Color.Transparent;
            this.lblapellido.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(57, 199);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(100, 16);
            this.lblapellido.TabIndex = 4;
            this.lblapellido.Text = "Apellido Cliente";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(46, 232);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 16);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // CUI
            // 
            this.CUI.AutoSize = true;
            this.CUI.BackColor = System.Drawing.Color.Transparent;
            this.CUI.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUI.Location = new System.Drawing.Point(126, 260);
            this.CUI.Name = "CUI";
            this.CUI.Size = new System.Drawing.Size(31, 16);
            this.CUI.TabIndex = 6;
            this.CUI.Text = "CUI";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(32, 290);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(125, 16);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Numero De Telefono";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(40, 323);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(117, 16);
            this.lblemail.TabIndex = 15;
            this.lblemail.Text = "Correo Electronico";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(105, 358);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(52, 16);
            this.lblusuario.TabIndex = 16;
            this.lblusuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(82, 386);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 16);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(109, 418);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 16);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // txtIdTarjeta
            // 
            this.txtIdTarjeta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTarjeta.Location = new System.Drawing.Point(163, 130);
            this.txtIdTarjeta.Name = "txtIdTarjeta";
            this.txtIdTarjeta.Size = new System.Drawing.Size(80, 23);
            this.txtIdTarjeta.TabIndex = 19;
            this.txtIdTarjeta.Tag = "pkIdTarjeta";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(163, 165);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 23);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.Tag = "nombreCliente";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(163, 196);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(199, 23);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.Tag = "apellidoCliente";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(162, 227);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaNacimiento.TabIndex = 22;
            this.dtpFechaNacimiento.Tag = "saltar";
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // txtFechanacimiento
            // 
            this.txtFechanacimiento.Enabled = false;
            this.txtFechanacimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechanacimiento.Location = new System.Drawing.Point(368, 229);
            this.txtFechanacimiento.Name = "txtFechanacimiento";
            this.txtFechanacimiento.Size = new System.Drawing.Size(37, 23);
            this.txtFechanacimiento.TabIndex = 23;
            this.txtFechanacimiento.Tag = "fechaNacimiento";
            this.txtFechanacimiento.Visible = false;
            // 
            // txtCui
            // 
            this.txtCui.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCui.Location = new System.Drawing.Point(163, 257);
            this.txtCui.Name = "txtCui";
            this.txtCui.Size = new System.Drawing.Size(199, 23);
            this.txtCui.TabIndex = 24;
            this.txtCui.Tag = "CUI";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(163, 287);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(199, 23);
            this.txtTelefono.TabIndex = 25;
            this.txtTelefono.Tag = "telefonoCliente";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(163, 320);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(199, 23);
            this.txtCorreo.TabIndex = 26;
            this.txtCorreo.Tag = "emailCliente";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(162, 355);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 23);
            this.txtUsuario.TabIndex = 27;
            this.txtUsuario.Tag = "usuarioCliente";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(163, 383);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(199, 23);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.Tag = "passwordCliente";
            // 
            // dgvTarjeta
            // 
            this.dgvTarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjeta.Location = new System.Drawing.Point(430, 126);
            this.dgvTarjeta.Name = "dgvTarjeta";
            this.dgvTarjeta.Size = new System.Drawing.Size(611, 334);
            this.dgvTarjeta.TabIndex = 32;
            // 
            // rbHabilitado
            // 
            this.rbHabilitado.AutoSize = true;
            this.rbHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbHabilitado.Location = new System.Drawing.Point(163, 418);
            this.rbHabilitado.Name = "rbHabilitado";
            this.rbHabilitado.Size = new System.Drawing.Size(72, 17);
            this.rbHabilitado.TabIndex = 34;
            this.rbHabilitado.TabStop = true;
            this.rbHabilitado.Tag = "saltar";
            this.rbHabilitado.Text = "Habilitado";
            this.rbHabilitado.UseVisualStyleBackColor = false;
            // 
            // rbDeshabilitado
            // 
            this.rbDeshabilitado.AutoSize = true;
            this.rbDeshabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbDeshabilitado.Location = new System.Drawing.Point(241, 417);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(89, 17);
            this.rbDeshabilitado.TabIndex = 35;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Tag = "saltar";
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(163, 441);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 36;
            this.txtEstado.Tag = "estadoCliente";
            this.txtEstado.Visible = false;
            // 
            // frmMantenmientoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.Mantenimiento_Centro_1141515;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 568);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbDeshabilitado);
            this.Controls.Add(this.rbHabilitado);
            this.Controls.Add(this.dgvTarjeta);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCui);
            this.Controls.Add(this.txtFechanacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdTarjeta);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.CUI);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.navegador1);
            this.DoubleBuffered = true;
            this.Name = "frmMantenmientoTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0301-Mantenimiento Tarjeta";
            this.Load += new System.EventHandler(this.frmMantenmientoPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label CUI;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtIdTarjeta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtFechanacimiento;
        private System.Windows.Forms.TextBox txtCui;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dgvTarjeta;
        private System.Windows.Forms.RadioButton rbHabilitado;
        private System.Windows.Forms.RadioButton rbDeshabilitado;
        private System.Windows.Forms.TextBox txtEstado;
    }
}