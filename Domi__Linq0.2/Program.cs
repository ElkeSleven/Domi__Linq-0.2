using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            SortLinq_a();
            SortLinq_b();
            SortLinq_c(); 
            SortLinq_d();   
            SortLinq_e();
            SortLinq_f();// vanaf 'f'  zijn de querys niet af of kunnen er fouten in zitten 
            SortLinq_g();
            SortLinq_h();
            SortLinq_i();


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
            Console.WriteLine("-------end querySyntax a------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            var methodSyntax = LinqData.warehouses.Where(x => x.City == "Berchem").Select(x => x.BuildingName);
            foreach (string x2 in methodSyntax)
            {
                Console.WriteLine(x2);

            }
            Console.WriteLine("-----end methodSyntax a---------------------------------------------------------------------------");
            Console.ReadLine();
        }

        // * b. Wat zijn de namen en steden van al de magazijnen geordend (van hoog naar laag) op meeste ratings van hun werknemers
        public static void SortLinq_b()
        {
            var querySyntax = from entities in LinqData.warehouses orderby entities.EmployeeSatisfactionRating.Count() descending select (entities.BuildingName, entities.City, entities.EmployeeSatisfactionRating.Count).ToString();

            foreach (string entitie in querySyntax)
            {
                Console.WriteLine(entitie);

            }
            Console.WriteLine("-----end querySyntax b--------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            var methodSyntax = LinqData.warehouses.OrderByDescending(x => x.EmployeeSatisfactionRating.Count());
            foreach (var entitie in methodSyntax)
            {
                Console.WriteLine($"{entitie.BuildingName} {entitie.City} {entitie.EmployeeSatisfactionRating.Count}");      
            }
            Console.WriteLine("-----end methodSyntax b---------------------------------------------------------------------------");
            Console.ReadLine();

        }
        // * c.Wat zijn de volledige namen en id van al de werknemers alfabetisch geordend op hun achternaam? (a tot z) 
        public static void SortLinq_c()
        {
            // manier 1 query syntax
            var querySyntax = from entities in LinqData.employees orderby entities.LastName ascending select (entities.FirstName, entities.LastName, entities.ID).ToString();
            foreach (string entitie in querySyntax)
            {
                Console.WriteLine(entitie);

            }
            Console.WriteLine("---------end querySyntax c----------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
              var methodSyntax = LinqData.employees.OrderByDescending(x => x.LastName);
            foreach (var entitie in methodSyntax)
            {
                Console.WriteLine($"{entitie.FirstName} {entitie.LastName} {entitie.ID}");
            }
            Console.WriteLine("-----end methodSyntax c---------------------------------------------------------------------------");
            Console.ReadLine();
        }

        // * d.Rangschik al de magazijnen van hoog naar laag op basis van gemiddelde rating.
        public static void SortLinq_d()
        {
            // manier 1 query syntax
            var querySyntax = from entities in LinqData.warehouses orderby (from x in entities.EmployeeSatisfactionRating select x).Average() descending select entities;
            foreach (var entitie in querySyntax)
            {
                Console.WriteLine($"{entitie.BuildingName} {entitie.WarehouseID} {entitie.City} {entitie.PostCode} {entitie.Street}" +
                    $" {entitie.HouseNumber} {entitie.StorageCapacity} {entitie.EmployeeSatisfactionRating.Average()} ");
            }
            Console.WriteLine("-----end querySyntax d--------------------------------------------------------------------------");
            Console.ReadLine();


            // manier 2 Method syntax
            var methodSyntax = LinqData.warehouses.OrderByDescending(x => x.EmployeeSatisfactionRating.Average());
            foreach (var entitie in methodSyntax)
            {
                Console.WriteLine($"{entitie.BuildingName} {entitie.WarehouseID} {entitie.City} {entitie.PostCode} {entitie.Street}" +
                    $" {entitie.HouseNumber} {entitie.StorageCapacity} {entitie.EmployeeSatisfactionRating.Average()} ");
            }
            Console.WriteLine("---end methodSyntax d-----------------------------------------------------------------------------");
            Console.ReadLine();
        }

        //* e.Wat zijn de magazijnen met postcode onder 4000 gegroepeerd per stad?
        public static void SortLinq_e()
        {
            // manier 1 query syntax
            var querySyntax = from entities in LinqData.warehouses where entities.PostCode >= 4000 orderby entities.City descending select entities;

            foreach (var entitie in querySyntax)
            {
                Console.WriteLine($"{entitie.BuildingName} {entitie.City}");

            }
            Console.WriteLine("-----end querySyntax e--------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            var methodSyntax = LinqData.warehouses.Where(x => x.PostCode >= 4000).OrderByDescending(x => x.City);
            foreach (var entitie in querySyntax)
            {
                Console.WriteLine($"{entitie.BuildingName} {entitie.City}");

            }
            Console.WriteLine("---end methodSyntax e-----------------------------------------------------------------------------");
            Console.ReadLine();
        }
        
        
        
        
        //* f. Wat zijn de volledige namen van de werknemers die werken voor een
        //  magazijn met een opslagcapaciteit groter dan 2000?
        //  Vermeld ook de naam en capaciteit van het magazijn.
        public static void SortLinq_f()
        {
            // manier 1 query syntax
            /*       var querySyntax = from entities in LinqData.employees 

           /*        foreach (string entitie in querySyntax)
                   {
                       Console.WriteLine(entitie);

                   }*/
            Console.WriteLine("--------end querySyntax f-----------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            // methodSyntax = 
            Console.WriteLine("----------end methodSyntax f-----------------------------------------------------------------------");
            Console.ReadLine();
        }

        //* g. Wat zijn de id’s en voornamen van werknemers
        //die een achternaam delen met een andere werknemer
        //van het magazijn?
        public static void SortLinq_g()
        {
            // manier 1 query syntax
            //var querySyntax = from entities in LinqData.employees where entities.LastName == "beb" group entities by entities.WarehouseID;
   
/*            foreach (var entitie in querySyntax)
            {
                Console.WriteLine(entitie);

            }*/
            Console.WriteLine("-------end querySyntax g------------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            //var methodSyntax = 
         
            Console.WriteLine("-------end methodSyntax g-------------------------------------------------------------------------");
            Console.ReadLine();
        }


        // * h.Wat zijn de voornamen van de werknemers die werken voor een magazijn met een opslagcapaciteit die groter is dan 5000. 

        // Vermeld ook de volledige locatie (stad, postcode, straat, huisnummer) van het magazijn.
        public static void SortLinq_h()
        {
            // manier 1 query syntax
            var querySyntax = (from employees in LinqData.employees
                               join magazijn in LinqData.warehouses
                               on employees.WarehouseID equals magazijn.WarehouseID
                               where employees.WarehouseID == magazijn.WarehouseID
                               // where magazijn.StorageCapacity < 500
                               //orderby magazijn.City
                               select (employees, magazijn));
            //  (from entities in LinqData.warehouses where entities.StorageCapacity < 5000 select entities.WarehouseID)
            foreach (var entitie in querySyntax)
            {
                Console.WriteLine($"{entitie.employees.FirstName} {entitie.employees.LastName}");
                Console.WriteLine($"werkt in het magazijn: {entitie.magazijn.City} {entitie.magazijn.PostCode} {entitie.magazijn.Street} {entitie.magazijn.HouseNumber}");
            
            }
            Console.WriteLine("--------end querySyntax h-----------------------------------------------------------------------");
            Console.ReadLine();



            // manier 2 Method syntax
            //var methodSyntax =  
            Console.WriteLine("---------end methodSyntax h-----------------------------------------------------------------------");
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
            Console.WriteLine("---------end querySyntax i----------------------------------------------------------------------");
            Console.ReadLine();

            // manier 2 Method syntax
            //var methodSyntax = 
            Console.WriteLine("--------end methodSyntax i------------------------------------------------------------------------");
            Console.ReadLine();
        }










    } 
}
