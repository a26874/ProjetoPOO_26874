/*
*	<copyright file="RegistoCategorias" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 11:12:08 AM</date>
*	<description></description>
**/


using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Outros;

namespace Dados
{
    /// <summary>
    /// Classe para registo de categorias.
    /// </summary>
    public class RegistoCategorias
    {
        #region ATRIBUTOS
        private static int numCategorias;
        private static List<Categoria> listaCategorias;
        private List<Categoria> categorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor para inicializar um novo registo de categorias.
        /// </summary>
        static RegistoCategorias()
        {
            listaCategorias = new List<Categoria>();
        }
        public RegistoCategorias()
        {
            categorias = new List<Categoria>();
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
        public static bool InserirCategoria(string nomeCategoria, int idProd)
        {
            foreach (Categoria aux in listaCategorias)
            {
                if (aux.NomeCategoria == string.Empty)
                    continue;
                if (aux.NomeCategoria == nomeCategoria)
                    return false;
            }
            Categoria c = new Categoria(nomeCategoria, idProd);
            listaCategorias.Add(c);
            numCategorias++;
            return true;
        }
        public static bool ExisteCategoriasProduto(int idProduto, out List<Categoria> categoriasInserir)
        {
            categoriasInserir = new List<Categoria>();
            foreach(Categoria c in listaCategorias)
            {
                if (c.IdProduto == idProduto)
                {
                    categoriasInserir.Add(c);
                }
            }
            if (categoriasInserir.Count > 0)
                return true;
            categoriasInserir = null;
            return false;
        }
        #endregion

        #endregion
    }
}