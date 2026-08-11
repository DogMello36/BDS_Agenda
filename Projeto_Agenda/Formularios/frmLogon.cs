using Projeto_Agenda.DataSet1TableAdapters;
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
    public partial class frmLogon : Form
    {
        public frmLogon()
        {
            InitializeComponent();
        }
        int erros=0;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" ){
                errorProvider1.SetError(txtUsuario, "Por favor preencher o nome");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "");
            }
                DataTable dt = new DataTable();
            UsuarioTableAdapter  taUsuario = new UsuarioTableAdapter();
            dt = taUsuario.GetDataBy(txtUsuario.Text,txtSenha.Text);
            if (dt.Rows.Count>0) // se achou
            {

                Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
                Properties.Settings.Default.NIvelUsuarioLogado = int.Parse(dt.Rows[0]["Nível"].ToString());
                MDI_menu menu = new MDI_menu();
                menu.Show();
                Close();
            }
            else // se não achou
            {
                MessageBox.Show("Usuário ou senha não encontrado");
                erros++;
                if (erros==3)
                {
                    MessageBox.Show("N° de tentativas excedido");
                    Application.Exit();
                } 
            }

        }

        private void frmLogon_Load(object sender, EventArgs e)
        {

        }
    }
}
