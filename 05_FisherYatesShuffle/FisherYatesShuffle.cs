public class FisherYatesShuffle
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        Console.WriteLine("Shuffle Bag Die Rolls with Fisher-Yates Shuffle:");

        // Create bag:
        var bag = new List<int>();
        for (int i = 1; i <= 6; i++)
        {
            bag.Add(i);
        }

        Shuffle(bag);

        // Get random values:
        int index = 0;
        for (int i = 0; i < 12; i++)
        {
            int result = bag[index];
            Console.WriteLine(result);

            // Increment index.
            // If we're near end, reshuffle the bag and start at beginning to prevent card counting:
            index++;
            if (index > bag.Count - 3)
            {
                index = 0;
                Shuffle(bag);
            }
        }
    }

    private static void Shuffle(List<int> bag)
    {
        // Shuffle the order of elements: (https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle)
        int n = bag.Count - 2;
        for (int i = 0; i < n; i++)
        {
            var j = random.Next(i, bag.Count);
            var temp = bag[i];
            bag[i] = bag[j];
            bag[j] = temp;
        }

        Console.Write("Shuffled bag: [ ");
        for (int i = 0; i < bag.Count; i++)
        {
            Console.Write($"{bag[i]} ");
        }
        Console.WriteLine("]");
    }
}