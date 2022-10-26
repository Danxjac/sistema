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

namespace SistemaGestionDeportiva.gestion_personal
{
    public partial class Mantenimiento_contactos : MetroFramework.Forms.MetroForm
    {
        public Mantenimiento_contactos(Agenda_Contactos ag)
        {
            InitializeComponent();
            Txtshow.Visible = false;
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
        Agenda_Contactos ag = new Agenda_Contactos();

        public Agenda_Contactos Agenda_Contactos { get; private set; }

        //  public DataTable dt;
        //public SqlDataAdapter da;


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
      public void InsertarContacto(int Id,string Nombre,string Correo,string Telefono,string Motivo)
           
        {
                                  
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "InsertarContacto";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.Parameters.AddWithValue("@idter", Id);
            obj.VarCmd.Parameters.AddWithValue("@nombre", Nombre);
            obj.VarCmd.Parameters.AddWithValue("@correo", Correo);
            obj.VarCmd.Parameters.AddWithValue("@numtelefono", Telefono);
            obj.VarCmd.Parameters.AddWithValue("@motivo",Motivo);
            obj.VarCmd.ExecuteNonQuery();
            obj.VarCmd.Parameters.Clear();
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Txtid.Text.Trim()=="" ||Txttelefono.Text.Trim()=="" || Txtnombre.Text.Trim() == "") {

                MessageBox.Show("por favor llenar todos los campos");

            }

            else {

                Agenda_Contactos ag = new Agenda_Contactos();


                InsertarContacto(Convert.ToInt32(Txtid.Text),
                                 Txtnombre.Text,
                                 Txtcorreo.Text,
                                 Txttelefono.Text,
                                 Txtmotivo.Text);

                ag.ListarContacto();
                MessageBox.Show("Se ha guardado con exito...!");
            }
            
            Insert();
    
           
           
    
            // txtFechaa.Text = Convert.ToString(DateTime.Now);

        }

      /*  public void ListarContacto()

        {
            DataGridViewU.DataSource = ListarContactos();
        }*/


            /* public void ListarContacto()

             {
                 DataGridViewU.DataSource = ListarContactos();


                   obj.VarCmd.Connection = BDcomun.ObtenerConexion();
                   try
                   {
                       foreach (DataGridViewRow row in DataGridViewU.Rows)
                       {
                           obj.VarCmd.Parameters.Clear();
                           obj.VarCmd.CommandText = "ListarContactos";
                           obj.VarCmd.CommandType = CommandType.StoredProcedure;
                         obj.VarCmd.Parameters.AddWithValue("@idter", Convert.ToString(row.Cells["Column1"].Value));
                           obj.VarCmd.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells["Column2"].Value));
                           obj.VarCmd.Parameters.AddWithValue("correo", Convert.ToString(row.Cells["Column3"].Value));
                           obj.VarCmd.Parameters.AddWithValue("numtelefono", Convert.ToString(row.Cells["Column4"].Value));
                           obj.VarCmd.Parameters.AddWithValue("@motivo", Convert.ToString(row.Cells["Column5"].Value));
                           obj.VarCmd.ExecuteNonQuery();

                       }
                       MessageBox.Show("Datos agregados in tabla");
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Error al agregar"+ex.ToString());
                   }
                   finally
                   {
                       BDcomun.ObtenerConexion().Close();
                   }*/

            //  }



      /*      public DataTable ListarContactos()
            {

                DataTable Tabla = new DataTable();
                obj.VarCmd.Connection = BDcomun.ObtenerConexion();
                obj.VarCmd.CommandText = "ListarContactos";
                obj.VarCmd.CommandType = CommandType.StoredProcedure;
                obj.VarCmd.CommandType = CommandType.StoredProcedure;
                obj.VarReader = obj.VarCmd.ExecuteReader();
                Tabla.Load(obj.VarReader);
                obj.VarReader.Close();
                obj.VarCmd.Connection.Close();
                ; return Tabla;


            }*/

     


     /*    private void LlenarGrid()
            {
                string sql = @"SELECT  
          t.nombre ,con.motivo   
      FROM  Tercero t inner join contacto con
      on t.idter=con.idcontacto";

              obj.BuscarDatos(sql);

                DataGridViewU.Rows.Clear();

                while (obj.VarReader.Read())
                {
                    DataGridViewU.Rows.Add(obj.VarReader["nombre"].ToString(),
                        obj.VarReader["motivo"].ToString()
                        ); 
                }*/

            
      
        

        private void Mantenimiento_contactos_Load(object sender, EventArgs e)
        {

            //   ListarContacto();

           ag.ListarContacto();
        
           
         
            
            
        }

        private void Txtid_TextChanged(object sender, EventArgs e)
        {

            string sql1 = "SELECT *FROM Tercero WHERE idter =" + Txtid.Text + "";
            if (Txtid.Text == "")
            {
                Txtshow.Visible = false;
            }
            else
            {
                obj.BuscarDatos(sql1);

            }
            if (obj.VarReader.Read())
            {
                Txtshow.Visible = true;


            }




            if (Txtid.Text.Trim() == "")
            {
                Txtnombre.Text = "";
                Txtcorreo.Text = "";
                Txttelefono.Text = "";
                Txtmotivo.Text = "";
               
                return;
            }

            string sql="select i.nombre as nombre,co.correo as correo,n.numtelefono as telefono,c.motivo as motivo from"+
       " contacto c inner join tercero i on i.idter = c.idter"+
     "  inner join correo co on i.idter = co.idter"+
     "  inner join telefono n on i.idter = n.idter where c.idter = " + Txtid.Text + "";


            obj.BuscarDatos(sql);

            if (obj.VarReader.Read())

            {

                Txtnombre.Text = obj.VarReader["nombre"].ToString();
                Txtcorreo.Text = obj.VarReader["correo"].ToString();
                Txttelefono.Text = obj.VarReader["telefono"].ToString();
                Txtmotivo.Text = obj.VarReader["motivo"].ToString();


            }
            else
            {
                Txtnombre.Text = "";
                Txtcorreo.Text = "";
                Txttelefono.Text = "";
                Txtmotivo.Text = "";

                return;

            }
        }

        private void Txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
