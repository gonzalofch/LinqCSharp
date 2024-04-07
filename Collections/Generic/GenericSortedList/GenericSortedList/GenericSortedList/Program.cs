using System;
using System.Collections.Generic;

namespace GenericSortedList;

class Program
{
    static void Main(string[] args)
    {
        SortedList<string,string> slist = new SortedList<string,string>();
        slist.Add("America", "Hamburguesa");
        slist.Add("Brasil", "Pizza");
        slist.Add("Koala", "Kiwi");
        slist.Add("Avestruz", "Stringggg");
        foreach (KeyValuePair<string,string> kvp in slist)
        {
            Console.WriteLine(kvp.Key + " ---- "+kvp.Value);
        }
    }
}