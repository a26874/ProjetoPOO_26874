/*
*	<copyright file="Pessoa" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/3/2023 9:16:37 AM</date>
*	<description></description>
**/

namespace Pessoas
{
    public class Pessoa
    {
        #region ATRIBUTOS
        private int contacto;
        private string nome;
        private Moradas morada;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        public Pessoa()
        {

        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulacao da variavel contacto.
        /// </summary>
        public int Contacto
        {
            get { return contacto; }
            set 
            { 
                if (value >0)
                contacto = value; 
            }
        }
        /// <summary>
        /// Manipulacao da variavel Nome.
        /// </summary>
        public string Nome
        { 
            get { return nome; } 
            set {  nome = value; } 
        }
        /// <summary>
        /// Manipulacao da variavel Morada.
        /// </summary>
        public Moradas Morada
        {
            get { return morada; }
            set { morada = value;}
        }
        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}