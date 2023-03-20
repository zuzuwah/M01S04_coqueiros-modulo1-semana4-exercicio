using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
    public static class Repositorio
    {
        private static List<Bebida> ListaBebida { get; set; }
        private static List<Suco> ListaSuco { get; set; }
        private static List<Refrigerante> ListaRefrigerante { get; set; }

        static Repositorio()
        {
            if (ListaBebida == null)
            {
                ListaBebida = new List<Bebida>();
            }

            if (ListaSuco == null)
            {
                ListaSuco = new List<Suco>();
            }

            if (ListaRefrigerante == null)
            {
                ListaRefrigerante = new List<Refrigerante>();
            }
        }

        public static void InserirBebida(Bebida bebida)
        {
            ListaBebida.Add(bebida);
        }

        public static void InserirSuco(Suco suco)
        {
            ListaSuco.Add(suco);
        }

        public static void InserirRefrigerante(Refrigerante refrigerante)
        {
            ListaRefrigerante.Add(refrigerante);
        }

        public static void Alterar(Bebida bebida)
        {
            foreach (var item in ListaBebida.Where(listaEmMemoria => listaEmMemoria.Id == bebida.Id)) 
            {
                item.NomeBebida = bebida.NomeBebida;
            }
        }

        public static void Remover(int id)
        {
          
            var localBebida = ListaBebida.FirstOrDefault(w => w.Id == id);
            if (localBebida != null)
            {
                ListaBebida.Remove(localBebida);
            }
        }

        public static List<Bebida> Listar()
        {
            return ListaBebida;
        }

        public static void ImprimirSuco()
        {
            foreach (var suco in ListaSuco)
            {
                suco.ImprimirDados();
            }
        }

        public static void ImprimirRefrigerante()
        {
            foreach (var refrigerante in ListaRefrigerante)
            {
                refrigerante.ImprimirDados();
            }
        }

        internal static void Alterar()
        {
            throw new NotImplementedException();
        }


    }
}
