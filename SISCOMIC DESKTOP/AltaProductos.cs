using CrystalDecisions.CrystalReports.Engine;
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
    public partial class AltaProductos : Form
    {
        Productos productos = new Productos();
        ValidacionCampos vl = new ValidacionCampos();
        public AltaProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {
            cboCategoria.DataSource = new BusProductos().CargarComboCategoria();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";
            cboMarca.DataSource = new BusProductos().CargarComboMarca();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
            //   cboModelo.Items.Insert(0, "--Seleccione una Marca--");
            cboModelo.SelectedIndex = 0;
            //    cboColor.Items.Insert(0, "--Seleccione un Modelo--");
            cboColor.SelectedIndex = 0;
            if (txtClave.Text == "" && txtClave.Enabled == true)
            {
                DateTime fechaHoy = DateTime.Today;
                lblFechaAlta.Text = fechaHoy.ToShortDateString();
            }
            else
            {
                ObtenerProducto(txtClave.Text);
                DesactivarControles();
                btnAtras.Visible = true;
                btnNuevo.Visible = false;
            }
            if (txtClave.Enabled == true)
            {
                btnPrecio.Enabled = false;
                btnCBarras.Enabled = false;
                btnDescuentos.Enabled = false;
            }
            else
            {
                btnPrecio.Enabled = true;
                btnCBarras.Enabled = true;
                btnDescuentos.Enabled = true;
            }






        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditarControles();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtClave.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                EntProductos ent = new EntProductos();
                if (vl.ValidarRequeridoTexto(txtClave, 6, lblRequeridoClave) == false)
                {
                    return;
                }
                if (vl.ValidarRequeridoTexto(txtDescripcion, 10, lblRequeridoDesc) == false)
                {
                    return;
                }
                if (vl.ValidarRequeridoTexto(txtCantidad, 1, lblRequeridoCant) == false)
                {
                    return;
                }
                if (vl.ValidarRequeridoCombo(cboCategoria, 0, lblRequeridoCat) == false)
                {
                    return;
                }
                if (vl.ValidarRequeridoCombo(cboMarca, 0, lblRequeridoMarca) == false)
                {
                    return;
                }
                if (vl.ValidarRequeridoCombo(cboModelo, 0, lblRequeridoModel) == false)
                {
                    return;
                }
                if (vl.ValidarRequeridoCombo(cboColor, 0, lblRequeridoColor) == false)
                {
                    return;
                }
                ent.Id = txtClave.Text;
                ent.Descripcion = txtDescripcion.Text;
                ent.CategoriaId = Convert.ToInt32(cboCategoria.SelectedValue);
                ent.MarcaId = Convert.ToInt32(cboMarca.SelectedValue);
                ent.ModeloId = Convert.ToInt32(cboModelo.SelectedValue);
                ent.ColorId = Convert.ToInt32(cboColor.SelectedValue);
                ent.Cantidad = Convert.ToInt32(txtCantidad.Text);
                ent.FechaAlta = Convert.ToDateTime(lblFechaAlta.Text);
                ent.UsuarioId = EntGlobalUsuarios.IdUsuario;
                ent.Observaciones = txtObservaciones.Text;
                ent.Estatus = 1;

                BusProductos bus = new BusProductos();
                Boolean validar = bus.ValidarClave(ent.Id);
                if (validar == true && txtClave.Enabled == true)
                {
                    MessageBox.Show("La Clave que Ingreso Ya Existe" + "\n" + "Por Favor Escriba Otra Clave Diferente", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtClave.Focus();
                }
                else if (validar == true && txtClave.Enabled == false)
                {
                    int validarUpdate = bus.ActualizarProducto(ent);
                    if (validarUpdate > 0)
                    {
                        MessageBox.Show("Producto Actualizado Exitosamente", "¡ Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LimpiarCampos();
                        // txtClave.Enabled = false;
                        btnPrecio.Enabled = true;
                        btnCBarras.Enabled = true;
                        btnDescuentos.Enabled = true;
                        DesactivarControles();
                    }
                }
                else if (validar == false && txtClave.Enabled == true)
                {
                    int validarInsert = bus.AgregarProducto(ent);
                    if (validarInsert > 0)
                    {
                        MessageBox.Show("Producto Registrado Exitosamente", "¡ Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //LimpiarCampos();
                        // txtClave.Enabled = false;
                        btnPrecio.Enabled = true;
                        btnCBarras.Enabled = true;
                        btnDescuentos.Enabled = true;
                        DesactivarControles();

                    }
                }
                // }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void cboMarcaSelectIndexChanged(object sender, EventArgs e)
        {
            // EntMarca ent = new EntMarca();
            // ent.Id =Convert.ToInt32 (cboMarca.SelectedValue);
            // string idMarca="0";
            // ent.Descripcion = cboMarca.SelectedValue.ToString() ;
            //cboModelo.DataSource = new BusProductos().CargarComboModelo("MODELO_PRODUCTOS", idMarca , "MODE_MARC_ID");
            //cboModelo.ValueMember = "Id";
            //cboModelo.DisplayMember = "Descripcion";
        }

        private void cboMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex == 0)
            {
                LimpiarCombos(cboModelo, "--Seleccione una Marca--");
                LimpiarCombos(cboColor, "--Seleccione un Modelo--");
            }
            else
            {
                lblRequeridoMarca.Visible = false;
                cboModelo.DataSource = new BusProductos().CargarComboModelo(Convert.ToInt32(cboMarca.SelectedValue));
                cboModelo.ValueMember = "Id";
                cboModelo.DisplayMember = "Descripcion";
                LimpiarCombos(cboColor, "--Seleccione un Modelo--");
            }

        }



        private void cboModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboModelo.SelectedIndex == 0)
            {
                LimpiarCombos(cboColor, "--Seleccione un Modelo--");
            }
            else
            {
                lblRequeridoModel.Visible = false;
                cboColor.DataSource = new BusProductos().CargarComboColor(Convert.ToInt32(cboModelo.SelectedValue));
                cboColor.ValueMember = "Id";
                cboColor.DisplayMember = "Descripcion";
            }
        }
        private void LimpiarCombos(ComboBox cboNombre, string seleccion)
        {
            cboNombre.DataSource = null;
            cboNombre.ValueMember = null;
            cboNombre.DisplayMember = null;
            cboNombre.Items.Clear();
            cboNombre.Items.Insert(0, seleccion);
            cboNombre.SelectedIndex = 0;
        }
        private void LimpiarCampos()
        {
            txtClave.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtObservaciones.Text = "";
            cboCategoria.SelectedValue = 0;
            cboMarca.SelectedValue = 0;
            LimpiarCombos(cboModelo, "--Seleccione una Marca--");
            LimpiarCombos(cboColor, "--Seleccione un Modelo--");
            ActivarControles();
        }
        private void DesactivarControles()
        {
            txtClave.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCantidad.Enabled = false;
            txtObservaciones.Enabled = false;
            cboCategoria.Enabled = false;
            cboMarca.Enabled = false;
            cboModelo.Enabled = false;
            cboColor.Enabled = false;
        }
        private void ActivarControles()
        {
            txtClave.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCantidad.Enabled = true;
            txtObservaciones.Enabled = true;
            cboCategoria.Enabled = true;
            cboMarca.Enabled = true;
            cboModelo.Enabled = true;
            cboColor.Enabled = true;
        }
        private void EditarControles()
        {
            txtDescripcion.Enabled = true;
            //txtCantidad.Enabled = true;
            txtObservaciones.Enabled = true;
            cboCategoria.Enabled = true;
            cboMarca.Enabled = true;
            cboModelo.Enabled = true;
            cboColor.Enabled = true;
        }

        private void cboMarca_TextChanged(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex == 0)
            {
                LimpiarCombos(cboModelo, "--Seleccione una Marca--");
                LimpiarCombos(cboColor, "--Seleccione un Modelo--");
            }
            else
            {
                cboModelo.DataSource = new BusProductos().CargarComboModelo(Convert.ToInt32(cboMarca.SelectedValue));
                cboModelo.ValueMember = "Id";
                cboModelo.DisplayMember = "Descripcion";
                LimpiarCombos(cboColor, "--Seleccione un Modelo--");
            }
        }

        private void cboModelo_TextChanged(object sender, EventArgs e)
        {
            if (cboModelo.SelectedIndex == 0)
            {
                LimpiarCombos(cboColor, "--Seleccione un Modelo--");
            }
            else
            {
                cboColor.DataSource = new BusProductos().CargarComboColor(Convert.ToInt32(cboModelo.SelectedValue));
                cboColor.ValueMember = "Id";
                cboColor.DisplayMember = "Descripcion";
            }
        }

        private void cboMarca_Leave(object sender, EventArgs e)
        {
            int index = cboMarca.FindString(cboMarca.Text);
            if (index < 0)
            {
                cboMarca.SelectedValue = 0;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            vl.ValidarCamposTexto(txtDescripcion, "^[0-9a-zA-ZñÑáéíóúÁÉÍÓÚ\\ _\\-\\.\\#\\/\\,\\s\\xF1\\xD1]+$", "min");
            vl.RestanCaracteres(txtDescripcion, 100, lblRestanDesc);
            lblRequeridoDesc.Visible = false;
        }

        private void AltaProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z01]?"))
            //{
            //    MessageBox.Show("aceptado");
            //}
            //else
            //{
            //    MessageBox.Show("No aceptado");
            //}
        }
        private void txtObservaciones_TextChanged_1(object sender, EventArgs e)
        {
            vl.ValidarCamposTexto(txtObservaciones, "^[0-9a-zA-ZñÑáéíóúÁÉÍÓÚ\\ _\\-\\.\\#\\/\\,\\s\\xF1\\xD1]+$", "min");
            vl.RestanCaracteres(txtObservaciones, 250, lblRestanObse);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            vl.ValidarCamposTexto(txtCantidad, "^[0-9]+$", "min");
            lblRequeridoCant.Visible = false;
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            vl.ValidarCamposTexto(txtClave, "^[0-9a-zA-Z]+$", "may");
            lblRequeridoClave.Visible = false;

        }
        //private void txtClave_GotFocus(object sender, EventArgs e)
        //{
        //    pB1.Visible = true;
        //}

        private void AltaProductos_Paint(object sender, PaintEventArgs e)
        {
        }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblRequeridoCat.Visible = false;
        }

        private void cboColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblRequeridoColor.Visible = false;
        }



        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            Boolean bol;
            AgregarPrecio ap = new AgregarPrecio();
            DateTime fechaInicio;
            DateTime fechaFin;
            bol = new BusProductos().ValidarPrecio(txtClave.Text);
            if (bol == true)
            {
                List<string> lst = new BusProductos().ObtenerPrecio(txtClave.Text);
                ap.hidIdPrecio.Text = lst[0];
                ap.txtPrecioCompra.Text = lst[1];
                ap.txtPrecioVenta.Text = lst[2];
                fechaInicio = Convert.ToDateTime(lst[3]);
                ap.dtFechaInicio.Text = fechaInicio.ToString("dd/MM/yyyy");
                fechaFin = Convert.ToDateTime(lst[4]);
                ap.dtFechaFin.Text = fechaFin.ToString("dd/MM/yyyy");
                ap.txtPrecioCompra.Enabled = false;
                ap.txtPrecioVenta.Enabled = false;
                ap.dtFechaInicio.Enabled = false;
                ap.dtFechaFin.Enabled = false;

            }
            else
            {
                ap.hidIdPrecio.Text = "";
            }

            ap.lblClaveProducto.Text = txtClave.Text;
            ap.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ObtenerProducto(string clave)
        {
            EntProductos ent = new EntProductos();
            ent = new BusProductos().ObtenerProducto(clave);
            txtDescripcion.Text = ent.Descripcion;
            txtCantidad.Text = ent.Cantidad.ToString();
            txtObservaciones.Text = ent.Observaciones;
            cboCategoria.SelectedValue = ent.CategoriaId;
            cboMarca.SelectedValue = ent.MarcaId;
            cboModelo.SelectedValue = ent.ModeloId;
            cboColor.SelectedValue = ent.ColorId;
            lblFechaAlta.Text = ent.FechaAlta.ToString("dd/MM/yyyy");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblRestanObse_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                StockProductos sp = new StockProductos(); ; //creamos un objeto del formulario 2
                sp.txtCantidadActual.Enabled = false;
                sp.txtCantidadActual.Text = txtCantidad.Text;
                sp.lblClaveProducto.Text = txtClave.Text;
                // sp.ShowDialog();
                DialogResult res = sp.ShowDialog(); //abrimos el la ventana de stock como cuadro de dialogo modal


                if (res == DialogResult.Cancel)
                {
                    //recuperando la variable publica del formulario Stock
                    txtCantidad.Text = sp.stockNuevo.ToString(); //asignamos al texbox el dato de la variable
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al intentar Actualizar la cantidad desde la ventana stock. " + ex + "", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void StockProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //StockProductos sp = new StockProductos();
            //txtCantidad.Text=sp.stockNuevo.ToString();
        }

        private void btnCBarras_Click(object sender, EventArgs e)
        {
            CodigoBarrasViewer cbv = new CodigoBarrasViewer();
            //ReportDocument rep = new ReportDocument();
            //rep.Load(@"C:\\Leonel\\SISCOMIC DESKTOP\\SISCOMIC DESKTOP\\Reportes\rptProductosCB.rpt"); //C:\Leonel\SISCOMIC DESKTOP\SISCOMIC DESKTOP\Reportes\rptProductosCB.rpt
            //rep.SetDataSource(new BusProductos().ObtenerProductoId(txtClave.Text));
            cbv.txtProductoId.Text = txtClave.Text;
            cbv.txtProdDescripcion.Text = txtDescripcion.Text;
            cbv.txtTamaño.Text = "Carta";
            cbv.ShowDialog();
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {

        }

    }
}
