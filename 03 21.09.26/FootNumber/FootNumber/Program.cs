namespace FootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta jalanumber");

            string foot = Console.ReadLine();
            int FS = int.Parse(foot);

            if (FS >= 30 && FS <= 33)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (FS >= 34 && FS <= 38)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (FS >= 39 && FS <= 44)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (FS >= 45 && FS <= 49)
            {
                Console.Beep();
                Thread.Sleep(1000);
                     Console.Beep();
                Thread.Sleep(1000);
                     Console.Beep();
                Thread.Sleep(1000);
                     Console.Beep();
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Sinu jalanumber on väga suur");
            }
        }
    }
}
