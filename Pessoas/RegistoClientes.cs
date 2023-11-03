/*
*	<copyright file="Pessoas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/1/2023 8:16:49 PM</date>
*	<description></description>
**/

using Pessoas;

namespace Pessoas
{
    /// <summary>
    /// Classe para armazenamento de vários clientes.
    /// </summary>
    public class RegistoClientes
    {
        const int MAXCLIENTES = 5;
        #region ATRIBUTOS
        private int numCliente;
        Cliente[] listaClientes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoClientes()
        {
            listaClientes = new Cliente[MAXCLIENTES];
            IniciarArrayClientes(listaClientes);
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Retorna a array de clientes.
        /// </summary>
        /// <value>
        /// Obter clientes.
        /// </value>
        public Cliente[] ObterClientes
        {
            get { return listaClientes; }
        }
        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Metodo para inicialização da array.
        /// </summary>
        /// <param name="a"></param>
        void IniciarArrayClientes(Cliente[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Cliente();
            }
        }
        /// <summary>
        /// Insere um novo cliente na array de clientes.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool InsereCliente(Cliente c)
        {
            //Verificar se a já existe!!! && se existe espaço
            foreach (Cliente a in listaClientes)
            {
                if (a.NIF == -1)
                    continue;
                if (a.Equals(c) || (numCliente >= MAXCLIENTES))
                    return false;
            }
            listaClientes[numCliente] = c;
            numCliente++;
            return true;
        }
        #endregion

        #endregion
    }
}