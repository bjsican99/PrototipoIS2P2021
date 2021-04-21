
namespace CapaVista.Mantenimientos
{
    partial class frmMantenimientoAutor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.txtIdAutor = new System.Windows.Forms.TextBox();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.txtApellidoAutor = new System.Windows.Forms.TextBox();
            this.dtpFechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.rbHabilitado = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 96);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(99, 198);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(107, 322);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(48, 16);
            this.Estado.TabIndex = 5;
            this.Estado.Text = "Estado";
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAutor.Location = new System.Drawing.Point(162, 195);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Size = new System.Drawing.Size(72, 23);
            this.txtIdAutor.TabIndex = 6;
            this.txtIdAutor.Tag = "pkIdAutor";
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAutor.Location = new System.Drawing.Point(162, 223);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(200, 23);
            this.txtNombreAutor.TabIndex = 7;
            this.txtNombreAutor.Tag = "nombreAutor";
            this.txtNombreAutor.TextChanged += new System.EventHandler(this.txtNombreAutor_TextChanged);
            // 
            // txtApellidoAutor
            // 
            this.txtApellidoAutor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAutor.Location = new System.Drawing.Point(162, 253);
            this.txtApellidoAutor.Name = "txtApellidoAutor";
            this.txtApellidoAutor.Size = new System.Drawing.Size(200, 23);
            this.txtApellidoAutor.TabIndex = 8;
            this.txtApellidoAutor.Tag = "apellidoAutor";
            // 
            // dtpFechanacimiento
            // 
            this.dtpFechanacimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechanacimiento.Location = new System.Drawing.Point(162, 282);
            this.dtpFechanacimiento.Name = "dtpFechanacimiento";
            this.dtpFechanacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechanacimiento.TabIndex = 9;
            this.dtpFechanacimiento.Tag = "saltar";
            this.dtpFechanacimiento.ValueChanged += new System.EventHandler(this.dtpFechanacimiento_ValueChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(368, 284);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(44, 23);
            this.txtFechaNacimiento.TabIndex = 10;
            this.txtFechaNacimiento.Tag = "fechaNacimiento";
            this.txtFechaNacimiento.Visible = false;
            // 
            // rbHabilitado
            // 
            this.rbHabilitado.AutoSize = true;
            this.rbHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbHabilitado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHabilitado.Location = new System.Drawing.Point(161, 322);
            this.rbHabilitado.Name = "rbHabilitado";
            this.rbHabilitado.Size = new System.Drawing.Size(85, 20);
            this.rbHabilitado.TabIndex = 11;
            this.rbHabilitado.TabStop = true;
            this.rbHabilitado.Tag = "saltar";
            this.rbHabilitado.Text = "Habilitado";
            this.rbHabilitado.UseVisualStyleBackColor = false;
            this.rbHabilitado.CheckedChanged += new System.EventHandler(this.rbHabilitado_CheckedChanged);
            // 
            // rbDeshabilitado
            // 
            this.rbDeshabilitado.AutoSize = true;
            this.rbDeshabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbDeshabilitado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeshabilitado.Location = new System.Drawing.Point(257, 322);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(105, 20);
            this.rbDeshabilitado.TabIndex = 12;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Tag = "saltar";
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = false;
            this.rbDeshabilitado.CheckedChanged += new System.EventHandler(this.rbDeshabilitado_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(162, 348);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 23);
            this.txtEstado.TabIndex = 13;
            this.txtEstado.Tag = "estadoAutor";
            this.txtEstado.Visible = false;
            // 
            // dgvAutor
            // 
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Location = new System.Drawing.Point(445, 126);
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.Size = new System.Drawing.Size(599, 325);
            this.dgvAutor.TabIndex = 14;
            // 
            // frmMantenimientoAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.Mantenimiento_Centro_1141515;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 559);
            this.Controls.Add(this.dgvAutor);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbDeshabilitado);
            this.Controls.Add(this.rbHabilitado);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.dtpFechanacimiento);
            this.Controls.Add(this.txtApellidoAutor);
            this.Controls.Add(this.txtNombreAutor);
            this.Controls.Add(this.txtIdAutor);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.navegador1);
            this.DoubleBuffered = true;
            this.Name = "frmMantenimientoAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0302-Mantenimiento Autor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.TextBox txtIdAutor;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.TextBox txtApellidoAutor;
        private System.Windows.Forms.DateTimePicker dtpFechanacimiento;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.RadioButton rbHabilitado;
        private System.Windows.Forms.RadioButton rbDeshabilitado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvAutor;
    }
}