/*
*	<copyright file="RegistoProblemas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/20/2023 7:57:30 PM</date>
*	<description></description>
**/

using System.Collections.Generic;
using System.Linq;

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
        private List<ProblemasCon> listaSolucoes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor para inicializar um novo registo de ProblemasConhecidos.
        /// </summary>
        public RegistoProblemas()
        {
            listaSolucoes = new List<ProblemasCon>();
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve o array de problemas conhecidos.
        /// </summary>
        /// <value>
        /// The obter problemascon.
        /// </value>
        public List<ProblemasCon> ObterSolucoes
        {
            get { return listaSolucoes.ToList(); }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        
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
            listaSolucoes.Add(p);
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