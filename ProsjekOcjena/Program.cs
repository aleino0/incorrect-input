using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekOcjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varijable
            int ocjena, brojOcjena, brojac = 0;
            double prosjek, zbrojOcjena = 0.0;

            //zaglavlje aplikacije
            Console.WriteLine("###############################");
            Console.WriteLine("#    Izračunavanje prosjeka   #");
            Console.WriteLine("###############################");
            Console.WriteLine("Za kraj unesi 0");

            

            

            //unos ocjena
            try
            {
                //unos broja ocjena
                Console.WriteLine("Unesi broj ocjena");
                brojOcjena = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (brojOcjena == 0)
                    {
                        break;
                    }

                    Console.WriteLine("Unesi ocjenu");
                    ocjena = Convert.ToInt32(Console.ReadLine());

                    if (ocjena > 0 && ocjena <= 5)
                    {

                         zbrojOcjena = ocjena + zbrojOcjena;
                    }

                    //provjera ako su ocjene pravilno upisane
                    else
                    {
                        Console.WriteLine("Ocjena mora biti od 1 do 5");
                        break;
                    }
                    if (ocjena == 1)
                    {
                        Console.WriteLine("Nisi prošao razred");
                        break;
                    }

                    //izračun i ispis prosjeka
                    if (brojac == brojOcjena - 1)
                    {
                        prosjek = zbrojOcjena / brojOcjena;
                        Console.WriteLine("Prosjek ocjena je");
                        Console.WriteLine(prosjek);
                    }
                    brojac++;
                }while(brojac<brojOcjena);
            }
            catch (Exception greska)
            {
                Console.WriteLine("Neispravan Unos, pokušaj ponovo.");
                Console.Write("Opis greške: " + greska.Message);
            }


            Console.ReadKey();
        }
    }
}
