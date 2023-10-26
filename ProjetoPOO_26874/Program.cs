using Assistencia;
using Clientes;
using System;
using EstadoAssistencia;
using TipoAssistencia;

namespace ProjetoPOO_26874
{
    internal class Program
    {
        const int MAXASSISTENCIAS = 5;
        const int TIPOSASSISTENCIA = 5;
        const int MAXCLIENTES = 10;
        static void Main(string[] args)
        {
            Assist[] assistencias = new Assist[MAXASSISTENCIAS];

            /// Nova assistencias
            Assist a1 = new Assist(1, DateTime.Now, 20);
            Assist a2 = new Assist(2, DateTime.Now, 30);
            Assist a3 = new Assist(3, DateTime.Now, 40);
            assistencias[0] = a1;
            assistencias[1] = a2;
            assistencias[2] = a3;
            ///Tipo assistencias
            TipoAssist[] tipoAssistencias = new TipoAssist[TIPOSASSISTENCIA];
            TipoAssist descAssist1 = new TipoAssist();
            descAssist1.Desc = "Realizada Chamada para resolucao problemas";
            descAssist1.NomeTipo = "Telefone/Telemovel";
            descAssist1.Id = 1;
            tipoAssistencias[0] = descAssist1;
            a1.tipoAssis = tipoAssistencias[0];


            EstadoAssist estado1 = new EstadoAssist();
            estado1.aDecorrer = true;
            estado1.DescEstado = "Ainda objetivos para realizar.";

            a1.estadoA = estado1;


            //Console.WriteLine("{0},{1},{2}", a1.tipoAssis.NomeTipo, a1.tipoAssis.Id, a1.tipoAssis.Desc);
            //Console.WriteLine(descAssist1.ToString());

            Console.WriteLine(a1.estadoA.ToString());
            
            //foreach (Assist c in assistencias)
            //{
            //    if (c != null)
            //        Console.WriteLine(c.ToString());
            //}
        }
    }
}
