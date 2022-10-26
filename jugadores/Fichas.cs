using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.jugadores
{
    public partial class Fichas : Form
    {
        public Fichas()
        {
            InitializeComponent();
            Txtshow.Visible = false;
            ListBox1.Visible = false;
            BtnEditarJ.Visible = false;
            BtnCancel.Visible = false;
            
            
        }
        Master obj = new Master();
        private bool Editarcheck = false;



        private void Pbjug_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*jpg|PNG|*png",
                ValidateNames = true

            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    Pbjug.Image = Image.FromFile(ofd.FileName);
            }
        
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

        private void ListarEquipos()
        {
            Cmb12.DataSource =ListarEquipo();
            Cmb12.DisplayMember = "tipo_equipo";
            Cmb12.ValueMember = "idtipoEquipo";
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
        public void Editar(int Id, int Dorsal, string Nombre,
            string Apellidos, string Dni, DateTime Fechanac,
            string Correo, string Telefono, string Nacionalidad, DateTime Fechaalta,
            DateTime Finderechos, string Cluborigen, int Tipoequipo, byte[] Foto)

        {

            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "EditarJugadores";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.Parameters.AddWithValue("@idter", Id);
            obj.VarCmd.Parameters.AddWithValue("@Dorsal", Dorsal);
            obj.VarCmd.Parameters.AddWithValue("@nombre", Nombre);
            obj.VarCmd.Parameters.AddWithValue("@apellidos", Apellidos);
            obj.VarCmd.Parameters.AddWithValue("@dni", Dni);
            obj.VarCmd.Parameters.AddWithValue("@fechanac", Fechanac);
            obj.VarCmd.Parameters.AddWithValue("@correo", Correo);
            obj.VarCmd.Parameters.AddWithValue("@numtelefono", Telefono);
            obj.VarCmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
            obj.VarCmd.Parameters.AddWithValue("@fecha_de_alta", Fechaalta);
            obj.VarCmd.Parameters.AddWithValue("@fin_derechos", Finderechos);
            obj.VarCmd.Parameters.AddWithValue("@club_origen", Cluborigen);
            obj.VarCmd.Parameters.AddWithValue("@tipoequipo", Tipoequipo);
            obj.VarCmd.Parameters.AddWithValue("@foto", Foto);

            obj.VarCmd.ExecuteNonQuery();
            obj.VarCmd.Parameters.Clear();
        }




        public void InsertarJugador(int Id, int Dorsal, string Nombre,
              string Apellidos,string Dni,DateTime Fechanac,
              string Correo,string Telefono, string Nacionalidad,DateTime Fechaalta ,
              DateTime Finderechos ,string Cluborigen,int Tipoequipo,byte[] Foto)

        {

            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "InsertarJugadores";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.Parameters.AddWithValue("@idter", Id);
            obj.VarCmd.Parameters.AddWithValue("@dorsal", Dorsal);
            obj.VarCmd.Parameters.AddWithValue("@nombre", Nombre);
            obj.VarCmd.Parameters.AddWithValue("@apellidos", Apellidos);
            obj.VarCmd.Parameters.AddWithValue("@dni", Dni);
            obj.VarCmd.Parameters.AddWithValue("@fechanac", Fechanac);
            obj.VarCmd.Parameters.AddWithValue("@correo", Correo);
            obj.VarCmd.Parameters.AddWithValue("@numtelefono",Telefono);
            obj.VarCmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
            obj.VarCmd.Parameters.AddWithValue("@fecha_de_alta", Fechaalta);
            obj.VarCmd.Parameters.AddWithValue("@fin_derechos",Finderechos );
            obj.VarCmd.Parameters.AddWithValue("@club_origen", Cluborigen);
            obj.VarCmd.Parameters.AddWithValue("@tipoequipo", Tipoequipo);
            obj.VarCmd.Parameters.AddWithValue("@foto", Foto);

            obj.VarCmd.ExecuteNonQuery();
            obj.VarCmd.Parameters.Clear();
        }


     

        private void BtnGuard_Click(object sender, EventArgs e)
        {
            if (Txtid.Text.Trim() == "" || Txtdorsal.Text.Trim() == "" || Txtdni.Text.Trim() == "" ||
                        Txtnombre.Text.Trim() == "" || Txtap.Text.Trim() == "" || Txttel.Text.Trim() == ""
                        )
            {

                MessageBox.Show("por favor llenar todos los campos");

            }

           else
            {

                string sql = "SELECT *FROM Tercero WHERE idter =" + Txtid.Text + "";
                obj.BuscarDatos(sql);


                if (obj.VarReader.HasRows)
                {
                    MessageBox.Show("Este codigo existe ya en el sistema");

                }

                 else
                   if (Editarcheck == false)
                {


                    try
                    {

                        // Lista_personal per = new Lista_personal();
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        Pbjug.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        InsertarJugador(Convert.ToInt32(Txtid.Text), Convert.ToInt32(Txtdorsal.Text), Txtnombre.Text,
                                        Txtap.Text, Txtdni.Text, Txtfnac.Value,
                                        Txtcor.Text, Txttel.Text, Txtnac.Text, Txtfalta.Value, Txtfind.Value, Txtclubo.Text,
                                         Convert.ToInt32(Cmb12.SelectedValue), ms.GetBuffer()

                                        );

                         
                        MessageBox.Show("Se ha guardado con exito...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar los datos" +ex);
                    }

                }
                //Editar
                if(Editarcheck==true)
                    try
                    {
                   
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        Pbjug.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        Editar(Convert.ToInt32(Txtid.Text), Convert.ToInt32(Txtdorsal.Text), Txtnombre.Text,
                                        Txtap.Text, Txtdni.Text, Txtfnac.Value,
                                        Txtcor.Text, Txttel.Text, Txtnac.Text, Txtfalta.Value, Txtfind.Value, Txtclubo.Text,
                                         Convert.ToInt32(Cmb12.SelectedValue), ms.GetBuffer()

                                        );
                        MessageBox.Show("se edito correctamente");
                        LimpiarForm();
                        Editarcheck = false;
                        Txtid.Enabled = true;


                    }
                    catch
                    {

                    }


            }

            
    }
    private void Fichas_Load(object sender, EventArgs e)
        {
            ListarEquipos();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
           
        
        public void LimpiarForm() {
                Txtid.Text = "";
                Txtdorsal.Text = "";
                 Txtnombre.Clear();
                Txtap.Clear();
                Txtdni.Clear();
                Txtfnac.Text = "";
                Txtcor.Clear();
                 Txttel.Text = "";
                Txtnac.Text = "";
                Txtfalta.Text = "";
                Txtfind.Text = "";
                Txtclubo.Text = "";
                Pbjug.Image = Properties.Resources._007_user;
            }


        



        public void Mostrarj()
        {
            if (Txtid.Text.Trim() == "")
            {
                    LimpiarForm();

                return;
            }



            string sql = "select i.nombre as nombre,co.correo as correo,n.numtelefono as telefono,j.dorsal as dorsal," +
           " j.nacionalidad as nacionalidad,j.fecha_de_alta as fecha_alta,j.fin_derechos as finderecho,j.club_origen as club," +
            "    w.tipo_equipo as tipo,j.foto as foto , p.apellidos as apellido,p.dni as dni,"+
           " p.fechanac as fechanac from mantjugador j" +
        "    inner join tercero i on i.idter = j.idter" +
          "  inner join correo co on i.idter = co.idter" +
         "   inner join telefono n on i.idter = n.idter" +
          "   inner join tipo_equipo w  on j.tipoequipo =w.idtipoEquipo" +
          " inner join persona p on i.idter = p.idter" +
          "  where j.idter = " + Txtid.Text + "";


            obj.BuscarDatos(sql);

            if (obj.VarReader.Read())
            {


                Txtdorsal.Text = obj.VarReader["dorsal"].ToString();
                Txtnombre.Text = obj.VarReader["nombre"].ToString();
                Txtap.Text = obj.VarReader["apellido"].ToString();
                Txtdni.Text = obj.VarReader["dni"].ToString();
                Txtfnac.Text = obj.VarReader["fechanac"].ToString();
                Txtcor.Text = obj.VarReader["correo"].ToString();
                Txttel.Text = obj.VarReader["telefono"].ToString();
                Txtnac.Text = obj.VarReader["nacionalidad"].ToString();
                Txtfalta.Text = obj.VarReader["fecha_alta"].ToString();
                Txtfind.Text = obj.VarReader["finderecho"].ToString();
                Txtclubo.Text = obj.VarReader["club"].ToString();
                byte[] img = (byte[])obj.VarReader["foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                Pbjug.Image = Image.FromStream(ms);
                Cmb12.Text= obj.VarReader["tipo"].ToString();

            }
          
        }
        private void Txtid_TextChanged(object sender, EventArgs e)
        {
            Mostrarj();


            string sql = "SELECT *FROM Tercero WHERE idter =" + Txtid.Text + "";
            if (Txtid.Text == "")
            {
                Txtshow.Visible = false;
            }
            else
            {
                obj.BuscarDatos(sql);

            }
            if (obj.VarReader.Read())
            {
                Txtshow.Visible = true;
                BtnEditarJ.Visible = true;

            }
            else
            {

                Txtshow.Visible = false;
                BtnEditarJ.Visible = false;
              
               // Txtid.Text = "";
                Txtdorsal.Text = "";
                Txtnombre.Text = "";
                Txtap.Text = "";
                Txtdni.Text = "";
                Txtfnac.Text = "";
                Txtcor.Text = "";
                Txttel.Text = "";
                Txtnac.Text = "";
                Txtfalta.Text = "";
                Txtfind.Text = "";
                Txtclubo.Text = "";
                Pbjug.Image = Properties.Resources._007_user;

            }
        }

        private void Txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Listarj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Listarc();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Listari();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListBox1.Visible = true;
            Listara();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox1.Visible = false;
            BtnCancel.Visible = false;
        }

        private void Fichas_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox1.Visible = false;
            BtnCancel.Visible = false;
        }

        private void Fichas_MouseHover(object sender, EventArgs e)
        {
           // ListBox1.Visible = false;
        }

        private void Txtdorsal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Editarcheck = true;
            MessageBox.Show("Puedes editar campos ");
            BtnCancel.Visible = true;
            Txtid.Enabled = false;
            

        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {

         
            if (ListBox1.SelectedIndex == -1)
                return;
            else
            {
                BtnCancel.Visible = false;
                string sql = "select i.nombre as nombre,i.idter as id,co.correo as correo,n.numtelefono as telefono,j.dorsal as dorsal," +
       " j.nacionalidad as nacionalidad,j.fecha_de_alta as fecha_alta,j.fin_derechos as finderecho,j.club_origen as club," +
        "w.tipo_equipo as tipo,j.foto as foto , p.apellidos as apellido,p.dni as dni," +
       " p.fechanac as fechanac from mantjugador j" +
    "    inner join tercero i on i.idter = j.idter" +
      "  inner join correo co on i.idter = co.idter" +
     "   inner join telefono n on i.idter = n.idter" +
     "   inner join tipo_equipo w  on j.tipoequipo =w.idtipoEquipo" +
      " inner join persona p on i.idter = p.idter" +
      "  where j.idter =" + ListBox1.SelectedValue.ToString() +"";


                obj.BuscarDatos(sql);

                if (obj.VarReader.Read())
                {


                    Txtdorsal.Text = obj.VarReader["dorsal"].ToString();
                    Txtnombre.Text = obj.VarReader["nombre"].ToString();
                    Txtap.Text = obj.VarReader["apellido"].ToString();
                    Txtdni.Text = obj.VarReader["dni"].ToString();
                    Txtfnac.Text = obj.VarReader["fechanac"].ToString();
                    Txtcor.Text = obj.VarReader["correo"].ToString();
                    Txttel.Text = obj.VarReader["telefono"].ToString();
                    Txtnac.Text = obj.VarReader["nacionalidad"].ToString();
                    Txtfalta.Text = obj.VarReader["fecha_alta"].ToString();
                    Txtfind.Text = obj.VarReader["finderecho"].ToString();
                    Txtclubo.Text = obj.VarReader["club"].ToString();
                    byte[] img = (byte[])obj.VarReader["foto"];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    Pbjug.Image = Image.FromStream(ms);
                    Cmb12.Text = obj.VarReader["tipo"].ToString();
                    Txtid.Text = obj.VarReader["id"].ToString();


                }

                //  MessageBox.Show(ListBox1.SelectedValue.ToString()); 

            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Txtid.Enabled = true;
            Editarcheck = false;

        }
    }
}
