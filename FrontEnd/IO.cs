﻿/*
*	<copyright file="IO" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/7/2023 4:22:23 PM</date>
*	<description></description>
**/

using Assistencia;
using RegistoAssistencias;
using Pessoas;
using System;
using Outros;
using System.Runtime.InteropServices;
using Produtos;

namespace FrontEnd
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

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Mostra o registo de assistencias na consola.
        /// </summary>
        /// <param name="listaAssistencias"></param>
        public static void MostrarAssistencias(RegistoAssist listaAssistencias)
        {
            foreach (Assist a in listaAssistencias.TodasAssistencias)
            {
                if (a.Id == -1)
                    continue;
                Console.WriteLine(a.ToString());
                Console.WriteLine();
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
                if (c.NIF == -1)
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
                if (o.Id == -1)
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
            foreach(Assist a in listaAssistencias.TodasAssistencias)
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
            foreach(Categoria c in listaCategorias)
            {
                if (c.NomeCategoria == string.Empty)
                    continue;
                Console.WriteLine(c.ToString());
            }
        }
        public static void MostrarProdutos(RegistoProdutos listaProdutos)
        {
            foreach(Produto p in listaProdutos.ObterProdutos)
            {
                if (p.Id == 0)
                    continue;
                Console.WriteLine(p.ToString());
                IO.MostrarCategorias(p.Categorias);
            }
        }
        //public static void MostrarProdutos(Produto listaProdutos)
        //{

        //}
        #endregion

        #endregion
    }
}