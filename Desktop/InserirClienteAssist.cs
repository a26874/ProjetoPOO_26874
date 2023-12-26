using ObjetosNegocio;
using RegrasNegocio;
using System;
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
    public partial class InserirClienteAssist : Form
    {
        #region ATRIBUTOS
        private MenuAssistencia menuAssist;
        #endregion
        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public InserirClienteAssist()
        {
            InitializeComponent();
        }

        public InserirClienteAssist(MenuAssistencia menuAssistForm)
        {
            InitializeComponent();
            menuAssist = menuAssistForm;
            FormClosing += InserirClienteAssist_FormClosing;
        }

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
    }
}
