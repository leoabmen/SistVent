using Stmx.Siscomic.Business;
using Stmx.Siscomic.Entity;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            lblUser.Text = EntGlobalUsuarios.NombreUsuario.ToUpper().Trim();
            this.WindowState = FormWindowState.Maximized;
            ActivarBotones();

        }
        private void CerrarVentana(object sender, FormClosingEventArgs e)
        {

            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
               "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void CerrarPrograma(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnCerrarSesionMouseDown_Press(object sender, MouseEventArgs e)
        {
            // btnCerrarSesion.Image = System.Drawing.Bitmap.FromFile(@"Images/cancelB.png");
            btnCerrarSesion.ForeColor = System.Drawing.Color.White;
        }

        private void btnCerrarSesionMouseUp_Press(object sender, MouseEventArgs e)
        {
            // btnCerrarSesion.Image = System.Drawing.Bitmap.FromFile(@"Images/cancel.png");
            btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
        }

        private void btnProductosMouseDown(object sender, MouseEventArgs e)
        {
            btnProductos.Image = System.Drawing.Bitmap.FromFile(@"Images/Inventario/InventarioP.png");
        }

        private void btnProductosMouseUp(object sender, MouseEventArgs e)
        {
            btnProductos.Image = System.Drawing.Bitmap.FromFile(@"Images/Inventario/InventarioG.png");
        }

        private void btnProductosMouseEnter(object sender, EventArgs e)
        {
            btnProductos.Image = System.Drawing.Bitmap.FromFile(@"Images/Inventario/InventarioG.png");
        }

        private void btnProductosMouseLeave(object sender, EventArgs e)
        {
            btnProductos.Image = System.Drawing.Bitmap.FromFile(@"Images/Inventario/InventarioM.png");
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            Login l = new Login();
            l.Show();
            this.Dispose();
        }

        private void btnVentasMouseDown(object sender, MouseEventArgs e)
        {
            btnVentas.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/VentaP.png");
        }

        private void btnVentasMouseEnter(object sender, EventArgs e)
        {
            btnVentas.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/VentaG.png");
        }

        private void btnVentasMouseLeave(object sender, EventArgs e)
        {
            btnVentas.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/VentaM.png");
        }

        private void btnVentasMouseUp(object sender, MouseEventArgs e)
        {
            btnVentas.Image = System.Drawing.Bitmap.FromFile(@"Images/Ventas/VentaG.png");
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                Ventas v = new Ventas();
                v.Show();
                this.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                Productos p = new Productos();
                p.Show();
                this.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }

       
       private void ActivarBotones()
        {
            new ControladorPermisos().RevisarPermisosButton(btnProductos, EntGlobalUsuarios.IdPerfil, EntDefinicionVentanas.IdFrmHome, EntDefinicionFunciones.IdBtnInventario);
            new ControladorPermisos().RevisarPermisosButton(btnVentas, EntGlobalUsuarios.IdPerfil, EntDefinicionVentanas.IdFrmHome, EntDefinicionFunciones.IdBtnVentas);
        }
       
       
    }
}
