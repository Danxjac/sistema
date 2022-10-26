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
    public partial class Historial_clinico : Form
    {
        public Historial_clinico()
        {
            InitializeComponent();
        }
        Master obj = new Master();
        private void Cmbjug_MouseClick(object sender, MouseEventArgs e)
        {
            if (Cmbjug.SelectedIndex == -1)
                return;
            else
            {

                string sql = "select i.nombre as nombre,i.idter as id,co.correo as correo,n.numtelefono as telefono,j.dorsal as dorsal," +

          " j.foto as foto , p.apellidos as apellido," +
      "p.fechanac as fechanac from mantjugador j" +
      " inner join tercero i on i.idter = j.idter" +
      " inner  join correo co on i.idter = co.idter" +
      " inner join telefono n on i.idter = n.idter" +
     " inner join persona p on i.idter = p.idter where j.idter = " + Cmbjug.SelectedValue.ToString() + "";


                obj.BuscarDatos(sql);

                if (obj.VarReader.Read())
                {


                    Lbd.Text = obj.VarReader["dorsal"].ToString();
                    Lbn.Text = obj.VarReader["nombre"].ToString();
                    Lb1.Text = obj.VarReader["apellido"].ToString();
                    Lb2.Text = obj.VarReader["fechanac"].ToString();
                    Lb3.Text = obj.VarReader["telefono"].ToString();
                    Lb4.Text = obj.VarReader["correo"].ToString();


                    byte[] img = (byte[])obj.VarReader["foto"];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    Pbjug.Image = Image.FromStream(ms);




                }



            }

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
            Cmbjug.DataSource = Listarjugador();
            Cmbjug.DisplayMember = "nombre";
            Cmbjug.ValueMember = "idter";

        }

        private void Historial_clinico_Load(object sender, EventArgs e)
        {
            Listarjug();
        }
    }
}
