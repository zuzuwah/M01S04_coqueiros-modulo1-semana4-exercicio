using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
    public class Suco : Bebida
    {
        public string TipoCaixa { get; set; }

        public void ImprimirDados(){
            Console.WriteLine($"O produto id {Id} é um suco é do tipo {TipoCaixa} com quantidade de MiliLitros {MiliLitro}");
        }
    }
}
