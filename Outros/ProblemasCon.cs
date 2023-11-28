/*
*	<copyright file="ProblemasCon" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:10:21 PM</date>
*	<description></description>
**/

using Assistencia;
using System;

namespace Outros
{
    [Serializable]
    /// <summary>
    /// Classe para listaSolucoes conhecidos.
    /// </summary>
    public class ProblemasCon
    {
        #region ATRIBUTOS
        private string descProblema;
        private int id;
        private string resolucaoProblema;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public ProblemasCon()
        {
            descProblema = string.Empty;
            id = -1;
            resolucaoProblema = string.Empty;
        }
        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="descProblema">The desc problema.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="resolucaoProblema">The resolucao problema.</param>
        public ProblemasCon(string descProblema, int id, string resolucaoProblema)
        {
            this.descProblema = descProblema;
            this.id = id;
            this.resolucaoProblema = resolucaoProblema;
        }

        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulacao da variavel ID.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get { return id; }
            set {
                if (value > 0)
                    id = value;
            } 
        }
        /// <summary>
        /// Manipulacao da variavel DescricaoProblema.
        /// </summary>
        /// <value>
        /// The descricao.
        /// </value>
        public string Descricao
        {
            get { return descProblema; }
            set { descProblema = value; }
        }
        /// <summary>
        /// Manipulacao da variavel ResolucaoProblema.
        /// </summary>
        /// <value>
        /// The resolucao.
        /// </value>
        public string Resolucao
        {
            get { return resolucaoProblema; }
            set { resolucaoProblema = value; }
        }
        #endregion

        #region OPERADORES        
        /// <summary>
        /// Redefinição do operador ==.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator == (ProblemasCon a, ProblemasCon b)
        {
            if (a.id == b.id)
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator != (ProblemasCon a, ProblemasCon b)
        {
            return !(a == b);
        }
        #endregion


        #region OVERRIDES        
        /// <summary>
        /// Redefinição da override Equals.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is TipoAssist)
            {
                TipoAssist t = (TipoAssist)obj;
                if (this.id == t.Id)
                    return true;
            }
            if (obj is ProblemasCon)
            {
                ProblemasCon p = (ProblemasCon)obj;
                if (this.id == p.Id)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Redefinição da override ToString.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return FichaProblemasCon();
        }
        //Ainda por fazer
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Metodo para impressao do problema conhecido
        /// </summary>
        /// <returns></returns>
        public string FichaProblemasCon()
        {
            return string.Format("Solucao:\nDescricao:{0}\nResolucao:{1}\n", descProblema, resolucaoProblema);
        }
        #endregion


        #endregion
    }
}