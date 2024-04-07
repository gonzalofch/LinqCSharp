using LinqCSharp.Tests;
using System.Collections;
using System.Text;
using System.Xml.Linq;

Animal[] zoo = new Animal[20]
{
        new Animal () {Name ="Loba", Type ="Perro",Age=1},
        new Animal () {Name ="Lobo", Type ="Perro",Age=6},
        new Animal () {Name ="Boba", Type ="Perro",Age=2},
        new Animal () {Name ="Bobo", Type ="Perro",Age=4},
        new Animal () {Name ="Dinky", Type ="Perro",Age=7},
        new Animal () {Name ="Donky", Type ="Perro",Age=5},
        new Animal () {Name ="Miguel", Type ="Gato",Age=1},
        new Animal () {Name ="Roberto", Type ="Gato",Age=0},
        new Animal () {Name ="Lola", Type ="Vaca",Age=13},
        new Animal () {Name ="Brayan", Type ="Mono",Age=int.MaxValue},
        new Animal () {Name ="Doraemon ", Type ="Gato",Age=10},
        new Animal () {Name ="Andrii", Type ="Mono",Age=8},
        new Animal () {Name ="Gorda", Type ="Vaca",Age=16},
        new Animal () {Name ="Tom", Type ="Gato",Age=4},
        new Animal () {Name ="Figaro", Type ="Gato",Age=11},
        new Animal () {Name ="Silvestre ", Type ="Gato",Age=3},
        new Animal () {Name ="Garfield ", Type ="Gato",Age=2},
        new Animal () {Name ="Kratos", Type ="Perro",Age=10},
        new Animal () {Name ="", Type ="Mono",Age=4},
        new Animal () {Name ="Loba", Type ="Perro",Age=15},
};

//foreach (var animal in zoo)
//{
//    Console.WriteLine(animal.Name);
//    Console.WriteLine(animal.Type);
//    Console.WriteLine(animal.Age);
//}

Console.WriteLine("LETRA L");
var animalesConLetraL = zoo.
        Where(z => z.Name.StartsWith('L')).Select(z => new { z.Name, z.Type, z.Age });
foreach (var animal in animalesConLetraL)
{
    StringBuilder mensaje = new StringBuilder();
    var años = animal.Age == 0 || animal.Age > 1
        ? animal.Age.ToString() + " años"
        : animal.Age.ToString() + " año";
    mensaje.Append(animal.Name)
    .Append(" tiene ")
    .Append(años)
    .Append(" y es un ")
    .Append(animal.Type);

    Console.WriteLine(mensaje.ToString());
}
Console.WriteLine("TODOS LOS GATOS");
var todosLosGatos = from z in zoo
                    where z.Type == "Gato"
                    select new { z.Name, z.Type, z.Age };

foreach (var animal in todosLosGatos)
{
    StringBuilder mensaje = new StringBuilder();
    var años = animal.Age == 0 || animal.Age > 1
        ? animal.Age.ToString() + " años"
        : animal.Age.ToString() + " año";
    mensaje.Append(animal.Name)
    .Append(" tiene ")
    .Append(años)
    .Append(" y es un ")
    .Append(animal.Type);

    Console.WriteLine(mensaje.ToString());
}
void ImprimirDatos(Animal animal)
{
    StringBuilder mensaje = new StringBuilder();
    var años = animal.Age == 0 || animal.Age > 1
        ? animal.Age.ToString() + " años"
        : animal.Age.ToString() + " año";
    mensaje.Append(animal.Name)
    .Append(" tiene ")
    .Append(años)
    .Append(" y es un ")
    .Append(animal.Type);

    Console.WriteLine(mensaje.ToString());
}

Console.WriteLine("GATOS CON METODO:");
//foreach (var animal in todosLosGatos)
//{

//    ImprimirDatos(animal);
//}
IEnumerable todosLosPerros = from z in zoo
                             where z.Type == "Gato"
                             select new { z.Name, z.Type, z.Age };


