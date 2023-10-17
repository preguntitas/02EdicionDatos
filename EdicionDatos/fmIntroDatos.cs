using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EdicionDatos
{
    public partial class fmIntroDatos : Form
    {
        public System.Windows.Forms.TextBox tbNombreMostrar;
        public fmIntroDatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNombreMostrar.Text = tbNombreSecundario.Text;
        }

        private void fmIntroDatos_Load(object sender, EventArgs e)
        {
            foreach (Control micontrol in Controls)
            {
                if (micontrol is System.Windows.Forms.TextBox)
                {
                    micontrol.Text = "";
                }
            }
            tbContra2.Enabled = false; //Deshabilitamos controles para
            laContra2.Enabled = false; // contraseña 2
            tbNombreSecundario.Focus(); //Envía el foco al primer textbox
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)8:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    break;
                default:
                    e.KeyChar = (char)0; //anulamos la pulsación
                    break;
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == "") return; // Para poder dejarlo en blanco
            string[] postarroba = tbEmail.Text.Split('@');
            if ((tbEmail.Text.IndexOf("@") < 0) ||
            (tbEmail.Text.IndexOf(".") < 0))
            {
                try
                {
                    if (postarroba[1].IndexOf(".") < 0)
                    {
                        MessageBox.Show("email inválido");
                        tbEmail.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("email inválido");
                    tbEmail.Focus();
                }
            }
        }

        private void tbContra1_TextChanged(object sender, EventArgs e)
        {
            laContra2.Enabled = tbContra1.TextLength != 0; // Des-Habilitamos
            tbContra2.Enabled = tbContra1.TextLength != 0; // si hay texto o no
        }

        private void tbContra2_Validating(object sender, CancelEventArgs e)
        {
            if (tbContra2.Text == "")
            {
                tbContra1.Text = ""; // Dejamos ambas en blanco
                return;
                // Salimos de validating
            }
            if ((tbContra1.Text != tbContra2.Text))
            {
                MessageBox.Show("Las contraseñas deben coincidir");
                tbContra1.Focus();
            }
        }

        private void tbContra1_Validating(object sender, CancelEventArgs e)
        {
            if (tbContra1.Text == "")
            {
                tbContra2.Text = ""; // Dejamos ambas en blanco
                return;
                // Salimos de validating
            }
            if ((tbContra2.Text != tbContra2.Text))
            {
                MessageBox.Show("Las contraseñas deben coincidir");
                tbContra2.Focus();
            }
        }

        private void tbDNICIF_Validating(object sender, CancelEventArgs e)
        {
            if ((tbDNICIF.Text.Length > 0) && (tbDNICIF.Text.Length < 9))
            {
                MessageBox.Show("DNI/CIF Debe tener 9 caracteres, completa con ceros, si tiene menos");
                tbDNICIF.Focus();
            }
        }

        private void tbDNICIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // tbDNICIF.TextLength Hace lo mismo
                if ((tbDNICIF.Text.Length > 0) && (tbDNICIF.Text.Length < 8))
                {
                    switch (e.KeyChar)
                    {
                        case (char)8:
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                            break;
                        default:
                            e.KeyChar = (char)0;
                            break;
                    }
                }
            }
        }

        private void tbDNICIF_TextChanged(object sender, EventArgs e)
        {
            string dni; char letra; char digi; bool esnumero = true;
            dnivalido = true;
            if (tbDNICIF.Text == "") return;
            digi = (char)tbDNICIF.Text[0];
            switch (digi)//comprobamos si el 1o carácter es letra o número
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0': break;
                default:
                    esnumero = false;
                    break;
            }
            if ((tbDNICIF.Text.Length == 9) && (esnumero))
            {
                letra = tbDNICIF.Text[8];
                dni = tbDNICIF.Text.Substring(0, 8);
                if (!calculaletranif(Convert.ToInt32(dni), letra))
                {
                    MessageBox.Show(letra + " Letra mal");
                    dnivalido = false;
                    tbDNICIF.Focus();
                }
            }
            else
            {
                if ((tbDNICIF.Text.Length == 9) && (!esnumero))
                {
                    if (!validacif(tbDNICIF.Text))
                    {
                        MessageBox.Show("CIF no Válido");
                        dnivalido = false;
                        tbDNICIF.Focus();
                    }
                }
            }
        }
        bool dnivalido = true; // variable necesaria definida de forma global

        //inicio de función comprueba NIF de un DNI
        public bool calculaletranif(int dni, char letra)
        {
            char letracorrecta;
            int resto; // resto de la funcion para saber la letra en la cadena
            string letras = "TRWAGMYFPDXBNJZSQUHLCKE";
            resto = dni % 23;
            letracorrecta = letras[resto]; // esto es lo que devuelve la funcion
            if (letracorrecta == letra)
                return true;
            else
            {
                return false;
                //este código se pone cuando mostramos letra buena al usuario
                // otroDNI = tbDNICIF.Text; //otroDNI.Remove(9, 1);
                //otroDNI.Insert(9, Convert.ToString(letracorrecta)); 
                //tbDNICIF.Text= otroDNI;
            }
        }
        //Inicio de función para comprobar si un CIF es válido
        public bool validacif(string cif)
        {
            int Suma = 0, Control; byte n; bool Resulta = false;
            if (cif.Length == 9)
            { //sumar las cifras pares
                Suma = Convert.ToInt32(Convert.ToString(cif[2])) +
                Convert.ToInt32(Convert.ToString(cif[4])) +
                Convert.ToInt32(Convert.ToString(cif[6]));
                for (n = 0; n <= 3; n++)
                {//suma los impares
                    string impares = Convert.ToString(
                    Convert.ToInt32(Convert.ToString(cif[n * 2 + 1])) * 2);
                    Suma = Suma + Convert.ToInt32(Convert.ToString(impares[0]));
                    if (impares.Length > 1)
                        Suma = Suma +
                        Convert.ToInt32(Convert.ToString(impares[1]));
                }
                Control = 10 - (Suma % 10);
                string primercar = Convert.ToString(cif[0]);
                if ((primercar.IndexOf("X") >= 0)
                || (primercar.IndexOf("P") >= 0))
                { //Control tipo letra
                    Resulta = (cif[8] == (char)(64 + Control));
                }
                else
                { //Control tipo número
                    if (Control == 10) Control = 0;
                    Resulta = (Convert.ToString(cif[8])) ==
                    Convert.ToString(Control);
                }
            }//DEL IF
            return Resulta;
        } //fin de la función 

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tbDNICIF.Text == "")
            {
                MessageBox.Show("FALTA EL DNI");
                tbDNICIF.Focus();
                return;
            }
            if (!dnivalido)
            {
                MessageBox.Show("DNI No valido");
                tbDNICIF.Focus();
                return;
            }
            if (tbNombreSecundario.Text == "")
            {
                MessageBox.Show("FALTA EL NOMBRE");
                tbNombreSecundario.Focus();
                return;
            }
            DialogResult = DialogResult.OK; //cierra formulario envía OK
        }

        private void fmIntroDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Al pulsar intro
            {
                if (ActiveControl is System.Windows.Forms.TextBox) // solo en los textbox
                {
                    SendKeys.Send("{TAB}"); //enviamos señal de tecla Tab
                }
            }
        }
    }
}
