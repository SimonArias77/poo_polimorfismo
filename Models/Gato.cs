using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models;

public class Gato : Animal
{

    public double TamanoBigotes { get; set; }
    public bool Orejas { get; set; }

    public Gato(string nombre, string genero, string especie, double pesoEnKg, double tamanoBigotes, bool orejas) : base(nombre, genero, especie, pesoEnKg)
    {
        TamanoBigotes = tamanoBigotes;
        Orejas = orejas;
    }
    public override void Hablar()
    {
        base.Hablar();
        Console.WriteLine("el gato dice miauu");
    }

    public override void Desplazarse()
    {

        Console.WriteLine("el gato está corriendo"); //NO se pone el base para no heredar del padre y solo mostrar lo del hijo
    }
}
