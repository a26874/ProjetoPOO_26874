﻿/*
*	<copyright file="RegistoCategorias" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 11:12:08 AM</date>
*	<description></description>
**/


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
        Categoria[] listaCategorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor para inicializar um novo registo de categorias.
        /// </summary>
        public RegistoCategorias()
        {
            listaCategorias= new Categoria[MAXCAT];
            InicializarArrayCategorias();
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve as categorias de um produto.
        /// </summary>
        /// <value>
        /// The obter categorias.
        /// </value>
        public Categoria[] ObterCategorias
        {
            get { return (Categoria[])listaCategorias.Clone(); }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Inicia a array de categorias.
        /// </summary>
        /// <param name="c">The c.</param>
        void InicializarArrayCategorias()
        { 
            for (int i = 0; i < listaCategorias.Length; i++)
            {
                listaCategorias[i] = new Categoria();
            }  
        }
        /// <summary>
        /// Insere um categoria.
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
            listaCategorias[numCategorias] = c;
            numCategorias++;
            return true;
        }

        #endregion

        #endregion
    }
}