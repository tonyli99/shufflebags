public class UnbiasedRandom
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Unbiased Random Die Rolls:");
        var random = new Random();
        for (int i = 0; i < 6; i++)
        {
            int result = random.Next(1, 7);
            Console.WriteLine(result);
        }
    }
}