
using Assistencia;
using Excecoes;
using ObjetosNegocio;
using Outros;
using Pessoas;
using RegrasNegocio;
using System;

namespace GereAssistencias
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            Cliente c7 = new Cliente("teste", 4885, new Morada("Porto", "478-222", "Arcos"), 2424);

            ////Inserir clientes na lista de clientes e saldos.
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


            try
            {
                bool aux = RegrasDeNegocio.InsereSaldoCliente(c1, 20000);
                aux = RegrasDeNegocio.InsereSaldoCliente(c2, 10000);
                aux = RegrasDeNegocio.InsereSaldoCliente(c3, 2488);
                aux = RegrasDeNegocio.InsereSaldoCliente(c4, 100);
                aux = RegrasDeNegocio.InsereSaldoCliente(c5, 1220);
                aux = RegrasDeNegocio.InsereSaldoCliente(c6, 5900);
                aux = RegrasDeNegocio.InsereSaldoCliente(c1, 282848);
                aux = RegrasDeNegocio.InsereSaldoCliente(c7, 20000);
            }
            catch(ClienteException e)
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

            //Criar soluções e inserir numa assistência.

            ProblemasCon prob1 = new ProblemasCon("Atendimento-Duvidas", 1, "Ditar problemas e conforme o numero digitado, apresentar solucao");
            ProblemasCon prob2 = new ProblemasCon("Entregas-Informacao", 2, "Oferecer detalhes sobre o estado de entrega");
            ProblemasCon prob4 = new ProblemasCon("Assistencia-Servico Manutencao", 4, "Enviar um funcionario ao local desejado");

            try
            {
                bool aux = RegrasDeNegocio.InsereSolucao(prob1);
                aux = RegrasDeNegocio.InsereSolucao(prob2);
                aux = RegrasDeNegocio.InsereSolucao(prob4);
            }
            catch (ProblemaException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                bool aux = RegrasDeNegocio.InsereSolucaoAssitencia(a1);
                aux = RegrasDeNegocio.InsereSolucaoAssitencia(a2);
                aux = RegrasDeNegocio.InsereSolucaoAssitencia(a3);
                aux = RegrasDeNegocio.InsereSolucaoAssitencia(a4);
                aux = RegrasDeNegocio.InsereSolucaoAssitencia(a5);
                aux = RegrasDeNegocio.InsereSolucaoAssitencia(a6);
            }
            catch(ProblemaException e)
            {
                Console.WriteLine(e.Message);
            }

            Avaliacao clsA1 = new Avaliacao("Bom servico", 10, "nada a apontar");
            Avaliacao clsA2 = new Avaliacao("Pessimo Servico", 2, "Melhorar comunicacao");

            try
            {
                bool aux = RegrasDeNegocio.ConcluirAssistencia(a1, clsA1);
                aux = RegrasDeNegocio.ConcluirAssistencia(a2, clsA2);
            }
            catch (AssistException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Assitencias concluidas:");
            RegrasDeNegocio.MostrarAssistenciasConcluidas();
            Console.WriteLine("Assistencias por concluir:");
            RegrasDeNegocio.MostrarAssistenciasAtivas();

            Console.WriteLine("\n\n\n");
            RegrasDeNegocio.MostrarTodasAssistencias();

            Console.WriteLine("\n\n\n");

            RegrasDeNegocio.MostrarTodosClientes();
            Console.WriteLine("\n\n\n");

            RegrasDeNegocio.MostrarTodosOperadores();
            Console.WriteLine("\n\n\n");

            RegrasDeNegocio.MostrarFichaClientesCompleto();

            Produto produto1 = new Produto("Telemovel", 300, "SAMSUNG");
            Produto produto2 = new Produto("PC Portatil", 2000, "Lenovo");
            try
            {
                bool aux = RegrasDeNegocio.InserirProdutoLista(produto1);
                aux = RegrasDeNegocio.InserirProdutoLista(produto2);
            }
            catch(ProdutosException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                bool aux = RegrasDeNegocio.InserirCategoriasLista("SMARTPHONE",1);
                aux = RegrasDeNegocio.InserirCategoriasLista("5G",1);
                aux = RegrasDeNegocio.InserirCategoriasLista("Portatil", 2);
            }
            catch(CategoriaException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                bool aux = RegrasDeNegocio.InserirCategoriasProduto(produto1);
                aux = RegrasDeNegocio.InserirCategoriasProduto(produto2);
            }
            catch(ProdutosException e)
            { 
                Console.WriteLine(e.Message); 
            }

            RegrasDeNegocio.MostrarProdutos();

            ////Produtos
            ////RegistoCategorias listaCategoriasProd1 = new RegistoCategorias();
            //////listaCategoriasProd1.InserirCategoria("SMARTPHONE");
            //////listaCategoriasProd1.InserirCategoria("5G");
            ////Produto prdt1 = new Produto("Telemovel", 1, 2000, "SAMSUNG", listaCategoriasProd1.ObterCategorias);


            #endregion






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



            //#endregion

            ////Assistencias
            //Console.WriteLine();
            //Console.WriteLine("Assistencias:");
            //IO.MostrarTodasAssistencias(listaAssist, listaSolucoes);
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
