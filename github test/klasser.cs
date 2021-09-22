using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_test
{
    class klasser
    {
        public static void nummer1()
        {
            int iNummer;
            Console.WriteLine("skriv in ett tal");
           iNummer = int.Parse(Console.ReadLine());

        }

        public static void nummer2()
        {
            int iNummer2;
            Console.WriteLine("skriv ett till tal");
            iNummer2 = int.Parse(Console.ReadLine());
        }
    }
    
    class NameChecking
    {
        public void namn1() 
        {
            string sFnamn;
            Console.WriteLine("skriv in ditt förnamn");
            sFnamn = Console.ReadLine();

        }

        public void namn2()
        {
            string sEnamn;
            Console.WriteLine("skriv in ditt förnamn");
            sEnamn = Console.ReadLine();
        }
    }

    class ProcessingData
    {
        public void checks()
        {
            bool check = true;

            if (check)
            {
                Console.WriteLine(check);
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}


