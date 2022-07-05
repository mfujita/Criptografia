using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;

namespace Fujicrypt
{
    class MapaDeBits
    {
        public string chave;
        private Bitmap imagem;

        public MapaDeBits(string texto)
        {
            chave = texto;
            imagem = new Bitmap(256, 256);
        }

        public void PintaPixelsAleatoriamente()
        {
            int x, y;
            Random r = new Random();

            int res;
            for (y = 0; y < imagem.Height; y++)
            {
                for (x = 0; x < imagem.Width; x++)
                {
                    res = r.Next(0, 2);
                    if (res.Equals(0))
                        imagem.SetPixel(x, y, Color.White);
                    else
                        imagem.SetPixel(x, y, Color.Black);
                }
            }
        }

        public string GeraChave()
        {
            int i;
            double somaDosValoresChave = 0;
            byte[] ansi = Unicode2ANSI(chave);
            chave = "";

            for (i = 0; i < ansi.Length; i++)
            {
                somaDosValoresChave += ansi[i]; //soma os valores decimais de cada caracter
            }
            
            int mediaDosValoresChave = Convert.ToInt32(Math.Truncate(somaDosValoresChave / 8)); //obtem a media dos valores decimais que compõem a chave
            int p8 = mediaDosValoresChave % 2;
            int dividendo = mediaDosValoresChave / 2;
            int p7 = mediaDosValoresChave % 2;
            //int dividendo = mediaDosValoresChave / 2;
            dividendo /= 2;
            int p6 = dividendo % 2;
            dividendo /= 2;
            int p5 = dividendo % 2;
            dividendo /= 2;
            int p4 = dividendo % 2;
            dividendo /= 2;
            int p3 = dividendo % 2;
            dividendo /= 2;
            int p2 = dividendo % 2;
            dividendo /= 2;
            int p1 = dividendo % 2;
            dividendo /= 2;
            int p0 = dividendo % 2;
            //Obtém a CHAVE que é composta pela media dos valores decimais do campo txtChaveCriptografar e transforma em bits
            //chave += "1" + p0.ToString() + p1.ToString() + p2.ToString() + p3.ToString() + p4.ToString() + p5.ToString() + p6.ToString() + p7.ToString();
            chave += p0.ToString() + p1.ToString() + p2.ToString() + p3.ToString() + p4.ToString() + p5.ToString() + p6.ToString() + p7.ToString() + p8.ToString();

            return chave;
        }

        public bool ConverteTextoEmPixels()
        {
            int i, x, y, posicao = 0, tamanho;
            string cadeia = "";
            bool verifica = false;

            byte[] ansi = Unicode2ANSI(chave);

            for (i = 0; i < ansi.Length; i++)
            {
                cadeia += Convert.ToString(ansi[i], 2).PadLeft(8, '0');
            }

            tamanho = cadeia.Length; // Completa com 0 até obter 64 bits
            for (i = tamanho + 1; i <= 64; i++)
            {
                cadeia += "0";
            }

            for (y = 40; y < 48; y++)
            {
                for (x = 150; x < 158; x++)
                {
                    string zeroOuUm = cadeia.Substring(posicao, 1);
                    posicao++;
                    if (zeroOuUm.Equals("0"))
                        imagem.SetPixel(x, y, Color.White);
                    else
                        imagem.SetPixel(x, y, Color.Black);
                }
            }

            imagem.Save("esteganografia.bmp");
            if (File.Exists("esteganografia.bmp"))
                verifica = true;

            return verifica;
        }

        private byte[] Unicode2ANSI(string text)
        {
            System.Text.Encoding codificador = System.Text.Encoding.GetEncoding("UTF-8");
            Byte[] ansi = codificador.GetBytes(text);
            int comprimento = ansi.Length;

            return ansi;
        }
    }
}
