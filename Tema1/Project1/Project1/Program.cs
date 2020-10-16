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
            Console.WriteLine("Criptare");
            string criptat = cf.Criptare(text);
            Console.WriteLine(criptat);
            Console.WriteLine("Decriptare");
            string decriptat = cf.Decriptare(criptat);
            Console.WriteLine(decriptat);
        }
        static void TestCezarGeneric()
        {
            int key = 1;
            Console.WriteLine($"Key:{key}");
            GenericCeaser cf = new GenericCeaser(ALPHABET,key);
            string text = "ABC";
            Console.WriteLine("Criptare");
            string criptat = cf.Criptare(text);
            Console.WriteLine(criptat);
            Console.WriteLine("Decriptare");
            string decriptat = cf.Decriptare(criptat);
            Console.WriteLine(decriptat);
        }
        static void TestROT13()
        {
            ROT13 cf = new ROT13(ALPHABET2);
            string text = "ABC";
            Console.WriteLine("Criptare");
            string criptat = cf.Criptare(text);
            Console.WriteLine(criptat);
            Console.WriteLine("Decriptare");
            string decriptat = cf.Decriptare(criptat);
            Console.WriteLine(decriptat);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cifrul lui Cezar");
            TestCezar();
            Console.WriteLine();
            Console.WriteLine("Cifrul lui Cezar generic");
            TestCezarGeneric();
            Console.WriteLine();
            Console.WriteLine("ROT13");
            TestROT13();
           
            



        }
    }
}
