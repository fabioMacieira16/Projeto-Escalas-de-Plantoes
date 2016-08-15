using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System;
using Agenda.Controller;
using Agenda.Model;


namespace Agenda
{
    public partial class frmNovoCadCombustivel : MetroForm
    {
        CadastroKm cadkm = new CadastroKm();
        ControleKm controlKm = new ControleKm();

        Controle contr = new Controle();
        string mensagem;

        public frmNovoCadCombustivel()
        {
            InitializeComponent();
            cbAnalista.DisplayMember = "NomeDoAnalista";
            cbAnalista.DataSource = contr.ListaAnalistas();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            cadkm.NomeDoAnalista = cbAnalista.Text;
            cadkm.NomeDaEmpresa = txtEmpresa.Text;
            cadkm.Km = Convert.ToDouble(txtKm.Text);
            cadkm.DataDaVisita = Convert.ToDateTime(mtrDate.Text);
            cadkm.Observacao = txtObservacao.Text;

            mensagem = controlKm.Gravar(cadkm);
            MetroMessageBox.Show(Owner, "QuiloMetragem Gravada com Sucesso", "Gravando Dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
