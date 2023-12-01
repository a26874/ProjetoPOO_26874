
using Assistencia;
using Excecoes;
using ObjetosNegocio;
using Pessoas;
using RegrasNegocio;
using System;

namespace GereAssistencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de registo Assistencias, Clientes, Operadores, produtos 
            //RegistoAssist listaAssist = new RegistoAssist();
            //RegistoClientes listaClientes = new RegistoClientes();
            //RegistoOperadores listaOperadores = new RegistoOperadores();
            //RegistoProdutos listaProdutos = new RegistoProdutos();
            //RegistoProblemas listaSolucoes = new RegistoProblemas();

            //listaClientes.LerFicheiroClientes("RegistoClientes.dat");
            //listaOperadores.LerFicheiroOperadores("RegistoOperadores.dat");
            //listaProdutos.LerFicheiroProdutos("RegistoProdutos.dat");
            //listaSolucoes.LerFicheiroSolucoes("RegistoSolucoes.dat");
            //listaAssist.LerFicheiroAssistencia("RegistoAssistencias.dat");

            #region IO dados
            //Nova assistencias
            Assist a1 = new Assist(new DateTime(2023, 4, 20, 16, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a2 = new Assist(new DateTime(2023, 10, 5, 10, 22, 11), new TipoAssist("Informacao entrega Produto", "Entregas", 2, 345), new EstadoAssist("Ativo", true), 1759, 12);
            Assist a3 = new Assist(new DateTime(2023, 11, 1, 13, 45, 44), new TipoAssist("Encomendas de produtos", "Entregas", 2, 255), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a4 = new Assist(new DateTime(2023, 9, 29, 11, 55, 51), new TipoAssist("Servico Manutencao", "Assistencia", 4, 1000), new EstadoAssist("Ativo", true), 1676, 12);
            Assist a5 = new Assist(new DateTime(2023, 7, 15, 19, 11, 33), new TipoAssist("Dificuldades Tecnicas", "Manutencao", 3, 200), new EstadoAssist("Ativo", true), 1676, 12);
            Assist a6 = new Assist(new DateTime(2023, 5, 15, 11, 9, 33), new TipoAssist("Dificuldades Tecnicas", "Manutencao", 3, 5000), new EstadoAssist("Ativo", true), 1266, 12);

            try
            {
                bool aux = RegrasDeNegocio.InsereAssistencia(a1);
                aux = RegrasDeNegocio.InsereAssistencia(a2);
                aux = RegrasDeNegocio.InsereAssistencia(a3);
                aux = RegrasDeNegocio.InsereAssistencia(a4);
                aux = RegrasDeNegocio.InsereAssistencia(a5);
                aux = RegrasDeNegocio.InsereAssistencia(a6);
            }
            catch (AssistException e)
            {
                Console.WriteLine(e.Message);
            }

            //Mostrar Assistências

            ////Criação de um novo cliente
            Cliente c1 = new Cliente("Marco", 94829, new Morada("Braga", "4720-452", "Amares"), 1874);
            Cliente c2 = new Cliente("Ruben", 9421474, new Morada("Braga", "4122-862", "VilaVerde"), 1676);
            Cliente c3 = new Cliente("Andre", 94, new Morada("Braga", "4000-221", "Barcelos"), 1266);
            Cliente c4 = new Cliente("Macedo", 274, new Morada("Porto", "4218-211", "Arouca"), 1759);
            Cliente c5 = new Cliente("Nuno", 974, new Morada("Porto", "4117-222", "Espinho"), 1911);
            Cliente c6 = new Cliente("Flavia", 244, new Morada("Porto", "478-222", "Arcos"), 1898);

            ////Inserir clientes na lista de clientes
            try
            {
                bool aux = RegrasDeNegocio.InsereCliente(c1);
                aux = RegrasDeNegocio.InsereCliente(c2);
                aux = RegrasDeNegocio.InsereCliente(c3);
                aux = RegrasDeNegocio.InsereCliente(c4);
                aux = RegrasDeNegocio.InsereCliente(c5);
                aux = RegrasDeNegocio.InsereCliente(c6);
            }
            catch (ClienteException e)
            {
                Console.WriteLine(e.Message);
            }

            ////Criar novos operadores
            Operador op1 = new Operador("Marco", 12, 2487, new Morada("Braga", "4720-444", "Amares"));
            Operador op2 = new Operador("Joao", 2, 2222, new Morada("Braga", "4700-124", "VilaVerde"));
            Operador op3 = new Operador("Goncalo", 34, 2444, new Morada("Porto", "4262-244", "Arouca"));
            Operador op4 = new Operador("Rui", 14, 11123, new Morada("Braga", "4991-242", "VilaVerde"));
            Operador op5 = new Operador("Luis", 25, 2444, new Morada("Porto", "4221-112", "Arouca"));
            Operador op6 = new Operador("Diogo", 6, 4959, new Morada("Braga", "4872-111", "Barcelos"));

            ////Inserir operadores.
            try
            {
                bool aux = RegrasDeNegocio.InsereOperador(op1);
                aux = RegrasDeNegocio.InsereOperador(op2);
                aux = RegrasDeNegocio.InsereOperador(op3);
                aux = RegrasDeNegocio.InsereOperador(op4);
                aux = RegrasDeNegocio.InsereOperador(op5);
                aux = RegrasDeNegocio.InsereOperador(op6);
                aux = RegrasDeNegocio.InsereOperador(op1);
            }
            catch (OperadorException e)
            { 
                Console.WriteLine(e.Message);
            }

            //Inserir clientes e operadores na assitência.

            try
            {
                bool aux = RegrasDeNegocio.InsereClienteAssistencia(a1);
                aux = RegrasDeNegocio.InsereClienteAssistencia(a2);
                aux = RegrasDeNegocio.InsereClienteAssistencia(a3);
                aux = RegrasDeNegocio.InsereClienteAssistencia(a4);
                aux = RegrasDeNegocio.InsereClienteAssistencia(a5);
                aux = RegrasDeNegocio.InsereClienteAssistencia(a6);
                aux = RegrasDeNegocio.InsereClienteAssistencia(a1);
            }
            catch (ClienteException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                bool aux = RegrasDeNegocio.InsereOperadorAssistencia(a1);
                aux = RegrasDeNegocio.InsereOperadorAssistencia(a2);
                aux = RegrasDeNegocio.InsereOperadorAssistencia(a3);
                aux = RegrasDeNegocio.InsereOperadorAssistencia(a4);
                aux = RegrasDeNegocio.InsereOperadorAssistencia(a5);
                aux = RegrasDeNegocio.InsereOperadorAssistencia(a6);
            }
            catch (OperadorException e)
            {
                Console.WriteLine(e.Message);
            }
            ////bool teste2 = listaOperadores.InsereOperador(op6);


            #endregion

            ////Print de cada lista
            //Console.WriteLine("Operadores:");
            ////Operadores
            //IO.MostrarOperadores(listaOperadores);

            //Console.WriteLine("Clientes");
            ////Clientes
            //IO.MostrarClientes(listaClientes);

            //#region IOdados
            ////bool resultadoClientes = listaClientes.RemoverClienteEspecifico(new Cliente("teste", 9191, new Morada("asd", "asdad", "asdasda"), 82748));
            ////bool resultadoClientes2 = listaClientes.RemoverClienteEspecifico(c3);
            ////Console.WriteLine(resultadoClientes);
            ////Console.WriteLine(resultadoClientes2);
            ////Console.WriteLine("Clientes removidos");
            //////Clientes removidos
            ////IO.MostrarClientes(listaClientes);

            ////bool resultadoOperador = listaOperadores.RemoverOperadorEspecifico(new Operador("teste", 187, 9888, new Morada("asda", "qwdq", "awsdd")));
            ////bool resultadoOperador2 = listaOperadores.RemoverOperadorEspecifico(op2);
            ////Console.WriteLine(resultadoOperador);
            ////Console.WriteLine(resultadoOperador2);
            ////Console.WriteLine("Operadores removidos");
            //////Operadores removidos
            ////IO.MostrarOperadores(listaOperadores);


            ////Produtos
            ////RegistoCategorias listaCategoriasProd1 = new RegistoCategorias();
            //////listaCategoriasProd1.InserirCategoria("SMARTPHONE");
            //////listaCategoriasProd1.InserirCategoria("5G");
            ////Produto prdt1 = new Produto("Telemovel", 1, 2000, "SAMSUNG", listaCategoriasProd1.ObterCategorias);


            ////listaProdutos.InserirProduto(prdt1);

            ////RegistoCategorias listaCategorias = new RegistoCategorias();
            ////listaCategorias.InserirCategoria("TABLET");
            ////listaCategorias.InserirCategoria("IOS");
            ////Produto produto2 = new Produto("Tablet", 2, 2500, "Apple", listaCategorias.ObterCategorias);

            ////listaProdutos.InserirProduto(produto2);

            //#endregion

            //Console.WriteLine("Produtos e as suas categorias:");
            //IO.MostrarProdutos(listaProdutos);

            ////Ordenar Clientes
            //listaClientes.OrdenarClientes();
            //Console.WriteLine("Ordenado por NIF");
            //IO.MostrarClientes(listaClientes);

            ////BubbleSortOperadores
            //listaOperadores.OrdenarOperadores();
            //Console.WriteLine("Ordenado por ID");
            //IO.MostrarOperadores(listaOperadores);

            //#region IODADOS

            ////ProblemasCon prob1 = new ProblemasCon("Atendimento-Duvidas", 1, "Ditar problemas e conforme o numero digitado, apresentar solucao");
            ////ProblemasCon prob2 = new ProblemasCon("Entregas-Informacao", 2, "Oferecer detalhes sobre o estado de entrega");
            ////ProblemasCon prob4 = new ProblemasCon("Assistencia-Servico Manutencao", 4, "Enviar um funcionario ao local desejado");

            ////listaSolucoes.InserirSolucao(prob1);
            ////listaSolucoes.InserirSolucao(prob2);
            ////listaSolucoes.InserirSolucao(prob4);



            ////listaAssist.InsereAssistLista(a1);
            ////listaAssist.InsereAssistLista(a2);
            ////listaAssist.InsereAssistLista(a3);
            ////listaAssist.InsereAssistLista(a4);
            ////listaAssist.InsereAssistLista(a5);



            ////listaAssist.InsereClienteAssist(a1, listaClientes.ObterClientes);
            ////listaAssist.InsereClienteAssist(a2, listaClientes.ObterClientes);
            ////listaAssist.InsereClienteAssist(a3, listaClientes.ObterClientes);
            ////listaAssist.InsereClienteAssist(a4, listaClientes.ObterClientes);
            ////listaAssist.InsereClienteAssist(a5, listaClientes.ObterClientes);

            ////listaAssist.InsereOperadorAssist(a1, listaOperadores.ObterOperadores);
            ////listaAssist.InsereOperadorAssist(a2, listaOperadores.ObterOperadores);
            ////listaAssist.InsereOperadorAssist(a3, listaOperadores.ObterOperadores);
            ////listaAssist.InsereOperadorAssist(a4, listaOperadores.ObterOperadores);
            ////listaAssist.InsereOperadorAssist(a5, listaOperadores.ObterOperadores);



            ////listaAssist.ConcluirAssistencia(a1);
            ////Avaliacao clsA1 = new Avaliacao("Bom servico", 10, "nada a apontar");
            ////listaAssist.RegistoAvaliacao(a1, clsA1);
            ////listaAssist.ConcluirAssistencia(a2);
            ////Avaliacao clsA2 = new Avaliacao("Pessimo Servico", 2, "Melhorar comunicacao");
            ////listaAssist.RegistoAvaliacao(a2, clsA2);

            //#endregion

            ////Assistencias
            //Console.WriteLine();
            //Console.WriteLine("Assistencias:");
            //IO.MostrarAssistencias(listaAssist, listaSolucoes);
            //Console.WriteLine("Clientes com morada:");
            //IO.MostrarFichaClientesCompleto(listaClientes.ObterClientes);

            //IO.NumeroClientes(listaClientes.ObterClientes);

            //listaAssist.GravarFicheiroAssistencias("RegistoAssistencias.dat");
            //listaClientes.GravarFicheiroClientes("RegistoClientes.dat");
            //listaOperadores.GravarFicheiroOperadores("RegistoOperadores.dat");
            //listaProdutos.GravarFicheiroProdutos("RegistoProdutos.dat");
            //listaSolucoes.GravarFicheiroSolucoes("RegistoSolucoes.dat");

            //Cliente teste = new Cliente("Marcooo", 240, new Morada("asdqq", "qqqqq", "lllqq"), 87927);

            //IO.ExisteCliente(listaClientes.ObterClientes, teste);
            //IO.ExisteSolucaoProblema(listaSolucoes.ObterSolucoes, listaAssist.ObterAssistencias, 3);

        }
    }
}
