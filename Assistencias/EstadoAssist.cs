/*
*	<copyright file="EstadoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:04:14 PM</date>
*	<description></description>
**/

using System;

namespace Assistencia
{
    [Serializable]
    /// <summary>
    /// Classe para estado de assistências.
    /// </summary>
    public class EstadoAssist
    {
        #region ATRIBUTOS
        private string descEstadoAssistencia;
        private bool servicoAtivo;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public EstadoAssist()
        {
            descEstadoAssistencia = "Ativo";
            servicoAtivo = true;
        }
        /// <summary>
        /// Construtor com parametros..
        /// </summary>
        /// <param name="descEstado">A descricao do estado da assistencia.</param>
        /// <param name="ativo">Se esta a decorrer ou nao.</param>
        public EstadoAssist(string descEstado, bool aDecorrer)
        {
            descEstadoAssistencia = descEstado;
            servicoAtivo = aDecorrer;
        }

        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulacao da variavel descEstadoAssistencia.
        /// </summary>
        public string DescEstado
        {
            set { descEstadoAssistencia = value; }
            get { return descEstadoAssistencia; }
        }
        /// <summary>
        /// Manipulacao da variavel servicoAtivo.
        /// </summary>
        public bool Ativo
        {
            set { servicoAtivo = value; }
            get { return servicoAtivo; }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES        
        /// <summary>
        /// Redefinição do metodo ToString.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return FichaEstadoAssistencia();
        }
        /// <summary>
        /// Determina se um determinado objeto do tipo EstadoAssist é igual a outro.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if(obj is EstadoAssist)
            {
                EstadoAssist a = (EstadoAssist)obj;
                if (this == a)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Retorna o hashcode para desta instância.
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
        /// Reformulação do metodo ToString na classe EstadoAssist.
        /// </summary>
        /// <returns></returns>
        public string FichaEstadoAssistencia()
        {
            return string.Format("Descricao:{0}|Ativo:{1}", descEstadoAssistencia, servicoAtivo.ToString());
        }
        /// <summary>
        /// Para clonar objetos da classe.
        /// </summary>
        /// <returns></returns>
        public EstadoAssist Clone()
        {
            return new EstadoAssist(descEstadoAssistencia, servicoAtivo);
        }
        #endregion

        #endregion

    }
}