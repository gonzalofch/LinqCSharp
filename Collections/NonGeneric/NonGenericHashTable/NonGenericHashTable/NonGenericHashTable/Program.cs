using System;
using System.Collections;

namespace NonGenericHashTable;
public class Program
{
    static void Main(string[] args)
    {
        Hashtable menu = new Hashtable();
        menu.Add(1, "Soda");
        menu.Add(2,"Sugar");
        menu.Add(3,"Salt");
        menu.Add(4,"Mars");
        menu.Add(5,"Venus");
        menu.Add(6,"Earth");
        //Pila
        foreach (DictionaryEntry O in menu)
        {
            Console.WriteLine(O.Key + " -- "+ O.Value);
        }
    }
}

