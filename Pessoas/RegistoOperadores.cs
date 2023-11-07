/*
*	<copyright file="RegistoOperadores" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/2/2023 2:20:36 PM</date>
*	<description></description>
**/
namespace Pessoas
{
    /// <summary>
    /// Classe para registo de operadores existentes.
    /// </summary>
    public class RegistoOperadores
    {
        const int MAXOPERADORES = 5;

        #region ATRIBUTOS
        private int numOperadores;
        private Operador[] listaOperadores;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoOperadores()
        {
            listaOperadores = new Operador[MAXOPERADORES];
            IniciarArrayOperadores(listaOperadores);
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Devolver a array com a lista de operadores existentes.
        /// </summary>
        public Operador[] ObterOperadores
        {
            get { return listaOperadores;}
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Metodo para inicialização de array dos operadores.
        /// </summary>
        /// <param name="o"></param>
        void IniciarArrayOperadores(Operador[] o)
        {
            for (int i = 0; i < o.Length;i++)
            {
                o[i] = new Operador();
            }
        }
        /// <summary>
        /// Metodo para inserir operadores no array.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool InserirOperador(Operador o)
        {
            foreach(Operador a in  listaOperadores)
            {
                if (a.Id == -1)
                    continue;
                if (a.Equals(o) || numOperadores >= MAXOPERADORES) 
                    return false;
            }
            listaOperadores[numOperadores] = o;
            numOperadores++;
            return true;
        }
        /// <summary>
        /// Substitui os operadores existentes por um novo objeto default de operador.
        /// </summary>
        /// <param name="r"></param>
        public bool RemoverOperadores()
        {
            for (int i = 0; i < listaOperadores.Length; i++)
            {
                if (listaOperadores[i] is null)
                    continue;
                else
                    listaOperadores[i] = new Operador();
            }
            return true;
        }
        /// <summary>
        /// Dado um certo objecto do tipo operador, caso exista é removido da array de operadores.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public bool RemoverOperadorEspecifico(Operador o)
        {
            for (int i = 0; i < listaOperadores.Length; i++)
            {
                if (listaOperadores[i].Equals(o))
                {
                    for (int j = i; j < listaOperadores.Length - 1; j++)
                        listaOperadores[j] = listaOperadores[j + 1];
                    listaOperadores[listaOperadores.Length - 1] = new Operador();
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Ordenação da array Operadores com o metodo bubblesort.
        /// </summary>
        /// <returns></returns>
        public void BubbleSortOperadores()
        {
            Operador aux;
            bool a = true;
            while (a)
            {
                a = false;
                for (int i = 0; i < listaOperadores.Length - 1; i++)
                {
                    if (listaOperadores[i].Id > listaOperadores[i + 1].Id)
                    {
                        aux = listaOperadores[i];
                        listaOperadores[i] = listaOperadores[i + 1];
                        listaOperadores[i + 1] = aux;
                        a = true;
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}