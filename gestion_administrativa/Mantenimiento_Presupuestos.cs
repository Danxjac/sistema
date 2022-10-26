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
    public partial class Mantenimiento_Presupuestos : Form
    {
        public Mantenimiento_Presupuestos(Presupuesto pre )
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
        Presupuesto pre = new Presupuesto();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void InsertarPresupuesto( int Origen, int Tipo, double Presupuesto,double Adaptado)

        {

            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "InsertarPresupuestos";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.Parameters.AddWithValue("@origen", Origen);
            obj.VarCmd.Parameters.AddWithValue("@tipo", Tipo);
            obj.VarCmd.Parameters.AddWithValue("@presupuesto", Presupuesto);
            obj.VarCmd.Parameters.AddWithValue("@Adaptado",Adaptado);
            obj.VarCmd.ExecuteNonQuery();
            obj.VarCmd.Parameters.Clear();



        }

        private void ListarOrigen()
        {
            Cmbo.DataSource = pre.ListarOrig();
            Cmbo.DisplayMember = "origen";
            Cmbo.ValueMember = "idorigen";
        }
        private void ListarTipos()
        {
            Cmbt.DataSource = pre.ListarTipo();
            Cmbt.DisplayMember = "tipo";
            Cmbt.ValueMember = "idtipo";
        }


        private void Mantenimiento_Presupuestos_Load(object sender, EventArgs e)
        {
            
            ListarOrigen();
            ListarTipos();

        }

        private void BtnGuardarp_Click(object sender, EventArgs e)
        {
            Presupuesto pre = new Presupuesto();

            
            InsertarPresupuesto(
                             Convert.ToInt32(Cmbo.SelectedValue),
                            Convert.ToInt32(Cmbt.SelectedValue),
                            Convert.ToDouble(Txtpre.Text),
                           Convert.ToDouble(Txtadap.Text));

            pre.ListarPresupuestos();
            MessageBox.Show("Se ha guardado con exito...!");
            Insert();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
