using CapaControlador;
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
    public partial class frmMantenimientoPelicula : Form
    {
        string UsuarioAplicacion;
        clsControlador controlador = new clsControlador();
        public frmMantenimientoPelicula(string usuario)
        {
            InitializeComponent();
            CargarCombobox();
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
            navegador1.aplicacion = 304;
            navegador1.tbl = "pelicula";
            navegador1.campoEstado = "estadoPelicula";

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
            navegador1.DatosActualizar = dgvPelicula;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "HTML/Ayudas.chm";
            navegador1.ruta = "Ayuda_Mantenimiento_Centros.html";
            rbHabilitado.Checked = true;
            rbDeshabilitado.Checked = false;
        }
        public void CargarCombobox()
        {
            //Autor
            cmbAutor.DisplayMember = "nombreAutor";
            cmbAutor.ValueMember = "pkIdAutor";
            cmbAutor.DataSource = controlador.funcObtenerCamposCombobox("pkIdAutor", "nombreAutor", "autorpelicula", "estadoAutor");
            cmbAutor.SelectedIndex = -1;
            //Categoria
            cmbCategoria.DisplayMember = "nombreCategoria";
            cmbCategoria.ValueMember = "pkIdCategoria";
            cmbCategoria.DataSource = controlador.funcObtenerCamposCombobox("pkIdCategoria", "nombreCategoria", "categoriapelicula", "estadoCategoria");
            cmbCategoria.SelectedIndex = -1;
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbDeshabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }

        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAutor.SelectedIndex != -1)
            {
                txtAutor.Text = cmbAutor.SelectedValue.ToString();
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex != -1)
            {
                txtCategoria.Text = cmbCategoria.SelectedValue.ToString();
            }
        }
    }
}
