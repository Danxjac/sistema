using DGVPrinterHelper;
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
    public partial class ingresos_gastos : Form
    {
        public ingresos_gastos()
        {
            InitializeComponent();
        }

        Master obj = new Master();

        private void buttonApunte_Click(object sender, EventArgs e)
        {
            ApunteIngGastos hijo = new ApunteIngGastos(this);
           
            hijo.UpdateEventHandler += F2_UpddateEventHandler1;
            hijo.ShowDialog();



            

        }
        private void F2_UpddateEventHandler1(object sender, ApunteIngGastos.UpdateEventArgs args)
        {
            ListarGasto();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresos_gastos_Load(object sender, EventArgs e)
        {
             ListarGasto();
           
        }

        public DataTable ListarBanco()
        {
            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarBanco";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;

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



       public DataTable ListarGastos()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarGastos";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }

        public void ListarGasto()

        {
            DataGridViewIng.DataSource = ListarGastos();

        }

        public void ImprimirIngresosGastos()
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
            Printer.PrintDataGridView(DataGridViewIng);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
            Informe.InformeIngresosGastos hijo = new Informe.InformeIngresosGastos();
            hijo.ShowDialog();
        }
    }
}
