using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Agenda.Controller;
using Agenda.Model;
using System;

namespace Agenda
{
    public partial class frmNovoCadPlantao : MetroForm
    {
        Controle contr = new Controle();
        ControlePlantao contrPlantao = new ControlePlantao();
        CadastroPlantao cadPlantao = new CadastroPlantao();
        string mensagem;

        public frmNovoCadPlantao()
        {
            InitializeComponent();
            cbAnalista.DisplayMember = "NomeDoAnalista";
            cbAnalista.DataSource = contr.ListaAnalistas();
        }
        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            cadPlantao.NomeDoAnalista = cbAnalista.Text;
            cadPlantao.DataDoPlantao = Convert.ToDateTime(mtrDtaPlantao.Text);
            cadPlantao.Valor = Convert.ToDecimal(txtValor1.Text);
            cadPlantao.Observacao = txtObservacao.Text;

            if (cbAnalista.Text != "")
            {
                mensagem = contrPlantao.Gravar(cadPlantao);
                MetroMessageBox.Show(Owner, mensagem + " Atualizado com sucesso.", "Atualizado dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(Owner, mensagem + "Informe o valor.", "Gravando dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}
