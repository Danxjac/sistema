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

namespace SistemaGestionDeportiva.gestion_personal
{
    public partial class Lista_personal : Form          
    {
        public Lista_personal()
        {
            InitializeComponent();
        }
        Master obj = new Master();
        private void Lista_personal_Load(object sender, EventArgs e)
        {
            ListarPersonal();
          //  Cmbp.SelectedIndex = 1;
        }

        private void BtnNuevoP_Click(object sender, EventArgs e)
        {
            Mantenimiento_personal hijo = new Mantenimiento_personal(this);

            hijo.UpdateEventHandler += F2_UpddateEventHandler1;
            hijo.ShowDialog();
        }

        private void F2_UpddateEventHandler1(object sender, Mantenimiento_personal.UpdateEventArgs args)
        {
            ListarPersonal();

        }


        public DataTable ListarPuesto()
        {
            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarPuesto";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;
        }


        public DataTable ListarPersonales()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarPersonales";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }

        public void ListarPersonal()

        {
            DataGridViewPer.DataSource = ListarPersonales();

        }


        public void ImprimirPersonal()
        {
            DGVPrinter Printer = new DGVPrinter();
            Printer.Title = "Reporte de Personal";
            Printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "Sistema de Gestion DePortivo";
            Printer.FooterSpacing = 15;
            Printer.PrintDataGridView(DataGridViewPer);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
            Informe.InformePersonal hijo = new Informe.InformePersonal();
            hijo.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Cmbp.SelectedIndex = 1;
            DataView dv = ListarPersonales().DefaultView;
           // dv.RowFilter = string.Format("{0}",Cmbp.Text);
            DataGridViewPer.DataSource = dv.ToTable();

        }

        private void BtneliminarP_Click(object sender, EventArgs e)
        {
        /*    DataGridViewPer.Rows.Remove(DataGridViewPer.CurrentRow);
       //   string eliminar = "delete tercero where idter="+ListarPersonales().Rows.;
          //  obj.BuscarDatos(eliminar);
            MessageBox.Show("Registro eliminado correctamente");*/
                
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
        

        }

    }
}

