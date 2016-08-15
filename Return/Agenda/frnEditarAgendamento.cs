using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System;
using Agenda.Controller;
using Agenda.Model;

namespace Agenda
{
    public partial class frnEditarAgendamento : MetroForm
    {
        Cadastro cad = new Cadastro();
        Controle contr = new Controle();
        string mensagem;
             
        public frnEditarAgendamento(string agendamento, string NomeDoContato,
            string NomedaEmpresa, string Fone1, string Fone2, string DataDaLigacao,
            string NomeDoAnalista, string Obs)
        {
            InitializeComponent();
            txtCodigo.Text = agendamento;
            txtContato.Text = NomeDoContato;
            txtEmpresa.Text = NomedaEmpresa;
            txtFone1.Text = Fone1;
            txtFone2.Text = Fone2;
            mtrDate.Text = DataDaLigacao;
            cbAnalista.Text = NomeDoAnalista;
            txtObservacao.Text = Obs;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtContato.Text != "")
            {
                cad.NomeContato = txtContato.Text;
                cad.NomeDaEmpresa = txtEmpresa.Text;
                cad.Fone1 = txtFone1.Text;
                cad.Fone2 = txtFone2.Text;
                cad.DataDaLigacao = Convert.ToDateTime(mtrDate.Text);
                cad.NomeDoAnalista = cbAnalista.Text;
                cad.Observacao = txtObservacao.Text;

                if (txtCodigo.Text != string.Empty)
                {
                    cad.Id = Convert.ToInt32(txtCodigo.Text);
                    mensagem = contr.Atualizar(cad);
                    MetroMessageBox.Show(Owner, mensagem + " Atualizado com sucesso.", "Atualizado dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(Owner, "Campo em Branco!", "Informe o nome do Contato.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
