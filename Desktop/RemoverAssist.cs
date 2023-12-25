using System;
using ObjetosNegocio;
using RegrasNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class RemoverAssist : Form
    {

        #region ATRIBUTOS   
        private bool enterCarregado = false;
        private MenuAssistencia menuAssist;
        #endregion        
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
        /// Verifica quando o enter foi pressionado.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void textBoxRemoverAssist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                enterCarregado = true;
        }
        /// <summary>
        /// Remove a assistência caso ela exista.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxRemoverAssist_TextChanged(object sender, EventArgs e)
        {
            while (!enterCarregado)
                Application.DoEvents();
            Assist auxAssist = new Assist();
            bool aux = false;
            textBoxRemoverAssist.Focus();

            if (int.TryParse(textBoxRemoverAssist.Text, out int idAssist))
                aux = RegrasDeNegocio.ExisteAssistencia(idAssist, out auxAssist);
            else
            {
                MessageBox.Show("Não existe uma assistência com esse ID.");
                Application.DoEvents();
            }
            textBoxRemoverAssist.KeyDown += textBoxRemoverAssist_KeyDown;
            if (aux && enterCarregado)
            {
                bool assistRemovida = RegrasDeNegocio.RemoverAssistencia(auxAssist);
                if (assistRemovida)
                    MessageBox.Show("Assist removida com sucesso.");
                else
                    MessageBox.Show("Não foi possivel remover essa assistência.");
            }
        }
    }
}
