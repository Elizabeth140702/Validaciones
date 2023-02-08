using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox4.Enabled = false;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static bool ValidarEmail(string email)
        {
            return email != null && Regex.IsMatch(email, "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$");
        }
        public static bool Email(string comprobacionEmail)
        {
            string formatoEmail;
            formatoEmail = "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$";
            if (Regex.IsMatch(comprobacionEmail, formatoEmail)) {
                if (Regex.Replace(comprobacionEmail, formatoEmail, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool CURP(string comprobacionCurp)
        {
            string formatoCurp;
            formatoCurp = "^([A-Z][AEIOUX][A-Z]{2}\\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\\d])(\\d)$";
            if (Regex.IsMatch(comprobacionCurp, formatoCurp))
            {
                if (Regex.Replace(comprobacionCurp, formatoCurp, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Email(txtEmail.Text) == true)
            {
                textBox6.Text = "Valido";
                groupBox4.Enabled = true;
                textBox6.ForeColor = Color.Green;
            }
            else
            {
                textBox6.Text = "No válido";
                groupBox4.Enabled = true;
                textBox6.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CURP(txtCurp.Text) == true)
            {
                textBox8.Text = "Valido";
                groupBox4.Enabled = true;
                textBox8.ForeColor = Color.Green;
            }
            else
            {
                textBox8.Text = "No válido";
                groupBox4.Enabled = true;
                textBox8.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCurp.Clear();
            textBox8.Clear();
        }
        public static bool RFC(string comprobacionRfc)
        {
            string formatoRfc;
            formatoRfc = "[A-z]{4}[0-9]{6}[A-z0-9]{3}";
            if (Regex.IsMatch(comprobacionRfc, formatoRfc))
            {
                if (Regex.Replace(comprobacionRfc, formatoRfc, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (RFC(txtRfc.Text) == true)
            {
                textBox10.Text = "Valido";
                groupBox4.Enabled = true;
                textBox10.ForeColor = Color.Green;
            }
            else
            {
                textBox10.Text = "No válido";
                groupBox4.Enabled = true;
                textBox10.ForeColor = Color.Red;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtRfc.Clear();
            textBox10.Clear();
        }
        public static bool Hora12(string comprobacionHora12)
        {
            string formatoHora12;
            formatoHora12 = "^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$";
            if (Regex.IsMatch(comprobacionHora12, formatoHora12))
            {
                if (Regex.Replace(comprobacionHora12, formatoHora12, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Hora12(txtHora.Text) == true)
            {
                textBox9.Text = "Valido";
                groupBox4.Enabled = true;
                textBox9.ForeColor = Color.Green;
            }
            else
            {
                textBox9.Text = "No válido";
                groupBox4.Enabled = true;
                textBox9.ForeColor = Color.Red;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtRfc.Clear();
            textBox9.Clear();
        }
        public static bool Fecha (string comprobacionFecha)
        {
            string formatoFecha;
            formatoFecha = "^([0-2][0-9]|3[0-1])(\\/)(0[1-9]|1[0-2])\\2(\\d{4})$";
            if (Regex.IsMatch(comprobacionFecha, formatoFecha))
            {
                if (Regex.Replace(comprobacionFecha, formatoFecha, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Fecha(txtFecha.Text) == true)
            {
                textBox7.Text = "Valido";
                groupBox4.Enabled = true;
                textBox7.ForeColor = Color.Green;
            }
            else
            {
                textBox7.Text = "No válido";
                groupBox4.Enabled = true;
                textBox7.ForeColor = Color.Red;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            txtFecha.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
} 