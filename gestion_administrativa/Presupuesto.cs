using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionDeportiva.Informe;




namespace SistemaGestionDeportiva.gestion_administrativa
{
    public partial class Presupuesto : Form
    {
        public Presupuesto()
        {
            InitializeComponent();
        }
        Master obj = new Master();
        private void Btnadd_Click(object sender, EventArgs e)
        {
            Mantenimiento_Presupuestos hijo = new Mantenimiento_Presupuestos(this);
            hijo.UpdateEventHandler += F2_UpddateEventHandler1;
            hijo.ShowDialog();
        }

        private void F2_UpddateEventHandler1(object sender, Mantenimiento_Presupuestos.UpdateEventArgs args)
        {
            ListarPresupuesto();
            SumarGastos();
            SumarIngresos();

        }

        








        public DataTable ListarOrig()
        {
            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarOrigen";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;
        }
        public DataTable ListarTipo()
        {
            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarTipo";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;
        }

        public DataTable ListarPresupuestos()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarPresupuestos";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }

        public void ListarPresupuesto()

        {
            DataGridViewPre.DataSource = ListarPresupuestos();

        }

        public void SumarGastos()
        {


            int Suma = 0;
            for (int i = 0; i <= DataGridViewPre.Rows.Count - 1; i++)
            {
                if (int.Parse(DataGridViewPre.Rows[i].Cells[4].Value.ToString())< 0)
                {

                    Suma += int.Parse(DataGridViewPre.Rows[i].Cells[4].Value.ToString());
                }

            }
            Txttotgas.Text = Suma.ToString();
        }


        public void SumarIngresos()
        {

            
            int Suma = 0;
            for (int i = 0; i <= DataGridViewPre.Rows.Count-1 ; i++)
            {
                if (int.Parse(DataGridViewPre.Rows[i].Cells[4].Value.ToString()) >= 0)
                {

                    Suma += int.Parse(DataGridViewPre.Rows[i].Cells[4].Value.ToString());
                }
             
            }
            Txttoting.Text = Suma.ToString();
        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {
            ListarPresupuesto();
            SumarIngresos();
            SumarGastos();
            ListarO();
            ListarT();
         
        }

        private void ListarO()
        {
            Cmbor.DataSource = ListarOrig();
            Cmbor.DisplayMember = "origen";
            Cmbor.ValueMember = "idorigen";
        }
        private void ListarT()
        {
            Cmbti.DataSource = ListarTipo();
            Cmbti.DisplayMember = "tipo";
            Cmbti.ValueMember = "idtipo";
        }

        public void ImprimirPresupuestos()
        {
            DGVPrinter Printer = new DGVPrinter();
            Printer.Title = "Reporte Presupuestos";
            Printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "Sistema de Gestion DePortivo";
            Printer.FooterSpacing = 15;
            Printer.PrintDataGridView(DataGridViewPre);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
           InformePresupuesto hijo = new InformePresupuesto();
           
           
            hijo.ShowDialog();
            
        }

        private void Txttoting_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
