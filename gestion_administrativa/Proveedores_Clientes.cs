using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.gestion_administrativa
{
    public partial class Proveedores_Clientes : Form
    {
        public Proveedores_Clientes()
        {
            InitializeComponent();
        }
        Master obj = new Master();

        private void Btnadds_Click(object sender, EventArgs e)
        {
            MantenimientoProvCli hijo = new MantenimientoProvCli(this);

            hijo.UpdateEventHandler += F2_UpddateEventHandler1;
            hijo.ShowDialog();
        }

        private void F2_UpddateEventHandler1(object sender, MantenimientoProvCli.UpdateEventArgs args)
        {
            ListarCliente();

        }

        public DataTable ListarClientes()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarClientes";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }

        public void ListarCliente()

        {
           DataGridViewCli.DataSource = ListarClientes();

        }





        private void Proveedores_Clientes_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
