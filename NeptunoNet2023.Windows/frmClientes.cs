using NeptunoNet2023.Entidades.Dtos;
using NeptunoNet2023.Entidades.Entidades;
using NeptunoNet2023.Servicios.Servicios;
using NeptunoNet2023.Windows.Helpers;
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
    public partial class frmClientes : Form
    {
        private readonly ServicioClientes _serviciosClientes;
        private List<ClienteDto> listaCliente;
        public frmClientes()
        {
            InitializeComponent();
            _serviciosClientes = new ServicioClientes();
        }
       
        

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                listaCliente = _serviciosClientes.GetAll();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (var item in listaCliente)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, item);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
