using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barmi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = new string[] { "János", "Pali", "Ildikó", "Éva", "Teréz", "Zsolt" };

            int[] szamok = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<string> ibetus = new List<string>();
            //foreach (var n in nevek)
            //{
            //    if (n.Contains('i'))
            //    {
            //        ibetus.Add(n);
            //    }
            //}

            //LINQ
            var ibetus = from nev in nevek 
                         where nev.Contains('i') 
                         select nev;

            Console.WriteLine("A nevek tartalmazzák az 'i betűt'");
            foreach (var i in ibetus)
            {
                Console.WriteLine(i);
            }

            var nagyobbot = from szam in szamok 
                            where (szam % 2 == 0) 
                            select szam;
            foreach (var n in nagyobbot)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
