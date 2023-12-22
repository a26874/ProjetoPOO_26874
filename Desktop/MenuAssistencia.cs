using Excecoes;
using RegrasNegocio;
using System;
using System.IO;
using System.Windows.Forms;

namespace Desktop
{
    public partial class MenuAssistencia : Form
    {
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
        }
        /// <summary>
        /// Quando o MenuAssistencia é aberto, executa o que seja necessário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuAssistencia_Load(object sender, EventArgs e)
        {
            
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
        /// Quando o menuAssistencia é fechado, executa o que seja necessário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuAssistencia_Closed(object sender, EventArgs e)
        {
            string pathClientes = ObterLocalizacaoFicheiro("RegistoClientes.dat");
            string pathOperadores = ObterLocalizacaoFicheiro("RegistoOperadores.dat");
            string pathProdutos = ObterLocalizacaoFicheiro("RegistoProdutos.dat");
            string pathSolucoes = ObterLocalizacaoFicheiro("RegistoSolucoes.dat");
            string pathAssistencias = ObterLocalizacaoFicheiro("RegistoAssistencias.dat");
            string pathCategorias = ObterLocalizacaoFicheiro("RegistoCategorias.dat");
            try
            {
                bool aux = RegrasDeNegocio.GravarFicheiroAssist(pathClientes);
                aux = RegrasDeNegocio.GravarFicheiroClientes(pathOperadores);
                aux = RegrasDeNegocio.GravarFicheiroOperadores(pathProdutos);
                aux = RegrasDeNegocio.GravarFicheiroProdutos(pathSolucoes);
                aux = RegrasDeNegocio.GravarFicheiroSolucoes(pathAssistencias);
                aux = RegrasDeNegocio.GravarFicheiroCategorias(pathCategorias);
            }
            catch (EscritaFicheiro ex)
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
            InsereAssist novaAdicao = new InsereAssist();
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
            ApresentarAssist novaApresenta = new ApresentarAssist();
            novaApresenta.ShowDialog();
        }
    }
}
