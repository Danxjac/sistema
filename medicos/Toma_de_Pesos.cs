using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.medicos
{
    public partial class Toma_de_Pesos : Form
    {
        public Toma_de_Pesos()
        {
            InitializeComponent();
        }
        Master obj = new Master();

        private void Toma_de_Pesos_Load(object sender, EventArgs e)
        {
            ListarEquipos();
        }


        public DataTable ListarEquipo()
        {
            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarEquipo";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;
        }
        private void ListarEquipos()
        {
            Cmb11.DataSource = ListarEquipo();
            Cmb11.DisplayMember = "tipo_equipo";
            Cmb11.ValueMember = "idtipoEquipo";
        }
    }
}
