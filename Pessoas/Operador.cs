/*
*	<copyright file="Operador" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:05:11 PM</date>
*	<description></description>
**/

namespace Pessoas
{
    /// <summary>
    /// Classe de operadores.
    /// </summary>
    public class Operador : Pessoa
    {
        #region ATRIBUTOS
        private int id;
        static private int numOperadores = 0;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        

        static Operador()
        {
            numOperadores = 0;
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public Operador()
        {
            Nome= string.Empty;
            id = -1;
            Contacto = -1;
            Morada = new Moradas();
            numOperadores++;
        }
        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="nomeOperador">O nome do operador.</param>
        /// <param name="idOperador">O numero do operador.</param>
        /// <param name="contactoOperador">O contacto do operador.</param>
        public Operador(string nomeOperador, int idOperador, int contactoOperador, Moradas moradaOperador)
        {
            Nome = nomeOperador;
            id = idOperador;
            Contacto = contactoOperador;
            Morada = moradaOperador;
            numOperadores++;
        }

        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulador de Numero
        /// </summary>
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        
        #endregion

        #region OPERADORES        
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator == ( Operador a, Operador b)
        {
            if ((a.id == b.id) && (a.Nome == b.Nome))
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static bool operator != (Operador a, Operador b)
        {
            return (!(a == b));
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
            return FichaOperador();
        }
        /// <summary>
        /// Redefinição do metodo Equals.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Operador)
            {
                Operador a = (Operador)obj;
                if (this == a)
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Redefinição do metodo ToString.
        /// </summary>
        /// <returns></returns>
        public string FichaOperador()
        {
            return string.Format("Nome:{0} | ID{1}: | Contacto:{2}", Nome, id.ToString(), Contacto.ToString());
        }

       
        #endregion

        #endregion

    }
}