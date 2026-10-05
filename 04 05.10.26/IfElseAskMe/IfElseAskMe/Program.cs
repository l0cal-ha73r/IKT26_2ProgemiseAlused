namespace IfElseAskMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta enda nimi");

            string name = Console.ReadLine();

            if (name == "Mati")
            {
                Console.WriteLine("Sinu nimi nüüd on Sten");
            }
            else
            {
                Console.WriteLine("sinu nimi ei ole Mati");
            }
        }
    }
}
