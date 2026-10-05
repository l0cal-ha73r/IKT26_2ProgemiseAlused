using System.Threading.Channels;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta maja suurus");
            //0 - 40; 41 - 90; 91 - 130; 131+
            int MSuurus = int.Parse(Console.ReadLine());

            if (MSuurus >= 0 && MSuurus <= 40)
            {
                Console.WriteLine($"Sinu maja suurus on {MSuurus} m2.");
            }
            else if (MSuurus >= 41 && MSuurus <= 90)
            {
                Console.WriteLine($"Sinu maja suurus on {MSuurus} m2.");
            }
            else if (MSuurus >= 91 && MSuurus <= 130)
            {
                Console.WriteLine($"Sinu maja suurus on {MSuurus} m2.");
            }
            else if (MSuurus >= 131)
            {
                Console.WriteLine($"Sinu maja suurus on {MSuurus} m2.");
            }
            else
            {
                Console.WriteLine($"{MSuurus}?");
            }
        }
    }
}
