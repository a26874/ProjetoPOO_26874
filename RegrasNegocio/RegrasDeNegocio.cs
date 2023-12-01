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
                throw new AssistException("Falha ao inserir assistencia.");
            }
        }
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
            catch(OperadorException e)
            {
                throw new OperadorException(e.Message + "-"+"Falha ao inserir o operador.");
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
            if (ReferenceEquals(a,null))
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
        /// Insere uma solução de um problema na assistência.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        /// <exception cref="Excecoes.AssistException"></exception>
        public static bool InsereSolucaoAssitencia(Assist a)
        {
            ProblemasCon problemaInserir = null;
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
        /// Mostra as assistencias na consola.
        /// </summary>
        /// <param name="listaAssistencias">The lista assistencias.</param>
        /// <param name="listaSolucoes">The lista solucoes.</param>
        //public static void MostrarAssistencias(RegistoAssist listaAssistencias, RegistoProblemas listaSolucoes)
        //{
        //    foreach (Assist a in listaAssistencias.ObterAssistencias)
        //    {
        //        if (ReferenceEquals(a, null) || a.Id == -1)
        //            continue;
        //        Console.WriteLine(a.ToString());
        //        if (a.estadoA.Ativo == false)
        //            continue;
        //        foreach (ProblemasCon p in listaSolucoes.ObterSolucoes)
        //        {
        //            if (p.Id == -1)
        //                continue;
        //            MostrarSolucao(a, p);
        //        }
        //    }
        //}
        public static bool MostrarAssistencias()
        {
            return RegistoAssist.MostrarListaAssistencias();
        }
        /// <summary>
        /// Mostra o registo de clientes na consola.
        /// </summary>
        /// <param name="listaClientes"></param>
        //public static void MostrarClientes(RegistoClientes listaClientes)
        //{
        //    foreach (Cliente c in listaClientes.ObterClientes)
        //    {
        //        if (ReferenceEquals(c, null) || c.NIF == -1)
        //            continue;
        //        Console.WriteLine(c.ToString());
        //    }
        //}
        /// <summary>
        /// Mostra o registo de operadores na consola.
        /// </summary>
        /// <param name="listaOperadores"></param>
        public static void MostrarOperadores(RegistoOperadores listaOperadores)
        {
            foreach (Operador o in listaOperadores.ObterOperadores)
            {
                if (ReferenceEquals(o, null) || o.Id == -1)
                    continue;
                Console.WriteLine(o.ToString());
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
        public static void MostrarProdutos(RegistoProdutos listaProdutos)
        {
            foreach (Produto p in listaProdutos.ObterProdutos)
            {
                if (ReferenceEquals(p, null) || p.Id == 0)
                    continue;
                Console.WriteLine(p.ToString());
                MostrarCategorias(p.Categorias);
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
        /// <summary>
        /// Mostra a ficha completa do cliente.
        /// </summary>
        /// <param name="listaClientes">The lista clientes.</param>
        public static void MostrarFichaClientesCompleto(List<Cliente> listaClientes)
        {
            foreach (Cliente c in listaClientes)
            {
                if (ReferenceEquals(c, null) || c.NIF == -1)
                    continue;
                Console.WriteLine(c.ToString());
                if (ReferenceEquals(c.Morada, null) || c.Morada.CodPostal == string.Empty)
                    continue;
                else
                {
                    Console.WriteLine(c.Morada.ToString());
                }
            }
        }
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