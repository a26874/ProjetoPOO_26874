/*
*	<copyright file="RegistoProdutos" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 10:09:25 AM</date>
*	<description></description>
**/


using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

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
        private List<Produto> listaProdutos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoProdutos()
        {
            listaProdutos = new List<Produto>();
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Retorna a array de produtos.
        /// </summary>
        public List<Produto> ObterProdutos
        {
            get { return listaProdutos.ToList(); }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
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
            listaProdutos.Add(p);
            numProdutos++;
            return true;
        }
        /// <summary>
        /// Remove todos os produtos do array.
        /// </summary>
        /// <returns></returns>
        public bool RemoverProdutos()
        {
            listaProdutos.Clear();
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
            if (listaProdutos.Remove(p))
                return true;
            return false;
        }
        /// <summary>
        /// Retorna o numero de produtos existentes.
        /// </summary>
        /// <returns></returns>
        public int NumeroProdutosExistentes()
        {
            return listaProdutos.Count;
        }
        /// <summary>
        /// Grava em ficheiro binário os produtos.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public bool GravarFicheiroProdutos(string nomeFicheiro)
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
                b.Serialize(ficheiro, listaProdutos);
                ficheiro.Close();
                return true;
            }
        }
        /// <summary>
        /// Le do ficheiro Produtos, todos os produtos.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public bool LerFicheiroProdutos(string nomeFicheiro)
        {
            Stream ficheiro = null;
            if (!File.Exists(nomeFicheiro))
                return false;
            else
            {
                ficheiro = File.Open(nomeFicheiro, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                listaProdutos = (List<Produto>)b.Deserialize(ficheiro);
                ficheiro.Close();
                return true;
            }
        }
        #endregion

        #endregion
    }
}