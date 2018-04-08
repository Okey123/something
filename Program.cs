using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 nums");
            int[] komb = new int[5];

            for (int i = 0; i < 5; i++)
            {
                if(komb[i] )
                komb[i] = Convert.ToInt32(Console.ReadLine());

            }

            int prov =  0;
            int prov2 = 0;
            int prov3 = 0;
            int prov4 = 0;
            int prov5 = 0;
            int prov6 = 0;
            for (int i = 0; i < komb.Length; i++)
            {
                switch (komb[i])
                {
                    case 1:prov++;break;
                    case 2:prov2++;break;
                    case 3:prov3++; break;
                    case 4:prov4++; break;
                    case 5:prov5++; break;
                    case 6:prov6++; break;

                }
            }
            bool che = false; ;
            if (prov == 5 || prov2 == 5 || prov3 == 5 || prov4 == 5 || prov5 == 5 || prov6 == 5)
            {
                Console.WriteLine("Pocker");
                che = true;
            }

            if(prov == 4 || prov2 == 4 || prov3 == 4 || prov4 == 4 || prov5 == 4 || prov6 == 4)
            {
                if (che == false)
                {
                    Console.WriteLine("Kare");
                }
            }

            if ((prov == 3 || prov2 == 3 || prov3 == 3 || prov4 == 3 || prov5 == 3 || prov6 == 3) && prov == 2 || prov2 == 2 || prov3 == 2 || prov4 == 2 || prov5 == 2 || prov6 == 2)
            {
                if (che == false)
                {
                    Console.WriteLine("full house");
                    che = true;
                }
            }

            if (prov == 3 || prov2 == 3 || prov3 == 3 || prov4 == 3 || prov5 == 3 || prov6 == 3)
            {
                if (che == false)
                {
                    Console.WriteLine("troyka");
                    che = true;
                }
            }

            if ((prov == 3 || prov2 == 3 || prov3 == 3 || prov4 == 3 || prov5 == 3 || prov6 == 3) && prov == 2 || prov2 == 2 || prov3 == 2 || prov4 == 2 || prov5 == 2 || prov6 == 2)
            {
                if (che == false)
                {
                    Console.WriteLine("full house");
                    che = true;
                }
            }

            if ((prov == 2 || prov2 == 2 || prov3 == 2 || prov4 == 2 || prov5 == 2 || prov6 == 2) && prov == 2 || prov2 == 2 || prov3 == 2 || prov4 == 2 || prov5 == 2 || prov6 == 2)
            {
                if (che == false)
                {
                    Console.WriteLine("two pars");
                    che = true;
                }
            }

            if (prov == 2 || prov2 == 2 || prov3 == 2 || prov4 == 2 || prov5 == 2 || prov6 == 2)
            {
                if (che == false)
                {
                    Console.WriteLine("par");
                    che = true;
                }
            }
            if (prov == 1 || prov2 == 2 || prov3 == 3 || prov4 == 4 || prov5 == 5 || prov6 == 6)
            {
                if (che == false)
                { }
            }

            for (int i = 0; i < 5; i++)
            {

               if((komb[i] >= komb[0]) && (komb[i] >= komb[1]) && (komb[i] >= komb[2]) && (komb[i] >= komb[3]) && (komb[i] >= komb[4]) && che == false)
               {
                    Console.WriteLine("The biggest " + komb[i]);
               }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(komb[i]);
            }


            Console.ReadKey(true);
        }
    }
}
