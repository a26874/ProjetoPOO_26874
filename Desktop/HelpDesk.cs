using Excecoes;
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
    public partial class HelpDesk : Form
    {
        public HelpDesk()
        {
            InitializeComponent();
            try
            {
                bool aux = RegrasDeNegocio.LerFicheiroClientes("C:\\Users\\marco\\Desktop\\Universidade\\2ºAno\\POO\\ProjetoPOO_26874\\GereAssistencias\\bin\\Debug\\RegistoClientes.dat");
                aux = RegrasDeNegocio.LerFicheiroOperadores("C:\\Users\\marco\\Desktop\\Universidade\\2ºAno\\POO\\ProjetoPOO_26874\\GereAssistencias\\bin\\Debug\\RegistoOperadores.dat");
                aux = RegrasDeNegocio.LerFicheiroProdutos("C:\\Users\\marco\\Desktop\\Universidade\\2ºAno\\POO\\ProjetoPOO_26874\\GereAssistencias\\bin\\Debug\\RegistoProdutos.dat");
                aux = RegrasDeNegocio.LerFicheiroSolucoes("C:\\Users\\marco\\Desktop\\Universidade\\2ºAno\\POO\\ProjetoPOO_26874\\GereAssistencias\\bin\\Debug\\RegistoSolucoes.dat");
                aux = RegrasDeNegocio.LerFicheiroAssist("C:\\Users\\marco\\Desktop\\Universidade\\2ºAno\\POO\\ProjetoPOO_26874\\GereAssistencias\\bin\\Debug\\RegistoAssistencias.dat");
                aux = RegrasDeNegocio.LerFicheiroCategorias("C:\\Users\\marco\\Desktop\\Universidade\\2ºAno\\POO\\ProjetoPOO_26874\\GereAssistencias\\bin\\Debug\\RegistoCategorias.dat");
            }
            catch (LeituraFicheiro e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void HelpDesk_Load(object sender, EventArgs e)
        {

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

        
    }
}
