﻿/*
*	<copyright file="Cliente" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:07:35 PM</date>
*	<description></description>
**/


using System;
using Pessoas;

namespace ObjetosNegocio
{
    [Serializable]
    /// <summary>
    /// Classe para cliente.
    /// </summary>
    public class Cliente : Pessoa, IComparable<Cliente>
    {
        #region ATRIBUTOS
        private int nif;
        private int saldo;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES     
        
        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public Cliente()
        {
            Nome = string.Empty;
            Contacto = -1;
            Morada = new Morada(string.Empty,string.Empty,string.Empty);
            nif = -1;
        }
        /// <summary>
        /// Construtor com nome, contacto, morada e NIF.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="c">The c.</param>
        /// <param name="m">The m.</param>
        /// <param name="ni">The ni.</param>
        public Cliente(string n, int c, Morada m, int ni) 
        {
            Nome= n;
            Contacto = c;
            Morada = m;
            nif = ni;
        }
        /// <summary>
        /// Construtor protegido para uso apenas do clone.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="c">The c.</param>
        /// <param name="m">The m.</param>
        /// <param name="ni">The ni.</param>
        /// <param name="saldo">The saldo.</param>
        protected Cliente(string n, int c, Morada m, int ni, int saldo)
        {
            Nome = n;
            Contacto = c;
            Morada = m;
            nif = ni;
            this.saldo = saldo;
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulacao da variavel nif.
        /// </summary>
        /// <value>
        /// O nif.
        /// </value>
        public int NIF
        {
            get { return nif; }
            set
            {
                if (value > 0)
                { nif = value; }
            }
        }
        /// <summary>
        /// manipulacao da variavel saldo.
        /// </summary>
        /// <value>
        /// The saldo.
        /// </value>
        public int Saldo
        {
            get { return saldo; }
            set
            {
                if(value > 0)
                {
                    saldo = value;
                }
            }
        }
        #endregion

        #region OPERADORES          
        /// <summary>
        /// Redefinição do operador ==.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator == (Cliente a, Cliente b)
        {
            if (a.nif == b.nif)
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator != (Cliente a, Cliente b)
        {
            return !(a == b);
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
            return FichaCliente();
        }
        /// <summary>
        /// Redefinição do metodo equals.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                Cliente c = (Cliente)obj;
                if (this == c)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Retorna o hashcode para a instância.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Metodo para impressão das informações essenciais do cliente.
        /// </summary>
        /// <returns></returns>
        public string FichaCliente()
        {
            return string.Format("Nome:{0}  Contacto:{1}  NIF:{2}", Nome, Contacto, nif);
        }
        /// <summary>
        /// Compara dois clientes.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int CompareTo(Cliente a)
        {
            if (a is null)
                return 1;
            if (nif < a.nif)
                return -1;
            else if (nif > a.nif)
                return 1;
            else
                return 0;
        }
        /// <summary>
        /// Para clonar objetos da classe.
        /// </summary>
        /// <returns></returns>
        public Cliente Clone()
        {
            return new Cliente(Nome, Contacto, Morada, nif, saldo);
        }
        #endregion

        #endregion
    }
}