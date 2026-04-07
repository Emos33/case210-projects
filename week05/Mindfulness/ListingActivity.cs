class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "Who are your heroes?"
    };

    private Random _rand = new Random();

    public ListingActivity() : base(
        "Listing Activity",
        "List as many positive things as you can.")
    { }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("\n" + _prompts[_rand.Next(_prompts.Count)]);
        Console.WriteLine("Start listing items...");

        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndMessage();
    }
}
