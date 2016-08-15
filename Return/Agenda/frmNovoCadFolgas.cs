using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System;
using Agenda.Model;
using Agenda.Controller;

namespace Agenda
{
    public partial class frmNovoCadFolgas : MetroForm
    {
        CadastroFolgas cadFolgas = new CadastroFolgas();
        ControleFolgas contrFolga = new ControleFolgas();
        Controle contr = new Controle();
        string mensagem;
        public frmNovoCadFolgas()
        {
            InitializeComponent();
            cbAnalista.DisplayMember = "NomeDoAnalista";
            cbAnalista.DataSource = contr.ListaAnalistas();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            cadFolgas.NomeDoAnalista = cbAnalista.Text;
            cadFolgas.DataTrabalhada = Convert.ToDateTime(mtrDtaTrabalhada.Text);
            cadFolgas.DataDaFolga = Convert.ToDateTime(mtrDtaFolga.Text);
            cadFolgas.Obervacao = txtObservacao.Text;

            mensagem = contrFolga.gravar(cadFolgas);
            MetroMessageBox.Show(Owner,"Folga Gravada com Sucesso.","Gravando Dados",MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
            this.Close();
        }
    }
}
