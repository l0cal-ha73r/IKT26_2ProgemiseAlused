namespace IfAndElseColours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Teha if ja else konsoolirakendus, kus" +
                " kontrollitakse stringi abil värvi vastavust");

            Console.WriteLine("värvide valikus on: red, blue, green ja white");
            Console.WriteLine("peab käsitlema juhust, kus vastaja ei sisesta" +
                " eelpool sisestatud värvi");

            Console.WriteLine("sisesta värv");
            string varv = Console.ReadLine();

            if (varv == "red")
            {
                Console.WriteLine("see on punane");
            }
            else if (varv == "blue")
            {
                Console.WriteLine("see on sinine");
            }
            else if (varv == "green")
            {
                Console.WriteLine("see on roheline");
            }
            else if (varv == "white")
            {
                Console.WriteLine("see on valge");
            }
            else
            {
                Console.WriteLine("see on suvaline värv");
            }
        }
    }
}
