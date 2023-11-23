﻿/*
*	<copyright file="RegistoProblemas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/20/2023 7:57:30 PM</date>
*	<description></description>
**/

namespace Outros
{
    /// <summary>
    /// Classe para registo de listaSolucoes conhecidos.
    /// </summary>
    public class RegistoProblemas
    {
        const int MAXPROBLEMASCON = 4;
        #region ATRIBUTOS
        private int numProblemas;
        ProblemasCon[] listaSolucoes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor para inicializar um novo registo de ProblemasConhecidos.
        /// </summary>
        public RegistoProblemas()
        {
            listaSolucoes = new ProblemasCon[MAXPROBLEMASCON];
            InicializarArraySolucoes();
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve o array de problemas conhecidos.
        /// </summary>
        /// <value>
        /// The obter problemascon.
        /// </value>
        public ProblemasCon[] ObterSolucoes
        {
            get { return (ProblemasCon[])listaSolucoes.Clone(); }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Inicializa o array de solucoes.
        /// </summary>
        /// <param name="p">The p.</param>
        void InicializarArraySolucoes()
        {
            for (int i = 0; i < listaSolucoes.Length; i++)
            {
                listaSolucoes[i] = new ProblemasCon();
            }
        }
        /// <summary>
        /// Insere uma solucao.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public bool InserirSolucao(ProblemasCon p)
        {
            foreach (ProblemasCon aux in listaSolucoes)
            {
                if (aux.Id == -1)
                    continue;
                if (aux.Equals(p) || numProblemas > MAXPROBLEMASCON)
                    return false;
            }
            listaSolucoes[numProblemas] = p;
            numProblemas++;
            return true;
        }
        /// <summary>
        /// Edita uma solucao.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="desc">The desc.</param>
        /// <param name="solucao">The solucao.</param>
        /// <returns></returns>
        public bool EditarSolucao(ProblemasCon p, int id, string desc, string solucao)
        {
            foreach (ProblemasCon s in listaSolucoes)
            {
                if (s.Id == -1)
                    continue;
                if (s.Equals(p))
                {
                    s.Descricao = desc;
                    s.Id = id;
                    s.Resolucao = solucao;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #endregion
    }
}