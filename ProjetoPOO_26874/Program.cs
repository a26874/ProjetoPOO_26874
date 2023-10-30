using Assistencia;
using Clientes;
using System;
using EstadoAssistencia;
using TipoAssistencia;
using Morada;
using Operadores;
using RegistoAssistencias;

namespace ProjetoPOO_26874
{
    internal class Program
    {
        const int MAXASSISTENCIAS = 10;
        const int TIPOSASSISTENCIA = 5;
        const int MAXCLIENTES = 10;
        const int MAXOPERADORES = 10;
        static void Main(string[] args)
        {
            RegistoAssist registoAssist = new RegistoAssist();

            //Nova assistencias
            Assist a1 = new Assist(1, DateTime.Now, 20);
            Assist a2 = new Assist(2, DateTime.Now, 30);
            //Assist a3 = new Assist(3, DateTime.Now, 40);
            a1.tipoAssis.NomeTipo = "teste";
            a1.tipoAssis.Id = 2;
            a1.estadoA.Ativo = true;
            a1.estadoA.DescEstado = "Concluido";

            a2.tipoAssis = new TipoAssist();
            a2.estadoA = new EstadoAssist();
            a2.cliente = new Cliente();
            a2.operador = new Operador();


            //Tipo assistencias
            TipoAssist[] tipoAssistencias = new TipoAssist[TIPOSASSISTENCIA];
            TipoAssist descAssist1 = new TipoAssist();
            descAssist1.Desc = "Realizada Chamada para resolucao problemas";
            descAssist1.NomeTipo = "Telefone/Telemovel";
            descAssist1.Id = 1;
            tipoAssistencias[0] = descAssist1;
            //a1.tipoAssis = tipoAssistencias[0];
            a1.tipoAssis = descAssist1;





            //Estado Assistencias
            EstadoAssist estado1 = new EstadoAssist();
            estado1.Ativo = true;
            estado1.DescEstado = "Ainda objetivos para realizar.";
            //a1.estadoA = estado1;

            //Clientes
            Cliente[] clientes = new Cliente[MAXCLIENTES];

            Cliente c1 = new Cliente();
            c1.Nome = "askdaskd";
            c1.Contacto = 424242;
            c1.Morada = new Moradas();
            c1.Morada.Localidade = "Braga";
            c1.Morada.Rua = "asdas";
            c1.Morada.CodPostal = "2487-248";
            clientes[0] = c1;

            a1.cliente = c1;



            //Operadores
            Operador[] operadores = new Operador[MAXOPERADORES];
            
            Operador op1 = new Operador();
            op1.Nome = "Marco";
            op1.Contacto = 18274;
            op1.Id = 2;

            a1.operador = op1;
            
            //foreach (Assist a in assistencias)
            //{
            //    if (a is null)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(a.ToString());
            //    Console.WriteLine();
            //}
            Console.WriteLine(a1.cliente.ToString());
            registoAssist.InsereAssist(a1);
        }

    }
}
