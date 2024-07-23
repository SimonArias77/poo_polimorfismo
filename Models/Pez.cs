using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models;

    public class Pez: Animal
    {
        public override void Desplazarse()
        {
            base.Desplazarse();  //LLAMA AL METODO DESPLAZAR DE LA CLASE PADRE
            Console.WriteLine("el pez está nadando en el agua");
        }
    }
