namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Unit unit1 = new Unit();
            Unit unit2 = new Unit("MyUnit");

            Console.WriteLine("unit 1.\nname: " + unit1.Name + "\ndamage: " + unit1.Damage + "\nhealth: " + unit1.Health);
            Console.WriteLine();
            Console.WriteLine("unit 2.\nname: " + unit2.Name + "\ndamage: " + unit2.Damage + "\nhealth: " + unit2.Health);

            Console.WriteLine(unit1.Name+ " is dead? - " + unit1.SetDamage(1000));

            Console.WriteLine();

            Console.WriteLine(unit2.Name + " is dead? - " + unit2.SetDamage(100));



        }
    }
}
