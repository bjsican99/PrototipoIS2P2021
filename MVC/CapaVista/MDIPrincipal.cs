using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaVistaSeguridad;
using CapaVistaSeguridad.Formularios;
using CapaVistaSeguridad.Formularios.Mantenimientos;

namespace CapaVista
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;
        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();//instancia para los permisos por aplicacion
        clsVistaBitacora bit = new clsVistaBitacora();//instancia para la bitacora.
        VariableGlobal glo = new VariableGlobal();
        public MDIPrincipal()
        {
            InitializeComponent();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Cerrar Secion
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = frm.usuario();
                glo.usuariog = txtusuario.Text;
            }
        }
        //Cuando Abre la ventana
        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = frm.usuario();
                glo.usuariog = txtusuario.Text;
            }

        }
        //Mantenimiento Usuario-0002
        private void mantenimientoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso A Mantenimiento Usuario", 2);
                frmMantenimientoUsuario mantenimientoUsuario = new frmMantenimientoUsuario(txtusuario.Text);
                mantenimientoUsuario.MdiParent = this;
                mantenimientoUsuario.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de ingresar a Mantenimiento Usuario", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Para el mantenimiento-0003
        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso A Mantenimiento Aplicaciones", 3);
                frmMantenimiento mantenimiento = new frmMantenimiento(txtusuario.Text);
                mantenimiento.MdiParent = this;
                mantenimiento.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de Ingresar A Mantenimiento Aplicaciones", 3);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Mantenimiento Perfil-0004
        private void mantenimientoAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("4", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso a Mantenimiento Perfil", 4);
                frmMantenimientoPerfil perfil = new frmMantenimientoPerfil(txtusuario.Text);
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de Ingresar A Mantenimiento Modulo", 4);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Asignacion De Aplicacion a Perfil-0005
        private void asignacionDeAplicacionAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("5", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso a Asignacion de Aplicaciones a Perfil", 5);
                frmAsignarAplicacionesAPerfil perfil = new frmAsignarAplicacionesAPerfil();
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de Ingresar A Asignacion de Aplicaciones a perfil", 5);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Asignacion DE Perfil-0006
        private void asignacionPerfilYAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("6", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("Ingreso a Asignacion de Perfil y Aplicaciones", 6);
                frmAsignacionDeAplicaciones perfil = new frmAsignacionDeAplicaciones();
                perfil.MdiParent = this;
                perfil.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de Ingresar a Asignacion de perfil y aplicaciones", 6);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Mantenimiento Modulo-0008
        private void mantenimientoModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("8", txtusuario.Text) == 1)
            {
                bit.user(txtusuario.Text);
                bit.insert("ingreso a Mantenimiento Modulo", 8);
                frmModulo modulo = new frmModulo(txtusuario.Text);
                modulo.MdiParent = this;
                modulo.Show();
            }
            else
            {
                bit.user(txtusuario.Text);
                bit.insert("Trato de Ingresar A Mantenimiento Modulo", 8);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Cambio De Contrasaeña-0011
        private void cambioDeContrasenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioContraseña frmCambioContraseña = new frmCambioContraseña(txtusuario.Text);
            frmCambioContraseña.MdiParent = this;
            frmCambioContraseña.Show();
            bit.user(txtusuario.Text);
            bit.insert("Ingreso A Cambio de Contraseña", 11);
        }


        //Mantenimiento Aplicaciones
        private void mantenimiendoAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
