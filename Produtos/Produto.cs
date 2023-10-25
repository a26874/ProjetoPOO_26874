/*
*	<copyright file="Produto" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/25/2023 6:09:10 PM</date>
*	<description></description>
**/

namespace Produtos
{
    public class Produto
    {
        #region ATRIBUTOS
        private string nome;
        private int id;
        private int preco;
        private string descricao;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        public Produto()
        {
            nome = string.Empty;
            id = 0;
            preco = 0;
            descricao = string.Empty;
        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}