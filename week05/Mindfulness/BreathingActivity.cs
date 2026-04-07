class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by guiding your breathing.")
    { }

    public void Run()
    {
        StartMessage();

        int time = 0;

        while (time < _duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(3);

            Console.Write("\nBreathe out...");
            ShowCountdown(3);

            time += 6;
        }

        EndMessage();
    }
}
