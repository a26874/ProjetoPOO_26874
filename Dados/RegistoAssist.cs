/*
*	<copyright file="RegistoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/30/2023 1:26:01 PM</date>
*	<description></description>
**/

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using ObjetosNegocio;
using Outros;
using Excecoes;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Classe para registar assistências.
    /// </summary>
    public class RegistoAssist /*: IRegistoAssist*/
    {

        #region ATRIBUTOS
        private static int numAssist;
        private static List<Assist> listaAssistencias;
        private static int assistenciasRealizadas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Inicializa <see cref="RegistoAssist"/> classe.
        /// </summary>
        static RegistoAssist()
        {
            assistenciasRealizadas = 0;
            listaAssistencias = new List<Assist>();
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoAssist()
        {

        }

        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve uma copia da lista de assistencias.
        /// </summary>
        /// <value>
        /// The todas assistencias.
        /// </value>
        public List<Assist> ObterAssistencias
        {
            get { return listaAssistencias.ToList(); }
        }

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Insere na list de assists.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public static bool InsereAssistLista(Assist a)
        {
            foreach(Assist b in listaAssistencias)
            {
                if (b.Id == -1)
                    continue;
                if (b.Equals(a))
                    return false;
            }
            listaAssistencias.Add(a);
            numAssist++;
            return true;
        }
        /// <summary>
        /// Insere um cliente numa assistencia.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="listaClientes">The lista clientes.</param>
        /// <returns></returns>
        public static bool InsereClienteAssistLista(Assist a, Cliente c)
        {
            foreach(Assist b in listaAssistencias)
            {
                if (ReferenceEquals(b,null)||b.Id == -1)
                    continue;

                if ((ReferenceEquals(b.Cliente, null) || b.Cliente == c) && !ReferenceEquals(a.Cliente, null))
                    throw new ClienteException("Ja existe cliente nesta assistencia");
                if (b.Id == a.Id && a.ClienteNIF == c.NIF)
                {
                    b.Cliente = c;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Insere um operador numa assistência.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="listaOperadores">The lista operadores.</param>
        /// <returns></returns>
        public static bool InsereOperadorAssistLista(Assist a, Operador o)
        {
            foreach (Assist b in listaAssistencias)
            {
                if (ReferenceEquals(b, null) || b.Id == -1)
                    continue;
                if ((ReferenceEquals(b.Operador, null) || b.Operador == o) && !ReferenceEquals(a.Operador, null))
                    throw new OperadorException("Ja existe operador nesta assitencia");
                if (b.Id == a.Id && a.OperadorId == o.Id)
                {
                    b.Operador = o;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Remove todas as assistencias da lista de assitencias.
        /// </summary>
        /// <returns></returns>
        public bool RemoverAssistencias()
        {
            listaAssistencias.Clear();
            numAssist = 0;
            return true;
        }
        /// <summary>
        /// Dada uma certa assistencia essa mesma é removida da lista de assistencias.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public bool RemoverAssistenciaEspecifica(Assist a)
        {
            if (listaAssistencias.Remove(a))
                return true;
            return false;
        }
        /// <summary>
        /// Ordena as assistencias.
        /// </summary>
        public void OrdenarAssistencias()
        {
            //Perguntar professor.
            //listaAssistencias.Sort((a1,a2) => a1.Id.CompareTo(a2.Id));

            listaAssistencias.Sort();
        }
        /// <summary>
        /// Conclui uma assistência.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public bool ConcluirAssistencia(Assist a)
        {
            foreach(Assist b in listaAssistencias)
            {
                if (ReferenceEquals(b,null) || b.Id == -1)
                    continue;
                if(b.Equals(a))
                {
                    if (b.estadoA.Ativo == false)
                        return false;
                    b.estadoA.Ativo = false;
                    b.estadoA.DescEstado = "Completado";
                    assistenciasRealizadas++;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Retorna o numero de assistencias realizadas.
        /// </summary>
        /// <returns></returns>
        public int MostrarAssistenciasRealizadas()
        {
            return listaAssistencias.Count;
        }
        /// <summary>
        /// Registar avaliacao de uma assistencia.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="cls">The CLS.</param>
        /// <returns></returns>
        public bool RegistoAvaliacao(Assist a, Avaliacao cls)
        {
            foreach (Assist b in listaAssistencias)
            {
                if (ReferenceEquals(b,null) || b.Id == -1)
                    continue;
                if (b.Equals(a))
                {
                    if (b.Classificacao.Pontuacao == -1)
                    {
                        b.Classificacao = cls;
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Grava em ficheiro binario todas as assistencias.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        public bool GravarFicheiroAssistencias(string nomeFicheiro)
        {
            try
            {
                using (Stream ficheiro = File.Open(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(ficheiro, listaAssistencias);
                    ficheiro.Close();
                }
            }
            catch (EscritaFicheiroAssistException e)
            {
                throw new EscritaFicheiroAssistException("Erro ao gravar o ficheiro." + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
                return false;
            }
            return true;

            //Stream ficheiro = null;

            //if (!File.Exists(nomeFicheiro))
            //    ficheiro = File.Open(nomeFicheiro, FileMode.Create);
            //else
            //    ficheiro = File.Open(nomeFicheiro, FileMode.Open);
            //if (ficheiro == null)
            //    return false;
            //else
            //{
            //    BinaryFormatter b = new BinaryFormatter();
            //    b.Serialize(ficheiro, listaAssistencias);
            //    ficheiro.Close();
            //    return true;
            //}
        }
        /// <summary>
        /// Lê o ficheiro assistencias.
        /// </summary>
        /// <param name="nomeFicheiro">The nome ficheiro.</param>
        /// <returns></returns>
        public bool LerFicheiroAssistencia(string nomeFicheiro)
        {
            Stream ficheiro = null;
            if (!File.Exists(nomeFicheiro))
                return false;
            else
            {
                ficheiro = File.Open(nomeFicheiro, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                listaAssistencias = (List<Assist>)b.Deserialize(ficheiro);
                ficheiro.Close();
                return true;
            }
        }

        public static bool MostrarListaAssistencias()
        {
            if (listaAssistencias.Count == 0) return false;
            foreach(Assist a in listaAssistencias)
            {
                Console.WriteLine(a.ToString());
            }
            return true;
        }
        #endregion

        #endregion
    }
}