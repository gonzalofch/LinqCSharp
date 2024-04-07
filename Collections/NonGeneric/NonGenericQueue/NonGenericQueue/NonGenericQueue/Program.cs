using System;
using System.Collections;
namespace GenericQueue;
public class Program
{
    public static void Main(string[] args)
    {

        Queue queue1 = new Queue();
        queue1.Enqueue("aA");
        queue1.Enqueue("bB");
        queue1.Enqueue("cC");
        queue1.Enqueue("dD");
        queue1.Enqueue("eE");
        queue1.Enqueue("fF");
        queue1.Enqueue("gG");
        queue1.Enqueue("hH");

        queue1.Dequeue();//quita de la cola el primer elemento y devuelve el objeto 
        var primerObjeto = queue1.Peek();//devuelve el primer objeto sin quitarlo
        foreach (var item in queue1)
        {
            Console.WriteLine(item);
        }
        //

        Console.WriteLine("Primer Elemento Ahora:" + primerObjeto);
    }

}
