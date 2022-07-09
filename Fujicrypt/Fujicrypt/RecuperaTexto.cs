using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fujicrypt
{
    class RecuperaTexto
    {
        public string GetText()
        {
            Bitmap imagem = new Bitmap("chave.jpg");

            int i, x, y, pos8;
            string caracter = string.Empty;

            for (y = 40; y < 48; y++)
            {
                for (x = 150; x < 158; x++)
                {                    
                    if (imagem.GetPixel(x, y).R.ToString().Equals("255"))
                        caracter += 0;
                    else
                        caracter += 1;
                }
            }

            string[] decimais = new string[8]; // declaração do vetor que recebe os valores de binario para decimal
            int caracter2numero;
            string palavra = "";
            double somaDoVetorDecimais = 0;
            double mediaDoVetorDecimais;

            pos8 = 0;
            for (i = 0; i < 8; i++)
            {
                decimais[i] = caracter.Substring(pos8, 8);
                pos8 += 8;
                caracter2numero = Convert.ToInt32(decimais[i], 2);
                palavra += (char)caracter2numero;
                somaDoVetorDecimais += Convert.ToInt32(decimais[i]);
            }

            mediaDoVetorDecimais = Math.Truncate(somaDoVetorDecimais / 8);
            
            return palavra;
        }
    }
}
