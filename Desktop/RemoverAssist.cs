/*
*	<copyright file="RemoverAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 12/25/2023 1:30:01 AM</date>
*	<description></description>
**/

using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Windows.Forms;

namespace Desktop
{
    /// <summary>
    /// Classe para um form de remover assistência.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RemoverAssist : Form
    {

        #region ATRIBUTOS   
        private MenuAssistencia menuAssist;
        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito
        /// </summary>
        public RemoverAssist()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="menuAssistForm">The menu assist form.</param>
        public RemoverAssist(MenuAssistencia menuAssistForm)
        {
            InitializeComponent();
            menuAssist = menuAssistForm;
            FormClosing += RemoverAssist_FormClosing;
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
        /// Ao fechar a janela de remover assistências volta ao menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void RemoverAssist_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAssist.Show();
            return;
        }

        /// <summary>
        /// Remove a assistência caso ela exista.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoverAssistButton_Click(object sender, EventArgs e)
        {
            Assist auxAssist = new Assist();
            bool aux = false;
            textBoxRemoverAssist.Focus();

            if (int.TryParse(textBoxRemoverAssist.Text, out int idAssist))
                aux = RegrasDeNegocio.ExisteAssistencia(idAssist, out auxAssist);
            if (aux)
            {
                bool assistRemovida = RegrasDeNegocio.RemoverAssistencia(auxAssist);
                if (assistRemovida)
                    MessageBox.Show("Assist removida com sucesso.");
                else
                    MessageBox.Show("Não foi possivel remover essa assistência.");
            }
            else
                MessageBox.Show($"Não existe assistência com o ID:{idAssist}");
        }
        #endregion

        #endregion
    }
}
