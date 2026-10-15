namespace InheritingHD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character Test = new Character("Barb");
            Console.WriteLine(Test.GetDescription());
            Console.WriteLine("Test is alive:" + Test.IsAlive());
            Console.WriteLine("Total number of Characters:" +Character.Count);
            Console.WriteLine("\n");
            Warrior w = new("Thorfin", 10);
            Console.WriteLine($"Warrior name:" + w.Name);
            Console.WriteLine($"Warrior heslth:" + w.Health);
            Console.WriteLine($"Warrior armor:" + w.Armor);
            Console.WriteLine(w.GetDescription());
            Console.WriteLine("\n");
            Mage m = new("Magnus", 10);
            Console.WriteLine($"Mage name:" + m.Name);
            Console.WriteLine($"Mage heslth:" + m.Health);
            Console.WriteLine($"Mage mana:" + m.Mana);
            Console.WriteLine(m.GetDescription());
            Console.WriteLine("\n");
            Console.WriteLine($"Warrior heslth:" + w.Health);
            Console.WriteLine($"Warrior heslth:" + w.TakeDamage(30));
            Console.WriteLine($"Warrior heslth:" + w.Health);
            Console.WriteLine($"Warrior heslth:" + w.TakeHeal(30));
            Console.WriteLine($"Warrior heslth:" + w.Health);
            Console.WriteLine("\n");
            Console.WriteLine($"Mage heslth:" + m.Health);
            Console.WriteLine($"Mage heslth:" + m.TakeDamage(30));
            Console.WriteLine($"Mage heslth:" + m.Health);
            Console.WriteLine($"Mage heslth:" + m.TakeHeal(30));
            Console.WriteLine($"Mage heslth:" + m.Health);
        }
    }
}
