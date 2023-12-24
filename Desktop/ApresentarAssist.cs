using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Windows.Forms;
namespace Desktop
{
    public partial class ApresentarAssist : Form
    {

        #region ATRIBUTOS
        private bool enterCarregado = false;
        #endregion
        public ApresentarAssist()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ao clicar no botão de todas as assistências, é tudo que existe referente a assistências apresentado ao utilizador.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TodasAssistButton_Click(object sender, EventArgs e)
        {
            MostrarAssistenciasListView.Clear();
            MostrarAssistenciasListView = IO.ListViewTodasAssistencias(MostrarAssistenciasListView);
        }

        /// <summary>
        /// Ao clicar no botão de apenas concluidas, irá mostrar todas as assistências que teem o seu estado concluido.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ApenasConcluidasButton_Click(object sender, EventArgs e)
        {
            MostrarAssistenciasListView.Clear();
            MostrarAssistenciasListView = IO.ListViewAssistConcluidas(MostrarAssistenciasListView);
        }

        /// <summary>
        /// Ao clicar no botão Por Concluir, irá apenas mostrar todas as assistências que ainda não foram concluidas.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PorConcluirButton_Click(object sender, EventArgs e)
        {
            MostrarAssistenciasListView.Clear();
            MostrarAssistenciasListView = IO.ListViewAssistPorConcluir(MostrarAssistenciasListView);
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
            MostrarAssistenciasListView.Clear();
            Assist auxAssist = new Assist();
            bool mostrarUmaVez = false;
            if (!mostrarUmaVez)
            {
                MessageBox.Show("Insira o ID da assistência:");
                mostrarUmaVez = true;
            }
            detalhadaTextBox.Visible = true;
            detalhadaTextBox.Focus();
            detalhadaTextBox.KeyDown += detalhadaTextBox_KeyDown;
            while (!enterCarregado)
                Application.DoEvents();
            if (int.TryParse(detalhadaTextBox.Text, out int idAssist))
            {
                bool aux = RegrasDeNegocio.ExisteAssistencia(idAssist, out auxAssist);
            }
            else
                Application.DoEvents();
            MostrarAssistenciasListView = IO.ListViewAssistDetalhada(MostrarAssistenciasListView, auxAssist);
        }
    }
}
