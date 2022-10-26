using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.jugadores
{
    public partial class Control_Asistencia : Form
    {
        public Control_Asistencia()
        {
            InitializeComponent();
         
          
         
            
           
        }
        Master obj = new Master();
        private void dataGridViewP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.VarCmd = new System.Data.SqlClient.SqlCommand("insert into Asist values (@Tipo,@observaciones," +
                         "@Avisa,@Asiste,@Jugador,@Id,@Fechaasist)",BDcomun.ObtenerConexion());
            
            try
            {
             foreach(DataGridViewRow row in DataGridViewAS.Rows)
                {
                    obj.VarCmd.Parameters.Clear();

                    obj.VarCmd.Parameters.AddWithValue("@Tipo",Convert.ToString(row.Cells["column2"].Value));
                    obj.VarCmd.Parameters.AddWithValue("@Observaciones", Convert.ToString(row.Cells["column3"].Value));
                    obj.VarCmd.Parameters.AddWithValue("@Avisa", Convert.ToString(row.Cells["column4"].Value));
                    obj.VarCmd.Parameters.AddWithValue("@Asiste", Convert.ToString(row.Cells["column5"].Value));
                    obj.VarCmd.Parameters.AddWithValue("@Jugador", Convert.ToString(row.Cells["Jugador"].Value));
                    obj.VarCmd.Parameters.AddWithValue("@Id", Convert.ToString(row.Cells["Id"].Value));
                    obj.VarCmd.Parameters.AddWithValue("@Fechaasist",Txtfnac.Value);
                    obj.VarCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Datos guardados");
            }
            catch(Exception ex)

            {
                MessageBox.Show("error al agregar"+ex);
            }
            finally
            {
               
                BDcomun.ObtenerConexion().Close();
            }
        }


        public DataTable ListarNombre()
        {
            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarNombre";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;
        }



        public DataTable ListarAsistencia()
        {
            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "ListarAsistencia";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;
        }

        private void ListarAsistencias()
        {
           Column2.DataSource  =ListarAsistencia();

            Column2.DisplayMember = "tipoasist";
          
        }
        


        
        private void Control_Asistencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDdeportivoDataSet.ListarAsistencia' Puede moverla o quitarla según sea necesario.
          //  this.listarAsistenciaTableAdapter.Fill(this.bDdeportivoDataSet.ListarAsistencia);
            ListarAsistencias();
            DataGridViewAS.DataSource = ListarNombre();
        }
    }
}
