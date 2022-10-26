using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.gestion_personal
{
    public partial class Agenda_Contactos : Form
    {
        public Agenda_Contactos()
        {
            InitializeComponent();
           
        }
        Master obj = new Master();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnContacto_Click(object sender, EventArgs e)
        {

            Mantenimiento_contactos hijo = new Mantenimiento_contactos(this);
           
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.UpdateEventHandler += F2_UpddateEventHandler1;
           hijo.ShowDialog();

            /*  AddOwnedForm(hijo);
              hijo.FormBorderStyle = FormBorderStyle.None;
              hijo.TopLevel = false;
              hijo.Dock = DockStyle.Fill;
              this.Controls.Add(hijo);
              this.Tag = hijo;
              hijo.BringToFront(); */

            
        }
           public DataTable ListarContactos()
           {

               DataTable Tabla = new DataTable();
               obj.VarCmd.Connection = BDcomun.ObtenerConexion();
               obj.VarCmd.CommandText = "ListarContactos";
               obj.VarCmd.CommandType = CommandType.StoredProcedure;
               obj.VarCmd.CommandType = CommandType.StoredProcedure;
               obj.VarReader = obj.VarCmd.ExecuteReader();
               Tabla.Load(obj.VarReader);
               obj.VarReader.Close();
               obj.VarCmd.Connection.Close();
               ; return Tabla;


           }

        public void ListarContacto()

        {
            DataGridViewU.DataSource = ListarContactos();
            
        }

        private void F2_UpddateEventHandler1(object sender,Mantenimiento_contactos.UpdateEventArgs args )
        {
            ListarContacto();

        }


        private void Agenda_Contactos_Load(object sender, EventArgs e)
        {
            ListarContacto();
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          DataView dv = ListarContactos().DefaultView;
            dv.RowFilter = string.Format("NOMBRES like '%{0}%'"+ 
                  " or CORREO like '%" + Txtbus.Text.Trim() + "%'" +
                    " or TELEFONO like '%" + Txtbus.Text.Trim() + "%'" +
                    " or MOTIVO like '%" + Txtbus.Text.Trim() + "%'", Txtbus.Text);
            DataGridViewU.DataSource = dv.ToTable();
            
        }

        private void BtnelimC_Click(object sender, EventArgs e)
        {

            string sql = "delete from contacto where idter=" + Txtbus.Text + "";
            obj.ManipularDB(sql);

            MessageBox.Show("Registro borrado...!");

           

        }
    }
}
