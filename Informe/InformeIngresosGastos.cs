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
    public partial class InformeIngresosGastos : Form
    {
        public InformeIngresosGastos()
        {
            InitializeComponent();
        }
      
        gestion_administrativa.ingresos_gastos gp = new gestion_administrativa.ingresos_gastos();

        private void InformeIngresosGastos_Load(object sender, EventArgs e)
        {
            gp.ListarGasto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gp.ImprimirIngresosGastos();
        }
    }
}
