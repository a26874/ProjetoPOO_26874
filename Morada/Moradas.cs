/*
*	<copyright file="Moradas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/27/2023 9:49:48 AM</date>
*	<description></description>
**/

namespace Morada
{
    public class Moradas
    {
        #region ATRIBUTOS
        private string rua;
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
            rua = string.Empty;
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
            this.rua = r;
            this.codigoPostal = codPost;
            this.localidade = l;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulacao da variavel rua.
        /// </summary>
        public string Rua
        {
            set { rua = value; }
            get { return rua.ToUpper(); }
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
            if ((a.rua == b.rua) && (a.localidade == b.localidade) && (a.codigoPostal == b.codigoPostal))
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
        public override string ToString()
        {
            return string.Format("Rua:{0}|Codigo-Postal:{1}|Localidade:{2}", rua, codigoPostal, localidade);
        }
        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}