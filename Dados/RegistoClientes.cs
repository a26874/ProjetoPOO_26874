/*
*	<copyright file="Pessoas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/1/2023 8:16:49 PM</date>
*	<description></description>
**/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using ObjetosNegocio;
using Interfaces;
using Excecoes;
using System.Net;

namespace Dados
{
    /// <summary>
    /// Classe para armazenamento de vários clientes.
    /// </summary>
    public class RegistoClientes
    {

        #region ATRIBUTOS
        private static int numCliente;
        private static List<Cliente> listaClientes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES             
        /// <summary>
        /// Construtor estático, para inicialização da classe.
        /// </summary>
        static RegistoClientes()
        {
            listaClientes = new List<Cliente>();
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoClientes()
        {

        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Retorna a array de clientes.
        /// </summary>
        /// <value>
        /// Obter clientes.
        /// </value>
        public List<Cliente> ObterClientes
        {
            get { return listaClientes.ToList(); }
        }

        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Insere um cliente, na lista de clientes.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public static bool InsereClienteLista(Cliente c)
        {
            //Verificar se a já existe!!! && se existe espaço
            foreach (Cliente a in listaClientes)
            {
                if (a.Equals(c))
                    throw new ClienteException("Ja existe este cliente.");
            }
            listaClientes.Add(c);
            numCliente++;
            listaClientes.Sort();
            return true;
        }
        /// <summary>
        /// Insere saldo num cliente.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public static bool InsereSaldo(Cliente c, int valor)
        {
            foreach(Cliente a in listaClientes)
            {
                if (a.Equals(c))
                {
                    if (a.Saldo == 0)
                    {
                        a.Saldo = valor;
                        return true;
                    }
                    else
                        throw new ClienteException("Cliente ja tem saldo, carregue.");
                }
            }
            throw new ClienteException("Cliente não existe na nossa base de dados");
        }
        /// <summary>
        /// Limpa a lista de clientes.
        /// </summary>
        /// <returns></returns>
        public bool RemoverClientes()
        {
            listaClientes.Clear();
            numCliente = 0;
            return true;
        }
        /// <summary>
        /// Dado um certo cliente, esse mesmo é removido da lista de clientes.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public bool RemoverClienteEspecifico(Cliente c)
        {
            if (listaClientes.Remove(c))
                return true;
            return false;
        }
        /// <summary>
        /// Ordena a lista de clientes, pelo seu NIF.
        /// </summary>
        public void OrdenarClientes()
        {
            //listaClientes.Sort((c1, c2) => c1.NIF.CompareTo(c2.NIF));
            listaClientes.Sort();
        }
        /// <summary>
        /// Retorna o numero de clientes existentes.
        /// </summary>
        /// <returns></returns>
        public int NumeroClientesExistentes()
        {
            return listaClientes.Count;
        }
        /// <summary>
        /// Grava em ficheiro binário todos os clientes.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool GravarFicheiroClientes(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, listaClientes);
                    ficheiro.Close();
                    return true;
                }
            }
            catch (EscritaFicheiro)
            {
                throw new EscritaFicheiro("Erro ao gravar o ficheiro de clientes.");
            }
            //Stream ficheiro = null;
            //if (!File.Exists(nomeFicheiro))
            //    ficheiro = File.Open(nomeFicheiro, FileMode.Create);
            //else
            //    ficheiro = File.Open(nomeFicheiro, FileMode.Open);
            //if (ficheiro == null)
            //    return false;
            //else
            //{
            //    BinaryFormatter b = new BinaryFormatter();
            //    b.Serialize(ficheiro, listaClientes);
            //    ficheiro.Close();
            //    return true;
            //}
        }
        /// <summary>
        /// Le do ficheiro de clientes, todos os clientes.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool LerFicheiroClientes(string nomeFicheiro)
        {
            Stream ficheiro = null;
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;
                using (ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    listaClientes = (List<Cliente>)b.Deserialize(ficheiro);
                    ficheiro.Close();
                    return true;
                }
            }
            catch (LeituraFicheiro)
            {
                throw new LeituraFicheiro("Erro ao ler o ficheiro de clientes.");
            }
        }
        /// <summary>
        /// Metodo para verificar se existe um cliente.
        /// </summary>
        /// <param name="nif">The nif.</param>
        /// <param name="clienteInserir">The cliente inserir.</param>
        /// <returns></returns>
        public static bool ExisteCliente(int nif, out Cliente clienteInserir)
        {
            foreach (Cliente c in listaClientes)
            {
                if (c.NIF == nif)
                {
                    clienteInserir = c;
                    return true;
                }
            }
            clienteInserir =null;
            return false;
        }
        /// <summary>
        /// Verifica se um cliente tem saldo para conseguir pagar a assistência.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        /// <exception cref="ClienteException"></exception>
        public static bool VerificaSaldo(Assist a)
        {
            foreach (Cliente c in listaClientes)
            {
                if (c.NIF == a.Cliente.NIF && c.Saldo > a.tipoAssis.Preco)
                {
                    c.Saldo -= a.tipoAssis.Preco;
                    return true;
                }
            }
            throw new ClienteException("O cliente não tem saldo suficiente para concluir a assistencia.");
        }
        #endregion

        #endregion
    }
}