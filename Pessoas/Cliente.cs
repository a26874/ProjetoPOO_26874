/*
*	<copyright file="Cliente" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:07:35 PM</date>
*	<description></description>
**/

namespace Pessoas
{
    /// <summary>
    /// Classe para cliente.
    /// </summary>
    public class Cliente
    {
        #region ATRIBUTOS
        private string nome;
        private int contacto;
        private Moradas morada;
        private int nif;
        private static int numClientes=0; //
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES     
        
        static Cliente()
        {
            numClientes = 0;
        }

        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public Cliente()
        {
            nome = string.Empty;
            contacto = -1;
            morada = new Moradas(string.Empty,string.Empty,string.Empty);
            nif = -1;
            numClientes = 0;
        }
        /// <summary>
        /// Construtor por parametros.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="c">The c.</param>
        /// <param name="M">The m.</param>
        public Cliente(string n, int c, Moradas m, int ni)
        {
            nome = n;
            contacto = c;
            morada = m;
            nif = ni;
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulacao da variavel nome.
        /// </summary>
        /// <value>
        /// The nome.
        /// </value>
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        /// <summary>
        /// Manipulacao da variavel contacto.
        /// </summary>
        /// <value>
        /// The contacto.
        /// </value>
        public int Contacto
        {
            set
            {
                if (value > 0)
                    contacto = value;
            }
            get { return contacto; }
        }
        /// <summary>
        /// Manipulacao da variavel Pessoas.
        /// </summary>
        /// <value>
        /// The morada.
        /// </value>
        public Moradas Morada
        {
            get { return morada; }
            set { morada = value; }
        }
        public int NIF
        {
            get { return nif; }
            set
            {
                if (value > 0)
                { nif = value; }
            }
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
        public static bool operator == (Cliente a, Cliente b)
        {
            if (a.nif == b.nif)
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
        public static bool operator != (Cliente a, Cliente b)
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
            return FichaCliente();
        }
        /// <summary>
        /// Redefinição do metodo equals.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                Cliente c = (Cliente)obj;
                if (this == c)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Returns a hash code for this instance.
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
        /// Metodo para impressão das informações essenciais do cliente.
        /// </summary>
        /// <returns></returns>
        public string FichaCliente()
        {
            return string.Format("Nome:{0} - Contacto:{1}", nome, contacto);
        }
        #endregion

        #endregion
    }
}