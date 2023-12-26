using Excecoes;
using RegrasNegocio;
using System;
using System.IO;
using System.Windows.Forms;

namespace Desktop
{
    public partial class MenuAssistencia : Form
    {
        /// <summary>
        /// Construtor estático.
        /// </summary>
        static MenuAssistencia()
        {
            LerDadosFicheiros();
        }
        /// <summary>
        /// Construtor para menu assistência.
        /// </summary>
        public MenuAssistencia()
        {
            InitializeComponent();
            FormClosing += MenuAssistencia_FormClosing;
        }
        /// <summary>
        /// Ao fechar a janela, executa metodos.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void MenuAssistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerDataHora.Stop();
            GravarDadosFicheiros();
            return;
        }
        /// <summary>
        /// Quando o MenuAssistencia é aberto, executa o que seja necessário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuAssistencia_Load(object sender, EventArgs e)
        {
            timerDataHora.Start();   
        }

       
        /// <summary>
        /// Grava a informação em ficheiros.
        /// </summary>
        private static void GravarDadosFicheiros()
        {
            string pathClientes = ObterLocalizacaoFicheiro("RegistoClientes.dat");
            string pathOperadores = ObterLocalizacaoFicheiro("RegistoOperadores.dat");
            string pathProdutos = ObterLocalizacaoFicheiro("RegistoProdutos.dat");
            string pathSolucoes = ObterLocalizacaoFicheiro("RegistoSolucoes.dat");
            string pathAssistencias = ObterLocalizacaoFicheiro("RegistoAssistencias.dat");
            string pathCategorias = ObterLocalizacaoFicheiro("RegistoCategorias.dat");
            try
            {
                bool aux = RegrasDeNegocio.GravarFicheiroClientes(pathClientes);
                aux = RegrasDeNegocio.GravarFicheiroOperadores(pathOperadores);
                aux = RegrasDeNegocio.GravarFicheiroProdutos(pathProdutos);
                aux = RegrasDeNegocio.GravarFicheiroSolucoes(pathSolucoes);
                aux = RegrasDeNegocio.GravarFicheiroAssist(pathAssistencias);
                aux = RegrasDeNegocio.GravarFicheiroCategorias(pathCategorias);
            }
            catch (EscritaFicheiro ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Lê os dados de todos os ficheiros.
        /// </summary>
        private static void LerDadosFicheiros()
        {
            string pathClientes = ObterLocalizacaoFicheiro("RegistoClientes.dat");
            string pathOperadores = ObterLocalizacaoFicheiro("RegistoOperadores.dat");
            string pathProdutos = ObterLocalizacaoFicheiro("RegistoProdutos.dat");
            string pathSolucoes = ObterLocalizacaoFicheiro("RegistoSolucoes.dat");
            string pathAssistencias = ObterLocalizacaoFicheiro("RegistoAssistencias.dat");
            string pathCategorias = ObterLocalizacaoFicheiro("RegistoCategorias.dat");
            try
            {
                bool aux = RegrasDeNegocio.LerFicheiroClientes(pathClientes);
                aux = RegrasDeNegocio.LerFicheiroOperadores(pathOperadores);
                aux = RegrasDeNegocio.LerFicheiroProdutos(pathProdutos);
                aux = RegrasDeNegocio.LerFicheiroSolucoes(pathSolucoes);
                aux = RegrasDeNegocio.LerFicheiroAssist(pathAssistencias);
                aux = RegrasDeNegocio.LerFicheiroCategorias(pathCategorias);
            }
            catch (LeituraFicheiro ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Usado o metodo pathcombine com o diretorio atual do executavel para obter o path
        /// para os ficheiros de dados.
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        private static string ObterLocalizacaoFicheiro(string nomeFicheiro)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeFicheiro);
        }
        /// <summary>
        /// Abre o menu para inserir uma assistência.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void InsereAssistButton_Click(object sender, EventArgs e)
        {
            Hide();
            InsereAssist novaAdicao = new InsereAssist(this);
            novaAdicao.ShowDialog();
        }
        /// <summary>
        /// Abre o menu para apresentar assistências.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApresentaAssistButton_Click(object sender, EventArgs e)
        {
            Hide();
            ApresentarAssist novaApresenta = new ApresentarAssist(this);
            novaApresenta.ShowDialog();
        }
        /// <summary>
        /// Abre o menu para remoção de uma assistência.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoverAssistButton_Click(object sender, EventArgs e)
        {
            Hide();
            RemoverAssist novaRemocao = new RemoverAssist(this);
            novaRemocao.ShowDialog();
        }

        /// <summary>
        /// Timer para mostrar a data e hora em tempo real.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            DataHoraLabel.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Insere um cliente numa assistência.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void inserirClienteButton_Click(object sender, EventArgs e)
        {
            Hide();
            InserirClienteAssist novoCliente = new InserirClienteAssist(this);
            novoCliente.ShowDialog();
        }

        /// <summary>
        /// Insere um operador numa assistência.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void inserirOperadorButton_Click(object sender, EventArgs e)
        {
            Hide();
            InserirOperadorAssist novoOperador = new InserirOperadorAssist(this);
            novoOperador.ShowDialog();
        }
    }
}
