﻿/*
*	<copyright file="RegistoProblemas" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 11/20/2023 7:57:30 PM</date>
*	<description></description>
**/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Excecoes;
using ObjetosNegocio;
namespace Dados
{
    /// <summary>
    /// Classe para registo de listaSolucoes conhecidos.
    /// </summary>
    public class RegistoProblemas
    {
        #region ATRIBUTOS
        private static List<ProblemasCon> listaSolucoes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES            
        /// <summary>
        /// Construtor estatico para inicilização da classe.
        /// </summary>
        static RegistoProblemas()
        {
            listaSolucoes = new List<ProblemasCon>();
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoProblemas()
        {

        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve o array de problemas conhecidos.
        /// </summary>
        /// <value>
        /// The obter problemascon.
        /// </value>
        static public List<ProblemasCon> ObterSolucoes
        {
            get { return listaSolucoes.ToList(); }
        }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS        
        /// <summary>
        /// Insere uma solucao.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public static bool InserirSolucaoLista(ProblemasCon p)
        {
            foreach (ProblemasCon aux in listaSolucoes)
            {
                if (aux.Id == -1)
                    continue;
                if (aux.Equals(p))
                    return false;
            }
            listaSolucoes.Add(p);
            return true;
        }
        /// <summary>
        /// Edita uma solucao.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="desc">The desc.</param>
        /// <param name="solucao">The solucao.</param>
        /// <returns></returns>
        public static bool EditarSolucao(ProblemasCon p, int id, string desc, string solucao)
        {
            foreach (ProblemasCon s in listaSolucoes)
            {
                if (s.Id == -1)
                    continue;
                if (s.Equals(p))
                {
                    s.Descricao = desc;
                    s.Id = id;
                    s.Resolucao = solucao;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Grava em ficheiro binário as solucoes existentes.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool GravarFicheiroSolucoes(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, listaSolucoes);
                    ficheiro.Close();
                    return true;
                }
            }
            catch (EscritaFicheiro)
            {
                throw new EscritaFicheiro("Erro ao gravar o ficheiro de solucoes.");
            }
        }
        /// <summary>
        /// Le do ficheiro de solucoes.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool LerFicheiroSolucoes(string nomeFicheiro)
        {
            Stream ficheiro = null;
            try
            {
                if (!File.Exists(nomeFicheiro))
                    return false;
                using (ficheiro = File.Open(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    listaSolucoes = (List<ProblemasCon>)b.Deserialize(ficheiro);
                    ficheiro.Close();
                    return true;
                }
            }
            catch (LeituraFicheiro)
            {
                throw new LeituraFicheiro("Erro ao ler o ficheiro de solucoes.");
            }
        }
        /// <summary>
        /// Dado um id de um tipo de assistência, verifica se existe solução para a mesma
        /// </summary>
        /// <param name="tipoAssistId">The tipo assist identifier.</param>
        /// <param name="problemaInserir">The problema inserir.</param>
        /// <returns></returns>
        public static bool ExisteSolucao(int tipoAssistId, out ProblemasCon problemaInserir)
        {
            foreach(ProblemasCon p in listaSolucoes)
            {
                if (tipoAssistId == p.Id)
                {
                    problemaInserir = p;
                    return true;
                }
            }
            problemaInserir=null;
            return false;
        }
        #endregion

        #endregion
    }
}