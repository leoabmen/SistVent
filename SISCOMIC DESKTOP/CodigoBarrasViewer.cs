using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Stmx.Siscomic.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCOMIC_DESKTOP
{
    public partial class CodigoBarrasViewer : Form
    {
        ValidacionCampos vl = new ValidacionCampos();
        string pathReporteCarta = Path.Combine(Application.StartupPath, "Reportes\\ReportesCB\\rptClaveCBCarta.rpt"); //Libreria para Path system.io, Ruta relativa para no ocasionar problemas al generar exe.
        string pathReporteTicket = Path.Combine(Application.StartupPath, "Reportes\\ReportesCB\\rptClaveCBTicket.rpt");
        public CodigoBarrasViewer()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CodigoBarrasViewer_Load(object sender, EventArgs e)
        {
            ReportDocument rep = new ReportDocument();
            //rep.Load(@"C:\\Leonel\\SISCOMIC DESKTOP\\SISCOMIC DESKTOP\\Reportes\rptClaveCBCarta.rpt"); //C:\Leonel\SISCOMIC DESKTOP\SISCOMIC DESKTOP\Reportes\rptProductosCB.rpt
            rep.Load(pathReporteCarta);
            rep.SetDataSource(new BusProductos().ObtenerProductoIdCB(txtProductoId.Text, 0));
            crvReporteCB.ReportSource = rep;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ReportDocument rep = new ReportDocument();
           //rep.Load(@"C:\\Leonel\\SISCOMIC DESKTOP\\SISCOMIC DESKTOP\\Reportes\rptClaveCBTicket.rpt"); //C:\Leonel\SISCOMIC DESKTOP\SISCOMIC DESKTOP\Reportes\rptProductosCB.rpt
            rep.Load(pathReporteTicket);
            rep.SetDataSource(new BusProductos().ObtenerProductoIdCB(txtProductoId.Text, txtCopias.Text == "" ? 0 : (int.Parse(txtCopias.Text))-1));
            crvReporteCB.ReportSource = rep;
            txtTamaño.Text = "Ticket";
        }

        private void txtCopias_TextChanged(object sender, EventArgs e)
        {
            vl.ValidarCamposTexto(txtCopias, "^[0-9]+$", "min");
        }

        private void btnCopiasCarta_Click(object sender, EventArgs e)
        {
            ReportDocument rep = new ReportDocument();
            //rep.Load(@"C:\\Leonel\\SISCOMIC DESKTOP\\SISCOMIC DESKTOP\\Reportes\rptClaveCBCarta.rpt"); //C:\Leonel\SISCOMIC DESKTOP\SISCOMIC DESKTOP\Reportes\rptProductosCB.rpt
            rep.Load(pathReporteCarta);
            rep.SetDataSource(new BusProductos().ObtenerProductoIdCB(txtProductoId.Text, txtCopias.Text == "" ? 0 : (int.Parse(txtCopias.Text)) - 1));
            crvReporteCB.ReportSource = rep;
            txtTamaño.Text = "Carta";
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscar");
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ReportDocument rep = new ReportDocument();
        //        rep.Load(@"C:\\Leonel\\SISCOMIC DESKTOP\\SISCOMIC DESKTOP\\Reportes\CrystalReport3.rpt"); //C:\Leonel\SISCOMIC DESKTOP\SISCOMIC DESKTOP\Reportes\rptProductosCB.rpt
        //        rep.SetDataSource(new BusProductos().ObtenerProductoIdCB(txtProductoId.Text, txtCopias.Text == "" ? 0 : (int.Parse(txtCopias.Text)) - 1));
        //        crvReporteCB.ReportSource = rep;
        //        rep.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"E:\\ASD.pdf");
        //        MessageBox.Show("Exported Successful");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //} 
    }
}
