using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
   
public class Bebida
{
     public int Id { get; set; }
    public string Tipo { get; set; }
    public decimal MiliLitro { get; set; }
    public string NomeBebida { get; set; }
    public decimal ValorCompra { get; set; }
    
    public void Comprar(decimal novoValorCompra)
    {
        ValorCompra = novoValorCompra;
        Console.WriteLine($"Valor da compra do produto id {Id} alterado para {ValorCompra}");
    }

        internal static Bebida Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public Bebida(int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra)
        {
            Id = id;
            Tipo = tipo;
            MiliLitro = miliLitro;
            NomeBebida = nomeBebida;
            ValorCompra = valorCompra;
        }

        public Bebida()
        {
        }
    
         public virtual void ImprimirDados()
        {
            Console.WriteLine($"O produto id {this.Id} é uma bebida com {this.MiliLitro} mL"); 
        }
    
    }



}



