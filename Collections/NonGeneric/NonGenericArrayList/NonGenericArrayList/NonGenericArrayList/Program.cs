using System;
using System.Collections;

namespace NonGenericArrayList;
public class Program
{
    static void Main(string[] args)
    {
        ArrayList al = new ArrayList();
        string str = "Like, share, Subscribe";
        int x = 11;
        DateTime d = DateTime.Parse("3-dec-1998");
        al.Add(str);
        al.Add(x);
        al.Add(d);
        foreach (object O in al) {
            Console.WriteLine(O);
        }
    }
}

