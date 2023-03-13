using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S04
{
    public static class Repositório
{
    private static List<Bebida> _bebidas = new List<Bebida>();
    private static List<Suco> _sucos = new List<Suco>();
    private static List<Refrigerante> _refrigerantes = new List<Refrigerante>();

    public static List<Bebida> Bebidas
    {
        get { return _bebidas; }
    }

    public static List<Suco> Sucos
    {
        get { return _sucos; }
    }

    public static List<Refrigerante> Refrigerantes
    {
        get { return _refrigerantes; }
    }

    public static void AdicionarSuco(Suco suco)
    {
        _sucos.Add(suco);
    }

    public static void AdicionarRefrigerante(Refrigerante refrigerante)
    {
        _refrigerantes.Add(refrigerante);
    }

    public static void AdicionarBebida(Bebida bebida)
    {
        _bebidas.Add(bebida);
    }

    public static void AlterarBebida(Bebida bebida)
    {
        int index = _bebidas.FindIndex(b => b.Id == bebida.Id);
        if (index != -1)
        {
            _bebidas[index] = bebida;
        }
    }

    public static void ExcluirBebida(int id)
    {
        _bebidas.RemoveAll(b => b.Id == id);
    }

    public static List<Bebida> ListarBebidas()
    {
        return _bebidas;
    }
    }
}
