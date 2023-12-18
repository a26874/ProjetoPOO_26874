/*
*	<copyright file="IO" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 12/18/2023 2:09:07 PM</date>
*	<description></description>
**/
using Assistencia;
using ObjetosNegocio;
using Outros;
using Pessoas;
using System;
using System.Collections.Generic;

namespace GereAssistencias
{
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

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Dada uma lista de assistências dá print das mesmas.
        /// </summary>
        /// <param name="listaAssistencias"></param>
        public static void MostrarAssistencias (List<Assist> listaAssistencias)
        {
            foreach (Assist a in listaAssistencias)
                Console.WriteLine(a.ToString ());
        }
        /// <summary>
        /// Dada uma lista de clientes dá print dos mesmos.
        /// </summary>
        /// <param name="listaClientes"></param>
        public static void MostrarClientes(List<Cliente> listaClientes)
        {
            foreach (Cliente c in listaClientes)
                Console.WriteLine(c.ToString ());
        }
        /// <summary>
        /// Dada uma lista de operadores dá print dos mesmos.
        /// </summary>
        /// <param name="listaClientes"></param>
        public static void MostrarOperadores(List<Operador> listaOperadores)
        {
            foreach (Operador o in listaOperadores)
                Console.WriteLine(o.ToString());
        }
        /// <summary>
        /// Dada uma lista de clientes, mostra todas as suas informações
        /// </summary>
        /// <param name="listaClientes"></param>
        public static void MostrarClientesCompleto(List<Cliente> listaClientes)
        {
            foreach (Cliente c in listaClientes)
            {
                Console.WriteLine(c.ToString());
                if (c.Morada is null || c.Morada.CodPostal == string.Empty)
                    continue;
                else
                    Console.WriteLine(c.Morada.ToString());
            }
        }
        /// <summary>
        /// Dada uma lista de problemas, dá print dos mesmos.
        /// </summary>
        /// <param name="listaSolucoes"></param>
        public static void MostrarSolucoes(List<ProblemasCon> listaSolucoes)
        {
            foreach (ProblemasCon p in listaSolucoes)
                Console.WriteLine(p.ToString());
        }
        /// <summary>
        /// Dada uma lista de assistências, mostra o id da assistência e a sua data.
        /// </summary>
        /// <param name="listaAssistencias"></param>
        public static void DadosIdentificacaoAssist(List<Assist> listaAssistencias)
        {
            foreach (Assist a in listaAssistencias)
            {
                Console.WriteLine("ID:{0} - Data:{1}", a.Id, a.Data);
            }
        }
        /// <summary>
        /// Dada uma lista de produtos, mostra a sua informação.
        /// </summary>
        /// <param name="listaProdutos"></param>
        public static void MostrarProdutos(List<Produto> listaProdutos, List<Categoria> listaCategorias)
        {
            foreach (Produto p in listaProdutos)
            {
                //if (ReferenceEquals(p, null) || p.Id == 0)
                //    continue;
                Console.WriteLine(p.ToString());
                foreach (Categoria c in listaCategorias)
                {
                    if (p.Id == c.IdProduto)
                        Console.WriteLine(c.ToString());
                }
            }
        }
        #endregion

        #endregion
    }
}