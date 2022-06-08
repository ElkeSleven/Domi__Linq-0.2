using System;
using System.Linq;
/* Opdracht
* 3. Los de volgende verzoeken op met behulp van LINQ
* a. Wat zijn de namen van de magazijnen in Berchem?
* b. Wat zijn de namen en steden van al de magazijnen geordend (van hoog naar laag) op meeste ratings van hun werknemers
* c. Wat zijn de volledige namen en id van al de werknemers alfabetisch geordend op hun achternaam? (a tot z) 
* d. Rangschik al de magazijnen van hoog naar laag op basis van gemiddelde rating.
* e. Wat zijn de magazijnen met postcode onder 4000 gegroepeerd per stad ?
* f. Wat zijn de volledige namen van de werknemers die werken voor een
* magazijn met een opslagcapaciteit groter dan 2000? Vermeld ook de naam en capaciteit van het magazijn.
* g. Wat zijn de id’s en voornamen van werknemers die een achternaam delen met een andere werknemer van het magazijn?
* h. Wat zijn de voornamen van de werknemers die werken voor een magazijn met een opslagcapaciteit die groter is dan 5000. 
* Vermeld ook de volledige locatie (stad, postcode, straat, huisnummer) van het magazijn.
* i. Groepeer de werknemers per straat van het magazijn waarvoor ze werken.

* 
*/
namespace Domi__Linq0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortLinq_a();


        }

        // * a.Wat zijn de namen van de magazijnen in Berchem?
        public static void SortLinq_a()
        {
            // manier 1 query syntax
            var querySyntax = from entities in LinqData.warehouses where entities.City == "Berchem" select entities.BuildingName;

            foreach (string entitie in querySyntax)
            {
                Console.WriteLine(entitie);

            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
          /*  var methodSyntax = LinqData.tekst.Where(x2 => x2.Length > 10);
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }*/
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        // * b. Wat zijn de namen en steden van al de magazijnen geordend (van hoog naar laag) op meeste ratings van hun werknemers

        // * c.Wat zijn de volledige namen en id van al de werknemers alfabetisch geordend op hun achternaam? (a tot z) 
        // * d.Rangschik al de magazijnen van hoog naar laag op basis van gemiddelde rating.

        //* e.Wat zijn de magazijnen met postcode onder 4000 gegroepeerd per stad?
        //* f. Wat zijn de volledige namen van de werknemers die werken voor een
        // * magazijn met een opslagcapaciteit groter dan 2000? Vermeld ook de naam en capaciteit van het magazijn.
        //
        //* g. Wat zijn de id’s en voornamen van werknemers die een achternaam delen met een andere werknemer van het magazijn?
        // * h.Wat zijn de voornamen van de werknemers die werken voor een magazijn met een opslagcapaciteit die groter is dan 5000. 
        // * Vermeld ook de volledige locatie (stad, postcode, straat, huisnummer) van het magazijn.
        // * i.Groepeer de werknemers per straat van het magazijn waarvoor ze werken.

    }
}
