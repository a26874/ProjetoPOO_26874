using Excecoes;
using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Desktop
{
    /// <summary>
    /// Classe para adição de assistência.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class InsereAssist : Form
    {
        #region ATRIBUTOS
        private string textoAtualSelecione = string.Empty;
        #endregion


        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public InsereAssist()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpDesk_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Assim que for preenchida todos os dados referentes a uma assistência, ao clicar no botão insere a assistência.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void InserirAssist_Click(object sender, EventArgs e)
        {
            Assist assistenciaInserir = new Assist();

            assistenciaInserir.EstadoAssistencia.DescEstado = "Ativo";
            assistenciaInserir.EstadoAssistencia.Ativo = true;

            //Dicionários, foi definido como a key dele uma string que neste caso vai ser
            //o respetivo nome do serviço a executar
            //De seguida é especificado o nome do Tipo e qual o seu id.
            Dictionary<string, (string nomeTipo, int id)> mapaMenuTipoAssist = new Dictionary<string, (string nomeTipo, int id)>();

            mapaMenuTipoAssist.Add("Atendimento", ("Atendimento", 1));
            mapaMenuTipoAssist.Add("Entregas", ("Entregas", 2));
            mapaMenuTipoAssist.Add("Esclarecimento", ("Esclarecimento", 3));
            mapaMenuTipoAssist.Add("Assistencias", ("Assistencias", 4));



            if (textoAtualSelecione != string.Empty)
            {
                if (mapaMenuTipoAssist.ContainsKey(textoAtualSelecione))
                {
                    var valoresMenu = mapaMenuTipoAssist[textoAtualSelecione];
                    assistenciaInserir.TipoAssistencia.NomeTipo = valoresMenu.nomeTipo;
                    assistenciaInserir.TipoAssistencia.Id = valoresMenu.id;
                }
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum tipo de assistência.");
                return;
            }

            if (int.TryParse(idOperadorAssist.Text, out int id))
                assistenciaInserir.OperadorId = id;

            if (int.TryParse(nifClienteAssist.Text, out int nifCliente))
                assistenciaInserir.ClienteNIF = nifCliente;

            if (int.TryParse(precoAssist.Text, out int precoAssistencia))
                assistenciaInserir.TipoAssistencia.Preco = precoAssistencia;

            //if (int.TryParse(idTipoAssist.Text, out int idTipoAssistencia))
            //    assistenciaInserir.TipoAssistencia.Id = idTipoAssistencia;


            if (descricaoAssist != null)
                assistenciaInserir.TipoAssistencia.Desc = descricaoAssist.Text;

            //Assist a1 = new Assist(new DateTime(2023, 4, 20, 16, 40, 29), new TipoAssist("Esclarecimento duvidas", "Atendimento", 1, 500), new EstadoAssist("Ativo", true), 1874, 12);

            if (DateTime.TryParseExact(dataHoraAssist.Text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataInserir))
            {
                assistenciaInserir.Data = dataInserir;
            }
            else
            {
                MessageBox.Show("Data inválida.");
                return;
            }
            try
            {
                bool aux = RegrasDeNegocio.InsereAssistencia(assistenciaInserir);
                if (aux)
                {
                    MessageBox.Show("Assistencia inserida com sucesso.");
                    HelpDesk returnMain = new HelpDesk();
                    returnMain.Show();
                    Close();
                }
            }
            catch (AssistException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        /// <summary>
        /// Quando é carregado num tipo de assistência muda o seu texto para esse mesmo tipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (atendimentoToolStripMenuItem.Pressed)            
                selecioneToolStripMenuItem.Text = atendimentoToolStripMenuItem.Text;
            textoAtualSelecione = atendimentoToolStripMenuItem.Text;
        }
        /// <summary>
        /// Quando é carregado num tipo de assistência muda o seu texto para esse mesmo tipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entregasToolStripMenuItem.Pressed)
                selecioneToolStripMenuItem.Text = entregasToolStripMenuItem.Text;
            textoAtualSelecione = entregasToolStripMenuItem.Text;
        }
        /// <summary>
        /// Quando é carregado num tipo de assistência muda o seu texto para esse mesmo tipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void esclarecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (esclarecimentoToolStripMenuItem.Pressed)
                selecioneToolStripMenuItem.Text = esclarecimentoToolStripMenuItem.Text;
            textoAtualSelecione = esclarecimentoToolStripMenuItem.Text;
        }
        /// <summary>
        /// Quando é carregado num tipo de assistência muda o seu texto para esse mesmo tipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (assistenciaToolStripMenuItem.Pressed)
                selecioneToolStripMenuItem.Text = assistenciaToolStripMenuItem.Text;
            textoAtualSelecione = assistenciaToolStripMenuItem.Text;
        }

        /// <summary>
        /// Obtem o texto do botão selecionar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selecioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clicado = (ToolStripMenuItem)sender;

            textoAtualSelecione = clicado.Text;
        }
    }
}
