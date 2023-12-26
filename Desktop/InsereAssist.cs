using Assistencia;
using Dados;
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
        RegistoAssist auxRegisto = new RegistoAssist();
        private MenuAssistencia menuAssist;
        #endregion


        /// <summary>
        /// Construtor por defeito.
        /// </summary>
        public InsereAssist()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor por parametros.
        /// </summary>
        /// <param name="menuAssistForm">The menu assist form.</param>
        public InsereAssist(MenuAssistencia menuAssistForm)
        {
            InitializeComponent();
            menuAssist = menuAssistForm;
            FormClosing += InsereAssist_FormClosing;
        }
        /// <summary>
        /// Quando é aberto a janela do Inserir Assist, o que estiver dentro deste metodo inicia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsereAssist_Load(object sender, EventArgs e)
        {
            DataHoraTimer.Start();
        }
        
        /// <summary>
        /// Quando é fechado a janela do Inserir Assist, o que estiver dentro deste metodo para.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsereAssist_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataHoraTimer.Stop();
            menuAssist.Show();
            return;
        }

        /// <summary>
        /// Percorre o menu dos tipos de assistência e verifica qual é que foi selecionado. Devolve o proprio item, contendo o ID e Texto.
        /// </summary>
        /// <returns></returns>
        private ToolStripMenuItem ObterIdToolStripMenu()
        {
            ToolStripMenuItem auxMenu = null;

            foreach (ToolStripMenuItem subMenu in selecioneToolStripMenuItem.DropDownItems)
            {
                if (subMenu.Text == textoAtualSelecione)
                {
                    auxMenu = subMenu;
                    break;
                }
            }
            return auxMenu;
        }
        /// <summary>
        /// Verifica todas as assistências existentes e cria um dicionario com todos os tipos e o seu conteudo.
        /// </summary>
        /// <returns></returns>
        private Dictionary<TipoAssist, (string nomeTipo, int id)> CriarDicionarioTipoAssist()
        {
            Dictionary<TipoAssist, (string nomeTipo, int id)> auxMapaTipoAssist = new Dictionary<TipoAssist, (string nomeTipo, int id)>();
            foreach (Assist a in auxRegisto.ObterAssistencias)
            {
                if (auxMapaTipoAssist.ContainsValue((a.TipoAssistencia.NomeTipo, a.TipoAssistencia.Id)))
                    continue;
                auxMapaTipoAssist.Add(a.TipoAssistencia, (a.TipoAssistencia.NomeTipo, a.TipoAssistencia.Id));
            }
            return auxMapaTipoAssist;
        }
        /// <summary>
        /// Assim que for preenchida todos os dados referentes a uma assistência, ao clicar no botão insere a assistência.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void InserirAssist_Click(object sender, EventArgs e)
        {
            Assist assistenciaInserir = new Assist();

            RegistoAssist auxAssists = new RegistoAssist();
            assistenciaInserir.Id = auxAssists.ObterAssistencias.Count+1;
            //Dicionários, foi definido como a key dele o objeto TipoAssist 
            //De seguida é especificado o nome do Tipo e qual o seu id.
            Dictionary<TipoAssist, (string nomeTipo, int id)> mapaMenuTipoAssist = new Dictionary<TipoAssist, (string nomeTipo, int id)>();


            mapaMenuTipoAssist = CriarDicionarioTipoAssist();

            //Obter index do item para verificar se existe no dicionario
            ToolStripMenuItem posicaoItem = ObterIdToolStripMenu(); 
            int indexPosicaoItem = selecioneToolStripMenuItem.DropDownItems.IndexOf(posicaoItem)+1;


            if (textoAtualSelecione != string.Empty)
            {
                if (mapaMenuTipoAssist.ContainsValue((posicaoItem.Text, indexPosicaoItem)))
                {
                    assistenciaInserir.TipoAssistencia.NomeTipo = posicaoItem.Text;
                    assistenciaInserir.TipoAssistencia.Id = indexPosicaoItem;
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

            if (descricaoAssist != null)
                assistenciaInserir.TipoAssistencia.Desc = descricaoAssist.Text;


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
                    menuAssist.Show();
                    DataHoraTimer.Stop();
                    Close();
                }
            }
            catch (AssistException exc)
            {
                DataHoraTimer.Stop();
                MessageBox.Show(exc.Message);
                Close();
            }
        }
        /// <summary>
        /// Quando é carregado num tipo de assistência muda o seu texto para esse mesmo tipo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void EntregasToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void ManutencaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManutencaoToolStripMenuItem.Pressed)
                selecioneToolStripMenuItem.Text = ManutencaoToolStripMenuItem.Text;
            textoAtualSelecione = ManutencaoToolStripMenuItem.Text;
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

        /// <summary>
        /// Usado um timer para que seja possivel apresentar horas em tempo real.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataHoraTimer_Tick(object sender, EventArgs e)
        {
            DataHoraLabel.Text = DateTime.Now.ToString();
        }
    }
}
