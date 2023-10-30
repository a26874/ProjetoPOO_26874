/*
*	<copyright file="RegistoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/30/2023 1:26:01 PM</date>
*	<description></description>
**/
using Operadores;
using Clientes;
using Assistencia;

namespace RegistoAssistencias
{
    public class RegistoAssist
    {
        const int MAXASSISTENCIAS = 10;
        #region ATRIBUTOS
        int numAssist;
        private static int idRegisto; 
        private Cliente cliente;
        private Operador operadores;
        private Assist[] assistencias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoAssist()
        {
            idRegisto = -1;
            cliente = new Cliente();
            operadores = new Operador();
            assistencias = new Assist[MAXASSISTENCIAS];
        }
        /// <summary>
        /// Construtor por parametros.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="c"></param>
        /// <param name="o"></param>
        /// <param name="a"></param>
        
        #endregion

        #region PROPRIEDADES
        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        public bool InsereAssist(Assist a)
        {
            assistencias[numAssist] = a;
            numAssist++;
            return true;
        }
        #endregion

        #endregion
    }
}