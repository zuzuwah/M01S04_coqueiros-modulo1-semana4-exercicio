using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
   public class Suco : Bebida
{
    public string TipoCaixa { get; set; }
    
    public void ImprimirDados()
    {
        Console.WriteLine($"O produto id {Id} é um suco do tipo {TipoCaixa} com quantidade de MiliLitros {MiliLitro}");
    }
    
    public Suco(int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra, string tipoCaixa) 
        : base(id, tipo, miliLitro, nomeBebida, valorCompra)
    {
        TipoCaixa = tipoCaixa;
    }
    
    }
}
