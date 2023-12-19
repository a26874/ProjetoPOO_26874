/*
*	<copyright file="RegistoCategorias" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 11:12:08 AM</date>
*	<description></description>
**/


using System.Collections.Generic;
using System.IO;
using System.Linq;
using Excecoes;
using System.Runtime.Serialization.Formatters.Binary;
using Outros;

namespace Dados
{
    /// <summary>
    /// Classe para registo de categorias.
    /// </summary>
    public class RegistoCategorias
    {
        #region ATRIBUTOS
        private static List<Categoria> listaCategorias;
        private List<Categoria> categorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor para inicializar um novo registo de categorias.
        /// </summary>
        static RegistoCategorias()
        {
            listaCategorias = new List<Categoria>();
        }
        public RegistoCategorias()
        {
            categorias = new List<Categoria>();
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve as categorias de um produto.
        /// </summary>
        /// <value>
        /// The obter categorias.
        /// </value>
        public List<Categoria> ObterCategorias
        {
            get { return listaCategorias.ToList(); }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Insere uma categoria.
        /// </summary>
        /// <param name="nomeCategoria">The nome categoria.</param>
        /// <returns></returns>
        public static bool InserirCategoria(string nomeCategoria, int idProd)
        {
            foreach (Categoria aux in listaCategorias)
            {
                if (aux.NomeCategoria == string.Empty)
                    continue;
                if (aux.NomeCategoria == nomeCategoria)
                    return false;
            }
            Categoria c = new Categoria(nomeCategoria, idProd);
            listaCategorias.Add(c);
            return true;
        }
        /// <summary>
        /// Verifica se existe categorias para um produto.
        /// </summary>
        /// <param name="idProduto">The identifier produto.</param>
        /// <param name="categoriasInserir">The categorias inserir.</param>
        /// <returns></returns>
        public static bool ExisteCategoriasProduto(int idProduto, out List<Categoria> categoriasInserir)
        {
            categoriasInserir = new List<Categoria>();
            foreach(Categoria c in listaCategorias)
            {
                if (c.IdProduto == idProduto)
                {
                    categoriasInserir.Add(c);
                }
            }
            if (categoriasInserir.Count > 0)
                return true;
            categoriasInserir = null;
            return false;
        }
        /// <summary>
        /// Grava todas as categorias.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        /// <exception cref="EscritaFicheiro"></exception>
        public static bool GravarFicheiroCategorias(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, listaCategorias);
                    ficheiro.Close();
                    return true;
                }
            }
            catch (EscritaFicheiro)
            {
                throw new EscritaFicheiro("Erro ao gravar o ficheiro de categorias.");
            }
        }
        /// <summary>
        /// Lê tudo acerca de categorias.   
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        /// <exception cref="LeituraFicheiro"></exception>
        public static bool LerFicheiroCategorias(string nomeFicheiro)
        {
            Stream ficheiro = null;
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;
                using (ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    listaCategorias = (List<Categoria>)b.Deserialize(ficheiro);
                    ficheiro.Close();
                    return true;
                }
            }
            catch (LeituraFicheiro)
            {
                throw new LeituraFicheiro("Erro ao ler o ficheiro de categorias.");
            }
        }
        #endregion

        #endregion
    }
}