/*
*	<copyright file="RegistoCategorias" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 11:12:08 AM</date>
*	<description></description>
**/


using System.Collections.Generic;
using System.Linq;

namespace Outros
{
    /// <summary>
    /// Classe para registo de categorias.
    /// </summary>
    public class RegistoCategorias
    {
        const int MAXCAT = 2;
        #region ATRIBUTOS
        private int numCategorias;
        private List<Categoria> listaCategorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor para inicializar um novo registo de categorias.
        /// </summary>
        public RegistoCategorias()
        {
            listaCategorias = new List<Categoria>();
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve as categorias de um produto.
        /// </summary>
        /// <value>
        /// The obter categorias.
        /// </value>
        public List<Categoria> ObterCategorias
        {
            get { return listaCategorias.ToList(); }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Insere uma categoria.
        /// </summary>
        /// <param name="nomeCategoria">The nome categoria.</param>
        /// <returns></returns>
        public bool InserirCategoria(string nomeCategoria)
        {
            foreach (Categoria aux in listaCategorias)
            {
                if (aux.NomeCategoria == string.Empty)
                    continue;
                if (aux.NomeCategoria == nomeCategoria|| numCategorias > MAXCAT)
                    return false;
            }
            Categoria c = new Categoria(nomeCategoria);
            listaCategorias.Add(c);
            numCategorias++;
            return true;
        }

        #endregion

        #endregion
    }
}