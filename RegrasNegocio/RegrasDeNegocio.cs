/*
*	<copyright file="RegrasDeNegocio" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/30/2023 7:57:32 PM</date>
*	<description></description>
**/

using Dados;
using Excecoes;
using ObjetosNegocio;
using Outros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace RegrasNegocio
{
    public class RegrasDeNegocio
    {
        #region ATRIBUTOS

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        public RegrasDeNegocio()
        {

        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        

        #region ASSISTENCIAS

        /// <summary>
        /// Recebe uma assistência e reencaminha a mesma para os dados a inserir.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.AssistException">Falha ao inserir assistencia.</exception>
        public static bool InsereAssistencia(Assist a)
        {
            if (a.tipoAssis is null || a.estadoA is null)
                return false;
            try
            {
                RegistoAssist.InsereAssistLista(a);
                return true;
            }
            catch (AssistException e)
            {
                throw new AssistException("Falha ao inserir assistencia." + "-" + e.Message);
            }
        }
        /// <summary>
        /// Recebe uma assistência e reencaminha para a lista de assistências e insere um cliente caso exista.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ClienteException"></exception>
        public static bool InsereClienteAssistencia(Assist a)
        {
            Cliente clienteInserir = null;
            if (ReferenceEquals(a, null))
                return false;

            try
            {
                RegistoClientes.ExisteCliente(a.ClienteNIF, out clienteInserir);
                RegistoAssist.InsereClienteAssistLista(a, clienteInserir);
                return true;
            }
            catch (ClienteException e)
            {
                throw new ClienteException(e.Message + "-" + "A assistencia " + a.Id + " ja tem cliente");
            }
        }
        /// <summary>
        /// Recebe uma assistência e reencaminha para a lista de assistências e insere um cliente caso exista.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.OperadorException"></exception>
        public static bool InsereOperadorAssistencia(Assist a)
        {
            Operador operadorInserir = null;
            if (ReferenceEquals(a, null))
                return false;

            try
            {
                RegistoOperadores.ExisteOperador(a.OperadorId, out operadorInserir);
                RegistoAssist.InsereOperadorAssistLista(a, operadorInserir);
                return true;
            }
            catch (OperadorException e)
            {
                throw new OperadorException(e.Message + "-" + "A assistencia " + a.Id + " ja tem operador");
            }
        }
        /// <summary>
        /// Insere uma solução de um problema na assistência.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.AssistException"></exception>
        public static bool InsereSolucaoAssitencia(Assist a)
        {
            ProblemasCon problemaInserir;
            if (ReferenceEquals(a, null))
                return false;
            try
            {
                RegistoProblemas.ExisteSolucao(a.tipoAssis.Id, out problemaInserir);
                RegistoAssist.InsereSolucaoAssitLista(a, problemaInserir);
                return true;
            }
            catch (AssistException e)
            {
                throw new AssistException(e.Message + "-" + "A assistencia " + a.Id + " ja tem solucao");
            }
        }
        /// <summary>
        /// Mostra todas as assistências.
        /// </summary>
        /// <returns></returns>
        public static List<Assist> MostrarTodasAssistencias()
        {
            RegistoAssist aux = new RegistoAssist();
            List<Assist> listaOriginal = aux.ObterAssistencias;
            //listaOriginal = aux.ObterAssistencias;
            //List<Assist> todasAssist = listaOriginal.Select(Assist => Assist.Clone()).ToList();
            foreach (Assist a in listaOriginal)
            {
                a.tipoAssis.Id = 20000;
            }
            return listaOriginal;
        }
        /// <summary>
        /// Recebe todas as assistências e apenas mostra as ativas.
        /// </summary>
        public static void MostrarAssistenciasAtivas()
        {
            RegistoAssist listaAssist = new RegistoAssist();
            foreach (Assist a in listaAssist.ObterAssistencias)
            {
                if (a.estadoA.DescEstado == "Ativo" && a.estadoA.Ativo == true)
                    Console.WriteLine(a.ToString());
            }
        }
        /// <summary>
        /// Recebe todas as assistências e apenas mostra as concluidas.
        /// </summary>
        public static void MostrarAssistenciasConcluidas()
        {
            RegistoAssist listaAssist = new RegistoAssist();
            foreach (Assist a in listaAssist.ObterAssistencias)
            {
                if (a.estadoA.DescEstado == "Completado" && a.estadoA.Ativo == false)
                {
                    Console.WriteLine(a.ToString());
                }
            }
        }
        /// <summary>
        /// Conclui uma assistência e regista a sua avaliação.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="cls">The CLS.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.AssistException">Nao foi possivel concluir a assistencia" + "-" + e.Message</exception>
        public static bool ConcluirAssistencia(Assist a, Avaliacao cls)
        {
            try
            {
                RegistoAssist.ConcluirAssistencia(a);
                RegistoAssist.RegistoAvaliacao(a, cls);
                return true;
            }
            catch (AssistException e)
            {
                throw new AssistException("Nao foi possivel concluir a assistencia" + "-" + e.Message);
            }
        }
        /// <summary>
        /// De todas as assistencias, mostra o preço da mais cara.
        /// </summary>
        /// <param name="listaAssistencias">The lista assistencias.</param>
        /// <returns></returns>
        public static int MostrarAssistenciaMaisCara(RegistoAssist listaAssistencias)
        {
            int maisCaro = 0;
            foreach (Assist a in listaAssistencias.ObterAssistencias)
            {
                if (a.tipoAssis.Preco > maisCaro && a.tipoAssis.Preco != -1)
                    maisCaro = a.tipoAssis.Preco;
            }
            return maisCaro;
        }
        #endregion

        #region CLIENTES
        /// <summary>
        /// Recebe um cliente e reencaminha o mesmo para a "base de dados".
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ClienteException">Falha ao inserir o cliente.</exception>
        public static bool InsereCliente(Cliente c)
        {
            if (c.NIF == -1 || c.Contacto == -1)
                return false;
            try
            {
                RegistoClientes.InsereClienteLista(c);
                return true;
            }
            catch (ClienteException e)
            {
                throw new ClienteException("Falha ao inserir o cliente.");
            }
        }
        /// <summary>
        /// Insere saldo num cliente.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="valor">The valor.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ClienteException">Falha ao inserir saldo" + " - " + e.Message</exception>
        public static bool InsereSaldoCliente(Cliente c, int valor)
        {
            try
            {
                return RegistoClientes.InsereSaldo(c, valor);
            }
            catch (ClienteException e)
            {
                throw new ClienteException(" Falha ao inserir saldo" + " - " + e.Message);
            }
        }
        /// <summary>
        /// Mostra todos os clientes existentes.
        /// </summary>
        public static void MostrarTodosClientes()
        {
            RegistoClientes listaClientes = new RegistoClientes();
            foreach (Cliente c in listaClientes.ObterClientes)
            {
                Console.WriteLine(c.ToString());
            }
        }
        /// <summary>
        /// Mostra a ficha completa de um cliente.
        /// </summary>
        public static void MostrarFichaClientesCompleto()
        {
            RegistoClientes listaClientes = new RegistoClientes();
            foreach (Cliente c in listaClientes.ObterClientes)
            {
                Console.WriteLine(c.ToString());
                if (ReferenceEquals(c.Morada, null) || c.Morada.CodPostal == string.Empty)
                    continue;
                else
                {
                    Console.WriteLine(c.Morada.ToString());
                }
            }
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Recebe um operador e reencaminha o mesmo para a "base de dados".
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns></returns>
        /// <exception cref="OperadorException">Falha ao inserir o operador.</exception>
        public static bool InsereOperador(Operador o)
        {
            if (o.Id == -1 || o.Contacto == -1)
                return false;
            try
            {
                RegistoOperadores.InsereOperadorLista(o);
                return true;
            }
            catch (OperadorException e)
            {
                throw new OperadorException(e.Message + "-" + "Falha ao inserir o operador.");
            }
        }
        /// <summary>
        /// Mostra todos os operadores existentes.
        /// </summary>
        public static void MostrarTodosOperadores()
        {
            RegistoOperadores listaOperadores = new RegistoOperadores();
            foreach (Operador o in listaOperadores.ObterOperadores)
            {
                Console.WriteLine(o.ToString());
            }
        }
        #endregion

        #region SOLUCOES

        /// <summary>
        /// Insere uma solução na lista de soluções.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ProblemaException"></exception>
        public static bool InsereSolucao(ProblemasCon p)
        {
            if (p.Id == -1 || ReferenceEquals(p, null))
                return false;
            try
            {
                RegistoProblemas.InserirSolucaoLista(p);
                return true;
            }
            catch(ProblemaException e)
            {
                throw new ProblemaException(e.Message + "-" + "Ja existe esta solucao na lista de solucoes.");
            }
        }
        /// <summary>
        /// Se existir solucao para um problema, ela e mostrada.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="p">The p.</param>
        public static void MostrarSolucao(Assist a, ProblemasCon p)
        {
            bool existeSolucao = a.ExisteSolucao(a, p);
            if (existeSolucao)
            {
                Console.WriteLine(p.ToString());
            }
        }
        /// <summary>
        /// Mostra todas as solucoes disponiveis.
        /// </summary>
        /// <param name="listaSolucoes">The lista solucoes.</param>
        public static void MostrarSolucoesExistentes(RegistoProblemas listaSolucoes)
        {
            foreach (ProblemasCon p in listaSolucoes.ObterSolucoes)
            {
                if (p.Id == -1)
                    continue;
                Console.WriteLine(p.ToString());
            }
        }
        #endregion

        #region PRODUTOS

        /// <summary>
        /// Insere um produto na lista de produtos.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ProdutosException"></exception>
        public static bool InserirProdutoLista(Produto p)
        {
            try
            {
                RegistoProdutos.InserirProduto(p);
                return true;
            }
            catch(ProdutosException e)
            {
                throw new ProdutosException(e.Message + "-" + "Falha ao inserir o produto.");
            }
        }
        /// <summary>
        /// Insere categorias numa lista.
        /// </summary>
        /// <param name="nomeCategoria">The nome categoria.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.CategoriaException"></exception>
        public static bool InserirCategoriasLista(string nomeCategoria, int idProd)
        {
            try
            {
                RegistoCategorias.InserirCategoria(nomeCategoria, idProd);
                return true;
            }
            catch (CategoriaException e)
            {
                throw new CategoriaException(e.Message + "-" + "Falha ao inserir categoria");
            }
        }
        /// <summary>
        /// Insere categorias num produto.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.CategoriaException"></exception>
        public static bool InserirCategoriasProduto(Produto p)
        {
            List<Categoria> categoriasInserir;
            try
            {
                RegistoCategorias.ExisteCategoriasProduto(p.Id, out categoriasInserir);
                RegistoProdutos.InserirCategorias(p, categoriasInserir.ToList());
                return true;
            }
            catch (CategoriaException e)
            {
                throw new CategoriaException(e.Message);
            }
        }

        /// <summary>
        /// Mostra as categorias de um produto.
        /// </summary>
        /// <param name="listaCategorias">The lista categorias.</param>
        public static void MostrarCategorias(List<Categoria> listaCategorias)
        {
            foreach (Categoria c in listaCategorias)
            {
                if (c.NomeCategoria == string.Empty)
                    continue;
                Console.WriteLine(c.ToString());
            }
        }
        /// <summary>
        /// Mostra os produtos.
        /// </summary>
        /// <param name="listaProdutos">The lista produtos.</param>
        public static void MostrarProdutos()
        {
            RegistoProdutos listaProdutos = new RegistoProdutos();
            foreach (Produto p in listaProdutos.ObterProdutos)
            {
                if (ReferenceEquals(p, null) || p.Id == 0)
                    continue;
                Console.WriteLine(p.ToString());
                MostrarCategorias(p.Categorias);
            }
        }
        #endregion

        /// <summary>
        /// Mostra na consola o numero de clientes existentes.
        /// </summary>
        /// <param name="listaClientes"></param>
        public static void NumeroClientes(List<Cliente> listaClientes)
        {
            Console.WriteLine(listaClientes.Count);
        }
        /// <summary>
        /// Metodo para verificar se existe um cliente, na lista de clientes.
        /// </summary>
        /// <param name="listaClientes">The lista clientes.</param>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.ClienteNaoExisteException">Cliente não existe.</exception>
        public static bool ExisteCliente(List<Cliente> listaClientes, Cliente a)
        {
            try
            {
                if (!listaClientes.Contains(a))
                    throw new ClienteNaoExisteException("Cliente nao existe.");
            }
            catch (ClienteNaoExisteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Verifica se existe uma solucao para um determinado tipo de assitencia de um problema.
        /// </summary>
        /// <param name="listaSolucoes">The lista solucoes.</param>
        /// <param name="listaAssitencias">The lista assitencias.</param>
        /// <param name="tipoId">The tipo identifier.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.NaoExisteSolucaoException">O problema ainda nao tem solucao.</exception>
        public static bool ExisteSolucaoProblema(List<ProblemasCon> listaSolucoes, List<Assist> listaAssitencias, int tipoId)
        {
            bool existeSolucao = false;
            foreach (Assist a in listaAssitencias)
            {
                if (a.tipoAssis.Id == tipoId)
                {
                    foreach (ProblemasCon b in listaSolucoes)
                    {
                        if (b.Equals(a.tipoAssis))
                        {
                            existeSolucao = true;
                            break;
                        }
                    }
                }
            }
            try
            {
                if (existeSolucao)
                    return true;
                else
                    throw new NaoExisteSolucaoException("O problema ainda nao tem solucao.");
            }
            catch (NaoExisteSolucaoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        #endregion

        #endregion
    }
}