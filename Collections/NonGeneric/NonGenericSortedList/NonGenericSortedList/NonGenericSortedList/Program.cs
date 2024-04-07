using System;
using System.Collections;

namespace NonGenericSortedList;
public class Program
{
    static void Main(string[] args)
    {
        SortedList nonGenericsortedList= new SortedList();
        nonGenericsortedList.Add("Plas", "Soda");
        nonGenericsortedList.Add("Ples", "Sugar");
        nonGenericsortedList.Add("Plis", "Salt");
        nonGenericsortedList.Add("Plos", "Mars");
        nonGenericsortedList.Add("Plus", "Venus");
        //Pila
        foreach (DictionaryEntry d in nonGenericsortedList)
        {
            Console.WriteLine(d.Key + " -- " + d.Value);
        }
    }
}

