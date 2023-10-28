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
    public class Cliente
    {
        #region ATRIBUTOS
        private string nome;
        private int contacto;
        private Moradas morada;
        private static int numClientes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
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
        #endregion

        #region PROPRIEDADES
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        public int Contacto
        {
            set
            {
                if (contacto > 0)
                    contacto = value;
            }
            get { return contacto; }
        }
        public Moradas Morada
        {
            get { return morada; }
            set { morada = value; }
        }
        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}