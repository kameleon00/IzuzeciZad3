using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite brojilac: ");
                int brojilac;
                bool brojilacOK = Int32.TryParse(Console.ReadLine(), out brojilac);

                if (brojilacOK)
                {
                    Console.WriteLine("Unesite imenilac");
                    int imenilac;
                    bool imenilacOK = Int32.TryParse(Console.ReadLine(), out imenilac);

                    if (imenilacOK)
                    {
                        if (imenilac != 0)
                        {
                            int rezultat = brojilac / imenilac;
                            Console.WriteLine("Rezultat deljenja je {0}.", rezultat);
                        }
                        else
                        {
                            Console.WriteLine("Nije moguce deljenje nulom");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Imenilac mora biti izmedju {0} i {1}.", Int32.MinValue, Int32.MaxValue);
                    }
                }
                else
                {
                    Console.WriteLine("Brojilac mora biti izmedju {0} i {1}.", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
