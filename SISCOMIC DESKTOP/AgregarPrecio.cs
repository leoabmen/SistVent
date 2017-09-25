using Stmx.Siscomic.Business;
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
    public partial class AgregarPrecio : Form
    {
        ValidacionCampos vc = new ValidacionCampos();
        DateTime fechaHoy = DateTime.Today;
        DateTime fechaAño = DateTime.Today.AddYears(1);
        public AgregarPrecio()
        {
            InitializeComponent();
            
            dtFechaFin.Text = fechaAño.ToShortDateString();
        }
        private void AgregarPrecio_Load(object sender, EventArgs e)
        {
            //dtFechaInicio.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (vc.ValidarRequeridoTexto(txtPrecioCompra, 0, lblRequeridoPrecioCompra)==false)
                {
                    return;
                }
                if (vc.ValidarRequeridoTexto(txtPrecioVenta, 0, lblRequeridoPrecioVenta) == false)
                {
                    return;
                }
                if (dtFechaInicio.Value > dtFechaFin.Value)
                {
                    MessageBox.Show("Error: La fecha de inicio no puede ser mayor a la fecha de fin. ","¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtFechaFin.Text = fechaAño.ToShortDateString();
                    return;
                }
                if (dtFechaInicio.Value < fechaHoy && hidIdPrecio.Text == "")//Valida que la fecha de inicio no sea menor a la fecha de hoy en la Alta del precio. AAML-23/09/2017-Inicio
                {
                    MessageBox.Show("Error: La fecha de inicio no puede ser menor a la fecha de Hoy. ", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtFechaInicio.Text = fechaHoy.ToShortDateString();
                    return;
                }
                if (dtFechaInicio.Value > fechaHoy && hidIdPrecio.Text == "")//Valida que la fecha de inicio no sea mayor a la fecha de hoy en la Alta del precio. AAML-23/09/2017-Inicio
                {
                    MessageBox.Show("Error: Para asignar el precio por primera vez al producto,"+"\n"+"La fecha de inicio no puede ser mayor a la fecha de Hoy.", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtFechaInicio.Text = fechaHoy.ToShortDateString();
                    return;
                }
                if (dtFechaInicio.Value < fechaHoy)//Valida que la fecha de inicio no sea menor a la fecha de hoy en la actualización del precio. AAML-23/09/2017-Inicio
                {
                    MessageBox.Show("Error: La fecha de inicio no puede ser menor a la fecha de Hoy. ", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtFechaInicio.Text = fechaHoy.ToShortDateString();
                    return;
                }
                if (hidIdPrecio.Text == "" && lblBanderaNuevo.Text != "N" || hidIdPrecio.Text != "" && lblBanderaNuevo.Text == "N")
                {
                    int filas = new BusProductos().RegistrarPrecioProductos(lblClaveProducto.Text, Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioVenta.Text), dtFechaInicio.Value, dtFechaFin.Value);
                    if(lblBanderaNuevo.Text=="N" && dtFechaInicio.Value == fechaHoy)
                    {
                        int rows = new BusProductos().CierraVigenciaPrecio(DateTime.Today, lblClaveProducto.Text, Convert.ToInt32(hidIdPrecio.Text));
                        if (rows == 0)
                        {
                            MessageBox.Show("Ocurrio un error al cerrar la vigencia del precio anterior del Producto: "+lblClaveProducto.Text+"", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (lblBanderaNuevo.Text == "N" && dtFechaInicio.Value > fechaHoy)
                    {
                        int rows = new BusProductos().CierraVigenciaPrecio(dtFechaInicio.Value, lblClaveProducto.Text, Convert.ToInt32(hidIdPrecio.Text));
                        if (rows == 0)
                        {
                            MessageBox.Show("Ocurrio un error al cerrar la vigencia del precio anterior del Producto: " + lblClaveProducto.Text + "", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (filas > 0)
                    {
                        int idPrecio = new BusProductos().ObtenerUltimoPrecioId(lblClaveProducto.Text);
                        if (idPrecio > 0)
                        {
                            hidIdPrecio.Text = idPrecio.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al tratar de obtener el id del último precio registrado para el producto: "+lblClaveProducto.Text+"", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                        MessageBox.Show("Precio Registrado con Éxito: ", "¡ Información !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Registrar el precio del Producto: ", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (hidIdPrecio.Text != "" && lblBanderaNuevo.Text != "N")
                {
                    int filas = new BusProductos().ActualizarPrecioProductos(Convert.ToInt32(hidIdPrecio.Text), lblClaveProducto.Text, Convert.ToDouble(txtPrecioCompra.Text), Convert.ToDouble(txtPrecioVenta.Text), dtFechaInicio.Value, dtFechaFin.Value);
                    if (filas > 0)
                    {
                        MessageBox.Show("Precio Actualizado con Éxito: ", "¡ Información !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Actualizar el precio del Producto: ", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                DesactivarControles();
                lblBanderaNuevo.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Registrar y/o Actualizar el Precio del Producto: "+lblClaveProducto.Text+", "+ ex, "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DesactivarControles()
        {
            txtPrecioCompra.Enabled = false;
            txtPrecioVenta.Enabled = false;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
        }
        private void ActivarControles()
        {
            txtPrecioCompra.Enabled = true;
            txtPrecioVenta.Enabled = true;
            dtFechaInicio.Enabled = true;
            dtFechaFin.Enabled = true;
        }
        private void LimpiarControles()
        {
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean bol;
                bol = new BusProductos().ValidarPrecio(lblClaveProducto.Text);
                if (bol == true)
                {
                    List<string> lst = new BusProductos().ObtenerPrecio(lblClaveProducto.Text);
                    hidIdPrecio.Text = lst[0];
                }
                txtPrecioVenta.Enabled = true;
                dtFechaFin.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al tratar de obtener el Id del Precio para el Producto: " + lblClaveProducto.Text + ", " + ex, "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            vc.ValidarCamposTexto(txtPrecioCompra,"^(\\d|-)*\\.?\\d*$","min");
            lblRequeridoPrecioCompra.Visible = false;
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            vc.ValidarCamposTexto(txtPrecioVenta, "^(\\d|-)*\\.?\\d*$", "min");
            lblRequeridoPrecioVenta.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Esta seguro de agregar un nuevo precio al producto " + lblClaveProducto.Text + "?" + "\n" + "Esta acción cerrará la vigencia del precio anterior y al dar click en" + "\n" +"el botón guardar creará el nuevo precio para el producto con su respectiva vigencia.",
               "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    DateTime fechaHoy = DateTime.Today;
                    DateTime fechaAño = DateTime.Today.AddYears(1);
                    dtFechaInicio.Text = fechaHoy.ToShortDateString();
                    dtFechaFin.Text = fechaAño.ToShortDateString();
                    ActivarControles();
                    LimpiarControles();
                    lblBanderaNuevo.Text = "N";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al tratar de crear nuevo Precio para el Producto: " + lblClaveProducto.Text + ", " + ex, "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void tbcPrecios_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(tbcPrecios.SelectedIndex==1)
            {
                dgvHistoricoPrecio.DataSource = new BusProductos().ObtenerHistoricoPrecio(lblClaveProducto.Text);
            }
            else if (tbcPrecios.SelectedIndex == 0)
            {
                Boolean bol;
            DateTime fechaInicio;
            DateTime fechaFin;
            bol=new BusProductos().ValidarPrecio(lblClaveProducto.Text);
            if (bol == true)
            {
                List<string> lst = new BusProductos().ObtenerPrecio(lblClaveProducto.Text);
                hidIdPrecio.Text = lst[0];
                txtPrecioCompra.Text = lst[1];
                txtPrecioVenta.Text = lst[2];
                fechaInicio = Convert.ToDateTime(lst[3]);
                dtFechaInicio.Text = fechaInicio.ToString("dd/MM/yyyy");
                fechaFin = Convert.ToDateTime(lst[4]);
                dtFechaFin.Text = fechaFin.ToString("dd/MM/yyyy");
                txtPrecioCompra.Enabled = false;
                txtPrecioVenta.Enabled = false;
                dtFechaInicio.Enabled = false;
                dtFechaFin.Enabled = false;

            }
            else
            {
                hidIdPrecio.Text = "";
            }
            }
        }


    }
}
