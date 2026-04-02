using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Dungeon
    {
        Room[] rooms;

        public Dungeon()
        {
            rooms = new Room[3];
            rooms[0] = new Room(new Unit("Lancer"),
                    new Weapon("Lance", 2, 10));
            rooms[1] = new Room(new Unit("Barbarian"),
                        new Weapon("Axe", 5, 15));
            rooms[2] = new Room(new Unit("Knight"),
                        new Weapon("Sword", 4, 12));
        }

        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++) // поле типа Room[]
            {
                var room = rooms[i];
                Console.WriteLine($"Room: {i+1}");
                Console.WriteLine($"Unit of room: {room.unit.Name}");
                Console.WriteLine($"Weapon of room: {room.weapon.Name}");
                Console.WriteLine("—");
            }
        }

    }
}
