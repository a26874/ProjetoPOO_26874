/*
*	<copyright file="Pessoas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/1/2023 8:16:49 PM</date>
*	<description></description>
**/

using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pessoas
{
    /// <summary>
    /// Classe para armazenamento de vários clientes.
    /// </summary>
    public class RegistoClientes : IRegistoClientes
    {
        const int MAXCLIENTES = 5;

        #region ATRIBUTOS
        private int numCliente;
        private List<Cliente> listaClientes;
        private static int numeroClientesExistentes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        static RegistoClientes()
        {
            numeroClientesExistentes = 0;
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoClientes()
        {
            listaClientes = new List<Cliente>();
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
            listaClientes.Add(c);
            numCliente++;
            numeroClientesExistentes = listaClientes.Count;
            return true;
        }
        /// <summary>
        /// Limpa a lista de clientes.
        /// </summary>
        /// <returns></returns>
        public bool RemoverClientes()
        {
            listaClientes.Clear();
            numeroClientesExistentes = 0;
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
            {
                numCliente--;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Ordena a lista de clientes, pelo seu NIF.
        /// </summary>
        public void OrdenarClientes()
        {
            listaClientes.Sort((c1, c2) => c1.NIF.CompareTo(c2.NIF));
            //listaClientes.Sort();
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
        public bool GravarFicheiroClientes(string nomeFicheiro)
        {
            Stream ficheiro = null;
            if (!File.Exists(nomeFicheiro))
                ficheiro = File.Open(nomeFicheiro, FileMode.Create);
            else
                ficheiro = File.Open(nomeFicheiro, FileMode.Open);
            if (ficheiro == null)
                return false;
            else
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(ficheiro, listaClientes);
                ficheiro.Close();
                return true;
            }
        }
        /// <summary>
        /// Le do ficheiro de clientes, todos os clientes.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public bool LerFicheiroClientes(string nomeFicheiro)
        {
            Stream ficheiro = null;
            if (!File.Exists(nomeFicheiro))
                return false;
            else
            {
                ficheiro = File.Open(nomeFicheiro, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                listaClientes = (List<Cliente>)b.Deserialize(ficheiro);
                ficheiro.Close();
                return true;
            }
        }
        #endregion

        #endregion
    }
}