/*
*	<copyright file="RegistoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/30/2023 1:26:01 PM</date>
*	<description></description>
**/
using Assistencia;
using Pessoas;

namespace RegistoAssistencias
{
    public class RegistoAssist
    {
        const int MAXASSISTENCIAS = 5;
        #region ATRIBUTOS
        private int numAssist;
        private Assist[] listaAssistencias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoAssist()
        {
            listaAssistencias = new Assist[MAXASSISTENCIAS];
            IniciarArrayRegisto(listaAssistencias);
        }
        /// <summary>
        /// Construtor por parametros.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="c"></param>
        /// <param name="o"></param>
        /// <param name="a"></param>

        #endregion

        #region PROPRIEDADES
        public Assist[] TodasAssistencias
        {
            get { return listaAssistencias; }
        }
        #endregion

        #region OVERRIDES
        
        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Metodo para inicialização da array.
        /// </summary>
        /// <param name="a"></param>
        void IniciarArrayRegisto(Assist[] a)
        {
            for (int i = 0; i < a.Length;i++)
            {
                a[i] = new Assist();
            }
        }
        /// <summary>
        /// Metodo para a inserção de uma nova assistência na array de registos.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool InsereAssist(Assist a)
        {
            //Verificar se a já existe!!! && se existe espaço
            foreach (Assist aux in listaAssistencias)
            {
                if (aux.Id == -1)
                    continue;
                if (aux.Equals(a) || (numAssist >= MAXASSISTENCIAS))
                    return false;
            }
            listaAssistencias[numAssist] = a;
            numAssist++;
            return true;
        }
        /// <summary>
        /// Substitui as assistências existentes por novos objetos do tipo assist.
        /// </summary>
        /// <param name="r"></param>
        public bool RemoverAssistencias()
        {
            for (int i = 0; i < listaAssistencias.Length; i++)
            {
                if (listaAssistencias[i] is null)
                    continue;
                else
                    listaAssistencias[i] = new Assist();
            }
            return true;
        }
        /// <summary>
        /// Dada uma certa assistencia essa mesma é removida da array de assitências.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public bool RemoverAssistenciaEspecifica(Assist a)
        {
            for (int i = 0; i < listaAssistencias.Length; i++)
            {
                if (listaAssistencias[i].Equals(a))
                {
                    for (int j = i; j < listaAssistencias.Length - 1; j++)
                        listaAssistencias[j] = listaAssistencias[j + 1];
                    listaAssistencias[listaAssistencias.Length - 1] = new Assist();
                    return true;
                }
            }
            return false;
        }
        #endregion

        #endregion
    }
}