/*
*	<copyright file="RegistoAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 10/30/2023 1:26:01 PM</date>
*	<description></description>
**/
using Interfaces;
using Outros;
using Pessoas;
using System;
using System.Collections;
namespace Assistencia
{
    /// <summary>
    /// Classe para registar assistências.
    /// </summary>
    public class RegistoAssist : IRegistoAssist
    {
        const int MAXASSISTENCIAS = 5;

        #region ATRIBUTOS
        private int numAssist;
        private Assist[] listaAssistencias;
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
        }
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public RegistoAssist()
        {
            listaAssistencias = new Assist[MAXASSISTENCIAS];
            IniciarArrayRegisto();
        }

        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Devolve a array de todas as assistências.
        /// </summary>
        /// <value>
        /// The todas assistencias.
        /// </value>
        public Assist[] ObterAssistencias
        {
            get { return (Assist[])listaAssistencias.Clone(); }
        }
        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Metodo para inicialização da array.
        /// </summary>
        /// <param name="a"></param>
        void IniciarArrayRegisto()
        {
            for (int i = 0; i < listaAssistencias.Length;i++)
            {
                listaAssistencias[i] = new Assist();
            }
        }
        /// <summary>
        /// Insere uma assistencia na array.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public bool InsereAssistArray(Assist a)
        {
            foreach (Assist b in listaAssistencias)
            {
                if (b.Id == -1)
                    continue;
                if (b.Equals(a) || (numAssist>=MAXASSISTENCIAS))
                    return false;
            }
            listaAssistencias[numAssist] = a;
            numAssist++;
            return true;
        }
        /// <summary>
        /// Insere um cliente numa assistencia.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="listaClientes">The lista clientes.</param>
        /// <returns></returns>
        public bool InsereClienteAssist(Assist a, Cliente[] listaClientes)
        {
            foreach(Assist b in listaAssistencias)
            {
                if (ReferenceEquals(b,null)||b.Id == -1)
                    continue;
                if(b.Id == a.Id)
                    foreach (Cliente c in listaClientes)
                    {
                        if (ReferenceEquals(c,null) ||c.NIF == -1)
                            continue;
                        if (b.ClienteNIF == c.NIF)
                        {
                            b.Cliente = c;
                            return true;
                        }
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
        public bool InsereOperadorAssist(Assist a, Operador[] listaOperadores)
        {
            foreach(Assist b in listaAssistencias)
            {
                if (ReferenceEquals(b, null) || b.Id == -1)
                    continue;
                if (b.Id == a.Id)
                    foreach (Operador o in listaOperadores)
                    {
                        if (ReferenceEquals(o, null) || o.Id == -1)
                            continue;
                        if (b.OperadorId == o.Id)
                        {
                            b.Operador = o;
                            return true;
                        }
                    }
            }
            return false;
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
                    listaAssistencias[i] = null;
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
                    listaAssistencias[listaAssistencias.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Organiza a array de assistencias conforme o ID da assistência.
        /// </summary>
        public void BubbleSortAssistencias()
        {
            Assist aux;
            bool a = true;
            while (a)
            {
                a = false;
                for (int i = 0; i < listaAssistencias.Length - 1; i++)
                {
                    if (ReferenceEquals(listaAssistencias[i], null)||listaAssistencias[i].Id > listaAssistencias[i + 1].Id)
                    {
                        aux = listaAssistencias[i];
                        listaAssistencias[i] = listaAssistencias[i + 1];
                        listaAssistencias[i + 1] = aux;
                        a = true;
                    }
                }
            }
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
            return assistenciasRealizadas;
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

        #endregion

        #endregion
    }
}