namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi!");

            string name = Console.ReadLine();

            if (name != "")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tere, " + name);
            }
            else
            {
                Console.WriteLine("Tere, Tundmatu!");
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
            }
        }
    }
}
