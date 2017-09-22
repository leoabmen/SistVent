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
    public partial class Login : Form
    {
        int contador = 1;
        int contadorDos = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrarMouseUp_Press(object sender, MouseEventArgs e)
        {
            btnEntrar.Image = System.Drawing.Bitmap.FromFile(@"Images/sigin.png");
            btnEntrar.ForeColor = System.Drawing.Color.Black;
        }

        private void btnEntrarMouseDown_Press(object sender, MouseEventArgs e)
        {
            btnEntrar.Image = System.Drawing.Bitmap.FromFile(@"Images/siginB.png");
            btnEntrar.ForeColor = System.Drawing.Color.White;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                BusSeguridad s = new BusSeguridad();
                string strCadenaPass = s.cifrar(txtContraseña.Text);
                Boolean bolUser = new BusUsuarios().GetUsuarios(txtUsuario.Text);

                if (bolUser == true)
                {


                    Boolean bolPass = new BusUsuarios().GetContraseñas(txtUsuario.Text, strCadenaPass);

                    if (bolPass == true)
                    {
                        new BusGlobalUsuarios().ObtenerDatosGlobales(txtUsuario.Text);
                        if (EntGlobalUsuarios.Estatus == 1)
                        {
                            this.Hide();
                            Menu m = new Menu();
                            m.Show();
                            //  this.Hide();
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("¡Este Usuario se encuentra Bloquedo!"+"\n"+"Ponganse en contacto con el administrador del sistema"+"\n"+"para resolver este problema.");
                            Application.ExitThread();
                        }

                       
                    }
                    else
                    {

                        MessageBox.Show("Contraseña Incorrecta", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (contadorDos == 3)
                        {
                            Application.ExitThread();
                        }
                        contadorDos++;

                        txtContraseña.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (contador == 3)
                    {
                        Application.ExitThread();
                    }
                    contador++;

                    txtUsuario.Focus();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex + "", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                // throw;
            }



        }

        private void btnSalirMouseDown_Press(object sender, MouseEventArgs e)
        {
            btnSalir.Image = System.Drawing.Bitmap.FromFile(@"Images/cancelB.png");
            btnSalir.ForeColor = System.Drawing.Color.White;
        }

        private void btnSalirMouseUp_Press(object sender, MouseEventArgs e)
        {
            btnSalir.Image = System.Drawing.Bitmap.FromFile(@"Images/cancel.png");
            btnSalir.ForeColor = System.Drawing.Color.Black;
        }

        private void txtContraseñaKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }


        private void txtUsuarioKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
               "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
            }
            else
            {
                Application.ExitThread();

            }
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

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Enter) //Quita el Sonido de Windows
            {
                e.Handled = true; 
            }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
