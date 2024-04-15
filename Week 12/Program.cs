using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Function asks for the amount of numbers being inputed and then creates a
        // stack of the integers inputed.
        Console.Write("Enter the number of integers: ");
        int N = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        Console.WriteLine("Enter the integers:");
        // Runs the function of listing each number in the stack, then in reverse, and then when
        // done with the number, pops it.
        for (int i = 0; i < N; i++)
        {
            int num = int.Parse(Console.ReadLine());
            stack.Push(num);
        }

        Console.WriteLine("Reversed order:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        // function takes the array listed below and the foreach section counts how many instances
        // of the integer there are.
        Console.WriteLine("Array Function:");
        int[] array = { 35, 4, 12, 2, 36, 35, 77, 3, 2 };

        Dictionary<int, int> occurrences = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (occurrences.ContainsKey(num))
            {
                occurrences[num]++;
            }
            else
            {
                occurrences[num] = 1;
            }
        }

        foreach (var pair in occurrences)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} times");
        }

        // function takes the input of 1 number and then runs it through a queue sequence where in
        // it takes the number given and adds 1 to it, then takes that same number and
        // multiplies by 2 and adds 1 to it, finally it takes that number and adds 2 to it.
        // Continuously running this through the for loop.
        Console.WriteLine("Queue Function:");
        Console.Write("Which number would you like to run?:  ");
        int J = int.Parse(Console.ReadLine());

        Queue<int> sequence = new Queue<int>();
        sequence.Enqueue(J);

        Console.WriteLine("First 50 numbers of the sequence:");
        for (int i = 0; i < 50; i++)
        {
            int current = sequence.Dequeue();
            Console.WriteLine(current);

            sequence.Enqueue(current + 1);
            sequence.Enqueue(2 * current + 1);
            sequence.Enqueue(current + 2);
        }
    }
}
