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

namespace CapaVista
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;


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
          
        }
        //Cuando Abre la ventana
        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            
        }
        //Mantenimiento Usuario-0002
        private void mantenimientoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        //Para el mantenimiento-0003
        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //Mantenimiento Perfil-0004
        private void mantenimientoAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //Asignacion De Aplicacion a Perfil-0005
        private void asignacionDeAplicacionAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //Asignacion DE Perfil-0006
        private void asignacionPerfilYAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //Mantenimiento Modulo-0008
        private void mantenimientoModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //Cambio De Contrasaeña-0011
        private void cambioDeContrasenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //Mantenimiento Aplicaciones
        private void mantenimiendoAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
