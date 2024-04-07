using System;
namespace GenericStack;
public class Program
{
    static void Main(string[] args)
    {
        Stack<string> stack1 = new Stack<string>();
        stack1.Push("1");
        stack1.Push("2");
        stack1.Push("3");
        stack1.Push("4");
        stack1.Push("5");
        stack1.Push("6");
        stack1.Push("7");
        //Pila, se almacenan en el mismo orden en el que entran al stack, el ultimo elemento en escribirse, sera el primero al leerse
        foreach (var item in stack1)
        {
            Console.WriteLine(item);
        }
    }
}