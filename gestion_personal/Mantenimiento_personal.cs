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
    public partial class Mantenimiento_personal : Form
    {
        public Mantenimiento_personal(Lista_personal per)
        {
            InitializeComponent();
            Txtshow.Visible = false;
            btnEditarP.Visible = false;
           
        }
        private bool Editarcheck = false;
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
        Lista_personal per = new Lista_personal();

        private void Mantenimiento_personal_Load(object sender, EventArgs e)
        {
            ListarPuestos();
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ListarPuestos()
        {
            Cmb11.DataSource = per.ListarPuesto();
            Cmb11.DisplayMember = "puesto";
            Cmb11.ValueMember = "idpuesto";
        }


        public void InsertarPersonal(int Id, string Nombre,
         string Apellidos, string Dni, DateTime Fecha,
         string Correo, string Telefono, string Direccion,
         string Provincia, string Pais, string Cuenta, int Puesto,byte[] Foto)

        {

            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "InsertarPersonales";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.Parameters.AddWithValue("@idter", Id);
            obj.VarCmd.Parameters.AddWithValue("@nombre", Nombre);
            obj.VarCmd.Parameters.AddWithValue("@apellidos", Apellidos);
            obj.VarCmd.Parameters.AddWithValue("@dni", Dni);
            obj.VarCmd.Parameters.AddWithValue("@fechanac", Fecha);
            obj.VarCmd.Parameters.AddWithValue("@correo", Correo);
            obj.VarCmd.Parameters.AddWithValue("@numtelefono", Telefono);
            obj.VarCmd.Parameters.AddWithValue("@direccion", Direccion);
            obj.VarCmd.Parameters.AddWithValue("@provincia", Provincia);
            obj.VarCmd.Parameters.AddWithValue("@pais", Pais);
            obj.VarCmd.Parameters.AddWithValue("@cuenta", Cuenta);
            obj.VarCmd.Parameters.AddWithValue("@puesto", Puesto);
            obj.VarCmd.Parameters.AddWithValue("@foto", Foto);

            obj.VarCmd.ExecuteNonQuery();
            obj.VarCmd.Parameters.Clear();
            
        }

        public void Editar(int Id, string Nombre,
        string Apellidos, string Dni, DateTime Fecha,
        string Correo, string Telefono, string Direccion,
        string Provincia, string Pais, string Cuenta, int Puesto, byte[] Foto)

        
            {
            obj.VarCmd.Connection = BDcomun.ObtenerConexion();
            obj.VarCmd.CommandText = "EditarPersonales";
            obj.VarCmd.CommandType = CommandType.StoredProcedure;
            obj.VarCmd.Parameters.AddWithValue("@idter", Id);
            obj.VarCmd.Parameters.AddWithValue("@nombre", Nombre);
            obj.VarCmd.Parameters.AddWithValue("@apellidos", Apellidos);
            obj.VarCmd.Parameters.AddWithValue("@dni", Dni);
            obj.VarCmd.Parameters.AddWithValue("@fechanac", Fecha);
            obj.VarCmd.Parameters.AddWithValue("@correo", Correo);
            obj.VarCmd.Parameters.AddWithValue("@numtelefono", Telefono);
            obj.VarCmd.Parameters.AddWithValue("@direccion", Direccion);
            obj.VarCmd.Parameters.AddWithValue("@provincia", Provincia);
            obj.VarCmd.Parameters.AddWithValue("@pais", Pais);
            obj.VarCmd.Parameters.AddWithValue("@cuenta", Cuenta);
            obj.VarCmd.Parameters.AddWithValue("@puesto", Puesto);
            obj.VarCmd.Parameters.AddWithValue("@foto", Foto);

            obj.VarCmd.ExecuteNonQuery();
            obj.VarCmd.Parameters.Clear();
            
        }

       

         
        
        private void LimpiarForm()
        {
            
            Txt1.Text="";
            Txt2.Clear();
            Txt3.Clear();
            Txt4.Clear();
            Txt6.Clear();
            Txt7.Clear();
            Txt8.Clear();
            Txt9.Clear();
            Txt10.Clear();
            Txt12.Clear();
            Pbjug.Image = Properties.Resources._007_user;



        }



    



        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Txt1.Text.Trim() == "" || Txt2.Text.Trim() == "" || Txt3.Text.Trim() == "" ||
                Txt4.Text.Trim() == "" || Txt9.Text.Trim() == "" || Txt6.Text.Trim() == ""
                )
            {

                MessageBox.Show("por favor llenar todos los campos");

            }

            else
            {

                string sql = "SELECT *FROM Tercero WHERE idter =" + Txt1.Text + "";
                obj.BuscarDatos(sql);


                if (obj.VarReader.HasRows)
                {
                    BDcomun.ObtenerConexion().Close();

                    MessageBox.Show("Este codigo existe ya en el sistema");
                    
                }
                else
                  if (Editarcheck == false)
                {
                    try
                    {

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        Pbjug.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Lista_personal per = new Lista_personal();

                        InsertarPersonal(Convert.ToInt32(Txt1.Text), Txt2.Text, Txt3.Text,
                                        Txt4.Text, Txt5.Value, Txt6.Text,
                                        Txt7.Text, Txt8.Text, Txt9.Text,
                                        Txt10.Text, Txt12.Text, Convert.ToInt32(Cmb11.SelectedValue), ms.GetBuffer()

                                        );

                        per.ListarPersonales();
                        MessageBox.Show("Se ha guardado con exito...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo insertar los datos por: " + ex);
                    }


                }
                //EDITAR
                if (Editarcheck == true)
                {
                    try
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        Pbjug.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Lista_personal per = new Lista_personal();
                        Editar(Convert.ToInt32(Txt1.Text), Txt2.Text, Txt3.Text,
                                          Txt4.Text, Txt5.Value, Txt6.Text,
                                          Txt7.Text, Txt8.Text, Txt9.Text,
                                          Txt10.Text, Txt12.Text, Convert.ToInt32(Cmb11.SelectedValue), ms.GetBuffer()

                                          );
                        MessageBox.Show("se edito correctamente");
                        
                        LimpiarForm();
                        Editarcheck = false;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("no se pudo editar los datos por: " + ex);
                    }
                   
                }
            }
            
            Insert();

        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

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

       

        public void Mostrar()
        {
           if (Txt1.Text.Trim() == "")
            {

                LimpiarForm();
                return;
            }
          




                string sql = "     select i.nombre AS nombre,p.apellidos AS apellido ,pu.puesto AS puesto," +
                     " n.numtelefono AS telefono,co.correo AS correo,p.dni as nif,d.direccion as direccion," +
                     " pro.provincia as provincia,cu.cuenta as cuenta,c.idter as id,p.fechanac as fechanac," +
                     "  pa.pais as pais,c.foto as foto from empleado c" +
                " inner join tercero i on c.idter = i.idter" +
                " inner join correo co on c.idter = co.idter" +
                 " inner join persona p on c.idter = p.idter" +
                 " inner join telefono n on c.idter = n.idter" +
                "  inner join direccion d on c.idter = d.idter" +
                "  inner join provincia pro on c.idter = pro.idter" +
                " inner join puesto pu on pu.idpuesto = c.puesto" +
                 " inner join pais pa on c.idter = pa.idpais" +
                "  inner join cuenta_bancaria cu on c.idter = cu.idter" +
                 " where c.idter =" +Txt1.Text+ "";


                obj.BuscarDatos(sql);
            

            if (obj.VarReader.Read())
            {


                Txt1.Text = obj.VarReader["id"].ToString();
                Txt2.Text = obj.VarReader["nombre"].ToString();
                Txt3.Text = obj.VarReader["apellido"].ToString();
                Txt4.Text = obj.VarReader["nif"].ToString();
                Txt5.Text = obj.VarReader["fechanac"].ToString();
                Txt6.Text = obj.VarReader["correo"].ToString();
                Txt7.Text = obj.VarReader["telefono"].ToString();
                Txt12.Text = obj.VarReader["cuenta"].ToString();
                Txt10.Text = obj.VarReader["pais"].ToString();
                Txt8.Text = obj.VarReader["direccion"].ToString();
                Txt9.Text = obj.VarReader["provincia"].ToString();
                Cmb11.Text = obj.VarReader["puesto"].ToString();
                byte[] img = (byte[])obj.VarReader["foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                Pbjug.Image = Image.FromStream(ms);
            }
        

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {


            Mostrar();
            
 
            
            string sql = "SELECT *FROM Tercero WHERE idter ="+Txt1.Text +"";
            if (Txt1.Text =="")
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
                btnEditarP.Visible = true;

            }
            else{

                Txtshow.Visible = false;
                btnEditarP.Visible = false;
              //  Txt1.Text = "";
                Txt2.Clear();
                Txt3.Clear();
                Txt4.Clear();
                Txt6.Clear();
                Txt7.Clear();
                Txt8.Clear();
                Txt9.Clear();
                Txt10.Clear();
                Txt12.Clear();
                Pbjug.Image = Properties.Resources._007_user;

            }

        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            Editarcheck = true;
            MessageBox.Show("Puedes editar campos ");
           
        }
    }
}
