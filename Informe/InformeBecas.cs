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
    public partial class InformeBecas : Form
    {
        public InformeBecas()
        {
            InitializeComponent();
        }
        gestion_becas.Lista_becas gp = new gestion_becas.Lista_becas();
        private void button1_Click(object sender, EventArgs e)
        {
            gp.ImprimirBecas();
        }

        private void InformeBecas_Load(object sender, EventArgs e)
        {
            gp.ListarBeca();
        }
    }
}
