using System.Windows.Forms;
using MetroFramework.Forms;
using Agenda.Model;
using Agenda.Controller;
using System;
using MetroFramework;
using System.Data.OleDb;

namespace Agenda
{
    public partial class frmCadastroAnalista : MetroForm
    {
        CadastroAnalistas cad = new CadastroAnalistas();
        ControleAnalista contr = new ControleAnalista();
        Conexao connectio = new Conexao();
        public frmCadastroAnalista()
        {
            InitializeComponent();
            PovoaGrade();
        }
        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            HabilitaCampos();
            LimpaTela();
        }
        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            string mensagem;
            if (txtNomeAnalista.Text != "")
            {
                cad.NomeDoAnalista = txtNomeAnalista.Text;

                if (txtCodigo.Text != string.Empty)
                {
                    cad.Id = Convert.ToInt32(txtCodigo.Text);
                    mensagem = contr.Atualizar(cad);
                    MetroMessageBox.Show(Owner, "Atualizado com sucesso.", "Editando dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaTela();
                }
                else
                {
                    mensagem = contr.Gravar(cad);
                    MetroMessageBox.Show(Owner, "Gravado com sucesso.", "Gravando dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaTela();
                }
                dgvListaAnalistas.DataSource = contr.ListaAnalista();
                dgvListaAnalistas.Refresh();
            }
            else
            {
                MetroMessageBox.Show(Owner, "Informe o Nome do Analista", "Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(Owner, "Excluir Analista.", "Deseja Excluir o Analista?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
               
                int idCadAnalista = int.Parse(txtCodigo.Text);
                contr.Exluir(idCadAnalista);
                LimpaTela();
                PovoaGrade();
                btnExcluir.Enabled = false;
                MetroMessageBox.Show(Owner, "Analista Excluido");
            }
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DesabilitaCampos();
            LimpaTela();
        }
        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            LimpaTela();
        }
        public void HabilitaCampos()
        {
            txtNomeAnalista.Enabled = true;
            txtNomeAnalista.Focus();

            //Habilitando Botoes
            btnNovo.Enabled = btnGravar.Enabled = btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
        }
        public void DesabilitaCampos()
        {
            btnGravar.Enabled = btnExcluir.Enabled = btnCancelar.Enabled = false;
        }
        public void LimpaTela() 
        {
            txtCodigo.Text = txtNomeAnalista.Text = string.Empty;
        }
        public void PovoaGrade()
        {
            dgvListaAnalistas.DataSource = contr.ListaAnalista();
        }
        private void dgvListaAnalistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvListaAnalistas.Rows.Count > 0)
            {
                var linhaSelecionada = dgvListaAnalistas.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                txtNomeAnalista.Text = linhaSelecionada.Cells["NomeDoAnalistaDataGridViewTextBoxColumn"].Value.ToString();
                HabilitaCampos();
                btnExcluir.Enabled = true;
            }
        }
    }
}
