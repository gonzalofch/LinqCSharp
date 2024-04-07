using System;
namespace GenericQueue;
public class Program
{
    public static void Main(string[] args)
    {

    Queue<string> queue1= new Queue<string>();
        queue1.Enqueue("a");
        queue1.Enqueue("b");
        queue1.Enqueue("c");
        queue1.Enqueue("d");
        queue1.Enqueue("e");
        queue1.Enqueue("f");
        queue1.Enqueue("g");
        queue1.Enqueue("h");

        queue1.Dequeue();//quita de la cola el primer elemento

        foreach (var item in queue1)
        {
            Console.WriteLine(item);
        }
    }

}
