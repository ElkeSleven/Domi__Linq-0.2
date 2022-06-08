using System;
using System.Collections.Generic;
using System.Text;
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
    public class EntitieWarehouse
    {
        public string BuildingName { get; set; }
        public int WarehouseID { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public string Street { get; set; } 
        public int HouseNumber { get; set; }
        public int StorageCapacity { get; set; }
        public List<int> EmployeeSatisfactionRating { get; set; }

        public EntitieWarehouse(string name, int id, string city, int postcode, string street, int number, int storage, List<int> rating)
        {
            BuildingName = name;
            WarehouseID = id;
            City = city;
            PostCode = postcode;
            Street = street;
            HouseNumber = number;
            StorageCapacity = storage;
            EmployeeSatisfactionRating = rating;
        }

    }
}
