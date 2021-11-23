using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaVentas
{
    public partial class frmMdi : Form
    {
        public frmMdi()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBodega frmb = new frmBodega();
            frmb.MdiParent = this;
            frmb.Show();

        }

        private void mantenimientoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto frmp = new frmProducto();
            frmp.MdiParent = this;
            frmp.Show();

        }

        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmc = new frmCliente();
            frmc.MdiParent = this;
            frmc.Show();
        }

        private void mantenimientoTipoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoPago frmt = new frmTipoPago();
            frmt.MdiParent = this;
            frmt.Show();
        }
    }
}
