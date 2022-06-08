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
*/

/* Keywoords
 * from     in
 * where 
 * orderby
 * group    by    into
 * join     in    on     equals 
 * descending (van hoog naar laag)
 * ascending (a tot z) 
 */


namespace Domi__Linq0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            SortLinq_a();
            SortLinq_b();
            SortLinq_c(); */  
            //SortLinq_d();   
            SortLinq_e();   


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
            var methodSyntax = LinqData.warehouses.Where(x => x.City == "Berchem").Select(x => x.BuildingName);
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        // * b. Wat zijn de namen en steden van al de magazijnen geordend (van hoog naar laag) op meeste ratings van hun werknemers
        public static void SortLinq_b()
        {
            /*          BuildingName = name;
                        WarehouseID = id;
                        City = city;
                        PostCode = postcode;
                        Street = street;
                        HouseNumber = number;
                        StorageCapacity = storage;
                        EmployeeSatisfactionRating = rating;*/
            var querySyntax = from entities in LinqData.warehouses orderby entities.EmployeeSatisfactionRating.Count() descending select(entities.BuildingName, entities.City, entities.EmployeeSatisfactionRating.Count).ToString();

            foreach (string entitie in querySyntax)
            {
                Console.WriteLine(entitie);

            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            //var methodSyntax = LinqData.warehouses.Select(entities => entities.BuildingName).ToString().OrderBy(entities => entities.EmployeeSatisfactionRating.Count().OrderByDescending);
/*            foreach (var x in methodSyntax)
            {
                

            }*/
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        // * c.Wat zijn de volledige namen en id van al de werknemers alfabetisch geordend op hun achternaam? (a tot z) 
        public static void SortLinq_c()
        {
            // manier 1 query syntax
            var querySyntax = from entities in LinqData.employees orderby entities.LastName ascending select(entities.FirstName, entities.LastName, entities.ID).ToString();
            foreach (string entitie in querySyntax)
            {
                Console.WriteLine(entitie);

            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
   /*         var methodSyntax = 
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }*/
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        // * d.Rangschik al de magazijnen van hoog naar laag op basis van gemiddelde rating.
        public static void SortLinq_d()
        {
            // manier 1 query syntax
            var querySyntax = from entities in LinqData.warehouses orderby(from x in entities.EmployeeSatisfactionRating select x).Average() descending select entities.EmployeeSatisfactionRating.Count.ToString();
            foreach (var entitie in querySyntax)
            {
                Console.WriteLine(entitie);
                

            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
/*            var methodSyntax = 
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }*/
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        //* e.Wat zijn de magazijnen met postcode onder 4000 gegroepeerd per stad?
        public static void SortLinq_e()
        {
            // manier 1 query syntax
            var querySyntax = from entities in LinqData.warehouses where entities.PostCode >= 4000 orderby entities.City descending select entities.WarehouseID;

            foreach (var entitie in querySyntax)
            {
                Console.WriteLine(entitie);

            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
          /*  var methodSyntax =
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }*/
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        //* f. Wat zijn de volledige namen van de werknemers die werken voor een
        //  magazijn met een opslagcapaciteit groter dan 2000? Vermeld ook de naam en capaciteit van het magazijn.
        public static void SortLinq_f()
        {
            // manier 1 query syntax
     /*       var querySyntax = from entities in LinqData.employees 

    /*        foreach (string entitie in querySyntax)
            {
                Console.WriteLine(entitie);

            }*/
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
/*            var methodSyntax = 
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }*/
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        
       
        //
        //* g. Wat zijn de id’s en voornamen van werknemers die een achternaam delen met een andere werknemer van het magazijn?
        public static void SortLinq_g()
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
            var methodSyntax = LinqData.warehouses.Where(x => x.City == "Berchem").Select(x => x.BuildingName);
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        // * h.Wat zijn de voornamen van de werknemers die werken voor een magazijn met een opslagcapaciteit die groter is dan 5000. 
        // Vermeld ook de volledige locatie (stad, postcode, straat, huisnummer) van het magazijn.
        public static void SortLinq_h()
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
            var methodSyntax = LinqData.warehouses.Where(x => x.City == "Berchem").Select(x => x.BuildingName);
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        // * i.Groepeer de werknemers per straat van het magazijn waarvoor ze werken.
        public static void SortLinq_i()
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
            var methodSyntax = LinqData.warehouses.Where(x => x.City == "Berchem").Select(x => x.BuildingName);
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }

    }
}
