using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegrasNegocio;
using Assistencia;
using ObjetosNegocio;
using Dados;
using System.Windows.Forms;
using Excecoes;
using System.Globalization;

namespace Desktop
{
    public partial class HelpDesk : Form
    {
        public HelpDesk()
        {
            InitializeComponent();
            RegrasDeNegocio.LerFicheiroAssist("RegistoAssistencias.dat");
        }

        private void HelpDesk_Load(object sender, EventArgs e)
        {

        }


        private void InserirAssist_Click(object sender, EventArgs e)
        {
            Assist assistenciaInserir = new Assist();

            assistenciaInserir.EstadoAssistencia.DescEstado = "Ativo";
            assistenciaInserir.EstadoAssistencia.Ativo = true;

            if (int.TryParse(idOperadorAssist.Text, out int id))
                assistenciaInserir.OperadorId = id;
            
            if (int.TryParse(nifClienteAssist.Text, out int nifCliente))
                assistenciaInserir.ClienteNIF = nifCliente;
            
            if (int.TryParse(precoAssist.Text, out int precoAssistencia))
                assistenciaInserir.TipoAssistencia.Preco = precoAssistencia;

            if (int.TryParse(idTipoAssist.Text, out int idTipoAssistencia))
                assistenciaInserir.TipoAssistencia.Id = idTipoAssistencia;

            if (nomeTipoAssist != null)
                assistenciaInserir.TipoAssistencia.NomeTipo = nomeTipoAssist.Text;
            
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
                    MessageBox.Show("Assistencia inserida com sucesso.");
            }
            catch (AssistException exc)
            {
                MessageBox.Show(exc.Message);
            }


        }
    }
}
