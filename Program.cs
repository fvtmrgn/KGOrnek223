using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGOrnek223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir isim giriniz: ");
            string isim = Console.ReadLine();

            char[] isimHarf = isim.ToCharArray(); 

            bool[] D = new bool[isim.Length]; 

            Random rastgele = new Random();

            for (int a = 0; a < isim.Length; a++)
            {
                int sayi;
                do
                {
                    sayi = rastgele.Next(isim.Length);
                } while (D[sayi]);

                D[sayi] = true;
                Console.Write(isimHarf[sayi]);
            }

            Console.Write("\n\n\nDevam etmek için herhangi bir tuşa basın...");
            Console.ReadKey(true);
        }
    }
}
