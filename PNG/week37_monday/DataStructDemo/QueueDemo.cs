static class QueueDemo
{
    public static void Run()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("Dequeue: " + queue.Dequeue()); // First
        Console.WriteLine("Peek: " + queue.Peek()); // Second
    }
}