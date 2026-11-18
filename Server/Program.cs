namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Напиши свое имя: ");

            string name = Console.ReadLine();
            Privet(name);
        }

        static void Privet(string name)
        {
            Console.WriteLine($"Привет, {name}");
        }
    }
}
