namespace Fujicrypt
{
    public partial class Form1 : Form
    {
        private string chave = "";
        public Form1()
        {
            InitializeComponent();
            txtTplano.Text = "Murilo Fujita";
            txtChaveCriptografar.Text = "12345678";
        }

        private void btnPlano2Cripto_Click(object sender, EventArgs e)
        {
            if (txtChaveCriptografar.Text.Length >= 4 && txtChaveCriptografar.Text.Length <= 8)
            {
                txtCriptografado.Text = "";
                Criptografadora cripto = new Criptografadora(txtTplano.Text);
                Byte[] ansi = cripto.FazSubstituicao();

                string binario = cripto.Decimal2Binary();

                //txtCriptografado.Text =  binario + "    binario \r\n";

                MapaDeBits mdb = new MapaDeBits(txtChaveCriptografar.Text);
                string chave = mdb.GeraChave();

                string textoPermutado = ""; //Executa a opera��o XOR 16 vezes
                for (int i = 0; i < 16; i++)
                {
                    textoPermutado = cripto.PermutaComChave(binario, chave);
                }

                //txtCriptografado.Text += textoPermutado + "    texto permutado \r\n";

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
                    //btnPlano2Cripto.Enabled = false;
                }
            }

            else
            {
                MessageBox.Show("A chave deve ter no m�nimo 4 e no m�ximo 8 caracteres.");
            }
        }

        private void btnSelecionaArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = Path.GetFileName(openFileDialog1.FileName);
                if (nomeArquivo.Equals("esteganografia.bmp"))
                {
                    btnDecriptografar.Enabled = true;
                    string arquivoEsteganografia = openFileDialog1.FileName;
                    RecuperaTexto rt = new RecuperaTexto(arquivoEsteganografia);
                    string textoDaImagem = rt.GetText();
                    string senhaDigitada = txtChaveDecriptografadora.Text.Trim();
                    //if (textoDaImagem.Equals(senhaDigitada))
                }
            }
        }

        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            txtLegivel.Text = "";
            Criptografadora cripto = new Criptografadora(txtSecreto.Text);
            string binario = cripto.Decimal2Binary();
            //txtLegivel.Text = binario + "     binario \r\n";

            MapaDeBits mdb = new MapaDeBits(txtChaveDecriptografadora.Text);
            chave = mdb.GeraChave();

            string textoSemPermutacao = ""; //Executa a opera��o XOR 16 vezes
            for (int i = 0; i < 16; i++)
            {
                textoSemPermutacao = cripto.DesfazPermutacaoComChave(binario, chave);
            }
            //txtLegivel.Text += textoSemPermutacao + "     texto sem permuta��o \r\n";
            char[] binary2character = cripto.Binary2Char(textoSemPermutacao);
            Byte[] substituicaoDesfeita = cripto.DesfazSubstituicao(binary2character);

            string decimalParaBinario = cripto.Decimal2Binary(substituicaoDesfeita);

            char[] binariosLegiveis = cripto.Binary2Char(decimalParaBinario);
            //char[] binariosLegiveis = cripto.Binary2CharDecriptar(decimalParaBinario);

            for (int i = 0; i < binariosLegiveis.Length; i++)
            {
                if (Convert.ToInt32(binariosLegiveis[i]) == 13)
                    txtLegivel.Text += "\r\n";

                if (Convert.ToInt32(binariosLegiveis[i]) == 20)
                    continue;

                // Na vers�o 1.1 a logica XOR originou o caracter 150                
                //if (Convert.ToInt32(binariosLegiveis[i]) == 150)
                //    txtLegivel.Text += " ";

                //if (Convert.ToInt32(binariosLegiveis[i]) == 139)
                //    txtLegivel.Text += " ";

                txtLegivel.Text += binariosLegiveis[i].ToString();
            }
        }
    }
}

/*
Vers�o 1.2 - aumento da seguran�a executando a opera��o XOR 16 vezes 
Vers�o 1.1 - integra��o dos prot�tipos key2draw e draw2key exigindo que apresente o arquivo estenografia.bmp e a "senha".
Vers�o 1.0 - cripta��o com a chave fixa "10001000".
*/