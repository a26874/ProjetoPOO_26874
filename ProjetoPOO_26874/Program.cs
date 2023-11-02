using Assistencia;
using System;
using EstadoAssistencia;
using TipoAssistencia;
using Produtos;
using RegistoAssistencias;
using Pessoas;

namespace ProjetoPOO_26874
{
    internal class Program
    {
        const int MAXCLIENTES = 10;
        static void Main(string[] args)
        {
            RegistoAssist registoAssist = new RegistoAssist();

            //Nova assistencias
            Assist a1 = new Assist(1, DateTime.Now);
            Assist a2 = new Assist(2, DateTime.Now);
            //Assist a3 = new Assist(3, DateTime.Now, 40);
            a1.tipoAssis.NomeTipo = "teste";
            a1.tipoAssis.Id = 2;
            a1.estadoA.Ativo = true;
            a1.estadoA.DescEstado = "Concluido";
            a1.ClienteId = 1;
            a1.OperadorId = 1;
            a2.tipoAssis = new TipoAssist();
            a2.estadoA = new EstadoAssist();


            //Tipo assistencias
            TipoAssist descAssist1 = new TipoAssist();
            descAssist1.Desc = "Realizada Chamada para resolucao problemas";
            descAssist1.NomeTipo = "Telefone/Telemovel";
            descAssist1.Id = 1;
            descAssist1.Preco = 20000;
            //a1.tipoAssis = tipoAssistencias[0];
            a1.tipoAssis = descAssist1;





            //Estado Assistencias
            EstadoAssist estado1 = new EstadoAssist();
            estado1.Ativo = true;
            estado1.DescEstado = "Ainda objetivos para realizar.";
            //a1.estadoA = estado1;

            //Pessoas
            Clientes listaClientes = new Clientes();


            Cliente c1 = new Cliente();
            c1.Nome = "askdaskd";
            c1.Contacto = 424242;
            c1.NIF = 29442442;
            c1.Morada = new Moradas();
            c1.Morada.Localidade = "Braga";
            c1.Morada.Rua = "asdas";
            c1.Morada.CodPostal = "2487-248";

            Cliente c2 = new Cliente("Marco", 9274, new Moradas("Teste", "4718-222", "Braga"), 284719);

            listaClientes.InsereCliente(c1);

            //foreach (Cliente c in listaClientes.ObterClientes)
            //{
            //    if (c.NIF == -1)
            //        continue;
            //    Console.WriteLine(c.ToString());
            //}

            bool teste = false;

            teste =listaClientes.InsereCliente(c1);

            listaClientes.InsereCliente(c2);
            foreach (Cliente c in listaClientes.ObterClientes)
            {
                if (c.NIF == -1)
                    continue;
                Console.WriteLine(c.ToString());
            }
            Produto prdt1 = new Produto("Telemovel", 1, 2000, "SAMSUNG");


            //Pessoas
            
            Operador op1 = new Operador();
            op1.Nome = "Marco";
            op1.Contacto = 18274;
            op1.Id = 2;


            
            registoAssist.InsereAssist(a1);
            foreach (Assist a in registoAssist.TodasAssistencias)
            {
                if (a.Id == -1)
                    continue;
                Console.WriteLine(a.ToString());
            }
        }
    }
}
