using NeptunoNet2023.Entidades.Entidades;
using NeptunoNet2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptunoNet2023.Windows
{
    public partial class frmCategoriaAE : Form
    {
        private readonly IServicioCategoria _servicio;
        public frmCategoriaAE(IServicioCategoria servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }
        private Categoria categoria;
        internal Categoria GetAll()
        {
            return categoria;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (categoria != null)
            {
                txtCategoria.Text = categoria.NombreCategoria;
                txtDescripcion.Text = categoria.Descripcion;

            }
        }

        private void frmCategoriaAE_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (categoria == null)
                {
                    categoria = new Categoria();

                }
                categoria.NombreCategoria = txtCategoria.Text;
                categoria.Descripcion = txtDescripcion.Text;


                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                valido = false;
                errorProvider1.SetError(txtCategoria, "Debe ingresar una categoria");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "Debe colocar una descripcion para la categoria ");
            }

            return valido;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void SetCategoria(Categoria categoria)
        {
           this.categoria= categoria;   
        }
    }
}
