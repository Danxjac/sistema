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
    public partial class Sanciones : Form
    {
        public Sanciones()
        {
            InitializeComponent();
            ListBox1.Visible = false;
        }
        Master obj = new Master();
        private void Sanciones_Load(object sender, EventArgs e)
        {

        }
        public DataTable Listarjuvenil()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "Listarjuvenil";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }
        public DataTable Listarcadete()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "Listarcadete";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }
        public DataTable Listarinfantil()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "Listarinfantil";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }
        public DataTable Listaralevin()
        {

            DataTable Tabla = new DataTable();
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "Listaralevin";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarReader = obj.VarCmd.ExecuteReader();
            Tabla.Load(obj.VarReader);
            obj.VarReader.Close();
            obj.VarCmd.Connection.Close();
            ; return Tabla;


        }

      

        private void Listarj()
        {
            ListBox1.DataSource = Listarjuvenil();
            ListBox1.DisplayMember = "nombre";
            ListBox1.ValueMember = "idter";

        }
        private void Listarc()
        {
            ListBox1.DataSource = Listarcadete();
            ListBox1.DisplayMember = "nombre";
            ListBox1.ValueMember = "idter";
        }
        private void Listari()
        {
            ListBox1.DataSource = Listarinfantil();
            ListBox1.DisplayMember = "nombre";
            ListBox1.ValueMember = "idter";
        }
        private void Listara()
        {
            ListBox1.DataSource = Listaralevin();
            ListBox1.DisplayMember = "nombre";
            ListBox1.ValueMember = "idter";
        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ListBox1.SelectedIndex == -1)
                return;
            else
            {
                
                string sql = "select i.nombre as nombre,i.idter as id,co.correo as correo,n.numtelefono as telefono,j.dorsal as dorsal,"+
       
          " j.foto as foto , p.apellidos as apellido,"+
      "p.fechanac as fechanac from mantjugador j"+
      " inner join tercero i on i.idter = j.idter"+
      " inner  join correo co on i.idter = co.idter"+
      " inner join telefono n on i.idter = n.idter"+
     " inner join persona p on i.idter = p.idter where j.idter = "+ ListBox1.SelectedValue.ToString() + "";


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

        private void Btnjuv_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Listarj();
        }

        private void Btncad_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Listarc();
        }

        private void Btninf_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Listari();
        }

        private void Btnal_Click(object sender, EventArgs e)

        { 
             ListBox1.Visible = true;
            Listara();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox1.Visible = false;
        }

        private void Sanciones_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox1.Visible = false;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox1.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
