using ObjetosNegocio;
using RegrasNegocio;
using System.Windows.Forms;

namespace Desktop
{
    public partial class InserirOperadorAssist : Form
    {

        #region ATRIBUTOS
        private MenuAssistencia menuAssist;
        #endregion
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public InserirOperadorAssist()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="menuAssistForm">The menu assist form.</param>
        public InserirOperadorAssist(MenuAssistencia menuAssistForm)
        {
            InitializeComponent();
            menuAssist = menuAssistForm;
            FormClosing += InserirOperadorAssist_FormClosing;
        }

        /// <summary>
        /// Ao fechar a janela volta ao menu de assistências.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void InserirOperadorAssist_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAssist.Show();
            return;
        }

        /// <summary>
        /// Insere um operador numa assistência.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void inserirOperadorAssistButton_Click(object sender, System.EventArgs e)
        {
            Assist auxAssist = new Assist();
            Operador auxOperador = new Operador();
            bool existeAssist = false;
            bool existeOperador = false;

            if (int.TryParse(inserirOperadorAssistIDTextBox.Text, out int idAssist))
                existeAssist = RegrasDeNegocio.ExisteAssistencia(idAssist, out auxAssist);

            if (int.TryParse(inserirOperadorIDAssistTextBox.Text, out int idOperador))
                if (idOperador == auxAssist.OperadorId)
                {
                    existeOperador = RegrasDeNegocio.ExisteOperador(idOperador, out auxOperador);
                }

            if ((auxAssist.Operador.Id == -1) && existeAssist && existeOperador)
            {
                auxAssist.Operador = auxOperador;
                MessageBox.Show("Operador inserido com sucesso.");
            }
            else
                MessageBox.Show("Erro ao inserir o operador.");
        }
    }
}
