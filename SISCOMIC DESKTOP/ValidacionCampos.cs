using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCOMIC_DESKTOP
{
    public class ValidacionCampos
    {
        public Boolean ValidarRequeridoTexto(TextBox campo, int tamañoMin, Label mensaje)
        {
            if (campo.Text == "" || campo.TextLength < tamañoMin)
            {
                if (campo.TextLength > 0 && campo.TextLength < tamañoMin)
                {
                    mensaje.Text = "* Mínimo " + tamañoMin + " caracteres";
                }
                else
                {
                    mensaje.Text = "* Requerido";
                }
                mensaje.Visible = true;
                campo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean ValidarRequeridoCombo(ComboBox combo, int valorMin, Label mensaje)
        {

            if (combo.SelectedIndex == valorMin)
            {
                mensaje.Text = "* Selecciona un valor";
                mensaje.Visible = true;
                combo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ValidarCamposTexto(TextBox campoTexto, string expresion, string tipoLetra)
        {
            string texto = campoTexto.Text;
            String pattern = expresion;
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(pattern);
            if (regex.IsMatch(campoTexto.Text))
            {

                if (tipoLetra == "min")
                {
                    if (texto.Length == 1)
                    {
                        campoTexto.Select(campoTexto.TextLength, 0);
                        campoTexto.Text = texto.ToUpper();
                        //}else
                        //  if(texto.Length > 1){
                        // campoTexto.Select(campoTexto.TextLength, 0);
                        //   campoTexto.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.to(texto);
                        // campoTexto.SelectionStart = campoTexto.Text.Length;
                    }
                    else
                    {
                        campoTexto.Text = texto;
                    }
                }
                else if (tipoLetra == "may")
                {
                    // campoTexto.Select(campoTexto.TextLength, 0);
                    // campoTexto.SelectionStart = campoTexto.SelectionStart;
                    //  campoTexto.Select(campoTexto.TextLength,0);
                    //  campoTexto.Text = texto.ToUpper();
                    //   campoTexto.SelectionStart=campoTexto.CharacterCasing;
                    campoTexto.CharacterCasing = CharacterCasing.Upper;
                    //string str;
                    //str = texto.ToUpper();
                    //char[] arr = str.ToCharArray();
                    //Array.Reverse(arr);
                    //string str2 = new string (arr);
                    //campoTexto.Text = str2;
                    //char letra = Convert.ToChar(texto);
                    //letra = char.ToUpper(letra);
                    //texto= Convert.ToString(letra);
                    //campoTexto.Text = texto;
                    // campoTexto.Text = string.Concat((texto.ToList().ConvertAll(c => Char.IsLower(c) ? Char.ToUpper(c) : Char.ToLower(c))));
                }

            }
            else
            {
                int tamañoOriginal = texto.Length;
                int tamañoRestado = texto.Length - 1;

                if (tamañoOriginal > 0)
                {
                    texto = texto.Substring(0, tamañoRestado);
                    campoTexto.Text = texto;
                    campoTexto.Select(campoTexto.TextLength, 0);
                }
                else
                {
                    campoTexto.Text = texto.Substring(0, tamañoOriginal);
                    campoTexto.Text = texto;
                    campoTexto.Select(campoTexto.TextLength, 0);
                }
            }
        }
        public void RestanCaracteres(TextBox campoTexto, int limite, Label lblMostrar)
        {
            // string tamañoTexto = campoTexto.Text;
            //  int tamañoTexto = texto.Length;
            if (campoTexto.TextLength >= limite - 30)
            {
                lblMostrar.Visible = true;
                lblMostrar.Text = "Restan: " + (limite - campoTexto.TextLength) + " caracteres";
            }
            else
            {
                lblMostrar.Visible = false;
            }
        }
    }
}
