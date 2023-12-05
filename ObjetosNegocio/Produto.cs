/*
*	<copyright file="Produto" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:09:10 PM</date>
*	<description></description>
**/

using System;
using System.Collections.Generic;
using Outros;

namespace ObjetosNegocio
{
    [Serializable]
    /// <summary>
    /// Classe para descrever um produto.
    /// </summary>
    public class Produto : IComparable<Produto>
    {
        #region ATRIBUTOS
        private string nome;
        private int id;
        private static int contIdProduto;
        private int preco;
        private string descricao;
        List<Categoria> categorias; 
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES     
        static Produto()
        {
            contIdProduto = 1;
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public Produto()
        {
            nome = string.Empty;
            id = 0;
            preco = 0;
            descricao = string.Empty;
        }
        /// <summary>
        /// Construtor com todos os parametros.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="i">The i.</param>
        /// <param name="p">The p.</param>
        /// <param name="d">The d.</param>
        public Produto(string n, int p, string d)
        {
            id = contIdProduto;
            if (id >= 1)
                id = contIdProduto++;
            nome = n;
            preco = p;
            descricao = d;
        }
        protected Produto(string nome, int id, int preco, string descricao, List<Categoria> categorias)
        {
            this.nome = nome;
            this.id = id;
            this.preco = preco;
            this.descricao = descricao;
            this.categorias = categorias;
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Manipulacao da variavel Nome.
        /// </summary>
        /// <value>
        /// The nome.
        /// </value>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Manipulacao da variavel Id.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Manipulacao da variavel Preco.
        /// </summary>
        /// <value>
        /// The preco.
        /// </value>
        public int Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        /// <summary>
        /// Manipulacao da variavel Descricao.
        /// </summary>
        /// <value>
        /// The descricao.
        /// </value>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        /// <summary>
        /// Manipulacao da variavel NomeCategoria.
        /// </summary>
        public List<Categoria> Categorias
        {
            get { return categorias; }
            set { categorias = value; }
        }
        #endregion

        #region OPERADORES

        /// <summary>
        /// Redefinição do operador ==.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Produto a, Produto b)
        {
            if ((a.id == b.id) && (a.descricao == b.descricao))
                return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Produto a, Produto b)
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
            return FichaProduto();
        }
        /// <summary>
        /// Determinar se um tipo de objeto Produto é igual a outro.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Produto)
            {
                Produto p = (Produto)obj;
                if (this == p)
                    return true;
            }
            return false;
        }
        //Ainda por fazer
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Metodo para impressao da ficha de um produto.
        /// </summary>
        /// <returns></returns>
        public string FichaProduto()
        {
            return string.Format("Nome:{0}\nID:{1}\nPreco:{2}\nDescricao:{3}", nome, id, preco, descricao);
        }
        /// <summary>
        /// Compara produtos a partir do seu ID.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public int CompareTo(Produto p)
        {
            if (p is null)
                return 1;
            if (id< p.id)
                return -1;
            else if (id > p.id)
                return 1;
            else
                return 0;
        }
        /// <summary>
        /// Para clonar objetos da classe.
        /// </summary>
        /// <returns></returns>
        public Produto Clone()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            foreach (Categoria c in categorias)
            {
                Categoria clone = c.Clone();
                listaCategorias.Add(clone);
            }
            return new Produto(nome, id, preco, descricao, listaCategorias);
        }
        #endregion

        #endregion
    }
}