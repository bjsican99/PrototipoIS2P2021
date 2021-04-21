using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos
{
    public partial class frmMantenimientoAutor : Form
    {
        string UsuarioAplicacion;
        public frmMantenimientoAutor(string usuario)
        {
            InitializeComponent();
            rbHabilitado.Checked = true;
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            txtEstado.Text = "1";
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 302;
            navegador1.tbl = "autorpelicula";
            navegador1.campoEstado = "estadoAutor";

            //se agregan los componentes del formulario a la lista tipo control
            foreach (Control C in this.Controls)
            {
                if (C.Tag != null)
                {
                    if (C.Tag.ToString() == "saltar")
                    {

                    }
                    else
                    {
                        if (C is TextBox)
                        {
                            lista.Add(C);
                        }
                        else if (C is ComboBox)
                        {
                            lista.Add(C);
                        }
                        else if (C is DateTimePicker)
                        {
                            lista.Add(C);
                        }
                    }
                }
            }

            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvAutor;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "HTML/Ayudas.chm";
            navegador1.ruta = "Ayuda_Mantenimiento_Centros.html";
            rbHabilitado.Checked = true;
            rbDeshabilitado.Checked = false;
        }

        private void txtNombreAutor_TextChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void dtpFechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpFechanacimiento.Value.ToString(dtpFechanacimiento.CustomFormat = "yyyy-MM-dd");
            txtFechaNacimiento.Text = dtpFechanacimiento.Value.ToString(dtpFechanacimiento.CustomFormat = "yyyy-MM-dd");
        }

        private void rbHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbDeshabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }
    }
}
