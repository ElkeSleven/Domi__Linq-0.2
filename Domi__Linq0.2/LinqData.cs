using System;
using System.Collections.Generic;
using System.Text;
/* zo maak je een data class
 * zet de class naar --> public static
 
 
 */
/* Opdaracht 
 * Gebruik de volgende code om data in te laden in je programma 
 */

namespace Domi__Linq0._2
{
    public static class LinqData
    {


        public static List<EntitieWarehouse> warehouses = new List<EntitieWarehouse>
       {
            new EntitieWarehouse("Brug4", 0, "Arendonk", 2370, "Holstraat", 14, 3000, new List<int>{ 4, 3, 1, 5 }),
            new EntitieWarehouse("Brug1", 1, "Arendonk", 2370, "Holstraat", 3, 8000, new List<int>{ 1, 4, 3, 5, 2, 3, 3, 4, 4}),
            new EntitieWarehouse("Poort1", 2, "Gent", 9000, "Stropkaai", 12, 7000, new List<int>{ 5, 4, 3, 4 , 4}),
            new EntitieWarehouse("Rijsteller", 3, "Hasselt", 3500, "Industrielaan", 1, 2500, new List<int>{ 5, 4, 3, 5, 2, 3, 4, 4}),
            new EntitieWarehouse("Automa klein", 4, "Berchem", 2600, "Nieuwevaart", 77, 10000, new List<int>{ 4 }),
            new EntitieWarehouse("Schuifla", 5, "Hasselt", 3500, "Industrielaan", 15, 1500, new List<int>{ 3, 5, 2 }),
            new EntitieWarehouse("Automa groot", 6, "Berchem", 2600, "Nieuwevaart", 76, 30000, new List<int>{ 5 }),
            new EntitieWarehouse("Brug2", 7, "Arendonk", 2370, "Molenweg", 7, 3000, new List<int>{ 4, 3, 5, 2 }),
            new EntitieWarehouse("Veerhal", 8, "Melle", 9090, "Merelstraat", 48, 500, new List<int>{ 5, 5 }),
            new EntitieWarehouse("Poort2", 9, "Gent", 9000, "Burgstraat", 113, 6600, new List<int>{ 1, 2, 1, 1, 2, 3}),
            new EntitieWarehouse("D1", 10, "Knokke", 8300, "Vaart", 2, 2200, new List<int>{ 5, 4, 1 }),
            new EntitieWarehouse("Brug3", 11, "Arendonk", 2370, "Molenweg", 8, 8000, new List<int>{ 5, 2, 3, 5, 5 }),
            new EntitieWarehouse("D2", 12, "Knokke", 8300, "Vaart", 4, 2200, new List<int>{ 2, 3, 4 }),
            new EntitieWarehouse("D3", 13, "Knokke", 8300, "Vaart", 6, 2200, new List<int>{ 3, 4, 3 }) 
       };


        public static List<EntitieEmployee> employees = new List<EntitieEmployee>
        {
            new EntitieEmployee("Jos", "Jansen", 0, 1),
            new EntitieEmployee("Ted", "Bériault", 1, 0),
            new EntitieEmployee("Tony", "Hawk", 2, 3),
            new EntitieEmployee("Peggy", "Corona", 3, 12),
            new EntitieEmployee("Edna", "Goosen", 4, 0),
            new EntitieEmployee("Mac", "Kowalski", 5, 11),
            new EntitieEmployee("Alejandro", "Mendoza", 6, 8),
            new EntitieEmployee("Aysha", "Lyon", 7, 7),
            new EntitieEmployee("Tyson", "Dyer", 8, 4),
            new EntitieEmployee("Nanou", "Hahn", 9, 6),
            new EntitieEmployee("Kevin", "Hahn", 10, 5),
            new EntitieEmployee("Kris", "Jacobsen", 11, 1),
            new EntitieEmployee("Boros", "Orzsebet", 12, 2),
            new EntitieEmployee("Buday", "Gedeon", 13, 2),
            new EntitieEmployee("Szölôsi", "Taksony", 14, 1),
            new EntitieEmployee("Kocsis", "Gyula", 15, 8),
            new EntitieEmployee("Asif", "Atiyeh", 16, 7),
            new EntitieEmployee("Ruwayd", "Akram", 17, 13),
            new EntitieEmployee("Makary", "Sobczak", 18, 12),
            new EntitieEmployee("Pawel", "Symanski", 19, 1),
            new EntitieEmployee("Settimio", "Calabresi", 20, 10),
            new EntitieEmployee("Ivo", "Bellucci", 21, 7),
            new EntitieEmployee("Matthieu", "Camus", 22, 9),
            new EntitieEmployee("Jacques", "Huard", 23, 8),
            new EntitieEmployee("Melville", "Bériault", 24, 4),
            new EntitieEmployee("René", "Michaud", 25, 9)
        };

    }
}
