using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
    public static class Repositório
    {
        public static List<Bebida> listaBebidas {get; set; }
        
        public static List<Suco> listaSucos {get; set; }

        public static List<Refrigerante> listaRefrigerante {get; set; }

        public static void AdicionarSuco (Suco suco)
        {
            listaSucos.Add(suco);

        }

        public static void AdicionarRefrigerante(Refrigerante refrigerante){
            listaRefrigerante.Add(refrigerante);

        }

        public static void AdiconarBebida(Bebida bebida){
            listaBebidas.Add(bebida);
        }

        public static void AlterarBebida (Bebida bebida){
            bebida.NomeBebida = "Pepsi";
        }

        public static void ExcluirBebida (Bebida bebida){
            
            var bebidaParaExcluir = listaBebidas.FirstOrDefault(b => b.Id == bebida.Id);
    
    
    if (bebidaParaExcluir != null)
    {
        listaBebidas.Remove(bebidaParaExcluir);
        Console.WriteLine($"Bebida com ID {bebida.Id} excluída com sucesso.");
    }
    else
    {
        Console.WriteLine($"Bebida com ID {bebida.Id} não encontrada.");
    }
        }
    }
}
