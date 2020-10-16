using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ROT13 : AlgoritmSimetric
    {
        char[] alphabet;
        public ROT13(string alphabet)
        {
            this.alphabet = alphabet.ToCharArray();
        }
        public override string Criptare(string text)
        {
            string criptat = "";
            for (int i = 0; i < text.Length; i++)
            {
                criptat += LetterCryptDecrypt(text[i]);
            }
            return criptat;
        }

        private char LetterCryptDecrypt(char v)
        {
            int length = this.alphabet.Length;
          
            for (int i = 0; i < length; i++)
            {
                if(v==alphabet[i])
                   return this.alphabet[(i + 13) % length];
            }
           throw new Exception();
        }

        public override string Decriptare(string text)
        {
            return Criptare(text);
        }
    }
}
