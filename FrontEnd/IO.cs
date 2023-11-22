/*
*	<copyright file="IO" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/7/2023 4:22:23 PM</date>
*	<description></description>
**/

using Assistencia;
using Pessoas;
using System;
using Outros;

namespace FrontEnd
{
    /// <summary>
    /// Classe para input e output.
    /// </summary>
    public class IO
    {
        #region ATRIBUTOS

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES

        public IO()
        {

        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Mostra as assistencias na consola.
        /// </summary>
        /// <param name="listaAssistencias">The lista assistencias.</param>
        /// <param name="listaSolucoes">The lista solucoes.</param>
        public static void MostrarAssistencias(RegistoAssist listaAssistencias, RegistoProblemas listaSolucoes)
        {
            foreach (Assist a in listaAssistencias.ObterAssistencias)
            {
                if (ReferenceEquals(a,null) || a.Id == -1)
                    continue;
                Console.WriteLine(a.ToString());
                if (a.estadoA.Ativo == false)
                    continue;
                foreach (ProblemasCon p in listaSolucoes.ObterSolucoes)
                {
                    if (p.Id == -1)
                        continue;
                    MostrarSolucao(a, p);
                }
            }
        }
        /// <summary>
        /// Mostra o registo de clientes na consola.
        /// </summary>
        /// <param name="listaClientes"></param>
        public static void MostrarClientes(RegistoClientes listaClientes)
        {
            foreach (Cliente c in listaClientes.ObterClientes)
            {
                if (ReferenceEquals(c,null)|| c.NIF == -1 )
                    continue;
                Console.WriteLine(c.ToString());
            }
        }
        /// <summary>
        /// Mostra o registo de operadores na consola.
        /// </summary>
        /// <param name="listaOperadores"></param>
        public static void MostrarOperadores(RegistoOperadores listaOperadores)
        {
            foreach (Operador o in listaOperadores.ObterOperadores)
            {
                if (ReferenceEquals(o,null)||o.Id == -1)
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
        public static void MostrarCategorias(Categoria[] listaCategorias)
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
                if (ReferenceEquals(p,null)||p.Id == 0)
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
        public static void InserirAssistenciaCompleta(RegistoAssist listaAssistencias, RegistoClientes listaClientes, Assist a)
        {

        }

        
        #endregion

        #endregion
    }
}