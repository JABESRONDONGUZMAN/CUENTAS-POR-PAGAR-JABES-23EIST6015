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
    public partial class FINICIO : Form
    {
        string USUARIO, CLAVE;

        public FINICIO()
        {
            InitializeComponent();
        }

        private void BENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow FILA = DAGVUSUARIOS.CurrentRow;
                // Para copiar los valores de las columnas en las variables US y CL
                string US = Convert.ToString(FILA.Cells[0].Value);
                string CL = Convert.ToString(FILA.Cells[1].Value);

                // Para validar el usuario y la contraseña
                if (TUSUARIO.Text == US && TCLAVE.Text == CL)
                {
                    FMENUPRI FP = new FMENUPRI();
                    FP.Show();
                }
                else
                {
                    // Si dejó los campos en blanco.
                    MessageBox.Show("DEBE ESCRIBIR EL NOMBRE DEL USUARIO Y CONTRASEÑA");
                }
            }
            catch
            {
                // Si el usuario o la contraseña no coinciden o son incorrectos
                MessageBox.Show("USUARIO O CONTRASEÑA INVÁLIDOS");
                TUSUARIO.Focus();
            }
        }

        private void TUSUARIO_TextChanged(object sender, EventArgs e)
        {
            //Para invocar el método BUSCAR USUARIO
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORUSUARIO(TUSUARIO.Text);
        }

        private void TCLAVE_TextChanged(object sender, EventArgs e)
        {
            //Para invocar el método BUSCAR CLAVE
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORCLAVE(TCLAVE.Text);
        }

        private void DAGVUSUARIOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FINICIO_Load(object sender, EventArgs e)
        {
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.MOSTRAR();
            // Para ocultar la clave.
            DAGVUSUARIOS.Columns[1].Visible = false;
            // Disfrazar los caracteres escritos en el TextBox TCLAVE
            TCLAVE.PasswordChar = '*';
        }
    }
}
