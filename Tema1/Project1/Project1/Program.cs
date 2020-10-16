using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    
    class Program
    {
        public static string ALPHABET = "AĂÂBCDEFGHIÎJKLMNOPQRSȘTȚUVWXYZ";
        static void Main(string[] args)
        {
            
            CifrulCezar cf = new CifrulCezar(ALPHABET);
            string text = "ABC";
            string criptat = cf.Criptare(text);
            Console.WriteLine(criptat);
            string decriptat = cf.Decriptare(criptat);
            Console.WriteLine(decriptat);



        }
    }
}
