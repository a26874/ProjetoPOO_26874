/*
*	<copyright file="RegistoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/30/2023 1:26:01 PM</date>
*	<description></description>
**/
using Assistencia;

namespace RegistoAssistencias
{
    public class RegistoAssist
    {
        const int MAXASSISTENCIAS = 5;
        #region ATRIBUTOS
        private int numAssist;
        private static int idRegisto; 
        private Assist[] assistencias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoAssist()
        {
            idRegisto = -1;
            assistencias = new Assist[MAXASSISTENCIAS];
            IniciarArrayRegisto(assistencias);
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
            get { return assistencias; }
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
            assistencias[numAssist] = a;
            numAssist++;
            return true;
        }
        /// <summary>
        /// Metodo para remoção de assistencias.
        /// </summary>
        /// <param name="r"></param>
        public bool RemoverAssistencias()
        {
            for (int i = 0; i < assistencias.Length; i++)
            {
                if (assistencias[i] is null)
                    continue;
                else
                    assistencias[i] = null;
            }
            return true;
        }
        #endregion

        #endregion
    }
}