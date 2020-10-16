using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    
    class Program
    {

        public static string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string ALPHABET2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static void TestCezar()
        {
            CifrulCezar cf = new CifrulCezar(ALPHABET);
            string text = "ABC";
            string criptat = cf.Criptare(text);
            Console.WriteLine(criptat);
            string decriptat = cf.Decriptare(criptat);
            Console.WriteLine(decriptat);
        }
        static void TestCezarGeneric()
        {
            GenericCeaser cf = new GenericCeaser(ALPHABET,1);
            string text = "ABC";
            string criptat = cf.Criptare(text);
            Console.WriteLine(criptat);
            string decriptat = cf.Decriptare(criptat);
            Console.WriteLine(decriptat);
        }
        static void TestROT13()
        {
            ROT13 cf = new ROT13(ALPHABET2);
            string text = "ABC";
            string criptat = cf.Criptare(text);
            Console.WriteLine(criptat);
            string decriptat = cf.Decriptare(criptat);
            Console.WriteLine(decriptat);
        }
        static void Main(string[] args)
        {
            TestCezar();
            Console.WriteLine();
            TestCezarGeneric();
            Console.WriteLine();
            TestROT13();
           
            



        }
    }
}
