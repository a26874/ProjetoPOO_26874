/*
*	<copyright file="Moradas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/27/2023 9:49:48 AM</date>
*	<description></description>
**/

namespace Pessoas
{
    /// <summary>
    /// Classe para moradas.
    /// </summary>
    public class Moradas
    {
        #region ATRIBUTOS
        private string distrito;
        private string codigoPostal;
        private string localidade;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public Moradas()
        {
            distrito = string.Empty;
            codigoPostal = string.Empty;
            localidade = string.Empty;
        }
        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="r"></param>
        /// <param name="codPost"></param>
        /// <param name="l"></param>
        public Moradas(string r, string codPost, string l)
        {
            distrito = r;
            codigoPostal = codPost;
            localidade = l;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulacao da variavel distrito.
        /// </summary>
        public string Rua
        {
            set { distrito = value; }
            get { return distrito.ToUpper(); }
        }
        /// <summary>
        /// Manipulacao da variavel CodPostal
        /// </summary>
        public string CodPostal
        {
            set { codigoPostal = value; }
            get { return codigoPostal.ToUpper(); }
        }
        /// <summary>
        /// Manipulacao da variavel localidade
        /// </summary>
        public string Localidade
        {
            set { localidade = value; }
            get { return localidade.ToUpper(); }
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefiniçao do operador ==.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Moradas a, Moradas b)
        {
            if ((a.distrito == b.distrito) && (a.localidade == b.localidade) && (a.codigoPostal == b.codigoPostal))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator != (Moradas a, Moradas b)
        {
            return !(a == b);
        }
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
            return FichaMorada();
        }
        /// Redefinição do metodo Equals.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            Moradas a = (Moradas)obj;
            if (this == a) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Metodo para impressão das informações essenciais de uma morada.
        /// </summary>
        /// <returns></returns>
        public string FichaMorada()
        {
            return string.Format("Rua:{0} - Codigo-Postal:{1} - Localidade:{2}", distrito, codigoPostal, localidade);
        }
        #endregion

        #endregion
    }
}