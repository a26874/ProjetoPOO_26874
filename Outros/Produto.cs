/*
*	<copyright file="Produto" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:09:10 PM</date>
*	<description></description>
**/

using Outros;

namespace Produtos
{
    /// <summary>
    /// Classe para descrever um produto.
    /// </summary>
    public class Produto
    {
        const int MAXCATEGORIA = 2;

        #region ATRIBUTOS
        private string nome;
        private int id;
        private int preco;
        private string descricao;
        Categoria categorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public Produto()
        {
            nome = string.Empty;
            id = 0;
            preco = 0;
            descricao = string.Empty;
            categorias = new Categoria();
        }
        /// <summary>
        /// Construtor com todos os parametros.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="i">The i.</param>
        /// <param name="p">The p.</param>
        /// <param name="d">The d.</param>
        public Produto(string n, int i, int p, string d, Categoria categoria)
        {
            nome = n;
            id = i;
            preco = p;
            descricao = d;
            categorias = categoria;
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
        public Categoria NomeCategoria
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
            return string.Format("Nome:{0}\nID:{1}\nPreco:{2}\nDescricao:{3}\n{4}", nome, id, preco, descricao, categorias.FichaCategoria());
        }
        #endregion

        #endregion
    }
}