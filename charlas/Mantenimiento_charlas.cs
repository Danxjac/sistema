using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.charlas
{
    public partial class Mantenimiento_charlas : Form
    {
        public Mantenimiento_charlas()
        {
            InitializeComponent();
        }
        Master obj = new Master();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mantenimiento_charlas_Load(object sender, EventArgs e)
        {
            Listarjug();
        }

        public DataTable Listarjugador()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "Listarjugadores";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }

        private void Listarjug()
        {
            Checklist.DataSource = Listarjugador();
            Checklist.DisplayMember = "nombre";
            Checklist.ValueMember = "idter";

        }
    }
}
