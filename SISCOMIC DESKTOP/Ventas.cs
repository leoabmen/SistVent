using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCOMIC_DESKTOP
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnMenu, "Ir al Menú Principal");
            toolTip.SetToolTip(btnNuevaVenta, "Nueva Venta de Contado");
            toolTip.SetToolTip(btnNuevoCredito, "Nueva Venta a Crédito");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMenuMouseDown(object sender, MouseEventArgs e)
        {
            btnMenu.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/HomeP.png");
            btnMenu.ForeColor = System.Drawing.Color.White;
        }

        private void btnMenuMouseUp(object sender, MouseEventArgs e)
        {
            btnMenu.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/HomeG.png");
            btnMenu.ForeColor = System.Drawing.Color.Black;
        }

        private void btnMenuMouseEnter(object sender, EventArgs e)
        {
            btnMenu.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/HomeG.png");
            btnMenu.ForeColor = System.Drawing.Color.Black;
        }

        private void btnMenuMouseLeave(object sender, EventArgs e)
        {
            btnMenu.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/HomeM.png");
            btnMenu.ForeColor = System.Drawing.Color.Black;
        }

        private void btnNuevaVentaMouseDown(object sender, MouseEventArgs e)
        {
            btnNuevaVenta.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/SaleP.png");
        }

        private void btnNuevaVentaMouseUp(object sender, MouseEventArgs e)
        {
            btnNuevaVenta.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/SaleG.png");
        }

        private void btnNuevaVentaMouseEnter(object sender, EventArgs e)
        {
            btnNuevaVenta.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/SaleG.png");
        }

        private void btnNuevaVentaMouseLeave(object sender, EventArgs e)
        {
            btnNuevaVenta.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/SaleM.png");
        }

        private void btnNuevoCreditoMouseDown(object sender, MouseEventArgs e)
        {
            btnNuevoCredito.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/CreditoP.png");
        }

        private void btnNuevoCreditoMouseUp(object sender, MouseEventArgs e)
        {
            btnNuevoCredito.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/CreditoG.png");
        }

        private void btnNuevoCreditoMouseEnter(object sender, EventArgs e)
        {
            btnNuevoCredito.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/CreditoG.png");
        }

        private void btnNuevoCreditoMouseLeave(object sender, EventArgs e)
        {
            btnNuevoCredito.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/CreditoM.png");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Menu m = new Menu();
                m.Show();
                this.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
