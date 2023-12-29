/*
*	<copyright file="InserirClienteAssist" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2023 12/26/2023 9:52:01 PM</date>
*	<description></description>
**/

using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Windows.Forms;

namespace Desktop
{
    /// <summary>
    /// Classe para um form de inserir um cliente.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class InserirClienteAssist : Form
    {
        #region ATRIBUTOS
        private MenuAssistencia menuAssist;
        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public InserirClienteAssist()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Construtor com parametros.
        /// </summary>
        /// <param name="menuAssistForm">The menu assist form.</param>
        public InserirClienteAssist(MenuAssistencia menuAssistForm)
        {
            InitializeComponent();
            menuAssist = menuAssistForm;
            FormClosing += InserirClienteAssist_FormClosing;
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
        /// Ao fechar a janela, volta atrás
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void InserirClienteAssist_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuAssist.Show();
            return;
        }

        /// <summary>
        /// Ao clicar no botão, é inserido um cliente na assistência.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void inserirClienteAssistButton_Click(object sender, EventArgs e)
        {
            Assist auxAssist = new Assist();
            Cliente auxCliente = new Cliente();
            bool existeAssist = false;
            bool existeCliente = false;
            if (int.TryParse(inserirClienteAssistIDTextBox.Text, out int idAssist))
                existeAssist = RegrasDeNegocio.ExisteAssistencia(idAssist, out auxAssist);
            else
                MessageBox.Show("Não existe essa assistência.");

            if (int.TryParse(inserirClienteNIFAssistTextBox.Text, out int nifCliente))
            {
                if(nifCliente == auxAssist.ClienteNIF)
                    existeCliente = RegrasDeNegocio.ExisteCliente(nifCliente, out auxCliente);
            }

            if ((auxAssist.Cliente.NIF == -1) && existeAssist && existeCliente)
            {
                auxAssist.Cliente = auxCliente;
                MessageBox.Show("Cliente inserido com sucesso.");
            }
            else
                MessageBox.Show("Erro ao inserir o cliente.");
        }
        #endregion

        #endregion

    }
}
