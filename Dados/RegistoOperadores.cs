/*
*	<copyright file="RegistoOperadores" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/2/2023 2:20:36 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Excecoes;
using ObjetosNegocio;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Classe para registo de operadores existentes.
    /// </summary>
    public class RegistoOperadores 
    {
        #region ATRIBUTOS
        private static int numOperadores;
        private static List<Operador> listaOperadores;
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
            listaOperadores = new List<Operador>();
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoOperadores()
        {
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Devolver a array com a lista de operadores existentes.
        /// </summary>
        public List<Operador> ObterOperadores
        {
            get { return listaOperadores.ToList();}
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Metodo para inserir operadores no array.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static bool InsereOperadorLista(Operador o)
        {
            foreach(Operador a in  listaOperadores)
            {
                if (a.Id == -1)
                    continue;
                if (a.Equals(o))
                    throw new OperadorException("O operador ja existe ");
            }
            listaOperadores.Add(o);
            numOperadores++;
            numeroOperadoresExistentes++;
            return true;
        }
        /// <summary>
        /// Remove os operadores.
        /// </summary>
        /// <returns></returns>
        public bool RemoverOperadores()
        {
            listaOperadores.Clear();
            numeroOperadoresExistentes = 0;
            numOperadores = 0;
            return true;
        }
        /// <summary>
        /// Remove o operador especificado da lista de operadores.
        /// </summary>
        /// <param name="o">The o.</param>
        /// <returns></returns>
        public bool RemoverOperadorEspecifico(Operador o)
        {
            if (listaOperadores.Remove(o))
                return true;
            return false;
        }
        /// <summary>
        /// Ordenação da lista de Operadores.
        /// </summary>
        public void OrdenarOperadores()
        {
            //listaOperadores.Sort((o1,o2)=>o1.Id.CompareTo(o2.Id));
            listaOperadores.Sort();
        }
        /// <summary>
        /// Retorna o numero de operadores existentes.
        /// </summary>
        /// <returns></returns>
        public int NumeroOperadoresExistentes()
        {
            return listaOperadores.Count;
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
                listaOperadores = (List<Operador>)b.Deserialize(ficheiro);
                ficheiro.Close();
                return true;
            }
        }
        /// <summary>
        /// Dado um id de um operador, verifica se ele existe na lista de operadores.
        /// </summary>
        /// <param name="opId">The op identifier.</param>
        /// <param name="operadorInserir">The operador inserir.</param>
        /// <returns></returns>
        public static bool ExisteOperador(int opId, out Operador operadorInserir)
        {
            foreach(Operador o in listaOperadores)
            {
                if (o.Id == opId)
                {
                    operadorInserir = o;
                    return true;
                }
            }
            operadorInserir = null;
            return false;
        }
        #endregion

        #endregion
    }
}