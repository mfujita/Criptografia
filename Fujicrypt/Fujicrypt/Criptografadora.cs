//https://segurancainformacao.wordpress.com/2008/12/10/introducao-a-criptografia-2/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Substitui caracteres
//abcdefghijklmnopqrstuvwxyz
//rstuvwxyzabcdefghijklmnopq
//hijklmnopqrstuvwxyzabcdefg

namespace Fujicrypt
{
    class Criptografadora
    {
        private Byte[] ansi;
        private string chave = ""; //"10001000";  //"01100001"; //"01001101"; // M (maiúsculo)

        //public Criptografadora()
        //{
        //    Byte[] ansi = Unicode2ANSI(texto);
        //}

        public Criptografadora(string texto)
        {
            ansi = Unicode2ANSI(texto);
        }

        private byte[] Unicode2ANSI(string texto)
        {
            System.Text.Encoding codificador = System.Text.Encoding.GetEncoding("UTF-8");
            Byte[] ansi = codificador.GetBytes(texto);

            return ansi;
        }

        public Byte[] FazSubstituicao(/*Byte[] ansi*/)
        {
            int i;
            for (i = 0; i < ansi.Length; i++)
            {
                if (ansi[i].Equals(65)) { ansi[i] = 82; } //A
                else if (ansi[i].Equals(66)) { ansi[i] = 83; } //B
                else if (ansi[i].Equals(67)) { ansi[i] = 84; }
                else if (ansi[i].Equals(68)) { ansi[i] = 85; }
                else if (ansi[i].Equals(69)) { ansi[i] = 86; }
                else if (ansi[i].Equals(70)) { ansi[i] = 87; }
                else if (ansi[i].Equals(71)) { ansi[i] = 88; }
                else if (ansi[i].Equals(72)) { ansi[i] = 89; }
                else if (ansi[i].Equals(73)) { ansi[i] = 90; }
                else if (ansi[i].Equals(74)) { ansi[i] = 65; }
                else if (ansi[i].Equals(75)) { ansi[i] = 66; }
                else if (ansi[i].Equals(76)) { ansi[i] = 67; }
                else if (ansi[i].Equals(77)) { ansi[i] = 68; }
                else if (ansi[i].Equals(78)) { ansi[i] = 69; }
                else if (ansi[i].Equals(79)) { ansi[i] = 70; }
                else if (ansi[i].Equals(80)) { ansi[i] = 71; }
                else if (ansi[i].Equals(81)) { ansi[i] = 72; }
                else if (ansi[i].Equals(82)) { ansi[i] = 73; }
                else if (ansi[i].Equals(83)) { ansi[i] = 74; }
                else if (ansi[i].Equals(84)) { ansi[i] = 75; }
                else if (ansi[i].Equals(85)) { ansi[i] = 76; }
                else if (ansi[i].Equals(86)) { ansi[i] = 77; }
                else if (ansi[i].Equals(87)) { ansi[i] = 78; }
                else if (ansi[i].Equals(88)) { ansi[i] = 79; }
                else if (ansi[i].Equals(89)) { ansi[i] = 80; }
                else if (ansi[i].Equals(90)) { ansi[i] = 81; }

                else if (ansi[i].Equals(97)) { ansi[i] = 114; } //a
                else if (ansi[i].Equals(98)) { ansi[i] = 115; } //b
                else if (ansi[i].Equals(99)) { ansi[i] = 116; }
                else if (ansi[i].Equals(100)) { ansi[i] = 117; }
                else if (ansi[i].Equals(101)) { ansi[i] = 118; }
                else if (ansi[i].Equals(102)) { ansi[i] = 119; }
                else if (ansi[i].Equals(103)) { ansi[i] = 120; }
                else if (ansi[i].Equals(104)) { ansi[i] = 121; }
                else if (ansi[i].Equals(105)) { ansi[i] = 122; }
                else if (ansi[i].Equals(106)) { ansi[i] = 97; }
                else if (ansi[i].Equals(107)) { ansi[i] = 98; }
                else if (ansi[i].Equals(108)) { ansi[i] = 99; }
                else if (ansi[i].Equals(109)) { ansi[i] = 100; }
                else if (ansi[i].Equals(110)) { ansi[i] = 101; }
                else if (ansi[i].Equals(111)) { ansi[i] = 102; }
                else if (ansi[i].Equals(112)) { ansi[i] = 103; }
                else if (ansi[i].Equals(113)) { ansi[i] = 104; }
                else if (ansi[i].Equals(114)) { ansi[i] = 105; }
                else if (ansi[i].Equals(115)) { ansi[i] = 106; }
                else if (ansi[i].Equals(116)) { ansi[i] = 107; }
                else if (ansi[i].Equals(117)) { ansi[i] = 108; }
                else if (ansi[i].Equals(118)) { ansi[i] = 109; }
                else if (ansi[i].Equals(119)) { ansi[i] = 110; }
                else if (ansi[i].Equals(120)) { ansi[i] = 111; }
                else if (ansi[i].Equals(121)) { ansi[i] = 112; }
                else if (ansi[i].Equals(122)) { ansi[i] = 113; }

                else if (ansi[i].Equals(192)) { ansi[i] = 226; } //À
                else if (ansi[i].Equals(193)) { ansi[i] = 227; } //Á
                else if (ansi[i].Equals(194)) { ansi[i] = 231; } //Â
                else if (ansi[i].Equals(195)) { ansi[i] = 233; } //Ã
                else if (ansi[i].Equals(199)) { ansi[i] = 234; } //Ç
                else if (ansi[i].Equals(201)) { ansi[i] = 237; } //É
                else if (ansi[i].Equals(202)) { ansi[i] = 243; } //Ê
                else if (ansi[i].Equals(205)) { ansi[i] = 244; } //Í
                else if (ansi[i].Equals(211)) { ansi[i] = 245; } //Ó
                else if (ansi[i].Equals(212)) { ansi[i] = 250; } //Ô
                else if (ansi[i].Equals(213)) { ansi[i] = 192; } //Õ
                else if (ansi[i].Equals(218)) { ansi[i] = 193; } //Ú

                else if (ansi[i].Equals(224)) { ansi[i] = 194; } //à
                else if (ansi[i].Equals(225)) { ansi[i] = 195; } //á
                else if (ansi[i].Equals(226)) { ansi[i] = 199; } //â
                else if (ansi[i].Equals(227)) { ansi[i] = 201; } //ã
                else if (ansi[i].Equals(231)) { ansi[i] = 202; } //ç
                else if (ansi[i].Equals(233)) { ansi[i] = 205; } //é
                else if (ansi[i].Equals(234)) { ansi[i] = 211; } //ê
                else if (ansi[i].Equals(237)) { ansi[i] = 212; } //í
                else if (ansi[i].Equals(243)) { ansi[i] = 213; } //ó
                else if (ansi[i].Equals(244)) { ansi[i] = 218; } //ô
                else if (ansi[i].Equals(245)) { ansi[i] = 224; } //ô
                else if (ansi[i].Equals(250)) { ansi[i] = 225; } //ú   

                else if (ansi[i].Equals(13)) { ansi[i] = 1; }
                else if (ansi[i].Equals(10)) { ansi[i] = 2; }
            }

            return ansi;
        }

        public string Decimal2Binary()
        {
            int i;
            string binario = "";
            for (i = 0; i < ansi.Length; i++)
            {
                //if (ansi[i] > 3)
                binario += Convert.ToString(ansi[i], 2).PadLeft(8, '0');
                //else
                //{
                //    binario += '.';                    
                //}
            }

            return binario;
        }


        public string PermutaComChave(string binario, string chave)
        {
            int i, pos8 = 0;
            char[] bits = new char[8];
            string textoPermutado = "";            

            string[] binarioArrayString = new string[binario.Length / 8]; // declaração do vetor com valores binários contendo 8 dígitos

            for (i = 0; i < binario.Length / 8; i++)
            {
                binarioArrayString[i] = binario.Substring(pos8, 8);
                pos8 += 8; // de 8 em 8 caracteres para cada índice do array conter um valor binário

                for (int j = 0; j < 8; j++)
                {
                    bits = binarioArrayString[i].ToCharArray();
                    textoPermutado += LogicaXOR(Convert.ToChar(bits[j]), chave[j]);
                }
            }

            return textoPermutado;
        }

        private string LogicaXOR(char bitsCriptografado, char parteChave)
        {
            return (Convert.ToInt32(bitsCriptografado) ^ Convert.ToInt32(parteChave)).ToString();
        }

        public char[] Binary2Char(string textoPermutado)
        {
            int i, pos8 = 0;
            string[] textoCriptografado = new string[textoPermutado.Length / 8];
            int[] textoEmNumeros = new int[textoPermutado.Length / 8];
            char[] number2char = new char[textoPermutado.Length / 8];
            int numero;
            char c;

            for (i = 0; i < textoPermutado.Length / 8; i++)
            {
                textoCriptografado[i] = textoPermutado.Substring(pos8, 8);
                pos8 += 8;
                textoEmNumeros[i] = Convert.ToInt32(textoCriptografado[i], 2);
                numero = textoEmNumeros[i];
                //if (numero > 127 && numero < 161)
                //    numero = 127;
                c = Convert.ToChar(numero);
                number2char[i] = c;
            }

            return number2char;
        }

        //public char[] Binary2CharDecriptar(string textoPermutado)
        //{
        //    int i, pos8 = 0;
        //    string[] textoCriptografado = new string[textoPermutado.Length / 8];
        //    int[] textoEmNumeros = new int[textoPermutado.Length / 8];
        //    char[] number2char = new char[textoPermutado.Length / 8];
        //    int numero;
        //    char c;

        //    for (i = 0; i < textoPermutado.Length / 8; i++)
        //    {
        //        textoCriptografado[i] = textoPermutado.Substring(pos8, 8);
        //        pos8 += 8;
        //        textoEmNumeros[i] = Convert.ToInt32(textoCriptografado[i], 2);
        //        numero = textoEmNumeros[i];
        //        //Aritmética modular
        //        if (numero > 126)
        //            numero = numero + 126;
        //        c = Convert.ToChar(numero);
        //        number2char[i] = c;
        //    }

        //    return number2char;
        //}

        public string DesfazPermutacaoComChave(string binario, string chave)
        {
            int i, pos8 = 0;
            char[] bits = new char[8];
            string textoSemPermutacao = "";
            string[] binarioArrayString = new string[binario.Length / 8]; // declaração do vetor com valores binários contendo 8 dígitos

            for (i = 0; i < binario.Length / 8; i++)
            {
                binarioArrayString[i] = binario.Substring(pos8, 8);
                pos8 += 8; // de 8 em 8 caracteres para cada índice do array conter um valor binário                

                for (int j = 0; j < 8; j++)
                {
                    bits = binarioArrayString[i].ToCharArray();
                    textoSemPermutacao += LogicaXNOR(Convert.ToChar(bits[j]), chave[j]);
                }
            }

            return textoSemPermutacao;
        }

        private string LogicaXNOR(char bitsCriptografado, char parteChave)
        {
            string tabelaVerdadeXNOR = "";

            if (bitsCriptografado.Equals('0') && parteChave.Equals('0'))
                tabelaVerdadeXNOR = "0";
            else if (bitsCriptografado.Equals('0') && parteChave.Equals('1'))
                tabelaVerdadeXNOR = "1";
            else if (bitsCriptografado.Equals('1') && parteChave.Equals('0'))
                tabelaVerdadeXNOR = "1";
            else /*if (bitsCriptografado.Equals('1') && parteChave.Equals('1'))*/
                tabelaVerdadeXNOR = "0";

            return tabelaVerdadeXNOR;
        }

        public Byte[] DesfazSubstituicao(char[] texto)
        {
            int i;
            Byte[] ansi = new Byte[texto.Length];

            for (i = 0; i < ansi.Length; i++)
            {
                ansi[i] = Convert.ToByte(texto[i]);
            }

            for (i = 0; i < ansi.Length; i++)
            {
                if (ansi[i].Equals(82)) { ansi[i] = 65; } //A
                else if (ansi[i].Equals(83)) { ansi[i] = 66; } //B
                else if (ansi[i].Equals(84)) { ansi[i] = 67; }
                else if (ansi[i].Equals(85)) { ansi[i] = 68; }
                else if (ansi[i].Equals(86)) { ansi[i] = 69; }
                else if (ansi[i].Equals(87)) { ansi[i] = 70; }
                else if (ansi[i].Equals(88)) { ansi[i] = 71; }
                else if (ansi[i].Equals(89)) { ansi[i] = 72; }
                else if (ansi[i].Equals(90)) { ansi[i] = 73; }
                else if (ansi[i].Equals(65)) { ansi[i] = 74; }
                else if (ansi[i].Equals(66)) { ansi[i] = 75; }
                else if (ansi[i].Equals(67)) { ansi[i] = 76; }
                else if (ansi[i].Equals(68)) { ansi[i] = 77; }
                else if (ansi[i].Equals(69)) { ansi[i] = 78; }
                else if (ansi[i].Equals(70)) { ansi[i] = 79; }
                else if (ansi[i].Equals(71)) { ansi[i] = 80; }
                else if (ansi[i].Equals(72)) { ansi[i] = 81; }
                else if (ansi[i].Equals(73)) { ansi[i] = 82; }
                else if (ansi[i].Equals(74)) { ansi[i] = 83; }
                else if (ansi[i].Equals(75)) { ansi[i] = 84; }
                else if (ansi[i].Equals(76)) { ansi[i] = 85; }
                else if (ansi[i].Equals(77)) { ansi[i] = 86; }
                else if (ansi[i].Equals(78)) { ansi[i] = 87; }
                else if (ansi[i].Equals(79)) { ansi[i] = 88; }
                else if (ansi[i].Equals(80)) { ansi[i] = 89; }
                else if (ansi[i].Equals(81)) { ansi[i] = 90; }

                else if (ansi[i].Equals(114)) { ansi[i] = 97; } //a
                else if (ansi[i].Equals(115)) { ansi[i] = 98; } //b
                else if (ansi[i].Equals(116)) { ansi[i] = 99; }
                else if (ansi[i].Equals(117)) { ansi[i] = 100; }
                else if (ansi[i].Equals(118)) { ansi[i] = 101; }
                else if (ansi[i].Equals(119)) { ansi[i] = 102; }
                else if (ansi[i].Equals(120)) { ansi[i] = 103; }
                else if (ansi[i].Equals(121)) { ansi[i] = 104; }
                else if (ansi[i].Equals(122)) { ansi[i] = 105; }
                else if (ansi[i].Equals(97)) { ansi[i] = 106; }
                else if (ansi[i].Equals(98)) { ansi[i] = 107; }
                else if (ansi[i].Equals(99)) { ansi[i] = 108; }
                else if (ansi[i].Equals(100)) { ansi[i] = 109; }
                else if (ansi[i].Equals(101)) { ansi[i] = 110; }
                else if (ansi[i].Equals(102)) { ansi[i] = 111; }
                else if (ansi[i].Equals(103)) { ansi[i] = 112; }
                else if (ansi[i].Equals(104)) { ansi[i] = 113; }
                else if (ansi[i].Equals(105)) { ansi[i] = 114; }
                else if (ansi[i].Equals(106)) { ansi[i] = 115; }
                else if (ansi[i].Equals(107)) { ansi[i] = 116; }
                else if (ansi[i].Equals(108)) { ansi[i] = 117; }
                else if (ansi[i].Equals(109)) { ansi[i] = 118; }
                else if (ansi[i].Equals(110)) { ansi[i] = 119; }
                else if (ansi[i].Equals(111)) { ansi[i] = 120; }
                else if (ansi[i].Equals(112)) { ansi[i] = 121; }
                else if (ansi[i].Equals(113)) { ansi[i] = 122; }

                else if (ansi[i].Equals(226)) { ansi[i] = 192; } //À
                else if (ansi[i].Equals(227)) { ansi[i] = 193; } //Á
                else if (ansi[i].Equals(231)) { ansi[i] = 194; } //Â
                else if (ansi[i].Equals(233)) { ansi[i] = 195; } //Ã
                else if (ansi[i].Equals(234)) { ansi[i] = 199; } //Ç
                else if (ansi[i].Equals(237)) { ansi[i] = 201; } //É
                else if (ansi[i].Equals(243)) { ansi[i] = 202; } //Ê
                else if (ansi[i].Equals(244)) { ansi[i] = 205; } //Í
                else if (ansi[i].Equals(245)) { ansi[i] = 211; } //Ó
                else if (ansi[i].Equals(250)) { ansi[i] = 212; } //Ô
                else if (ansi[i].Equals(192)) { ansi[i] = 213; } //Õ
                else if (ansi[i].Equals(193)) { ansi[i] = 218; } //Ú

                else if (ansi[i].Equals(194)) { ansi[i] = 224; } //à
                else if (ansi[i].Equals(195)) { ansi[i] = 225; } //á
                else if (ansi[i].Equals(199)) { ansi[i] = 226; } //â
                else if (ansi[i].Equals(201)) { ansi[i] = 227; } //ã
                else if (ansi[i].Equals(202)) { ansi[i] = 231; } //ç
                else if (ansi[i].Equals(205)) { ansi[i] = 233; } //é
                else if (ansi[i].Equals(211)) { ansi[i] = 234; } //ê
                else if (ansi[i].Equals(212)) { ansi[i] = 237; } //í
                else if (ansi[i].Equals(213)) { ansi[i] = 243; } //ó
                else if (ansi[i].Equals(218)) { ansi[i] = 244; } //ô
                else if (ansi[i].Equals(224)) { ansi[i] = 245; } //ô
                else if (ansi[i].Equals(225)) { ansi[i] = 250; } //ú   

                else if (ansi[i].Equals(1)) { ansi[i] = 13; }
                else if (ansi[i].Equals(2)) { ansi[i] = 20; }
            }

            return ansi;
        }

        public string Decimal2Binary(Byte[] ansi)
        {
            int i;

            string binario = "";
            for (i = 0; i < ansi.Length; i++)
            {
                //if (ansi[i] > 3)
                binario += Convert.ToString(ansi[i], 2).PadLeft(8, '0');
                //else
                //{
                //    binario += '.';                    
                //}
            }

            return binario;
        }
    }
}   
        
