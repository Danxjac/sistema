using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionDeportiva.Informe
{
    public partial class InformePersonal : Form
    {
        public InformePersonal()
        {
            InitializeComponent();
        }

        gestion_personal.Lista_personal gp = new gestion_personal.Lista_personal();

        private void button1_Click(object sender, EventArgs e)
        {
            gp.ImprimirPersonal();
        }

        private void InformePersonal_Load(object sender, EventArgs e)
        {
            gp.ListarPersonal();
        }
    }
}
