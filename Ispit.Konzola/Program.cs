using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispit.Model;
using Ispit.Model.Klase;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Podaci podaciZaIspit = new Podaci();
            var GrupirajPremaBanci = podaciZaIspit.ListaKlijenata   // Selector oblik
                .Where(klijent => klijent.Stanje >= 1000000.00)
                .GroupBy(klijent => klijent.Banka).
                Select(grupiraniMilijunasi =>
                    new GrupiraniMilijunasi(grupiraniMilijunasi.Key,
                        new List<string>(grupiraniMilijunasi
                            .Select(milijunas => milijunas.ImePrezime))));
            /*GrupirajPremaBanci = from klijent in podaciZaIspit.ListaKlijenata // Query oblik
                                 where klijent.Stanje >= 1000000.00
                                 group klijent by klijent.Banka into grupiraniMilijunasi
                                 select new GrupiraniMilijunasi(grupiraniMilijunasi.Key,
                                    new List<string>(grupiraniMilijunasi
                                        .Select(milijunas => milijunas.ImePrezime)));*/
            GrupirajPremaBanci.ToList().ForEach(banka =>
            {
                Console.Write(banka.Banka + ": ");
                List<string> listaMilijunasa = new List<string>(banka.Milijunasi);
                for (short i = 0; i < listaMilijunasa.Count; i++)
                {
                    Console.Write(listaMilijunasa[i]);
                    if (i < listaMilijunasa.Count - 2)
                    {
                        Console.Write(", ");
                    }
                    else if (i == listaMilijunasa.Count - 2)
                    {
                        Console.Write(" i ");
                    }
                }
                Console.WriteLine();
            });
            Console.WriteLine();

            var IzvjestajMilijunasi = podaciZaIspit.ListaKlijenata
                .Where(klijent => klijent.Stanje >= 1000000)
                .ToList();

            IzvjestajMilijunasi.Join(podaciZaIspit.ListaBanki,
                klijent => klijent.Banka,
                banka => banka.Simbol,
                (klijent, banka) => new
                {
                    Klijent = klijent.ImePrezime,
                    Banka = banka.Naziv,
                })
                .ToList()
                .ForEach(klijent => Console.WriteLine($"{klijent.Klijent} je u {klijent.Banka}."));
            Console.WriteLine();
        }
    }
}
