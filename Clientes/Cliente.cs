/*
*	<copyright file="Cliente" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:07:35 PM</date>
*	<description></description>
**/
using Morada;

namespace Clientes
{
    /// <summary>
    /// 
    /// </summary>
    public class Cliente
    {
        #region ATRIBUTOS
        private string nome;
        private int contacto;
        private Moradas morada;
        private static int numClientes; //Variavel estatica, inicializar sempre con construtor estático.
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
            numClientes = 0;
        }
        /// <summary>
        /// Construtor por parametros.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="c">The c.</param>
        /// <param name="M">The m.</param>
        public Cliente(string n, int c, Moradas m)
        {
            nome = n;
            contacto = c;
            morada = m;
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
        /// Manipulacao da variavel Morada.
        /// </summary>
        /// <value>
        /// The morada.
        /// </value>
        public Moradas Morada
        {
            get { return morada; }
            set { morada = value; }
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