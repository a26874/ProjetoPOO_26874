﻿/*
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
        private int idProduto;
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
        /// Construtor com parametros.
        /// </summary>
        /// <param name="nomeCategoria">The nome categoria.</param>
        /// <param name="idProduto">The identifier produto.</param>
        public Categoria(string nomeCategoria, int idProduto)
        {
            this.idProduto = idProduto;
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
        /// <summary>
        /// Devolve o IdProduto.
        /// </summary>
        /// <value>
        /// The identifier produto.
        /// </value>
        public int IdProduto
        {
            get { return idProduto; }
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Categoria a, Categoria b)
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
        public static bool operator !=(Categoria a, Categoria b)
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
                Categoria c = (Categoria)obj;
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
        /// <summary>
        /// Retorna o hashcode desta instância.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
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
        /// <summary>
        /// Para clonar objetos da classe.
        /// </summary>
        /// <returns></returns>
        public Categoria Clone()
        {
            return new Categoria(nomeCategoria, idProduto);
        }
        #endregion

        #endregion
    }
}