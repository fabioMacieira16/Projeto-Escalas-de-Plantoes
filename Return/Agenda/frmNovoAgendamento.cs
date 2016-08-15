using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Agenda.Model;
using Agenda.Controller;
using MetroFramework;
using System.Data.OleDb;
using Agenda.Properties;

namespace Agenda
{
    public partial class frmNovoAgendamento : MetroForm 
    {
        Cadastro cad = new Cadastro();
        Controle contr = new Controle();

        string mensagem;
        public frmNovoAgendamento()
        {
            InitializeComponent();
        }
        private void btnGravar_Click(object sender, System.EventArgs e)
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
                else
                {
                    mensagem = contr.Gravar(cad);
                    MetroMessageBox.Show(Owner, mensagem + " Gravado com sucesso.", "Gravando dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(Owner, "Campo em Branco!", "Informe o nome do Contato.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void cbAnalista_MouseClick(object sender, MouseEventArgs e)
        {
            cbAnalista.DisplayMember = "NomeDoAnalista";
            cbAnalista.DataSource = contr.ListaAnalistas();
        }
    }
}
