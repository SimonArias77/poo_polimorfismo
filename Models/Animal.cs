using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models;

public class Animal
{
    public Guid Id { get; set; } //PROPIEDADES DE LA CLASE ANIMAL
    public string Name { get; set; }
    public string Genero { get; set; }
    public string Especie { get; set; }
    private double PesoEnKG { get; set; } // como se cambia a "private" no se puede heredar, no podría utilizarse en las clases hijas

    public Animal(string name, string genero, string especie, double pesoEnKG)
    {
        Id = new Guid();
        Name = name;
        Genero = genero;
        Especie = especie;
        PesoEnKG = pesoEnKG;
        //Aquí se podría implementar un constructor para inicializar las propiedades
    }

    public virtual void Hablar()  // METODOS DE LA CLASE ANIMAL. Con la palabra "virtual" podemos permitir que las clases ijas tengan acceso al metodo y  lo usen a su gusto
    {
        Console.WriteLine("el animal está hablando");
    }
    public virtual void Desplazarse()
    {
        Console.WriteLine("el animal se está desplazando");
    }
}
