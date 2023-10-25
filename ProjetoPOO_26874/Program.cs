using Assistencia;
using Clientes;
using EstadoAssistencia;
using Operadores;
using Produtos;
using ProblemasConhecidos;
using Feedback;
using TipoAssistencia;
using System;
using System.Security.Cryptography;

namespace ProjetoPOO_26874
{
    internal class Program
    {
        const int MAXASSISTENCIAS = 5;
        const int MAXCLIENTES = 10;
        static void Main(string[] args)
        {
            Assist[] assistencias = new Assist[MAXASSISTENCIAS];

            Assist a1 = new Assist(1, DateTime.Now, 20);
            Assist a2 = new Assist(2, DateTime.Now, 30);
            Assist a3 = new Assist(3, DateTime.Now, 40);

            assistencias[0] = a1;
            assistencias[1] = a2;
            assistencias[2] = a3;

            Cliente[] clientes = new Cliente[MAXCLIENTES];
            //foreach (Assist c in assistencias)
            //{
            //    if (c != null)
            //        Console.WriteLine(c.ToString());
            //}
        }
    }
}
