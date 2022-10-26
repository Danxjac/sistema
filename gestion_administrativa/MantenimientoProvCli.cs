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
    public partial class MantenimientoProvCli : Form
    {
        public MantenimientoProvCli(Proveedores_Clientes cli)
        {
            InitializeComponent();
        }
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }



        Master obj = new Master();
        Proveedores_Clientes cli = new Proveedores_Clientes();

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void MantenimientoProvCli_Load(object sender, EventArgs e)
        {

        }

        public void InsertarCliente(int Id,string Nombre,
            string Apellidos,string Dni,DateTime Fecha, 
            string Correo,string Telefono,string Direccion,
            string Provincia, string Pais, string Actividad,string Cuenta)

        {

            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "InsertarClientes";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.Parameters.AddWithValue("@idter",Id);
            obj.VarCmd.Parameters.AddWithValue("@nombre",Nombre);
            obj.VarCmd.Parameters.AddWithValue("@apellidos", Apellidos);
            obj.VarCmd.Parameters.AddWithValue("@dni", Dni);
            obj.VarCmd.Parameters.AddWithValue("@fecha", Fecha);
            obj.VarCmd.Parameters.AddWithValue("@correo", Correo);
            obj.VarCmd.Parameters.AddWithValue("@numtelefono", Telefono);
            obj.VarCmd.Parameters.AddWithValue("@direccion", Direccion);
            obj.VarCmd.Parameters.AddWithValue("@provinvia", Provincia);
            obj.VarCmd.Parameters.AddWithValue("@pais", Pais);
            obj.VarCmd.Parameters.AddWithValue("@actividad", Actividad);
            obj.VarCmd.Parameters.AddWithValue("@cuenta", Cuenta);
            obj.VarCmd.ExecuteNonQuery();
            obj.VarCmd.Parameters.Clear();
        }
    
         private void BtnG_Click(object sender, EventArgs e)
        {
            Proveedores_Clientes cli = new Proveedores_Clientes();

            InsertarCliente(Convert.ToInt32(Txt1.Text),Txt2.Text,Txt3.Text,
                            Txt4.Text,Txt5.Value,Txt6.Text,
                            Txt7.Text,Txt8.Text,Txt9.Text,
                            Txt10.Text,Txt11.Text,Txt12.Text
                           
                            );

            cli.ListarClientes();
            MessageBox.Show("Se ha guardado con exito...!");
            Insert();



        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
