using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCSharp.Tests
{
    public class Animal
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public static List<Animal> GetAllAnimals()
        {
            List<Animal> todosLosAnimales = new List<Animal>()
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
            return todosLosAnimales;
        }
    }

}
