namespace Agenda
{
    partial class frmCadastroAnalista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.txtNomeAnalista = new MetroFramework.Controls.MetroTextBox();
            this.lblContato = new MetroFramework.Controls.MetroLabel();
            this.dgvListaAnalistas = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoAnalistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroAnalistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovo = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnGravar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnExcluir = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnCancelar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAnalistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroAnalistasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(88, 92);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(34, 23);
            this.txtCodigo.TabIndex = 27;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNomeAnalista
            // 
            // 
            // 
            // 
            this.txtNomeAnalista.CustomButton.Image = null;
            this.txtNomeAnalista.CustomButton.Location = new System.Drawing.Point(560, 1);
            this.txtNomeAnalista.CustomButton.Name = "";
            this.txtNomeAnalista.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeAnalista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeAnalista.CustomButton.TabIndex = 1;
            this.txtNomeAnalista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeAnalista.CustomButton.UseSelectable = true;
            this.txtNomeAnalista.CustomButton.Visible = false;
            this.txtNomeAnalista.Enabled = false;
            this.txtNomeAnalista.Lines = new string[0];
            this.txtNomeAnalista.Location = new System.Drawing.Point(128, 92);
            this.txtNomeAnalista.MaxLength = 50;
            this.txtNomeAnalista.Name = "txtNomeAnalista";
            this.txtNomeAnalista.PasswordChar = '\0';
            this.txtNomeAnalista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeAnalista.SelectedText = "";
            this.txtNomeAnalista.SelectionLength = 0;
            this.txtNomeAnalista.SelectionStart = 0;
            this.txtNomeAnalista.Size = new System.Drawing.Size(582, 23);
            this.txtNomeAnalista.TabIndex = 26;
            this.txtNomeAnalista.UseSelectable = true;
            this.txtNomeAnalista.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeAnalista.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(23, 92);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(59, 19);
            this.lblContato.TabIndex = 25;
            this.lblContato.Text = "Contato:";
            // 
            // dgvListaAnalistas
            // 
            this.dgvListaAnalistas.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dgvListaAnalistas.AllowUserToAddRows = false;
            this.dgvListaAnalistas.AllowUserToResizeRows = false;
            this.dgvListaAnalistas.AutoGenerateColumns = false;
            this.dgvListaAnalistas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaAnalistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaAnalistas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaAnalistas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaAnalistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaAnalistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAnalistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDoAnalistaDataGridViewTextBoxColumn});
            this.dgvListaAnalistas.DataSource = this.cadastroAnalistasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaAnalistas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaAnalistas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListaAnalistas.EnableHeadersVisualStyles = false;
            this.dgvListaAnalistas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListaAnalistas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaAnalistas.Location = new System.Drawing.Point(20, 121);
            this.dgvListaAnalistas.Name = "dgvListaAnalistas";
            this.dgvListaAnalistas.ReadOnly = true;
            this.dgvListaAnalistas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaAnalistas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaAnalistas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaAnalistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaAnalistas.Size = new System.Drawing.Size(713, 284);
            this.dgvListaAnalistas.TabIndex = 28;
            this.dgvListaAnalistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAnalistas_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDoAnalistaDataGridViewTextBoxColumn
            // 
            this.nomeDoAnalistaDataGridViewTextBoxColumn.DataPropertyName = "NomeDoAnalista";
            this.nomeDoAnalistaDataGridViewTextBoxColumn.HeaderText = "Nome Do Analista";
            this.nomeDoAnalistaDataGridViewTextBoxColumn.Name = "nomeDoAnalistaDataGridViewTextBoxColumn";
            this.nomeDoAnalistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDoAnalistaDataGridViewTextBoxColumn.Width = 600;
            // 
            // cadastroAnalistasBindingSource
            // 
            this.cadastroAnalistasBindingSource.DataSource = typeof(Agenda.Model.CadastroAnalistas);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = null;
            this.btnNovo.Location = new System.Drawing.Point(23, 63);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 29;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseSelectable = true;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = null;
            this.btnGravar.Location = new System.Drawing.Point(104, 63);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 30;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseSelectable = true;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = null;
            this.btnExcluir.Location = new System.Drawing.Point(185, 63);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = null;
            this.btnCancelar.Location = new System.Drawing.Point(266, 63);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastroAnalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 425);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvListaAnalistas);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNomeAnalista);
            this.Controls.Add(this.lblContato);
            this.MaximizeBox = false;
            this.Name = "frmCadastroAnalista";
            this.Resizable = false;
            this.Text = "Cadastro de Analistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAnalistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroAnalistasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroTextBox txtNomeAnalista;
        private MetroFramework.Controls.MetroLabel lblContato;
        private MetroFramework.Controls.MetroGrid dgvListaAnalistas;
        private System.Windows.Forms.BindingSource cadastroAnalistasBindingSource;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnNovo;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnGravar;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnExcluir;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoAnalistaDataGridViewTextBoxColumn;
    }
}