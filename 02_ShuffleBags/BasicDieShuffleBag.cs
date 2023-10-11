public class UnbiasedRandom
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Basic Shuffle Bag Die Rolls:");

        // Create bag containing [1, 2, 3, 4, 5, 6]:
        var bag = new List<int>();
        for (int i = 1; i <= 6; i++)
        {
            bag.Add(i);
        }

        // Pick elements at random, removing from bag:
        var random = new Random();
        for (int i = 0; i < 6; i++)
        {
            int index = random.Next(bag.Count);
            int result = bag[index];
            bag.RemoveAt(index);
            Console.WriteLine(result);
        }
    }
}