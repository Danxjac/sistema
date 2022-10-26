using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SistemaGestionDeportiva.gestion_usuarios
{
    public partial class Lista_usuarios : Form
    {
        public Lista_usuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
          Mantenimiento_de_usuarios hijo = new Mantenimiento_de_usuarios();

            _ = hijo.ShowDialog();

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
          //  panelChildForm.Controls.Add(childForm);
           // panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Lista_usuarios_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }

        private void InsertarFilas()
        {
            dataGridViewU.Rows.Insert(0, "1", "Sandro", "Rodriguez", "AV. Brown", "675868676");

        }
           
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Mantenimiento_de_usuarios frm = new Mantenimiento_de_usuarios(); 
            if (dataGridViewU.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridViewU.CurrentRow.Cells[0].Value.ToString();
                frm.txtnombre.Text = dataGridViewU.CurrentRow.Cells[1].Value.ToString();
                frm.txtapellido.Text = dataGridViewU.CurrentRow.Cells[2].Value.ToString();
                frm.txtdireccion.Text = dataGridViewU.CurrentRow.Cells[3].Value.ToString();
                frm.txttelefono.Text = dataGridViewU.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
