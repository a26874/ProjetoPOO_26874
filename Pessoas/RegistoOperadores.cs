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
        #endregion

        #endregion
    }
}