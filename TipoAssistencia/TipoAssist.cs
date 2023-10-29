/*
*	<copyright file="TipoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:03:03 PM</date>
*	<description></description>
**/
using Operadores;

namespace TipoAssistencia
{
    public class TipoAssist
    {
        #region ATRIBUTOS
        private string desc;
        private string nomeTipo;
        private int id;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public TipoAssist()
        {
            desc = string.Empty;
            nomeTipo = string.Empty;
        }
        /// <summary>
        /// Construtor para tipos de assistencia.
        /// </summary>
        /// <param name="descricao">The descricao.</param>
        /// <param name="nome">The nome.</param>
        public TipoAssist(string descricao, string nome, int id)
        {
            this.desc = descricao;
            this.nomeTipo = nome;
            this.id = id;
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulacao da variavel desc.
        /// </summary>
        public string Desc
        {
            set { desc = value; }
            get { return desc; }
        }
        /// <summary>
        /// Manipulacao da variavel nomeTipo.
        /// </summary>
        public string NomeTipo
        { 
            set { nomeTipo = value;}
            get { return nomeTipo; } 
        }
        /// <summary>
        /// Manipulacao da variavel ID.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            set 
            {
                if (id > 0)
                    id = value;
            }
            get { return id; }
        }
        #endregion

        #region OPERADORES  
        /// <summary>
        /// Redefinição do operador ==.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (TipoAssist a, TipoAssist b)
        {
            if ((a.id == b.id)&&(a.NomeTipo == b.NomeTipo))
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator != (TipoAssist a, TipoAssist b)
        {
            return (!(a == b));
        }
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Reformulação do metodo ToString na classe TipoAssist.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Format("Descricao:{0}|Tipo:{1}|ID:{2}", desc, nomeTipo, id);
        }
        /// <summary>
        /// Determina se um objeto do tipo TipoAssist é igual a outro.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is TipoAssist)
            {
                TipoAssist a = (TipoAssist)obj;
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

        #endregion

        #endregion
    }
}