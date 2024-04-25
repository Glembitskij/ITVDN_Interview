// Що буде виведено на консоль?

ThreadStart write = new ThreadStart(Write);

Thread thread = new Thread(write);
thread.Start();

Write();

static void Write()
{
    int counter = 0;

    while (counter < 10)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"counter = {counter} - thread - {Thread.CurrentThread.ManagedThreadId}");
        counter++;
    }
}