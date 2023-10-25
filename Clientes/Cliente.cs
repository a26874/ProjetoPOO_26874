/*
*	<copyright file="Cliente" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:07:35 PM</date>
*	<description></description>
**/

namespace Clientes
{
    public class Cliente
    {
        #region ATRIBUTOS
        private string nome;
        private int numero;
        private int contacto;
        private string morada;
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
            numero = -1;
            contacto = -1;
            morada = string.Empty;
            numClientes = 0;
        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}