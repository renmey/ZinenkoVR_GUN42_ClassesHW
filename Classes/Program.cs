namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Unit unit1 = new Unit();
            Unit unit2 = new Unit("MyUnit");

            Console.WriteLine("unit 1.\nname: " + unit1.Name + "\ndamage: " + unit1.Damage.Get + "\nhealth: " + unit1.Health);
            Console.WriteLine();
            Console.WriteLine("unit 2.\nname: " + unit2.Name + "\ndamage: " + unit2.Damage.Get + "\nhealth: " + unit2.Health);

            Console.WriteLine(unit1.Name+ " is dead? - " + unit1.SetDamage(1000));

            Console.WriteLine();

            Console.WriteLine(unit2.Name + " is dead? - " + unit2.SetDamage(100));

            Weapon weapon1 = new Weapon("Shotgun");
            Weapon weapon2 = new Weapon("Railgun", 0, 1);

            weapon1.SetDamageParams(2, 17);

            Console.WriteLine($"weapon 1.\nname: {weapon1.Name}\nmin damage: {weapon1.Damage.Min}\nmax damage: {weapon1.Damage.Max}" +
                $"\naverage damage: {weapon1.GetDamage()}");

            Console.WriteLine();

            Console.WriteLine($"weapon 1.\nname: {weapon2.Name}\nmin damage: {weapon2.Damage.Min}\nmax damage: {weapon2.Damage.Max}" +
                $"\naverage damage: {weapon2.GetDamage()}");


            Interval interval = new Interval(-33,33);

            Console.WriteLine(interval.Min +"\n" + interval.Max);

            Console.WriteLine(interval.Get);


            Dungeon dungeon = new Dungeon();

            dungeon.ShowRooms();

        }
    }
}
