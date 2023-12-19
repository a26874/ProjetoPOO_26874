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
        private static List<Operador> listaOperadores;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Inicializa a <see cref="RegistoOperadores"/> classe.
        /// </summary>
        static RegistoOperadores()
        {
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
                    throw new OperadorException("O operador ja existe "); // Enquanto deveria retornar false, pois é algo que é possivel controlar, decidi usar exceção para conseguir 
                                                                          // Explorar melhor a classe de exceções
            }
            listaOperadores.Add(o);
            listaOperadores.Sort();
            return true;
        }
        /// <summary>
        /// Remove os operadores.
        /// </summary>
        /// <returns></returns>
        public bool RemoverOperadores()
        {
            listaOperadores.Clear();
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
        public static bool GravarFicheiroOperadores(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, listaOperadores);
                    ficheiro.Close();
                    return true;
                }
            }
            catch (EscritaFicheiro)
            {
                throw new EscritaFicheiro("Erro ao gravar o ficheiro de operadores.");
            }
        }
        /// <summary>
        /// Le o ficheiro de operadores.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool LerFicheiroOperadores(string nomeFicheiro)
        {
            Stream ficheiro = null;
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;
                using (ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    listaOperadores = (List<Operador>)b.Deserialize(ficheiro);
                    ficheiro.Close();
                    return true;
                }
            }
            catch (LeituraFicheiro)
            {
                throw new LeituraFicheiro("Erro ao ler o ficheiro de operadores.");
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