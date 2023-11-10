/*
*	<copyright file="RegistoCategorias" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/10/2023 11:12:08 AM</date>
*	<description></description>
**/

using Produtos;
using System.Runtime.ExceptionServices;

namespace Outros
{
    public class RegistoCategorias
    {
        const int MAXCAT = 2;
        #region ATRIBUTOS
        private int numCategorias;
        Categoria[] listaCategorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        public RegistoCategorias()
        {
            listaCategorias= new Categoria[MAXCAT];
            InicializarArrayCategorias(listaCategorias);
        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        void InicializarArrayCategorias(Categoria[] c)
        { 
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = new Categoria();
            }  
        }

        public bool InserirCategoria(string nomeCategoria)
        {
            foreach (Categoria aux in listaCategorias)
            {
                if (aux.NomeCategoria == string.Empty)
                    continue;
                if (aux.NomeCategoria == nomeCategoria|| numCategorias > MAXCAT)
                    return false;
            }
            Categoria c = new Categoria(nomeCategoria);
            listaCategorias[numCategorias] = c;
            numCategorias++;
            return true;
        }
        #endregion

        #endregion
    }
}