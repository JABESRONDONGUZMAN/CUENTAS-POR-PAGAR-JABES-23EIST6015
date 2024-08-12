using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTAS_POR_PAGAR_JABES_23EIST6015
{
    public partial class FPROVEEDORES : Form
    {

        public FPROVEEDORES()
        {
            InitializeComponent();
        }

        private void FPROVEEDORES_Load(object sender, EventArgs e)
        {
            // Cargar los datos de los proveedores en el DataGridView
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();

            // Ocultar la columna "FACTURAS"
            DGVPROVEEDORES.Columns["FACTURAS"].Visible = false;

        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {

        }

        private void DGVPROVEEDORES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            // Recolectar datos desde los TextBoxs
            string codigo = TCODIGO.Text;
            string nombres = TNOMBRE.Text;
            string apellidos = TAPELLIDO.Text;
            string direccion = TDIRECCION.Text;
            string ciudad = TCIUDAD.Text;
            string telefono = TTELEFONO.Text;

            // Llamar al método para insertar un nuevo proveedor
            DATOSPROVEEDORES.INSERTARPROVEEDOR(codigo, nombres, apellidos, direccion, ciudad, telefono);

            // Actualizar el DataGridView después de agregar el proveedor
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();

            // Limpiar los TextBoxs después de la operación
            TCODIGO.Clear();
            TNOMBRE.Clear();
            TAPELLIDO.Clear();
            TDIRECCION.Clear();
            TCIUDAD.Clear();
            TTELEFONO.Clear();
        }

        private void TNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
