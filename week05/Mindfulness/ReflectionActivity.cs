class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you did something difficult.",
        "Think of a time you showed strength.",
        "Think of a time you stood up for someone."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made this different?",
        "How can you apply this again?"
    };

    private Random _rand = new Random();

    public ReflectionActivity() : base(
        "Reflection Activity",
        "Reflect on times when you showed strength and resilience.")
    { }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("\n" + _prompts[_rand.Next(_prompts.Count)]);
        Console.WriteLine("\nReflect on the following questions:");

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("\n> " + _questions[_rand.Next(_questions.Count)]);
            ShowSpinner(4);
        }

        EndMessage();
    }
}
