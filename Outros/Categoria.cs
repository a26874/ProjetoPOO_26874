/*
*	<copyright file="Categoria" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 9:45:46 AM</date>
*	<description></description>
**/

namespace Outros
{
    public class Categoria
    {
        #region ATRIBUTOS
        private string nomeCategoria;
        Categoria[] categorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Categoria()
        {
            nomeCategoria = string.Empty;
        }
        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="nomeCategoria"></param>
        public Categoria(string nomeCategoria)
        {
            this.nomeCategoria = nomeCategoria;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulacao da variavel nomeCategoria.
        /// </summary>
        public string NomeCategoria
        {
            get { return nomeCategoria; }
            set { nomeCategoria = value; }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}