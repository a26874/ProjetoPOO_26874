/*
*	<copyright file="IO" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 12/23/2023 10:53:41 PM</date>
*	<description></description>
**/

using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

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
        /// Limpa toda a data de uma datagrid.
        /// </summary>
        /// <param name="auxDataGrid">The aux data grid.</param>
        public static void LimparDataGrid(DataGridView auxDataGrid)
        {
            auxDataGrid.DataSource = null;
            auxDataGrid.Rows.Clear();
            auxDataGrid.Columns.Clear();
            auxDataGrid.Refresh();
        }

        #region ListViewAssistencias
        ///// <summary>
        ///// Mostra todas as assistências.
        ///// </summary>
        //public static ListView ListViewTodasAssistencias(ListView listViewAux)
        //{
        //    listViewAux.View = View.Details;
        //    List<Assist> auxAssist = RegrasDeNegocio.MostrarTodasAssistencias();
        //    Type tipoDados = typeof(Assist);
        //    foreach (PropertyInfo p in tipoDados.GetProperties())
        //    {
        //        if (p.Name == "Cliente" || p.Name == "Operador")
        //            continue;
        //        listViewAux.Columns.Add(p.Name, -1);
        //    }
        //    foreach (Assist a in auxAssist)
        //    {
        //        ListViewItem itemAdicionar = new ListViewItem(a.Id.ToString());
        //        itemAdicionar.SubItems.Add(a.Data.ToString());
        //        string tipoAssistComId = "IDTipo:" + a.TipoAssistencia.Id.ToString() + " - " + a.TipoAssistencia.NomeTipo.ToString();
        //        itemAdicionar.SubItems.Add(tipoAssistComId);
        //        itemAdicionar.SubItems.Add(a.EstadoAssistencia.DescEstado.ToString());
        //        itemAdicionar.SubItems.Add(a.ClienteNIF.ToString());
        //        itemAdicionar.SubItems.Add(a.OperadorId.ToString());
        //        if (a.Classificacao.Pontuacao != -1)
        //        {
        //            string classificacaoComData = "Data:" + a.Classificacao.Data.ToString() + " - " + "Pontuacao:" + a.Classificacao.Pontuacao.ToString();
        //            itemAdicionar.SubItems.Add(classificacaoComData);
        //        }
        //        else
        //            itemAdicionar.SubItems.Add("Não contem classificação !!");
        //        if (a.Solucao.Id != -1)
        //            itemAdicionar.SubItems.Add("Solução:" + a.Solucao.Resolucao.ToString());
        //        else
        //            itemAdicionar.SubItems.Add("Não contem solução !!");
        //        listViewAux.Items.Add(itemAdicionar);
        //    }
        //    listViewAux.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //    return listViewAux;
        //}
        ///// <summary>
        ///// Mostra todas as assistências por concluir.
        ///// </summary>
        ///// <param name="listViewAux">The list view aux.</param>
        ///// <returns></returns>
        //public static ListView ListViewAssistConcluidas(ListView listViewAux)
        //{
        //    listViewAux.View = View.Details;

        //    List<Assist> assistConcluidas = RegrasDeNegocio.MostrarAssistenciasConcluidas();
        //    Type tipoDados = typeof(Assist);
        //    foreach (PropertyInfo p in tipoDados.GetProperties())
        //    {
        //        if (p.Name == "Cliente" || p.Name == "Operador")
        //            continue;
        //        listViewAux.Columns.Add(p.Name, -1);
        //    }
        //    foreach (Assist a in assistConcluidas)
        //    {
        //        if (a.EstadoAssistencia.Ativo == false && a.EstadoAssistencia.DescEstado == "Completado")
        //        {
        //            ListViewItem itemAdicionar = new ListViewItem(a.Id.ToString());
        //            itemAdicionar.SubItems.Add(a.Data.ToString());
        //            string tipoAssistComId = "IDTipo:" + a.TipoAssistencia.Id.ToString() + " - " + a.TipoAssistencia.NomeTipo.ToString();
        //            itemAdicionar.SubItems.Add(tipoAssistComId);
        //            itemAdicionar.SubItems.Add(a.EstadoAssistencia.DescEstado.ToString());
        //            itemAdicionar.SubItems.Add(a.ClienteNIF.ToString());
        //            itemAdicionar.SubItems.Add(a.OperadorId.ToString());
        //            string classificacaoComData = "Data:" + a.Classificacao.Data.ToString() + " - " + "Pontuacao:" + a.Classificacao.Pontuacao.ToString();
        //            itemAdicionar.SubItems.Add(classificacaoComData);
        //            if (a.Solucao.Id != -1)
        //                itemAdicionar.SubItems.Add("Solução:" + a.Solucao.Resolucao.ToString());
        //            else
        //                itemAdicionar.SubItems.Add("Não contem solução !!");
        //            listViewAux.Items.Add(itemAdicionar);
        //        }
        //        else
        //            continue;
        //    }
        //    listViewAux.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //    return listViewAux;
        //}
        ///// <summary>
        ///// Mostra todas as assistências por concluir.
        ///// </summary>
        ///// <param name="listViewAux">The list view aux.</param>
        ///// <returns></returns>
        //public static ListView ListViewAssistPorConcluir(ListView listViewAux)
        //{
        //    listViewAux.View = View.Details;

        //    List<Assist> assistPorConcluir = RegrasDeNegocio.MostrarAssistenciasAtivas();
        //    Type tipoDados = typeof(Assist);
        //    foreach (PropertyInfo p in tipoDados.GetProperties())
        //    {
        //        if (p.Name == "Cliente" || p.Name == "Operador" || p.Name == "Classificacao")
        //            continue;
        //        listViewAux.Columns.Add(p.Name, -1);
        //    }
        //    foreach (Assist a in assistPorConcluir)
        //    {
        //        if (a.EstadoAssistencia.Ativo == true && a.EstadoAssistencia.DescEstado == "Ativo")
        //        {
        //            ListViewItem itemAdicionar = new ListViewItem(a.Id.ToString());
        //            itemAdicionar.SubItems.Add(a.Data.ToString());
        //            string tipoAssistComId = "IDTipo:" + a.TipoAssistencia.Id.ToString() + " - " + a.TipoAssistencia.NomeTipo.ToString();
        //            itemAdicionar.SubItems.Add(tipoAssistComId);
        //            itemAdicionar.SubItems.Add(a.EstadoAssistencia.DescEstado.ToString());
        //            itemAdicionar.SubItems.Add(a.ClienteNIF.ToString());
        //            itemAdicionar.SubItems.Add(a.OperadorId.ToString());
        //            if (a.Solucao.Id != -1)
        //                itemAdicionar.SubItems.Add("Solução:" + a.Solucao.Resolucao.ToString());
        //            else
        //                itemAdicionar.SubItems.Add("Não contem solução !!");
        //            listViewAux.Items.Add(itemAdicionar);
        //        }
        //        else
        //            continue;
        //    }
        //    listViewAux.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //    return listViewAux;
        //}
        ///// <summary>
        ///// Mostra todas as informações de um assistência.
        ///// </summary>
        ///// <param name="listViewAux">The list view aux.</param>
        ///// <param name="a">a.</param>
        ///// <returns></returns>
        //public static ListView ListViewAssistDetalhada(ListView listViewAux, Assist a)
        //{
        //    listViewAux.View = View.Details;

        //    Type tipoDados = typeof(Assist);
        //    foreach (PropertyInfo p in tipoDados.GetProperties())
        //    {
        //        listViewAux.Columns.Add(p.Name, -1);
        //    }
        //    ListViewItem itemAdicionar = new ListViewItem(a.Id.ToString());
        //    itemAdicionar.SubItems.Add(a.Data.ToString());
        //    itemAdicionar.SubItems.Add(a.TipoAssistencia.ToString());
        //    itemAdicionar.SubItems.Add(a.EstadoAssistencia.DescEstado.ToString());
        //    itemAdicionar.SubItems.Add(a.ClienteNIF.ToString());
        //    itemAdicionar.SubItems.Add(a.OperadorId.ToString());
        //    itemAdicionar.SubItems.Add(a.Operador.ToString());
        //    itemAdicionar.SubItems.Add(a.Cliente.ToString());
        //    if (a.Classificacao.Pontuacao != -1)
        //    {
        //        itemAdicionar.SubItems.Add(a.Classificacao.ToString());
        //    }
        //    else
        //        itemAdicionar.SubItems.Add("Não contem classificação !!");
        //    if (a.Solucao.Id != -1)
        //        itemAdicionar.SubItems.Add("Solução:" + a.Solucao.ToString());
        //    else
        //        itemAdicionar.SubItems.Add("Não contem solução !!");
        //    listViewAux.Items.Add(itemAdicionar);
        //    listViewAux.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //    return listViewAux;
        //}
        #endregion

        #region DataGridTodasAssist

        /// <summary>
        /// Cria colunas para um datagrid, conforme o tipo de dados de uma assistência.
        /// </summary>
        /// <param name="dataGridAux">The data grid aux.</param>
        /// <param name="auxTipoDados">The aux tipo dados.</param>
        /// <param name="countDadosAux">The count dados aux.</param>
        /// <returns></returns>
        public static DataGridView CriarColunasDataGrid(DataGridView dataGridAux, Type auxTipoDados, out int countDadosAux)
        {
            countDadosAux = 0;
            foreach (PropertyInfo p in auxTipoDados.GetProperties())
            {
                if (p.Name == "Cliente" || p.Name == "Operador")
                    continue;
                var coluna = new DataGridViewTextBoxColumn
                {
                    Name = p.Name + "Coluna",
                    HeaderText = p.Name,
                    DataPropertyName = p.Name,
                };
                countDadosAux++;
                dataGridAux.Columns.Add(coluna);
            }
            return dataGridAux;
        }
        /// <summary>
        /// Cria linhas de uma datagrid.
        /// </summary>
        /// <param name="dataGridAux">The data grid aux.</param>
        /// <param name="listaAuxAssist">The lista aux assist.</param>
        /// <param name="countDadosAux">The count dados aux.</param>
        /// <returns></returns>
        public static DataGridView CriarLinhasDataGridTodasAssist(DataGridView dataGridAux, List<Assist> listaAuxAssist, int countDadosAux)
        {
            string newline = Environment.NewLine;
            foreach (Assist a in listaAuxAssist)
            {
                int contAssist = 0;
                object[] dadosLinhaAux = new object[countDadosAux];
                dadosLinhaAux[contAssist++] = a.Id.ToString();
                dadosLinhaAux[contAssist++] = a.Data.ToString();
                string tipoComId = "Tipo: " + a.TipoAssistencia.NomeTipo + newline + "IDTipo:" + a.TipoAssistencia.Id;
                dadosLinhaAux[contAssist++] = tipoComId;
                dadosLinhaAux[contAssist++] = a.EstadoAssistencia.DescEstado;
                dadosLinhaAux[contAssist++] = a.ClienteNIF.ToString();
                dadosLinhaAux[contAssist++] = a.OperadorId.ToString();
                if (a.Classificacao.Pontuacao != -1)
                    dadosLinhaAux[contAssist++] = a.Classificacao.ToString();
                else
                    dadosLinhaAux[contAssist++] = "Não contém classificação !!";
                if (a.Solucao.Id != -1)
                    dadosLinhaAux[contAssist++] = a.Solucao.ToString();
                else
                    dadosLinhaAux[contAssist++] = "Não contém solução !!";
                dataGridAux.Rows.Add(dadosLinhaAux);
            }
            return dataGridAux;
        }

        /// <summary>
        /// Cria uma datagridview para mostrar todas as assistências existentes.
        /// </summary>
        /// <param name="auxDataGrid">The aux data grid.</param>
        /// <returns></returns>
        public static DataGridView DataGridTodasAssistencias(DataGridView auxDataGrid)
        {
            LimparDataGrid(auxDataGrid);
            int countDados;
            List<Assist> auxAssist = RegrasDeNegocio.MostrarTodasAssistencias();
            Type tipoDados = typeof(Assist);
            CriarColunasDataGrid(auxDataGrid, tipoDados, out countDados);
            CriarLinhasDataGridTodasAssist(auxDataGrid, auxAssist, countDados);
            auxDataGrid.ReadOnly = true;
            auxDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            auxDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            auxDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            return auxDataGrid;
        }
        #endregion

        #region DataGridApenasConcluidas        

        /// <summary>
        /// Cria linhas para a datagrid assistências apenas concluidas.
        /// </summary>
        /// <param name="auxDataGrid">The aux data grid.</param>
        /// <param name="listaAuxAssist">The lista aux assist.</param>
        /// <param name="countDadosAux">The count dados aux.</param>
        /// <returns></returns>
        public static DataGridView CriarLinhasDataGridApenasConcluidas(DataGridView auxDataGrid, List<Assist> listaAuxAssist, int countDadosAux)
        {
            string newline = Environment.NewLine;
            foreach (Assist a in listaAuxAssist)
            {
                int contAssist = 0;
                object[] dadosLinhaAux = new object[countDadosAux];
                dadosLinhaAux[contAssist++] = a.Id.ToString();
                dadosLinhaAux[contAssist++] = a.Data.ToString();
                string tipoComId = "Tipo: " + a.TipoAssistencia.NomeTipo + newline + "IDTipo:" + a.TipoAssistencia.Id;
                dadosLinhaAux[contAssist++] = tipoComId;
                if (a.EstadoAssistencia.DescEstado == "Completado" && a.EstadoAssistencia.Ativo == false)
                    dadosLinhaAux[contAssist++] = a.EstadoAssistencia.DescEstado;
                dadosLinhaAux[contAssist++] = a.ClienteNIF.ToString();
                dadosLinhaAux[contAssist++] = a.OperadorId.ToString();
                dadosLinhaAux[contAssist++] = a.Classificacao.ToString();
                if (a.Solucao.Id != -1)
                    dadosLinhaAux[contAssist++] = a.Solucao.ToString();
                else
                    dadosLinhaAux[contAssist++] = "Não contém solução !!";
                auxDataGrid.Rows.Add(dadosLinhaAux);
            }
            return auxDataGrid;
        }
        /// <summary>
        /// Cria uma datagrid para assistências apenas concluidas.
        /// </summary>
        /// <param name="auxDataGrid">The aux data grid.</param>
        /// <returns></returns>
        public static DataGridView DataGridApenasConcluidas(DataGridView auxDataGrid)
        {
            LimparDataGrid(auxDataGrid);
            int countDados;
            Type tipoDados = typeof(Assist);
            List<Assist> auxAssist = RegrasDeNegocio.MostrarAssistenciasConcluidas();
            CriarColunasDataGrid(auxDataGrid, tipoDados, out countDados);
            CriarLinhasDataGridApenasConcluidas(auxDataGrid, auxAssist, countDados);
            auxDataGrid.ReadOnly = true;
            auxDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            auxDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            auxDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            return auxDataGrid;
        }

        #region DataGridPorConcluir
        /// <summary>
        /// Cria as linhas para uma datagrid de assistências por concluir.
        /// </summary>
        /// <param name="auxDataGrid">The aux data grid.</param>
        /// <param name="listaAuxAssist">The lista aux assist.</param>
        /// <param name="countDadosAux">The count dados aux.</param>
        /// <returns></returns>
        public static DataGridView CriarLinhasDataGridPorConcluir(DataGridView auxDataGrid, List<Assist> listaAuxAssist, int countDadosAux)
        {
            string newline = Environment.NewLine;
            foreach (Assist a in listaAuxAssist)
            {
                int contAssist = 0;
                object[] dadosLinhaAux = new object[countDadosAux];
                dadosLinhaAux[contAssist++] = a.Id.ToString();
                dadosLinhaAux[contAssist++] = a.Data.ToString();
                string tipoComId = "Tipo: " + a.TipoAssistencia.NomeTipo + newline + "IDTipo:" + a.TipoAssistencia.Id;
                dadosLinhaAux[contAssist++] = tipoComId;
                if (a.EstadoAssistencia.DescEstado == "Ativo" && a.EstadoAssistencia.Ativo == true)
                    dadosLinhaAux[contAssist++] = a.EstadoAssistencia.DescEstado;
                else
                {
                    auxDataGrid = null;
                    return auxDataGrid;
                }
                dadosLinhaAux[contAssist++] = a.ClienteNIF.ToString();
                dadosLinhaAux[contAssist++] = a.OperadorId.ToString();
                dadosLinhaAux[contAssist++] = a.Classificacao.ToString();
                if (a.Solucao.Id != -1)
                    dadosLinhaAux[contAssist++] = a.Solucao.ToString();
                else
                    dadosLinhaAux[contAssist++] = "Não contém solução !!";
                auxDataGrid.Rows.Add(dadosLinhaAux);
            }
            return auxDataGrid;
        }
        /// <summary>
        /// Cria uma datagrid para assistências apenas por concluir.
        /// </summary>
        /// <param name="auxDataGrid">The aux data grid.</param>
        /// <returns></returns>
        public static DataGridView DataGridPorConcluir(DataGridView auxDataGrid)
        {
            LimparDataGrid(auxDataGrid);
            int countDados;
            Type tipoDados = typeof(Assist);
            List<Assist> auxAssist = RegrasDeNegocio.MostrarAssistenciasAtivas();
            CriarColunasDataGrid(auxDataGrid, tipoDados, out countDados);
            CriarLinhasDataGridPorConcluir(auxDataGrid, auxAssist, countDados);
            auxDataGrid.ReadOnly = true;
            auxDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            auxDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            auxDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            return auxDataGrid;
        }
        #endregion


        #endregion

        #region DataGridAssitenciaDetalhada

        /// <summary>
        /// Cria as colunas para uma datagrid de uma assistência detalhada
        /// </summary>
        /// <param name="auxDataGrid">The aux data grid.</param>
        /// <param name="tipoDados">The tipo dados.</param>
        /// <param name="countDadosAux">The count dados aux.</param>
        /// <returns></returns>
        public static DataGridView CriarColunasDataGridDetalhada(DataGridView auxDataGrid, Type tipoDados, out int countDadosAux)
        {
            countDadosAux = 0;
            foreach (PropertyInfo p in tipoDados.GetProperties())
            {
                var coluna = new DataGridViewTextBoxColumn
                {
                    Name = p.Name + "Coluna",
                    HeaderText = p.Name,
                    DataPropertyName = p.Name
                };
                countDadosAux++;
                auxDataGrid.Columns.Add(coluna);
            }
            return auxDataGrid;
        }
        /// <summary>
        /// Cria linhas para uma datagrid detalhada.
        /// </summary>
        /// <param name="auxDataGrid">The aux data grid.</param>
        /// <param name="a">a.</param>
        /// <param name="countDadosAux">The count dados aux.</param>
        /// <returns></returns>
        public static DataGridView CriarLinhasDataGridDetalhada(DataGridView auxDataGrid, Assist a, int countDadosAux)
        {
            int countAssist = 0;
            if (!ReferenceEquals(a, null))
            {
                object[] dadosLinhaAux = new object[countDadosAux];
                dadosLinhaAux[countAssist++] = a.Id.ToString();
                dadosLinhaAux[countAssist++] = a.Data.ToString();
                dadosLinhaAux[countAssist++] = a.TipoAssistencia.ToString();
                dadosLinhaAux[countAssist++] = a.EstadoAssistencia.ToString();
                dadosLinhaAux[countAssist++] = a.ClienteNIF.ToString();
                dadosLinhaAux[countAssist++] = a.OperadorId.ToString();
                if (a.Cliente.NIF != -1)
                    dadosLinhaAux[countAssist++] = a.Cliente.ToString();
                else
                    dadosLinhaAux[countAssist++] = "Não contém cliente !!";
                if (a.Operador.Id != -1)
                    dadosLinhaAux[countAssist++] = a.Operador.ToString();
                else
                    dadosLinhaAux[countAssist++] = "Não contém operador !!";
                if (a.Classificacao.Pontuacao != -1)
                    dadosLinhaAux[countAssist++] = a.Classificacao.ToString();
                else
                    dadosLinhaAux[countAssist++] = "Não contém classificação !!";
                if (a.Solucao.Id != -1)
                    dadosLinhaAux[countAssist++] = a.Solucao.ToString();
                else
                    dadosLinhaAux[countAssist++] = "Não contém solução !!";
                auxDataGrid.Rows.Add(dadosLinhaAux);
            }
            else
                auxDataGrid = null;
            return auxDataGrid;
        }
        public static DataGridView DataGridAssistDetalhada(DataGridView auxDataGrid, Assist a)
        {
            LimparDataGrid(auxDataGrid);
            int countDados;
            Type tipoDados = typeof(Assist);
            CriarColunasDataGridDetalhada(auxDataGrid, tipoDados, out countDados);
            CriarLinhasDataGridDetalhada(auxDataGrid, a, countDados);
            auxDataGrid.ReadOnly = true;
            auxDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            auxDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            auxDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            return auxDataGrid;
        }
        #endregion

        #endregion

        #endregion
    }
}