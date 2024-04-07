using LinqCSharp.Tests.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCSharp.Tests
{
    public class Enfermedad
    {
        public Riesgos Riesgo { get; set; }
        public string TipoAnimal { get; set; }
        public bool TieneCura { get; set; }
        public string NombreEnfermedad { get; set; }
        public static List<Enfermedad> GetEnfermedades()
        {
            List<Enfermedad> enfermedades = new List<Enfermedad>() {
            new Enfermedad { Riesgo = Riesgos.Bajo, TipoAnimal = "Perro", TieneCura = true, NombreEnfermedad = "Parvovirosis" },
            new Enfermedad { Riesgo = Riesgos.Medio, TipoAnimal = "Gato", TieneCura = false, NombreEnfermedad = "Leucemia Felina" },
            new Enfermedad { Riesgo = Riesgos.Alto, TipoAnimal = "Mono", TieneCura = false, NombreEnfermedad = "Fiebre del Mono" },
            new Enfermedad { Riesgo = Riesgos.Bajo, TipoAnimal = "Vaca", TieneCura = true, NombreEnfermedad = "Mastitis" },
        };
            return enfermedades;
        }

    }
}
