public class Distributions
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Fequency-Distributed Letters:");

        // Create bag:
        var bag = CreateBag();

        // Pick elements at random, removing from bag:
        var random = new Random();
        for (int i = 0; i < 15; i++)
        {
            int index = random.Next(bag.Count);
            char result = bag[index];
            bag.RemoveAt(index);
            Console.WriteLine(result);

            // If we're running low, create a new bag to prevent card counting:
            if (bag.Count < 5) bag = CreateBag();
        }
    }

    public static List<char> CreateBag()
    {
        var bag = new List<char>();

        // Add an amount of each letter according to its frequency (e.g., more E's than Z's):
        foreach (var c in LetterFrequency.Keys)
        {
            for (int i = 0; i <= LetterFrequency[c]; i++)
            {
                bag.Add(c);
            }
        }
        return bag;
    }

    // Letters appear with this approximate frequency in English:
    // https://en.wikipedia.org/wiki/Letter_frequency
    private static Dictionary<char, int> LetterFrequency = new Dictionary<char, int>()
    {
        {'E', 12},
        {'T', 9},
        {'A', 8},
        {'O', 8},
        {'I', 7},
        {'N', 7},
        {'S', 6},
        {'R', 6},
        {'H', 6},
        {'D', 4},
        {'L', 4},
        {'U', 3},
        {'C', 3},
        {'M', 3},
        {'F', 2},
        {'Y', 2},
        {'W', 2},
        {'G', 2},
        {'P', 2},
        {'B', 1},
        {'V', 1},
        {'K', 1},
        {'X', 1},
        {'Q', 1},
        {'J', 1},
        {'Z', 1},
    };
}