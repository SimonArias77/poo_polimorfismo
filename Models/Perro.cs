using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models;

public class Perro : Animal
{
    public override void Hablar() //PALABRA CLAVE "override" PARA SOBREESCRIBIR EL METODO DEL PADRE
    {
        base.Hablar(); //LLAMA AL METODO HABLAR DE LA CLASE PADRE
        Console.WriteLine("el perro dice wau");
    }

    public override void Desplazarse()
    {
        base.Desplazarse();
        Console.WriteLine("el perro está trotando");
    }
}

// POLIMORFISMO: SE UTILIZA CUANDO YO QUIERO HEREDAR METODOS O PROPIEDADES DE LA CLASE PADRE. Cuando uso la palabra reservada "base" puedo acceder tanto a los metedos del padre como del hijo. Se sobreescribe el método
// el OVERRIDE: se utiliza para sobreescribir y por buenas practicas