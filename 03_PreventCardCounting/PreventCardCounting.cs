public class PreventCardCounting
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Shuffle Bag Die Rolls, Preventing Card Counting:");

        // Create bag:
        var bag = CreateBag();

        // Pick elements at random, removing from bag:
        var random = new Random();
        for (int i = 0; i < 6; i++)
        {
            int index = random.Next(bag.Count);
            int result = bag[index];
            bag.RemoveAt(index);
            Console.WriteLine(result);

            // If we're halfway through, create a new bag to prevent card counting:
            if (bag.Count < 3) bag = CreateBag();
        }
    }

    public static List<int> CreateBag()
    {
        var bag = new List<int>();
        for (int i = 1; i <= 6; i++)
        {
            bag.Add(i);
        }
        return bag;
    }
}