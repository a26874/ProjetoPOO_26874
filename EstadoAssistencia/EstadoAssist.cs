/*
*	<copyright file="EstadoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:04:14 PM</date>
*	<description></description>
**/

namespace EstadoAssistencia
{
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
            descEstadoAssistencia = string.Empty;
            servicoAtivo = false;
        }
        /// <summary>
        /// Construtor com parametros..
        /// </summary>
        /// <param name="descEstado">A descricao do estado da assistencia.</param>
        /// <param name="ativo">Se esta a decorrer ou nao.</param>
        public EstadoAssist(string descEstado, bool aDecorrer)
        {
            this.descEstadoAssistencia = descEstado;
            this.servicoAtivo = aDecorrer;
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
        public bool aDecorrer
        {
            set { servicoAtivo = value; }
            get { return servicoAtivo; }
        }
        #endregion

        #region OPERADORES
        //public static bool operator == (EstadoAssist a, EstadoAssist b)
        //{ perguntar prof

        //}
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
            return string.Format("Descricao:{0}|Ativo:{1}", descEstadoAssistencia, servicoAtivo.ToString());
        }
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
        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion

    }
}