static class StackDemo
{
    public static void Run()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Pop: " + stack.Pop()); // 30
        Console.WriteLine("Peek: " + stack.Peek()); // 20
    }
}