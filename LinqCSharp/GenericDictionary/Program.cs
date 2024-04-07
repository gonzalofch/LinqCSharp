using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace GenericDictionary;

public class Programa
{
    public static void Main(string[] args)
    {
    Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(1, "soda");
        dict.Add(2, "Burger");
        dict.Add(3, "Fries");
        dict.Add(4, "Onion Rings");

        foreach (KeyValuePair<int, string> kvp in dict)
        {
            Console.WriteLine(kvp.Key + "  --- " + kvp.Value);
        }

        dict.TryAdd(5, "PAPASSSSS");
        foreach (KeyValuePair<int, string> kvp in dict)
        {
            Console.WriteLine(kvp.Key + "  --- " + kvp.Value);
        }
    }
}