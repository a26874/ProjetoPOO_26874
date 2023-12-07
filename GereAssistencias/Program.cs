
using Assistencia;
using Excecoes;
using ObjetosNegocio;
using Outros;
using Pessoas;
using RegrasNegocio;
using System;
using System.Collections.Generic;

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

            List<Assist> assistsInserir = new List<Assist>();
            #region IO dados
            //Nova assistencias
            Assist a1 = new Assist(new DateTime(2023, 4, 20, 16, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a2 = new Assist(new DateTime(2023, 10, 5, 10, 22, 11), new TipoAssist("Informacao entrega Produto", "Entregas", 2, 345), new EstadoAssist("Ativo", true), 1759, 12);
            Assist a3 = new Assist(new DateTime(2023, 11, 1, 13, 45, 44), new TipoAssist("Encomendas de produtos", "Entregas", 2, 255), new EstadoAssist("Ativo", true), 1874, 12);
            Assist a4 = new Assist(new DateTime(2023, 9, 29, 11, 55, 51), new TipoAssist("Servico Manutencao", "Assistencia", 4, 1000), new EstadoAssist("Ativo", true), 1676, 12);
            Assist a5 = new Assist(new DateTime(2023, 7, 15, 19, 11, 33), new TipoAssist("Dificuldades Tecnicas", "Manutencao", 3, 200), new EstadoAssist("Ativo", true), 1676, 12);
            Assist a6 = new Assist(new DateTime(2023, 5, 15, 11, 9, 33), new TipoAssist("Dificuldades Tecnicas", "Manutencao", 3, 5000), new EstadoAssist("Ativo", true), 1266, 12);

            assistsInserir.Add(a1);
            assistsInserir.Add(a2);
            assistsInserir.Add(a3);
            assistsInserir.Add(a4);
            assistsInserir.Add(a1); //Falha, já existe.
            assistsInserir.Add(a5);
            assistsInserir.Add(a6);
            foreach (Assist a in assistsInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InsereAssistencia(a);
                }
                catch (AssistException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            List<Cliente> clientesInserir = new List<Cliente>();
            ////Criação de um novo cliente
            Cliente c1 = new Cliente("Marco", 94829, new Morada("Braga", "4720-452", "Amares"), 1874);
            Cliente c2 = new Cliente("Ruben", 9421474, new Morada("Braga", "4122-862", "VilaVerde"), 1676);
            Cliente c3 = new Cliente("Andre", 94, new Morada("Braga", "4000-221", "Barcelos"), 1266);
            Cliente c4 = new Cliente("Macedo", 274, new Morada("Porto", "4218-211", "Arouca"), 1759);
            Cliente c5 = new Cliente("Nuno", 974, new Morada("Porto", "4117-222", "Espinho"), 1911);
            Cliente c6 = new Cliente("Flavia", 244, new Morada("Porto", "478-222", "Arcos"), 1898);
            Cliente c7 = new Cliente("teste", 4885, new Morada("Porto", "478-222", "Arcos"), 2424);

            clientesInserir.Add(c1);
            clientesInserir.Add(c2);
            clientesInserir.Add(c3);
            clientesInserir.Add(c1); //Falha, já existe. Na parte do saldo, falha também no c1, pois ele já o tem.
            clientesInserir.Add(c4);
            clientesInserir.Add(c5);
            clientesInserir.Add(c6);
            clientesInserir.Add(c7);

            ////Inserir clientes na lista de clientes e saldos.
            foreach (Cliente c in clientesInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InsereCliente(c);
                }
                catch (ClienteException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (Cliente c in clientesInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InsereSaldoCliente(c, 2000);
                }
                catch (ClienteException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            List<Operador> operadoresInserir = new List<Operador>();
            ////Criar novos operadores
            Operador op1 = new Operador("Marco", 12, 2487, new Morada("Braga", "4720-444", "Amares"));
            Operador op2 = new Operador("Joao", 2, 2222, new Morada("Braga", "4700-124", "VilaVerde"));
            Operador op3 = new Operador("Goncalo", 34, 2444, new Morada("Porto", "4262-244", "Arouca"));
            Operador op4 = new Operador("Rui", 14, 11123, new Morada("Braga", "4991-242", "VilaVerde"));
            Operador op5 = new Operador("Luis", 25, 2444, new Morada("Porto", "4221-112", "Arouca"));
            Operador op6 = new Operador("Diogo", 6, 4959, new Morada("Braga", "4872-111", "Barcelos"));

            operadoresInserir.Add(op1);
            operadoresInserir.Add(op2);
            operadoresInserir.Add(op3);
            operadoresInserir.Add(op4);
            operadoresInserir.Add(op5);
            operadoresInserir.Add(op6);
            operadoresInserir.Add(op1); //Falha ao inserir.

            ////Inserir operadores.
            foreach (Operador o in operadoresInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InsereOperador(o);
                }
                catch (OperadorException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //Inserir clientes e operadores na assitência.

            foreach (Assist a in assistsInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InsereClienteAssistencia(a);
                }
                catch (ClienteException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (Assist a in assistsInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InsereOperadorAssistencia(a);
                }
                catch (OperadorException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            //Criar soluções e inserir numa assistência.

            List<ProblemasCon> solucoesInserir = new List<ProblemasCon>();
            ProblemasCon prob1 = new ProblemasCon("Atendimento-Duvidas", 1, "Ditar problemas e conforme o numero digitado, apresentar solucao");
            ProblemasCon prob2 = new ProblemasCon("Entregas-Informacao", 2, "Oferecer detalhes sobre o estado de entrega");
            ProblemasCon prob4 = new ProblemasCon("Assistencia-Servico Manutencao", 4, "Enviar um funcionario ao local desejado");

            solucoesInserir.Add(prob1);
            solucoesInserir.Add(prob2);
            solucoesInserir.Add(prob4);

            foreach (ProblemasCon p in solucoesInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InsereSolucao(p);
                }
                catch (ProblemaException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (Assist a in assistsInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InsereSolucaoAssitencia(a);
                }
                catch (ProblemaException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (AssistException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //Criar avaliações e atribuir a assistências.
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

            //Output de assistências concluidas.
            Console.WriteLine("Assitencias concluidas:");
            List<Assist> todasAssistConcluidas = RegrasDeNegocio.MostrarAssistenciasConcluidas();
            foreach (Assist a in todasAssistConcluidas)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine("\n\n\n");

            //Output de assistências por concluir.
            Console.WriteLine("Assistencias por concluir:");
            List<Assist> todasAssistAtivas = RegrasDeNegocio.MostrarAssistenciasAtivas();
            foreach (Assist a in todasAssistAtivas)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine("\n\n\n");

            //Output de todas as assistências.
            List<Assist> todasAssist = RegrasDeNegocio.MostrarTodasAssistencias();

            foreach (Assist a in todasAssist)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine("\n\n\n");

            //Output de todos os clientes.
            List<Cliente> todosClientes = RegrasDeNegocio.MostrarTodosClientes();

            foreach (Cliente c in todosClientes)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("\n\n\n");

            //Output de todos os operadores.
            List<Operador> todosOperadores = RegrasDeNegocio.MostrarTodosOperadores();

            foreach (Operador o in todosOperadores)
            {
                Console.WriteLine(o.ToString());
            }

            Console.WriteLine("\n\n\n");

            //Output de todos os clientes com morada.
            List<Cliente> todosClientesCompleto = RegrasDeNegocio.MostrarFichaClientesCompleto();

            foreach (Cliente c in todosClientesCompleto)
            {
                Console.WriteLine(c.ToString());
                if (ReferenceEquals(c.Morada, null) || c.Morada.CodPostal == string.Empty)
                    continue;
                else
                {
                    Console.WriteLine(c.Morada.ToString());
                }
            }


            // Criação de produtos.
            List<Produto> produtosInserir = new List<Produto>();
            Produto produto1 = new Produto("Telemovel", 300, "SAMSUNG");
            Produto produto2 = new Produto("PC Portatil", 2000, "Lenovo");

            produtosInserir.Add(produto1);
            produtosInserir.Add(produto2);

            foreach (Produto p in produtosInserir)
            {
                try
                {
                    bool aux = RegrasDeNegocio.InserirProdutoLista(p);
                }
                catch (ProdutosException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            //Criação de categorias.
            try
            {
                bool aux = RegrasDeNegocio.InserirCategoriasLista("SMARTPHONE", 1);
                aux = RegrasDeNegocio.InserirCategoriasLista("5G", 1);
                aux = RegrasDeNegocio.InserirCategoriasLista("Portatil", 2);
            }
            catch (CategoriaException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                bool aux = RegrasDeNegocio.InserirCategoriasProduto(produto1);
                aux = RegrasDeNegocio.InserirCategoriasProduto(produto2);
            }
            catch (ProdutosException e)
            {
                Console.WriteLine(e.Message);
            }

            List<Produto> listaProdutos = RegrasDeNegocio.MostrarProdutos();
            List<Categoria> listaCategorias = RegrasDeNegocio.MostrarCategorias();
            foreach (Produto p in listaProdutos)
            {
                if (ReferenceEquals(p, null) || p.Id == 0)
                    continue;
                Console.WriteLine(p.ToString());
                foreach(Categoria c in listaCategorias)
                {
                    if (p.Id == c.IdProduto)
                        Console.WriteLine(c.ToString());
                }
            }


            #endregion








            //listaAssist.GravarFicheiroAssistencias("RegistoAssistencias.dat");
            //listaClientes.GravarFicheiroClientes("RegistoClientes.dat");
            //listaOperadores.GravarFicheiroOperadores("RegistoOperadores.dat");
            //listaProdutos.GravarFicheiroProdutos("RegistoProdutos.dat");
            //listaSolucoes.GravarFicheiroSolucoes("RegistoSolucoes.dat");

        }
    }
}
