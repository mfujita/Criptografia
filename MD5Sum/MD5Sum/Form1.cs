/*
Versão 1.0: Transforma qualquer texto em um string de 128 bits. 04/06/2022 
*/

using System.Security.Cryptography;
using System.Text;

namespace MD5Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMD5Sum_Click(object sender, EventArgs e)
        {
            bool marked = false;
            string codificacao = "";

            if (txtSaida.Text != "")
                txtSaida.Text = "";

            foreach (var gb in Controls.OfType<GroupBox>())
            {
                foreach (var rb in gb.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                    {
                        marked = true;
                        codificacao = rb.Text;
                        break;
                    }
                }
            }

            if (txtEntrada.Text != "" && marked)
            {
                byte[] entrada = new byte[1];

                MD5 md5 = MD5.Create();
                
                switch(codificacao)
                {
                    case "UTF-8":
                        {
                            entrada = Encoding.UTF8.GetBytes(txtEntrada.Text);
                            break;
                        }
                    case "Unicode":
                        {
                            entrada = Encoding.Unicode.GetBytes(txtEntrada.Text);
                            break;
                        }
                    case "ASCII":
                        {
                            entrada = Encoding.ASCII.GetBytes(txtEntrada.Text);
                            break;
                        }
                }
                
                byte[] saida = md5.ComputeHash(entrada);

                txtSaida.Text += BitConverter.ToString(saida).Replace("-", "");
                txtSaida.Focus();
            }
            else if (txtEntrada.Text == "")
            {
                MessageBox.Show("Escreva o texto para calcular o Hash.");
                txtEntrada.Focus();
            }
            else if (!marked)
            {
                MessageBox.Show("Escolha a codificação do texto.");
            }
        }
    }
}