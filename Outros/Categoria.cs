/*
*	<copyright file="Categoria" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 9:45:46 AM</date>
*	<description></description>
**/

using System;

namespace Outros
{
    [Serializable]
    /// <summary>
    /// Classe para categoria de produto.
    /// </summary>
    public class Categoria
    {
        #region ATRIBUTOS
        private string nomeCategoria;
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

        /// <summary>
        /// Redefinição do operador ==.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        #region OPERADORES
        public static bool operator == (Categoria a, Categoria b)
        {
            if (a.nomeCategoria == b.nomeCategoria)
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator != (Categoria a, Categoria b)
        {
            return !(a == b);
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Redefinição da override Equals.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Categoria)
            {
                Categoria c = (Categoria) obj;
                if (this == c)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Redefinição do override ToString.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return FichaCategoria();
        }
        //Ainda por fazer
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Metodo para impressão do nome da categoria.
        /// </summary>
        /// <returns></returns>
        public string FichaCategoria()
        {
            return string.Format("Categoria:{0}", nomeCategoria);
        }

        #endregion

        #endregion
    }
}