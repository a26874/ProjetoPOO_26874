/*
*	<copyright file="Pessoas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/1/2023 8:16:49 PM</date>
*	<description></description>
**/


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
            get { return (Cliente[])listaClientes.Clone(); }
        }
        
        #endregion

        #region OPERADORES

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
        /// <summary>
        /// Substitui os clientes existentes por novos objetos do tipo cliente.
        /// </summary>
        /// <returns></returns>
        public bool RemoverClientes()
        {
            for (int i = 0; i < listaClientes.Length; i++)
            {
                if (listaClientes[i] is null)
                    continue;
                else
                    listaClientes[i] = new Cliente();
            }
            return true;
        }
        /// <summary>
        /// Dado um certo cliente, esse mesmo é removido da array de clientes.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public bool RemoverClienteEspecifico(Cliente c)
        {
            for (int i = 0; i < listaClientes.Length; i++)
            {
                if (listaClientes[i].Equals(c))
                {
                    for (int j = i; j < listaClientes.Length-1; j++)
                        listaClientes[j] = listaClientes[j+1];
                    listaClientes[listaClientes.Length-1] = new Cliente();
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Ordenação da array listaClientes com o metodo BubbleSort.
        /// </summary>
        /// <returns></returns>
        public void BubbleSortClientes()
        {
            Cliente aux;
            bool a = true;
            while(a)
            {
                a = false;
                for (int i = 0; i < listaClientes.Length-1;i++)
                {
                    if (listaClientes[i].NIF > listaClientes[i+1].NIF && listaClientes[i+1].NIF !=-1)
                    {
                        aux = listaClientes[i];
                        listaClientes[i] = listaClientes[i+1];
                        listaClientes[i+1]= aux;
                        a = true;
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}