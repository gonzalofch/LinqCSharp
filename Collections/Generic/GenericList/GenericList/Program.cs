using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace GenericList;
public class Mascota
{
    public string Nombre { get; set; }

    public int Edad { get; set; }
}

    public static void Main(string[] args)
{
    List<int> genericList1 = new List<int>();
    List<int> genericList2 = new List<int>();

    genericList1.Add(1);
    genericList1.Add(2);
    genericList1.Add(3);
    genericList1.Add(4);
    genericList2.Add(5);
    genericList2.Add(6);
    genericList2.Add(7);
    genericList2.Add(8);
    genericList2.Add(9);
    genericList2.Add(10);
    genericList2.Add(11);
    genericList1.AddRange(genericList2);

    Console.WriteLine("Ex 1");
    //Lista 1 + Lista 2
    foreach (int item in genericList1)
    {
        Console.WriteLine(item);
    }
    //Lista 2 
    Console.WriteLine("Ex 2");
    foreach (int item in genericList2)
    {
        Console.WriteLine(item);
    }

    //Lista 2 removiendole Sus elementos
    genericList2.Remove(6);//6
    genericList2.RemoveAt(1);//7
                             //genericList2.RemoveAt(genericList2.Count);
    Console.WriteLine("Ex 3");
    foreach (int item in genericList2)
    {
        Console.WriteLine(item);
    }
    genericList2.RemoveAll(LessThan10);
    //Lista 2 removiendole los que son menores que 10
    Console.WriteLine("Ex 4");
    foreach (int item in genericList2)
    {
        Console.WriteLine(item);
    }
    //genericList1.Clear();  //REMUEVE TODOS LOS ELEMENTOS DE UNA LISTA
    //genericList1.RemoveRange(5, 6); //REMUEVE RANGO DE ELEMENTOS ENTRE LOS INDICES INDICADOS
    bool areLessThan10 = genericList1.All(LessThan10);
    Console.WriteLine("Ex 5");
    Console.WriteLine("Los elementos de la lista1 son menores que 10????");
    Console.WriteLine("Los elementos son: ");
    foreach (int item in genericList1)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("Respuesta: " + areLessThan10);
    Console.WriteLine("Ex 6");
    //USO DEL ANY 
    //determinar si una secuencia tiene elementos
    bool hasElements = genericList1.Any();
    Console.WriteLine("The list {0} empty.",
        hasElements
        ? "is not"
        : "is");
    //El metodo Any() en este caso sirve para revisar si algun objeto trae o no un array vacio de tipo Mascotas()
    Console.WriteLine("Ex 7");
    var personas = GetPersonas();

    var peron = from person in personas
    where person.Mascotas.Any()
    select new { person.Nombre, person.Edad, person.ComidaFavorita,person.Mascotas};
        foreach (var item in peron)
        {
            Console.WriteLine(item);
        }
    }
}