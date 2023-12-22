using ObjetosNegocio;
using Assistencia;
using Dados;
using Outros;
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
    public partial class ApresentarAssist : Form
    {
        public ApresentarAssist()
        {
            InitializeComponent();
        }

        private void testeButton_Click(object sender, EventArgs e)
        {

            RegistoAssist aux = new RegistoAssist();

            List<Assist> auxAssist = aux.ObterAssistencias;
            
            MostrarAssistenciasGrid.DataSource = auxAssist;
            MostrarAssistenciasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MostrarAssistenciasGrid.AutoGenerateColumns = true;
        }
    }
}
