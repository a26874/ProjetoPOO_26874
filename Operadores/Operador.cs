/*
*	<copyright file="Operador" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:05:11 PM</date>
*	<description></description>
**/

namespace Operadores
{
    public class Operador
    {
        #region ATRIBUTOS
        private string nome;
        private int id;
        private int contacto;
        static private int numOperadores;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public Operador()
        {
            nome = string.Empty;
            id = -1;
            contacto = -1;
            numOperadores = 0;
        }
        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="nomeOperador">O nome do operador.</param>
        /// <param name="numeroOperador">O numero do operador.</param>
        /// <param name="contactoOperador">O contacto do operador.</param>
        public Operador(string nomeOperador, int numeroOperador, int contactoOperador)
        {
            this.nome = nomeOperador;
            this.id = numeroOperador;
            this.contacto = contactoOperador;
        }

        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulador de nome.
        /// </summary>
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        /// <summary>
        /// Manipulador de Numero
        /// </summary>
        public int Numero
        {
            get { return id; }
            set
            {
                if (id > 0)
                    id = value;
            }
        }
        /// <summary>
        /// Manipulador de contacto.
        /// </summary>
        public int Contacto
        {
            set
            {
                if(contacto >0)
                    contacto = value;
            }
            get { return contacto; }
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
            if ((a.id == b.id) && (a.nome == b.nome))
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
        public override string ToString()
        {
            return string.Format("Nome:{0}|ID:{1}|Contacto:{2}", nome, id.ToString(), contacto.ToString());
        }
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
        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion

    }
}