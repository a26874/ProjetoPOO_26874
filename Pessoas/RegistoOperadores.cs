/*
*	<copyright file="RegistoOperadores" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/2/2023 2:20:36 PM</date>
*	<description></description>
**/
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pessoas
{
    [Serializable]
    /// <summary>
    /// Classe para registo de operadores existentes.
    /// </summary>
    public class RegistoOperadores
    {
        const int MAXOPERADORES = 5;

        #region ATRIBUTOS
        private int numOperadores;
        private Operador[] listaOperadores;
        private static int numeroOperadoresExistentes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Inicializa a <see cref="RegistoOperadores"/> classe.
        /// </summary>
        static RegistoOperadores()
        {
            numeroOperadoresExistentes = 0;
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoOperadores()
        {
            listaOperadores = new Operador[MAXOPERADORES];
            IniciarArrayOperadores();
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Devolver a array com a lista de operadores existentes.
        /// </summary>
        public Operador[] ObterOperadores
        {
            get { return (Operador[])listaOperadores.Clone();}
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
        void IniciarArrayOperadores()
        {
            for (int i = 0; i < listaOperadores.Length;i++)
            {
                listaOperadores[i] = new Operador();
            }
        }
        /// <summary>
        /// Metodo para inserir operadores no array.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool InsereOperador(Operador o)
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
            numeroOperadoresExistentes++;
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
                    listaOperadores[i] = null;
            }
            numeroOperadoresExistentes = 0;
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
                    listaOperadores[listaOperadores.Length - 1] = null;
                    numeroOperadoresExistentes--;
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
                    if (ReferenceEquals(listaOperadores[i + 1], null))
                        continue;
                    if (listaOperadores[i].Id > listaOperadores[i + 1].Id && listaOperadores[i+1].Id != -1)
                    {
                        aux = listaOperadores[i];
                        listaOperadores[i] = listaOperadores[i + 1];
                        listaOperadores[i + 1] = aux;
                        a = true;
                    }
                }
            }
        }
        /// <summary>
        /// Retorna o numero de operadores existentes.
        /// </summary>
        /// <returns></returns>
        public int NumeroOperadoresExistentes()
        {
            return numeroOperadoresExistentes;
        }
        /// <summary>
        /// Verifica se existe um operador.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="operadorInserir">The operador inserir.</param>
        /// <returns></returns>
        public bool ExisteOperador(int id, out Operador operadorInserir)
        {
            foreach (Operador o in listaOperadores)
            {
                if (ReferenceEquals(o, null))
                    continue;
                if (o.Id == id)
                {
                    operadorInserir = o;
                    return true;
                }
            }
            operadorInserir = null;
            return false;
        }
        /// <summary>
        /// Grava o ficheiro com os operadores existentes.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public bool GravarFicheiroOperadores(string nomeFicheiro)
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
                b.Serialize(ficheiro, listaOperadores);
                ficheiro.Close();
                return true;
            }
        }
        /// <summary>
        /// Le o ficheiro de operadores.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public bool LerFicheiroOperadores(string nomeFicheiro)
        {
            Stream ficheiro = null;
            if (!File.Exists(nomeFicheiro))
                return false;
            else
            {
                ficheiro = File.Open(nomeFicheiro, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                listaOperadores= (Operador[])b.Deserialize(ficheiro);
                ficheiro.Close();
                return true;
            }
        }
        #endregion

        #endregion
    }
}