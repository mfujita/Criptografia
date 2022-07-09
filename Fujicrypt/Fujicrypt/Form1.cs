namespace Fujicrypt
{
    public partial class Form1 : Form
    {
        private string textoDaImagem = "";
        public Form1()
        {
            InitializeComponent();
            //txtTplano.Text = "Murilo Fujita";
            //txtChaveCriptografar.Text = "12345678";
            //txtChaveDecriptografadora.Text = "12345678";
            lblDecripto2Arquivos.Text = "Selecione o arquivo com o conteúdo criptografado e o desenho contendo a chave.";
        }

        private void btnPlano2Cripto_Click(object sender, EventArgs e)
        {
            if (txtChaveCriptografar.Text.Length >= 4 && txtChaveCriptografar.Text.Length <= 8)
            {
                txtCriptografado.Text = "";
                Criptografadora cripto = new Criptografadora(txtTplano.Text);
                byte[] ansi = cripto.FazSubstituicao();

                string binario = cripto.Decimal2Binary();

                MapaDeBits mdb = new MapaDeBits(txtChaveCriptografar.Text);
                string chave = mdb.GeraChave();

                string textoPermutado = ""; //Executa a operação XOR 16 vezes
                //for (int i = 0; i < 16; i++)
                //{
                    textoPermutado = cripto.PermutaComChave(binario, chave);
                //}

                char[] textoCriptografado = cripto.Binary2Char(textoPermutado);

                FileStream fs = new FileStream("cripto.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < textoCriptografado.Length; i++)
                {
                    txtCriptografado.Text += textoCriptografado[i];
                    sw.Write(textoCriptografado[i]);
                }

                sw.Close();

                MapaDeBits mbits = new MapaDeBits(txtChaveCriptografar.Text);
                mbits.PintaPixelsAleatoriamente();

                if (mbits.ConverteTextoEmPixels())
                {
                    MessageBox.Show("Arquivo criado com sucesso.");
                }
            }

            else
            {
                MessageBox.Show("A chave deve ter no mínimo 4 e no máximo 8 caracteres.");
            }
        }

        private void btnSelecionaArquivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = Path.GetFileName(openFileDialog1.FileName);
                if (nomeArquivo.Equals("chave.jpg"))
                {
                    btnDecriptografar.Enabled = true;
                    string arquivoEsteganografia = openFileDialog1.FileName;
                    RecuperaTexto rt = new RecuperaTexto();
                    textoDaImagem = rt.GetText();
                }
            }
        }

        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            string senhaDigitada = txtChaveDecriptografadora.Text.Trim();
            if (textoDaImagem == senhaDigitada)
            { 
                FileStream fs = new FileStream("cripto.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string criptografado = sr.ReadToEnd();
                Criptografadora cripto = new Criptografadora(criptografado);
                string binario = cripto.Decimal2Binary();

                MapaDeBits mdb = new MapaDeBits(txtChaveDecriptografadora.Text);
                string chave = mdb.GeraChave();

                string textoSemPermutacao = ""; //Executa a operação XOR 16 vezes
                //for (int i = 0; i < 16; i++)
                //{
                    textoSemPermutacao = cripto.DesfazPermutacaoComChave(binario, chave);
                //}
                ////////txtLegivel.Text += textoSemPermutacao + "     texto sem permutação \r\n";
            
                char[] binary2character = cripto.Binary2Char(textoSemPermutacao);
                byte[] substituicaoDesfeita = cripto.DesfazSubstituicao(binary2character);

                string decimalParaBinario = cripto.Decimal2Binary(substituicaoDesfeita);

                char[] binariosLegiveis = cripto.Binary2Char(decimalParaBinario);

                for (int i = 0; i < binariosLegiveis.Length; i++)
                {
                    if (Convert.ToInt32(binariosLegiveis[i]) == 13)
                        txtLegivel.Text += "\r\n";

                    if (Convert.ToInt32(binariosLegiveis[i]) == 20)
                        continue;

                    txtLegivel.Text += binariosLegiveis[i].ToString();
                }
            }
            else
            {
                MessageBox.Show("Senha digitada ou arquivo não confere!", "Aviso");
            }
        }
    }
}

/*
Versáo 1.2 - aumento da segurança executando a operação XOR 16 vezes 
Versão 1.1 - integração dos protótipos key2draw e draw2key exigindo que apresente o arquivo estenografia.bmp e a "senha".
Versão 1.0 - criptação com a chave fixa "10001000".
*/