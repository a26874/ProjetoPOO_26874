/*
*	<copyright file="Avaliacao" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:24:15 PM</date>
*	<description></description>
**/

using System;

namespace Outros
{
    [Serializable]
    /// <summary>
    /// Classe para avaliação de uma assistência.
    /// </summary>
    public class Avaliacao
    {
        #region ATRIBUTOS
        private int idAvaliacao=1;
        private string descricao;
        private int pontuacao;
        private string melhorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public Avaliacao()
        {
            idAvaliacao = -1;
            descricao = string.Empty;
            pontuacao = -1;
            melhorias = string.Empty;
        }
        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="desc"></param>
        /// <param name="pont"></param>
        /// <param name="mel"></param>
        public Avaliacao(string desc, int pont, string mel)
        {
            idAvaliacao++;
            descricao = desc;
            pontuacao = pont;
            melhorias = mel;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulacao da variavel descricao.
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        /// <summary>
        /// Manipulacao da variavel Pontuacao.
        /// </summary>
        public int Pontuacao
        {
            get { return pontuacao; }
            set
            {
                if (value > 0)
                    pontuacao = value;
            }
        }
        /// <summary>
        /// Manipulacao da variavel Melhorias.
        /// </summary>
        public string Melhorias
        {
            get { return melhorias; }
            set { melhorias = value; }
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Avaliacao a, Avaliacao b)
        {
            if (a.idAvaliacao == b.idAvaliacao)
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Avaliacao a, Avaliacao b)
        {
            return !(a == b);
        }
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Redefinição do método ToString.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FichaAvaliacao();
        }
        /// <summary>
        /// Determinar se um tipo de objeto Avaliacao é igual a outro.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is  Avaliacao)
            {
                Avaliacao a = (Avaliacao)(obj);
                if (this == a)
                    return true;
            }
            return false;
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
        /// Retorna informações acerca de uma avaliação.
        /// </summary>
        /// <returns></returns>
        public string FichaAvaliacao()
        {
            return string.Format("Pontuacao:{0}\nDescricao:{1}\nMelhorias:{2}\n", pontuacao, descricao, melhorias);
        }
        /// <summary>
        /// Para clonar objetos da classe.
        /// </summary>
        /// <returns></returns>
        public Avaliacao Clone()
        {
            return new Avaliacao(descricao, pontuacao, melhorias);
        }
        #endregion

        #endregion
    }
}