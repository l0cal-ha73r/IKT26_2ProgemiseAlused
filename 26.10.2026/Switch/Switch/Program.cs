namespace Switch;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("sisesta esimene number");
        float number1 = float.Parse(Console.ReadLine());

        Console.WriteLine("vali tehe: *");
        string tehe = Console.ReadLine();

        Console.WriteLine("sisesta teine number");
        float number2 = float.Parse(Console.ReadLine());

        float tulemus = 0;
        bool KorrektneTehe = true;

        switch (tehe)
        {
            case "*":
                tulemus = number1 * number2;
                break;

            default:
                Console.WriteLine("tundmatu tehe!");
                KorrektneTehe = false;
                break;
        }
        if (KorrektneTehe)
        {
            Console.WriteLine($"Tulemus: {number1} {tehe} {number2} = {tulemus}");
        }
    }
}
