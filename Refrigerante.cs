using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
    public class Refrigerante : Bebida
{
    public bool Vidro { get; set; }
    
    public override void ImprimirDados()
    {
        string tipoEmbalagem = Vidro ? "vidro" : "garrafa pet";
        Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante MiliLitros {MiliLitro} em {tipoEmbalagem}");
    }
    
    public Refrigerante(int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra, bool vidro) 
        : base(id, tipo, miliLitro, nomeBebida, valorCompra)
    {
        Vidro = vidro;
    }
    }
}
