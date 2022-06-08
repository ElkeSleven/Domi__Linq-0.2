using System;
using System.Collections.Generic;
using System.Text;
/* zo maak je een entitie 
 *  zet class naar -> public 
 *  deleclaren van varable kan in --> public en private
 *  constructor : zo moet je entitie er uit zien 
 */

/* // opdracht
 * 2. Een bedrijf heeft magazijn over heel België. Gebruik LINQ en model classes om 
 * hun queries uit te voeren. Maak twee model klasses met de volgende properties:
    * Warehouse:
            - BuildingName
            - WarehouseID
            - City
            - PostCode
            - Street
            - HouseNumber
            - StorageCapacity (in m²)
            - EmployeeSatisfactionRating (een lijst van scores van één tot vijf)
    * Employee:
            - FirstName
            - LastName
            - ID
            - WarehouseID
 */

namespace Domi__Linq0._2
{
    public class EntitieEmployee
    {
        public EntitieEmployee(string firstname, string lastname, int id, int warehouseid)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
            WarehouseID = WarehouseID;
     
        }

        public string FirstName {get;set;}
        public string LastName {get;set;}   
        public int ID {get;set;}    
        public int WarehouseID {get;set;}

       
    }
}
