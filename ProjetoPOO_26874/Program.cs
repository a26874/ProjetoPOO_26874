using Assistencia;
using System;
using EstadoAssistencia;
using TipoAssistencia;
using Produtos;
using RegistoAssistencias;
using Pessoas;
using FrontEnd;
namespace ProjetoPOO_26874
{
    internal class Program
    {
        const int MAXCLIENTES = 10;
        static void Main(string[] args)
        {
            //Array de registo Clientes, Operadores;
            RegistoAssist listaAssist = new RegistoAssist();
            RegistoClientes listaClientes = new RegistoClientes();
            RegistoOperadores listaOperadores = new RegistoOperadores();

            //Nova assistencias
            Assist a1 = new Assist(1, DateTime.Now);
            Assist a2 = new Assist(2, DateTime.Now);
            Assist a3 = new Assist(DateTime.Now, new TipoAssist("Esclarecimento", "Atendimento", 2, 500), new EstadoAssist("Ativo", true), 42, 12);
            Assist a4 = new Assist(DateTime.Now, new TipoAssist("Entrega Produto", "Entregas", 3, 5020), new EstadoAssist("Ativo", false), 28, 12);
            Assist a5 = new Assist(DateTime.Now, new TipoAssist("Entrega Produto", "Entregas", 3, 5020), new EstadoAssist("Ativo", false), 28, 12);
            Assist a6 = new Assist(DateTime.Now, new TipoAssist("Entrega Produto", "Entregas", 3, 5020), new EstadoAssist("Ativo", false), 28, 12);

            a1.ClienteNIF = 1;
            a1.OperadorId = 1;
            a2.tipoAssis = new TipoAssist();
            a2.estadoA = new EstadoAssist();

            //Tipo assistencias
            TipoAssist descAssist1 = new TipoAssist();
            descAssist1.Desc = "Realizada Chamada para resolucao problemas";
            descAssist1.NomeTipo = "Telefone/Telemovel";
            descAssist1.Id = 1;
            descAssist1.Preco = 20000;
            a1.tipoAssis = descAssist1;





            //Estado Assistencias
            EstadoAssist estado1 = new EstadoAssist();
            estado1.Ativo = true;
            estado1.DescEstado = "Ainda objetivos para realizar.";
            a1.estadoA = estado1;

            

            //Criação de um novo cliente
            Cliente c1 = new Cliente("aaaa", 94829, new Moradas("Braga", "dsad", "4444-444"), 42);
            Cliente c2 = new Cliente("Marco", 9421474, new Moradas("asd", "222", "Braga"), 28);
            Cliente c3 = new Cliente("aadasd", 94, new Moradas("fdkk", "4718-22", "Braga"), 4);
            Cliente c4 = new Cliente("ascxzc", 274, new Moradas("zcxc", "4718-2", "Braga"), 9);
            Cliente c5 = new Cliente("cxzv", 974, new Moradas("lk", "47-222", "Braga"), 19);
            Cliente c6 = new Cliente("Mo", 244, new Moradas("zxc", "478-222", "Braga"), 29);

            //Inserir clientes na array listaClientes
            listaClientes.InsereCliente(c1);
            listaClientes.InsereCliente(c2);
            listaClientes.InsereCliente(c3);
            listaClientes.InsereCliente(c4);
            listaClientes.InsereCliente(c5);
            listaClientes.InsereCliente(c6);

            //Criar novos operadores
            Operador op1 = new Operador("Marco", 12, 2487, new Moradas("teste123","24848", "asddd"));
            Operador op2 = new Operador("asd", 2, 2222, new Moradas("teste123", "24848", "asddd"));
            Operador op3 = new Operador("Mar", 34, 2444, new Moradas("teste123", "24848", "asddd"));
            Operador op4 = new Operador("Mao", 14, 11123, new Moradas("teste123", "24848", "asddd"));
            Operador op5 = new Operador("Maco", 25, 2444, new Moradas("teste123", "24848", "asddd"));
            Operador op6 = new Operador("arco", 6, 4959, new Moradas("teste123", "24848", "asddd"));

            //Inserir operadores.
            listaOperadores.InserirOperador(op1);
            listaOperadores.InserirOperador(op2);
            listaOperadores.InserirOperador(op3);
            listaOperadores.InserirOperador(op4);
            listaOperadores.InserirOperador(op5);
            //bool teste2 = listaOperadores.InserirOperador(op6);



            //Print de cada array
            Console.WriteLine("Operadores:");
            //Operadores
            IO.MostrarOperadores(listaOperadores);

            Console.WriteLine("Clientes");
            //Clientes
            IO.MostrarClientes(listaClientes);

            bool resultadoClientes = listaClientes.RemoverClienteEspecifico(new Cliente("asdwqq", 9191, new Moradas("asd", "asdad", "asdasda"), 82748));
            bool resultadoClientes2 = listaClientes.RemoverClienteEspecifico(c3);
            Console.WriteLine(resultadoClientes);
            Console.WriteLine(resultadoClientes2);
            Console.WriteLine("Clientes removidos");
            //Clientes removidos
            IO.MostrarClientes(listaClientes);

            bool resultadoOperador = listaOperadores.RemoverOperadorEspecifico(new Operador("asda", 187, 9888, new Moradas("asda", "qwdq", "awsdd")));
            bool resultadoOperador2 = listaOperadores.RemoverOperadorEspecifico(op2);
            Console.WriteLine(resultadoOperador);
            Console.WriteLine(resultadoOperador2);
            Console.WriteLine("Operadores removidos");
            //Operadores removidos
            IO.MostrarOperadores(listaOperadores);
            //Produtos
            Produto prdt1 = new Produto("Telemovel", 1, 2000, "SAMSUNG");


            //BubbleSortClientes
            listaClientes.BubbleSortClientes();
            Console.WriteLine("Ordenado por NIF");
            IO.MostrarClientes(listaClientes);


            //BubbleSortOperadores
            listaOperadores.BubbleSortOperadores();
            Console.WriteLine("Ordenado por ID");
            IO.MostrarOperadores(listaOperadores);


            //Inserir nova assistencia;
            listaAssist.InsereAssist(listaOperadores.ObterOperadores,listaClientes.ObterClientes, a3);
            listaAssist.InsereAssist(listaOperadores.ObterOperadores, listaClientes.ObterClientes, a4);
            listaAssist.InsereAssist(listaOperadores.ObterOperadores, listaClientes.ObterClientes, a5);
            listaAssist.InsereAssist(listaOperadores.ObterOperadores, listaClientes.ObterClientes, a6);
            //Assistencias
            Console.WriteLine("Assistencias:");
            IO.MostrarAssistencias(listaAssist);

            //
            Console.WriteLine("teste");
            IO.MostrarAssistencias(listaAssist);
            IO.MostrarClientes(listaClientes);
            IO.MostrarOperadores(listaOperadores);
            int resultado = IO.MostrarAssistenciaMaisCara(listaAssist);
            Console.WriteLine(resultado);
        }

    }
}
