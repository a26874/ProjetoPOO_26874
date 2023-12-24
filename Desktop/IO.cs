/*
*	<copyright file="IO" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 12/23/2023 10:53:41 PM</date>
*	<description></description>
**/

using Dados;
using ObjetosNegocio;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System;
using RegrasNegocio;

namespace Desktop
{
    public class IO
    {
        #region ATRIBUTOS

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES        
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public IO()
        {

        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Mostra todas as assistências.
        /// </summary>
        public static ListView ListViewTodasAssistencias(ListView listViewAux)
        {
            listViewAux.View = View.Details;
            List<Assist> auxAssist = RegrasDeNegocio.MostrarTodasAssistencias();
            Type tipoDados = typeof(Assist);
            foreach (PropertyInfo p in tipoDados.GetProperties())
            {
                if (p.Name == "Cliente" || p.Name == "Operador")
                    continue;
                listViewAux.Columns.Add(p.Name, -1);
            }
            foreach (Assist a in auxAssist)
            {
                ListViewItem itemAdicionar = new ListViewItem(a.Id.ToString());
                itemAdicionar.SubItems.Add(a.Data.ToString());
                string tipoAssistComId = "IDTipo:" + a.TipoAssistencia.Id.ToString() + " - " + a.TipoAssistencia.NomeTipo.ToString();
                itemAdicionar.SubItems.Add(tipoAssistComId);
                itemAdicionar.SubItems.Add(a.EstadoAssistencia.DescEstado.ToString());
                itemAdicionar.SubItems.Add(a.ClienteNIF.ToString());
                itemAdicionar.SubItems.Add(a.OperadorId.ToString());
                if (a.Classificacao.Pontuacao != -1)
                {
                    string classificacaoComData = "Data:" + a.Classificacao.Data.ToString() + " - " + "Pontuacao:" + a.Classificacao.Pontuacao.ToString();
                    itemAdicionar.SubItems.Add(classificacaoComData);
                }
                else
                    itemAdicionar.SubItems.Add("Não contem classificação !!");
                if (a.Solucao.Id != -1)
                    itemAdicionar.SubItems.Add("Solução:" + a.Solucao.Resolucao.ToString());
                else
                    itemAdicionar.SubItems.Add("Não contem solução !!");
                listViewAux.Items.Add(itemAdicionar);
            }
            listViewAux.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            return listViewAux;
        }
        /// <summary>
        /// Mostra todas as assistências por concluir.
        /// </summary>
        /// <param name="listViewAux">The list view aux.</param>
        /// <returns></returns>
        public static ListView ListViewAssistConcluidas(ListView listViewAux)
        {
            listViewAux.View = View.Details;

            List<Assist> assistConcluidas = RegrasDeNegocio.MostrarAssistenciasConcluidas();
            Type tipoDados = typeof(Assist);
            foreach (PropertyInfo p in tipoDados.GetProperties())
            {
                if (p.Name == "Cliente" || p.Name == "Operador")
                    continue;
                listViewAux.Columns.Add(p.Name, -1);
            }
            foreach (Assist a in assistConcluidas)
            {
                if (a.EstadoAssistencia.Ativo == false && a.EstadoAssistencia.DescEstado == "Completado")
                {
                    ListViewItem itemAdicionar = new ListViewItem(a.Id.ToString());
                    itemAdicionar.SubItems.Add(a.Data.ToString());
                    string tipoAssistComId = "IDTipo:" + a.TipoAssistencia.Id.ToString() + " - " + a.TipoAssistencia.NomeTipo.ToString();
                    itemAdicionar.SubItems.Add(tipoAssistComId);
                    itemAdicionar.SubItems.Add(a.EstadoAssistencia.DescEstado.ToString());
                    itemAdicionar.SubItems.Add(a.ClienteNIF.ToString());
                    itemAdicionar.SubItems.Add(a.OperadorId.ToString());
                    string classificacaoComData = "Data:" + a.Classificacao.Data.ToString() + " - " + "Pontuacao:" + a.Classificacao.Pontuacao.ToString();
                    itemAdicionar.SubItems.Add(classificacaoComData);
                    if (a.Solucao.Id != -1)
                        itemAdicionar.SubItems.Add("Solução:" + a.Solucao.Resolucao.ToString());
                    else
                        itemAdicionar.SubItems.Add("Não contem solução !!");
                    listViewAux.Items.Add(itemAdicionar);
                }
                else
                    continue;
            }
            listViewAux.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            return listViewAux;
        }
        /// <summary>
        /// Mostra todas as assistências por concluir.
        /// </summary>
        /// <param name="listViewAux">The list view aux.</param>
        /// <returns></returns>
        public static ListView ListViewAssistPorConcluir(ListView listViewAux)
        {
            listViewAux.View = View.Details;

            List<Assist> assistPorConcluir = RegrasDeNegocio.MostrarAssistenciasAtivas();
            Type tipoDados = typeof(Assist);
            foreach (PropertyInfo p in tipoDados.GetProperties())
            {
                if (p.Name == "Cliente" || p.Name == "Operador" || p.Name  == "Classificacao")
                    continue;
                listViewAux.Columns.Add(p.Name, -1);
            }
            foreach (Assist a in assistPorConcluir)
            {
                if (a.EstadoAssistencia.Ativo == true && a.EstadoAssistencia.DescEstado == "Ativo")
                {
                    ListViewItem itemAdicionar = new ListViewItem(a.Id.ToString());
                    itemAdicionar.SubItems.Add(a.Data.ToString());
                    string tipoAssistComId = "IDTipo:" + a.TipoAssistencia.Id.ToString() + " - " + a.TipoAssistencia.NomeTipo.ToString();
                    itemAdicionar.SubItems.Add(tipoAssistComId);
                    itemAdicionar.SubItems.Add(a.EstadoAssistencia.DescEstado.ToString());
                    itemAdicionar.SubItems.Add(a.ClienteNIF.ToString());
                    itemAdicionar.SubItems.Add(a.OperadorId.ToString());
                    if (a.Solucao.Id != -1)
                        itemAdicionar.SubItems.Add("Solução:" + a.Solucao.Resolucao.ToString());
                    else
                        itemAdicionar.SubItems.Add("Não contem solução !!");
                    listViewAux.Items.Add(itemAdicionar);
                }
                else
                    continue;
            }
            listViewAux.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            return listViewAux;
        }
        /// <summary>
        /// Mostra todas as informações de um assistência.
        /// </summary>
        /// <param name="listViewAux">The list view aux.</param>
        /// <param name="a">a.</param>
        /// <returns></returns>
        public static ListView ListViewAssistDetalhada(ListView listViewAux, Assist a)
        {
            listViewAux.View = View.Details;

            Type tipoDados = typeof(Assist);
            foreach (PropertyInfo p in tipoDados.GetProperties())
            {
                listViewAux.Columns.Add(p.Name, -1);
            }
            ListViewItem itemAdicionar = new ListViewItem(a.Id.ToString());
            itemAdicionar.SubItems.Add(a.Data.ToString());
            itemAdicionar.SubItems.Add(a.TipoAssistencia.ToString());
            itemAdicionar.SubItems.Add(a.EstadoAssistencia.DescEstado.ToString());
            itemAdicionar.SubItems.Add(a.ClienteNIF.ToString());
            itemAdicionar.SubItems.Add(a.OperadorId.ToString());
            itemAdicionar.SubItems.Add(a.Operador.ToString());
            itemAdicionar.SubItems.Add(a.Cliente.ToString());
            if (a.Classificacao.Pontuacao != -1)
            {
                itemAdicionar.SubItems.Add(a.Classificacao.ToString());
            }
            else
                itemAdicionar.SubItems.Add("Não contem classificação !!");
            if (a.Solucao.Id != -1)
                itemAdicionar.SubItems.Add("Solução:" + a.Solucao.ToString());
            else
                itemAdicionar.SubItems.Add("Não contem solução !!");
            listViewAux.Items.Add(itemAdicionar);
            listViewAux.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            return listViewAux;
        }
        #endregion

        #endregion
    }
}