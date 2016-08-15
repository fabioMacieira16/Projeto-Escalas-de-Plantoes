using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Agenda.Model;
using Agenda.Controller;
using MetroFramework;
using System.Data.OleDb;
using Agenda.Properties;
using System.Collections.Generic;

namespace Agenda
{
    public partial class frmCadastroCliente : MetroForm
    {

        Cadastro cad = new Cadastro();
        Controle contr = new Controle();
        ControlePlantao contrPlantao = new ControlePlantao();
        ControleKm controlKm = new ControleKm();

        string mensagem;

        public frmCadastroCliente()
        {
            InitializeComponent();
            PovoaGrade();
            PovoaGradePlantao();
            PovoaGradeKm();
        }
        private void analistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAnalista cadAnalista = new frmCadastroAnalista();
            cadAnalista.ShowDialog();
            cadAnalista.Dispose();
        }
        private void tabAgendamento_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void rbAtivo_Click_1(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void rbInativo_Click_1(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void rbTodos_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            frmNovoAgendamento formNovo = new frmNovoAgendamento();
            formNovo.ShowDialog();
            formNovo.Dispose();
            PovoaGrade();
        }
        private void btnNovoEscPlantoa_Click(object sender, EventArgs e)
        {
            frmNovoCadPlantao cadPlatao = new frmNovoCadPlantao();
            cadPlatao.ShowDialog();
            cadPlatao.Dispose();
        }
        public void Filtrar()
        {
            if (rbTodos.Checked)
            {
                dgvListaClientes.DataSource = contr.ListaAgenda();
            }
            if (rbAtivo.Checked)
            {
                dgvListaClientes.DataSource = contr.Ativo();
                
            }
            if (rbInativo.Checked)
            {
                dgvListaClientes.DataSource = contr.Inativo();
                lblResultado.Text = contr.QtdAtivo().ToString();
            }
        }
        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFiltrar.Text == "Contato")
            {
                dgvListaClientes.DataSource = contr.RetContato(txtConsultar.Text + "%");
            }
            else if (CbFiltrar.Text == "Empresa")
            {
                dgvListaClientes.DataSource = contr.RetEmpresa(txtConsultar.Text + "%");
            }
            else if (CbFiltrar.Text == "Analista")
            {
                dgvListaClientes.DataSource = contr.RetNomeAnalista(txtConsultar.Text + "%");
            }
            else if (CbFiltrar.Text == "Data da Ligação")
            {
                dgvListaClientes.DataSource = contr.RetDataLigacao("%" + txtConsultar.Text + "%");
            }
        }
        private void btnNovoContCombustivel_Click(object sender, EventArgs e)
        {
            frmNovoCadCombustivel cadCombutivel = new frmNovoCadCombustivel();
            cadCombutivel.ShowDialog();
            cadCombutivel.Dispose();
            PovoaGradeKm();
        }
        private void dgvListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvListaClientes.Rows.Count > 0)
            {
                var linhaSelecionada = dgvListaClientes.Rows[e.RowIndex];
                frnEditarAgendamento fAgendamento = new frnEditarAgendamento(
                    dgvListaClientes.SelectedRows[0].Cells[0].Value.ToString(),
                    dgvListaClientes.SelectedRows[0].Cells[1].Value.ToString(),
                    dgvListaClientes.SelectedRows[0].Cells[2].Value.ToString(),
                    dgvListaClientes.SelectedRows[0].Cells[3].Value.ToString(),
                    dgvListaClientes.SelectedRows[0].Cells[4].Value.ToString(),
                    dgvListaClientes.SelectedRows[0].Cells[5].Value.ToString(),
                    dgvListaClientes.SelectedRows[0].Cells[6].Value.ToString(),
                    dgvListaClientes.SelectedRows[0].Cells[7].Value.ToString()
                    );
                btnExcluir.Enabled = true;
                fAgendamento.ShowDialog();
                PovoaGrade();
            }
        }
        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvListaClientes.Rows.Count > 0)
            {
                txtCodigo.Text = dgvListaClientes.SelectedRows[0].Cells[0].Value.ToString();

                btnExcluir.Enabled = true;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(Owner, "Deseja excluir o Agendamento", "Deletar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int idCad = int.Parse(txtCodigo.Text);
                contr.Exluir(idCad);
                PovoaGrade();
                btnExcluir.Enabled = false;
            }
        }
        private void btnRetonardo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MetroMessageBox.Show(Owner, "Modificação de dados!", "Informa uma contato.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cad.Id = Convert.ToInt32(txtCodigo.Text);
                mensagem = contr.retornar(cad);
                MetroMessageBox.Show(Owner, mensagem + " Retornado com sucesso.", "Dados Atualizado.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            dgvListaClientes.DataSource = contr.ListaAgenda();
            dgvListaClientes.Refresh();
        }
        public void PovoaGrade()
        {
            dgvListaClientes.DataSource = contr.ListaAgenda();
            dgvListaClientes.Refresh();
        }
        public void PovoaGradePlantao()
        {
            dgvListaPlantao.DataSource = contrPlantao.ListaDePlantao();
            dgvListaPlantao.Refresh();
        }

        public void PovoaGradeKm()
        {
            dgvListaKm.DataSource = controlKm.ListarKm();
            dgvListaKm.Refresh();
        }
        private void btnFolga_Click(object sender, EventArgs e)
        {
            frmNovoCadFolgas folgas = new frmNovoCadFolgas();
            folgas.ShowDialog();
            folgas.Dispose();

        }

    }
}

