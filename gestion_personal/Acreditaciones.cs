using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.gestion_personal
{
    public partial class Acreditaciones : Form
    {
        public Acreditaciones()
        {
            InitializeComponent();
        }
        Master obj = new Master();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += PrintDocument1_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();



         /*   using (var Bmp = new Bitmap(PanelTarjeta.Width, PanelTarjeta.Height))
            {
              PanelTarjeta.DrawToBitmap(Bmp, new Rectangle(0, 0, Bmp.Width, Bmp.Height));
                Bmp.Save(@"imagenes/" + Txtni.Text + ".bmp");
                MessageBox.Show("imagen guardada");
                


            }*/

        }
       

        private void PrintDocument1_PrintPage(object sender,PrintPageEventArgs e)
        {
            Bitmap Bmp = new Bitmap(PanelTarjeta.Width, PanelTarjeta.Height);
            
                PanelTarjeta.DrawToBitmap(Bmp, new Rectangle(0, 0, Bmp.Width, Bmp.Height));
            //    Bmp.Save(@"imagenes/" + Txtni.Text + ".bmp");  //guardar como imagen
            e.Graphics.DrawImage(Bmp,240,100);
            Bmp.Dispose();



            



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void Acreditaciones_Load(object sender, EventArgs e)
        {
            /* ControlExtension.Draggable(PanelTarjeta, true);
             ControlExtension.Draggable(Pbfoto, true);
             ControlExtension.Draggable(Pblogo, true);*/
            Listarjug();
        }

        private void Pbfoto_Click(object sender, EventArgs e)
        {
         /*   using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*jpg|PNG|*png",
                ValidateNames = true
            
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    Pbfoto.Image = Image.FromFile(ofd.FileName);
            }*/
        }

        private void Cmbjug_Click(object sender, EventArgs e)
        {
          
    }

        private void Cmbjug_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void Cmbjug_MouseClick(object sender, MouseEventArgs e)
        {
            if (Cmbjug.SelectedIndex == -1)
                return;
            else
            {

                string sql = "select i.nombre as nombre,i.idter as id,co.correo as correo,n.numtelefono as telefono,j.dorsal as dorsal," +
                 " u.tipo_equipo as tipo ," +
          " j.foto as foto , p.apellidos as apellido," +
      "p.fechanac as fechanac from mantjugador j" +
      " inner join tercero i on i.idter = j.idter" +
      " inner  join tipo_equipo u on j.tipoequipo = u.idtipoEquipo" +
      " inner  join correo co on i.idter = co.idter" +
      " inner join telefono n on i.idter = n.idter" +
     " inner join persona p on i.idter = p.idter where j.idter = " + Cmbjug.SelectedValue.ToString() + "";


                obj.BuscarDatos(sql);

                if (obj.VarReader.Read())
                {


                   // Lbd.Text = obj.VarReader["dorsal"].ToString();
                     Lb1.Text = obj.VarReader["nombre"].ToString();
                     Lb2.Text = obj.VarReader["apellido"].ToString();
                     Lb5.Text = obj.VarReader["tipo"].ToString();
                     Lb3.Text = obj.VarReader["telefono"].ToString();
                     Lb4.Text = obj.VarReader["correo"].ToString();


                    byte[] img = (byte[])obj.VarReader["foto"];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    Pbfoto.Image = Image.FromStream(ms);




                }




            }
        }

        private void Pblogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*jpg|PNG|*png",
                ValidateNames = true

            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    Pblogo.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
