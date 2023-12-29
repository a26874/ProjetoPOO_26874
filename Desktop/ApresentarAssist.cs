/*
*	<copyright file="ApresentarAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 12/23/2023 9:23:20 PM</date>
*	<description></description>
**/


using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Windows.Forms;
namespace Desktop
{
    /// <summary>
    /// Classe para um form de apresentar assistências
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ApresentarAssist : Form
    {

        #region ATRIBUTOS
        private bool enterCarregado = false;
        private MenuAssistencia menuAssist;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public ApresentarAssist()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="menuAssistForm">The menu assist form.</param>
        public ApresentarAssist(MenuAssistencia menuAssistForm)
        {
            InitializeComponent();
            menuAssist = menuAssistForm;
            FormClosing += ApresentarAssist_FormClosing;
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
        /// Verifica quando este form é fechado.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void ApresentarAssist_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAssist.Show();
            return;
        }
        /// <summary>
        /// Ao clicar no botão de todas as assistências, é tudo que existe referente a assistências apresentado ao utilizador.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TodasAssistButton_Click(object sender, EventArgs e)
        {
            dataGridAssitencias = IO.DataGridTodasAssistencias(dataGridAssitencias);
        }

        /// <summary>
        /// Ao clicar no botão de apenas concluidas, irá mostrar todas as assistências que teem o seu estado concluido.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ApenasConcluidasButton_Click(object sender, EventArgs e)
        {
            dataGridAssitencias = IO.DataGridApenasConcluidas(dataGridAssitencias);
        }
        /// <summary>
        /// Ao clicar no botão Por Concluir, irá apenas mostrar todas as assistências que ainda não foram concluidas.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PorConcluirButton_Click(object sender, EventArgs e)
        {
            dataGridAssitencias = IO.DataGridPorConcluir(dataGridAssitencias);
        }

        /// <summary>
        /// Verifica se a tecla enter foi pressionada.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void detalhadaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                enterCarregado = true;
        }
        /// <summary>
        /// Ao clicar no botão Detalhada, a partir do Id inserido mostra a assistência caso exista, toda detalhada.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DetalhadaButton_Click(object sender, EventArgs e)
        {
            Assist auxAssist = new Assist();

            DetalhadaIdLabel.Visible = true;
            detalhadaTextBox.Visible = true;
            detalhadaTextBox.Focus();
            detalhadaTextBox.KeyDown += detalhadaTextBox_KeyDown;
            while (!enterCarregado)
                Application.DoEvents();
            if (int.TryParse(detalhadaTextBox.Text, out int idAssist))
            {
                bool aux = RegrasDeNegocio.ExisteAssistencia(idAssist, out auxAssist);
                detalhadaTextBox.Clear();
            }
            else
                Application.DoEvents();
            dataGridAssitencias = IO.DataGridAssistDetalhada(dataGridAssitencias, auxAssist);
        }
        #endregion

        #endregion
    }
}
