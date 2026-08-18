using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formularios
{
    public partial class fmrVisualizaListaPessoas : Form
    {
        public fmrVisualizaListaPessoas()
        {
            InitializeComponent();
        }

        private void fmrVisualizaListaPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet1.Pessoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
