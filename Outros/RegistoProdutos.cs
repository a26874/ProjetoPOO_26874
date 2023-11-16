/*
*	<copyright file="RegistoProdutos" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 10:09:25 AM</date>
*	<description></description>
**/

using Produtos;

namespace Outros
{
    /// <summary>
    /// Classe para registo de produtos.
    /// </summary>
    public class RegistoProdutos
    {
        const int MAXPRODUTOS = 5;
        #region ATRIBUTOS
        private int numProdutos;
        Produto[] listaProdutos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        public RegistoProdutos()
        {
            listaProdutos = new Produto[MAXPRODUTOS];
            InicializarArrayProdutos(listaProdutos);
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Retorna a array de produtos.
        /// </summary>
        public Produto[] ObterProdutos
        {
            get { return (Produto[])listaProdutos.Clone(); }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Inicializar array de produtos.
        /// </summary>
        /// <param name="p"></param>
        void InicializarArrayProdutos(Produto[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Produto();
            }
        }
        /// <summary>
        /// Inserir um novo produto na array de produtos.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool InserirProduto(Produto p)
        {
            foreach (Produto aux in listaProdutos)
            {
                if (p.Id == -1)
                    continue;
                if (aux.Equals(p) || numProdutos > MAXPRODUTOS)
                    return false;
            }
            listaProdutos[numProdutos] = p;
            numProdutos++;
            return true;
        }
        #endregion

        #endregion
    }
}