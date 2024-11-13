using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPharmTrack
{
    public partial class PharmTrack : Form
    {
        public PharmTrack()
        {
            InitializeComponent();
        }


        private void btnPedido_Click(object sender, EventArgs e)
        {
            PedidoDeProductoFarmTrack.Form1 frmPrincipal = new PedidoDeProductoFarmTrack.Form1();
            frmPrincipal.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
