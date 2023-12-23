using ObjetosNegocio;
using Assistencia;
using Dados;
using Outros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Reflection;

namespace Desktop
{
    public partial class ApresentarAssist : Form
    {
        public ApresentarAssist()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Cria a estrutura a mostrar dos dados de uma assistência.
        /// </summary>
        private void CriarGridAssistencia()
        {
            Type tipoDados = typeof(Assist);
            foreach (PropertyInfo p in tipoDados.GetProperties())
            {
                if (p.Name == "Cliente" || p.Name == "Operador")
                    continue;
                var coluna = new DataGridViewTextBoxColumn
                {
                    Name = p.Name + "Coluna",
                    HeaderText = p.Name,
                    DataPropertyName = p.Name
                };
                MostrarAssistenciasGrid.Columns.Add(coluna);
            }
        }
        private void testeButton_Click(object sender, EventArgs e)
        {

            RegistoAssist aux = new RegistoAssist();

            List<Assist> auxAssist = aux.ObterAssistencias;
            MostrarAssistenciasGrid.Columns.Clear();

            CriarGridAssistencia();
            MostrarAssistenciasGrid.DataSource = auxAssist;
            MostrarAssistenciasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
