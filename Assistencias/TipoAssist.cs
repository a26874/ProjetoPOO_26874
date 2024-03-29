﻿/*
*	<copyright file="TipoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:03:03 PM</date>
*	<description></description>
**/
using System;

namespace Assistencia
{
    [Serializable]
    /// <summary>
    /// Classe para o tipo de assistência.
    /// </summary>
    public class TipoAssist
    {
        #region ATRIBUTOS
        // Atendimento = 1; Entregas = 2; Manutencao = 3; Assistência = 4;
        private string desc;
        private string nomeTipo;
        private int id;
        private int preco;
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
            id = -1;
            preco = -1;
        }
        /// <summary>
        /// Construtor para tipos de assistência.
        /// </summary>
        /// <param name="desc">The desc.</param>
        /// <param name="nomeTipo">The nome tipo.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="preco">The preco.</param>
        public TipoAssist(string desc, string nomeTipo, int id, int preco)
        {
            this.desc = desc;
            this.nomeTipo = nomeTipo;
            this.id = id;
            this.preco = preco;
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
                if (value > 0)
                    id = value;
            }
            get { return id; }
        }
        /// <summary>
        /// Manipulacao da variavel preco.
        /// </summary>
        public int Preco
        {
            get { return preco; }
            set 
            {
                if (value > 0) preco = value;
            }
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
            return FichaTipoAssist();
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
        /// <summary>
        /// Retorna o hashcode para desta instância.
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
        /// Reformulação do metodo ToString na classe Assist.
        /// </summary>
        /// <returns></returns>
        public string FichaTipoAssist()
        {
            return string.Format("Descricao:{0} Tipo:{1} ID:{2} Preco:{3} ", desc, nomeTipo, id, preco);
        }
        /// <summary>
        /// Para clonar objetos da classe.
        /// </summary>
        /// <returns></returns>
        public TipoAssist Clone()
        {
            return new TipoAssist(desc,nomeTipo, id, preco);
        }
        #endregion

        #endregion
    }
}