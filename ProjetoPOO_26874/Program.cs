using Assistencia;
using FrontEnd;
using Outros;
using Pessoas;
using System;


namespace ProjetoPOO_26874
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de registo Assistencias, Clientes, Operadores, produtos 
            RegistoAssist listaAssist = new RegistoAssist();
            RegistoClientes listaClientes = new RegistoClientes();
            RegistoOperadores listaOperadores = new RegistoOperadores();
            RegistoProdutos listaProdutos = new RegistoProdutos();
            RegistoProblemas listaSolucoes = new RegistoProblemas();

            //Nova assistencias
            Assist a1 = new Assist(new DateTime(2023, 4, 20, 16, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a2 = new Assist(new DateTime(2023, 10, 5, 10, 22, 11), new TipoAssist("Informacao entrega Produto", "Entregas", 2, 345), new EstadoAssist("Ativo", true), 1759, 12);
            Assist a3 = new Assist(new DateTime(2023, 11, 1, 13, 45, 44), new TipoAssist("Encomendas de produtos", "Entregas", 2, 255), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a4 = new Assist(new DateTime(2023, 9, 29, 11, 55, 51), new TipoAssist("Servico Manutencao", "Assistencia", 4, 1000), new EstadoAssist("Ativo", true), 1676, 12);
            Assist a5 = new Assist(new DateTime(2023, 7, 15, 19, 11, 33), new TipoAssist("Dificuldades Tecnicas", "Manutencao", 3, 200), new EstadoAssist("Ativo", true), 1676, 12);

            //Criação de um novo cliente
            Cliente c1 = new Cliente("Marco", 94829, new Morada("Braga", "4720-452", "Amares"), 1874);
            Cliente c2 = new Cliente("Ruben", 9421474, new Morada("Braga", "4122-862", "VilaVerde"), 1676);
            Cliente c3 = new Cliente("Andre", 94, new Morada("Braga", "4000-221", "Barcelos"), 1266);
            Cliente c4 = new Cliente("Macedo", 274, new Morada("Porto", "4218-211", "Arouca"), 1759);
            Cliente c5 = new Cliente("Nuno", 974, new Morada("Porto", "4117-222", "Espinho"), 1911);
            Cliente c6 = new Cliente("Flavia", 244, new Morada("Porto", "478-222", "Arcos"), 1898);

            //Inserir clientes na array listaClientes

            listaClientes.InsereCliente(c1);
            listaClientes.InsereCliente(c2);
            listaClientes.InsereCliente(c3);
            listaClientes.InsereCliente(c4);
            listaClientes.InsereCliente(c5);
            listaClientes.InsereCliente(c6);

            //Criar novos operadores
            Operador op1 = new Operador("Marco", 12, 2487, new Morada("Braga", "4720-444", "Amares"));
            Operador op2 = new Operador("Joao", 2, 2222, new Morada("Braga", "4700-124", "VilaVerde"));
            Operador op3 = new Operador("Goncalo", 34, 2444, new Morada("Porto", "4262-244", "Arouca"));
            Operador op4 = new Operador("Rui", 14, 11123, new Morada("Braga", "4991-242", "VilaVerde"));
            Operador op5 = new Operador("Luis", 25, 2444, new Morada("Porto", "4221-112", "Arouca"));
            Operador op6 = new Operador("Diogo", 6, 4959, new Morada("Braga", "4872-111", "Barcelos"));

            int numeroOperadores = listaOperadores.NumeroOperadoresExistentes();

            //Inserir operadores.
            listaOperadores.InsereOperador(op1);
            listaOperadores.InsereOperador(op2);
            listaOperadores.InsereOperador(op3);
            listaOperadores.InsereOperador(op4);
            listaOperadores.InsereOperador(op5);
            //bool teste2 = listaOperadores.InsereOperador(op6);



            //Print de cada array
            Console.WriteLine("Operadores:");
            //Operadores
            IO.MostrarOperadores(listaOperadores);

            Console.WriteLine("Clientes");
            //Clientes
            IO.MostrarClientes(listaClientes);

            bool resultadoClientes = listaClientes.RemoverClienteEspecifico(new Cliente("teste", 9191, new Morada("asd", "asdad", "asdasda"), 82748));
            bool resultadoClientes2 = listaClientes.RemoverClienteEspecifico(c3);
            Console.WriteLine(resultadoClientes);
            Console.WriteLine(resultadoClientes2);
            Console.WriteLine("Clientes removidos");
            //Clientes removidos
            IO.MostrarClientes(listaClientes);

            bool resultadoOperador = listaOperadores.RemoverOperadorEspecifico(new Operador("teste", 187, 9888, new Morada("asda", "qwdq", "awsdd")));
            bool resultadoOperador2 = listaOperadores.RemoverOperadorEspecifico(op2);
            Console.WriteLine(resultadoOperador);
            Console.WriteLine(resultadoOperador2);
            Console.WriteLine("Operadores removidos");
            //Operadores removidos
            IO.MostrarOperadores(listaOperadores);

            //Produtos
            RegistoCategorias listaCategoriasProd1 = new RegistoCategorias();
            listaCategoriasProd1.InserirCategoria("SMARTPHONE");
            listaCategoriasProd1.InserirCategoria("5G");
            Produto prdt1 = new Produto("Telemovel", 1, 2000, "SAMSUNG", listaCategoriasProd1.ObterCategorias);


            listaProdutos.InserirProduto(prdt1);

            Console.WriteLine("teste....");
            IO.MostrarProdutos(listaProdutos);

            //BubbleSortClientes
            listaClientes.BubbleSortClientes();
            Console.WriteLine("Ordenado por NIF");
            IO.MostrarClientes(listaClientes);


            //BubbleSortOperadores
            listaOperadores.BubbleSortOperadores();
            Console.WriteLine("Ordenado por ID");
            IO.MostrarOperadores(listaOperadores);


            ProblemasCon prob1 = new ProblemasCon("Atendimento-Duvidas", 1, "Ditar problemas e conforme o numero digitado, apresentar solucao");
            ProblemasCon prob2 = new ProblemasCon("Entregas-Informacao", 2, "Oferecer detalhes sobre o estado de entrega");
            ProblemasCon prob4 = new ProblemasCon("Assistencia-Servico Manutencao", 4, "Enviar um funcionario ao local desejado");

            listaSolucoes.InserirSolucao(prob1);
            listaSolucoes.InserirSolucao(prob2);
            listaSolucoes.InserirSolucao(prob4);



            listaAssist.InsereAssistArray(a1);
            listaAssist.InsereAssistArray(a2);
            listaAssist.InsereAssistArray(a3);
            listaAssist.InsereAssistArray(a4);
            listaAssist.InsereAssistArray(a5);
            


            listaAssist.InsereClienteAssist(a1, listaClientes.ObterClientes);
            listaAssist.InsereClienteAssist(a2, listaClientes.ObterClientes);
            listaAssist.InsereClienteAssist(a3, listaClientes.ObterClientes);
            listaAssist.InsereClienteAssist(a4, listaClientes.ObterClientes);
            listaAssist.InsereClienteAssist(a5, listaClientes.ObterClientes);

            listaAssist.InsereOperadorAssist(a1, listaOperadores.ObterOperadores);
            listaAssist.InsereOperadorAssist(a2, listaOperadores.ObterOperadores);
            listaAssist.InsereOperadorAssist(a3, listaOperadores.ObterOperadores);
            listaAssist.InsereOperadorAssist(a4, listaOperadores.ObterOperadores);
            listaAssist.InsereOperadorAssist(a5, listaOperadores.ObterOperadores);



            listaAssist.ConcluirAssistencia(a1);
            Avaliacao clsA1 = new Avaliacao("Bom servico", 10, "nada a apontar");
            listaAssist.RegistoAvaliacao(a1, clsA1);
            listaAssist.ConcluirAssistencia(a2);
            Avaliacao clsA2 = new Avaliacao("Pessimo Servico", 2, "Melhorar comunicacao");
            listaAssist.RegistoAvaliacao(a2, clsA2);


            //Assistencias
            Console.WriteLine();
            Console.WriteLine("Assistencias:");
            IO.MostrarAssistencias(listaAssist, listaSolucoes);
            Console.WriteLine("Clientes com morada:");
            IO.MostrarFichaClientesCompleto(listaClientes.ObterClientes);


            listaAssist.GravarFicheiroAssistencias("RegistoAssistencias.dat");
            listaAssist.RemoverAssistencias();
            IO.MostrarAssistencias(listaAssist,listaSolucoes);
            listaAssist.LerFicheiroAssistencia("RegistoAssistencias.dat");
            IO.MostrarAssistencias(listaAssist, listaSolucoes);


            Console.WriteLine("Clientes:");
            listaClientes.GravarFicheiroClientes("RegistoClientes.dat");
            listaClientes.RemoverClientes();
            IO.MostrarClientes(listaClientes);
            listaClientes.LerFicheiroClientes("RegistoClientes.dat");
            IO.MostrarClientes(listaClientes);

            Console.WriteLine("Operadores:");
            listaOperadores.GravarFicheiroOperadores("RegistoOperadores.dat");
            listaOperadores.RemoverOperadores();
            IO.MostrarOperadores(listaOperadores);
            listaOperadores.LerFicheiroOperadores("RegistoOperadores.dat");
            IO.MostrarOperadores(listaOperadores);
        }
    }
}
