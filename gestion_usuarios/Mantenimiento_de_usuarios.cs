using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.gestion_usuarios
{
    public partial class Mantenimiento_de_usuarios : Form
    {
        public Mantenimiento_de_usuarios()
        {
            InitializeComponent();
        }
       Master obj = new Master();

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mantenimiento_de_usuarios_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == TxtConfirmarContrasena.Text)
            {

                if (ClassUsuario.CrearCuentas(TxtUsuario.Text, TxtContrasena.Text) > 0)
                {
                    MessageBox.Show("Cuentas Creada con exito...!");
                }
                else
                {
                    MessageBox.Show("No se pudo crear la cuenta");
                }
                this.Hide();
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
