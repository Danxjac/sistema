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
    public partial class ApunteIngGastos : Form
    {
        public ApunteIngGastos(ingresos_gastos ing)
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
         ingresos_gastos ing = new ingresos_gastos();

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        public void InsertarGasto(DateTime Fecha,int Origen, int Tipo, string Descripcion, double Importe, string Marca, int Banco)
            
        {

            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "InsertarGastos";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.Parameters.AddWithValue("@fecha", Fecha);
            obj.VarCmd.Parameters.AddWithValue("@origen",Origen);
            obj.VarCmd.Parameters.AddWithValue("@tipo", Tipo);
            obj.VarCmd.Parameters.AddWithValue("@descripcion", Descripcion);
            obj.VarCmd.Parameters.AddWithValue("@importe",Importe);
            obj.VarCmd.Parameters.AddWithValue("@marca", Marca);
            obj.VarCmd.Parameters.AddWithValue("@banco", Banco);
            obj.VarCmd.ExecuteNonQuery();
            obj.VarCmd.Parameters.Clear();



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApunteIngGastos_Load(object sender, EventArgs e)
        {
            ListarBancos();
            ListarOrigen();
            ListarTipos();

        }

        private void ListarOrigen()
        {
            Cmborigen.DataSource = ing.ListarOrig();
            Cmborigen.DisplayMember = "origen";
            Cmborigen.ValueMember = "idorigen";
        }
        private void ListarTipos()
        {
            Cmbtipo.DataSource = ing.ListarTipo();
            Cmbtipo.DisplayMember = "tipo";
            Cmbtipo.ValueMember = "idtipo";
        }
        private void ListarBancos()
        {
            Cmbbanco.DataSource = ing.ListarBanco();
            Cmbbanco.DisplayMember = "banco";
            Cmbbanco.ValueMember = "idbanco";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
             ingresos_gastos ing = new ingresos_gastos();
            
            Txtdate.Text =Convert.ToString(DateTime.Now);
            InsertarGasto(Txtdate.Value,
                             Convert.ToInt32(Cmborigen.SelectedValue),
                            Convert.ToInt32(Cmbtipo.SelectedValue),
                             Txtdes.Text,
                            Convert.ToDouble(Txtimporte.Text),
                            Txtmarca.Text,
                           Convert.ToInt32(Cmbbanco.SelectedValue));

           ing.ListarGastos();
            MessageBox.Show("Se ha guardado con exito...!");
           Insert();




            

        }
    }
    
}
