using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class GenericCeaser:AlgoritmSimetric
    {
        char[] alphabet;
        char[] alphabetCezar;
        int key;
        public GenericCeaser(string alphabet, int key)
        {
            this.alphabet = alphabet.ToCharArray();
            this.key = key;
            this.InitializeAlphCezar();
            
        }

        public override string Criptare(string text)
        {
            string criptat = "";
            for (int i = 0; i < text.Length; i++)
            {
                criptat += LetterCryptDecrypt(text[i], alphabet, alphabetCezar);
            }
            return criptat;
        }
        public override string Decriptare(string text)
        {
            string decriptat = "";
            for (int i = 0; i < text.Length; i++)
            {
                decriptat += LetterCryptDecrypt(text[i], this.alphabetCezar, this.alphabet);
            }
            return decriptat;
        }
        private void InitializeAlphCezar()
        {
            int length = this.alphabet.Length;
            this.alphabetCezar = new char[length];
            for (int i = 0; i < length; i++)
            {
                this.alphabetCezar[i] = this.alphabet[(i + this.key) % length];
            }
        }

        private char LetterCryptDecrypt(char l, char[] alphabetFrom, char[] alphabetTo)
        {
            for (int i = 0; i < alphabetFrom.Length; i++)
            {
                if (l == alphabetFrom[i])
                    return alphabetTo[i];
            }
            throw new Exception("letter not found");
        }
    }
}
