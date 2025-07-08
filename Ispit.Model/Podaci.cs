using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Podaci
    {
        public List<Banka> ListaBanki = new List<Banka>
        {
            new Banka("ZABA", "Zagrebacka Banka"),
            new Banka("PBZ", "Privredna Banka Zagreb"),
            new Banka("Erste", "Erste&Steiermarkische Bank")
        };

        public List<Klijent> ListaKlijenata = new List<Klijent>
        {
            new Klijent("Ana Palic", 2000000.00, "ZABA"),
            new Klijent("Sara Ivic", 0.00, "ZABA"),
            new Klijent("Ive Pavlo Maric", 876085.50, "PBZ"),
            new Klijent("Ivan Bazant", 1370000.43, "PBZ"),
            new Klijent("Kristina Miller", 1244350.04, "Erste"),
            new Klijent("Petar Preradovic", 6240.20, "ZABA"),
            new Klijent("Karlo Kiseljak", 3460000.21, "Erste"),
            new Klijent("Matej Ilic", 390456.99, "PBZ"),
            new Klijent("Mijo Kovac", 1356544.54, "PBZ"),
            new Klijent("Sonja Milic", 478687.87, "Erste"),
            new Klijent("Katarina Ivic", 1988045.78, "Erste"),
            new Klijent("Maja Vilc", 989808.78, "ZABA")
        };
    }
}
