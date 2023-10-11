public class LazyShuffle
{
    // Based on: https://observablehq.com/@jobleonard/shuffle-vectors
    // Constant O(1). No need for O(n) shuffles.

    private static Random random = new Random();

    public static void Main(string[] args)
    {
        Console.WriteLine("Lazy Shuffle Bag Die Rolls:");

        // Create bag: (order doesn't matter)
        var bag = new List<int>();
        for (int i = 1; i <= 6; i++)
        {
            bag.Add(i);
        }

        // Get random values:
        int index = 0;
        for (int i = 0; i < 12; i++)
        {
            // If we're not at the end, swap current index with a random element from later in the list:
            // (This is implicitly the same as Fisher-Yates Shuffle.)
            if (index < bag.Count - 1)
            {
                int index2 = random.Next(index + 1, bag.Count);
                int temp = bag[index];
                bag[index] = bag[index2];
                bag[index2] = temp;
            }

            // Show value at current index in list:
            int result = bag[index];
            Console.WriteLine(result);

            // Increment index, looping to beginning.
            index = (index + 1) % bag.Count;
        }
    }
}
