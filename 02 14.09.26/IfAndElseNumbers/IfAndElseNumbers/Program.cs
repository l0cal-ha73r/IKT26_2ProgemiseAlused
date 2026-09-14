namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            //int userAge = Convert.ToInt32(Console.ReadLine());
            string userInput = Console.ReadLine();
            int userAge = int.Parse(userInput);

            if (userAge >= 18)
            {
                Console.WriteLine("Sa oled täisealine");
            }
            else
            {
                Console.WriteLine("Sa oled alaealine");
            }
        }
    }
}
