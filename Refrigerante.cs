using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
    public class Refrigerante : Bebida
    {
        public Refrigerante(int id, string refrigerante, string suco, decimal miliLitros, string nomeBebida, decimal valorcompra) : base(id, refrigerante, suco, miliLitros, nomeBebida, valorcompra)
        {
            this.Id = id;
            this.Refrigerante = refrigerante;
            this.Suco = suco;
            this.MiliLitro = miliLitros;
            this.NomeBebida = nomeBebida;
            this.ValorCompra = valorcompra;
        }

        public bool vidro { get; set; }

        void ImprimirDados(object id, object nomeBebida)
        {
            if (vidro == true){
                Console.WriteLine($"O produto id {id} com nome {nomeBebida} é um refrigerante MiliLitros {MiliLitro} é um vidro ");
        } while (vidro == false){
            Console.WriteLine($"O produto id {id} com nome {nomeBebida} é um refrigerante MiliLitros {MiliLitro} é uma garrafa pet");

        }
    }
  }
}
