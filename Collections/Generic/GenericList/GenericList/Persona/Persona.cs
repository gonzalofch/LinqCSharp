using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList.Persona
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string ComidaFavorita { get; set; }

        public int Edad { get; set; }

        public Mascota[] Mascotas { get; set; }

        private static bool LessThan10(int number)
        {
            return number < 10;
        }

        public static List<Persona> GetPersonas()
        {
            List<Persona> todasLasPersonas = new List<Persona>()
        {
        new Persona() { Nombre = "Gonzalo", Apellidos="Flore Chuchon", ComidaFavorita = "Ceviche" , Edad=19 , Mascotas = new Mascota[]
                        { new Mascota (){Nombre = "Loba", Edad = 3},
                          new Mascota (){Nombre = "Kratos", Edad = 10}}},
        new Persona() { Nombre = "Andrea", Apellidos="García Chavez", ComidaFavorita = "Calamares" , Edad=18 ,Mascotas = new Mascota[]
                        {
                            new Mascota() { Nombre = "Mondongo", Edad=12}
                        }
                      },
        new Persona() { Nombre = "Oscar", Apellidos="Alberto Diaz", ComidaFavorita = "Pizza" ,Edad=19 , Mascotas = new Mascota[]
                            {
                            new Mascota(){Nombre = "Dinky",Edad = 9 }
                            }
                      },
        new Persona() { Nombre = "Ansi", Apellidos="Chong Chang", ComidaFavorita = "Tacos" ,Edad=20 ,Mascotas= new Mascota[] { } },

        new Persona() { Nombre = "Diego", Apellidos = "Gabriel Ortiz", ComidaFavorita = "Hamburguesa", Edad = 16, Mascotas = new Mascota[] { } },

        new Persona() { Nombre = "Juan", Apellidos = "Diego Rios", ComidaFavorita = "Pizza", Edad = 17, Mascotas = new Mascota[]
                            {
                            new Mascota(){Nombre = "Dogo",Edad=8 },
                            new Mascota(){Nombre = "Colacao",Edad=10 },
                            }
                      },
        new Persona() { Nombre = "Juan", Apellidos = "Zapata Suarez", ComidaFavorita = "Pizza" ,Edad = 23 ,Mascotas = new Mascota[]{ }},
        new Persona() { Nombre = "Joseph", Apellidos = "Wong Adriel", ComidaFavorita = "Ceviche" ,Edad = 19 ,Mascotas = new Mascota[]
                            {
                            new Mascota(){Nombre="Bobo",Edad = 10},
                            new Mascota(){Nombre="Boba",Edad = 6},
                            }
                      },
        };
            return todasLasPersonas;
        }
    
    
    }
    }
