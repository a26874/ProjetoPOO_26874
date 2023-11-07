/*
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
using System.Runtime.InteropServices;

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
        #endregion

        #endregion
    }
}