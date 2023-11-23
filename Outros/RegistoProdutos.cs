/*
*	<copyright file="RegistoProdutos" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 10:09:25 AM</date>
*	<description></description>
**/


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
            InicializarArrayProdutos();
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
        void InicializarArrayProdutos()
        {
            for (int i = 0; i < listaProdutos.Length; i++)
            {
                listaProdutos[i] = new Produto();
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
        /// <summary>
        /// Remove todos os produtos do array.
        /// </summary>
        /// <returns></returns>
        public bool RemoverProdutos()
        {
            for (int i = 0; i <  listaProdutos.Length; i++)
            {
                if (listaProdutos[i] is null)
                    continue;
                else
                {
                    listaProdutos[i] = null;
                }
            }
            numProdutos = 0;
            return true;
        }
        /// <summary>
        /// Remove um produto especifico.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public bool RemoverProdutoEspecifico(Produto p)
        {
            for (int i = 0; i < listaProdutos.Length; i++)
            {
                if (listaProdutos[i].Equals(p))
                {
                    for (int j = i; j < listaProdutos.Length - 1; j++)
                        listaProdutos[j] = listaProdutos[j + 1];
                    listaProdutos[listaProdutos.Length - 1] = null;
                    numProdutos--;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Retorna o numero de produtos existentes.
        /// </summary>
        /// <returns></returns>
        public int NumeroProdutosExistentes()
        {
            return numProdutos;
        }

        #endregion

        #endregion
    }
}