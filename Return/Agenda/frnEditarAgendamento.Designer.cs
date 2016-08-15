namespace Agenda
{
    partial class frnEditarAgendamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtrDate = new MetroFramework.Controls.MetroDateTime();
            this.txtFone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtFone1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.cbAnalista = new MetroFramework.Controls.MetroComboBox();
            this.lblAnalista = new MetroFramework.Controls.MetroLabel();
            this.txtObservacao = new MetroFramework.Controls.MetroTextBox();
            this.lblObservacao = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.txtContato = new MetroFramework.Controls.MetroTextBox();
            this.lblFone = new MetroFramework.Controls.MetroLabel();
            this.lblNomeDaEmpresa = new MetroFramework.Controls.MetroLabel();
            this.lblContato = new MetroFramework.Controls.MetroLabel();
            this.btnGravar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtrDate);
            this.groupBox1.Controls.Add(this.txtFone2);
            this.groupBox1.Controls.Add(this.txtFone1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.cbAnalista);
            this.groupBox1.Controls.Add(this.lblAnalista);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.lblObservacao);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.txtContato);
            this.groupBox1.Controls.Add(this.lblFone);
            this.groupBox1.Controls.Add(this.lblNomeDaEmpresa);
            this.groupBox1.Controls.Add(this.lblContato);
            this.groupBox1.Location = new System.Drawing.Point(18, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 134);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Por:";
            // 
            // mtrDate
            // 
            this.mtrDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.mtrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtrDate.Location = new System.Drawing.Point(646, 16);
            this.mtrDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.mtrDate.Name = "mtrDate";
            this.mtrDate.Size = new System.Drawing.Size(221, 25);
            this.mtrDate.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrDate.TabIndex = 50;
            // 
            // txtFone2
            // 
            this.txtFone2.Location = new System.Drawing.Point(300, 83);
            this.txtFone2.Mask = "(99) 00000-0000";
            this.txtFone2.Name = "txtFone2";
            this.txtFone2.Size = new System.Drawing.Size(143, 20);
            this.txtFone2.TabIndex = 43;
            this.txtFone2.Text = "85";
            // 
            // txtFone1
            // 
            this.txtFone1.Location = new System.Drawing.Point(72, 83);
            this.txtFone1.Mask = "(99) 00000-0000";
            this.txtFone1.Name = "txtFone1";
            this.txtFone1.Size = new System.Drawing.Size(161, 20);
            this.txtFone1.TabIndex = 42;
            this.txtFone1.Text = "85";
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(72, 22);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(31, 23);
            this.txtCodigo.TabIndex = 49;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbAnalista
            // 
            this.cbAnalista.FormattingEnabled = true;
            this.cbAnalista.ItemHeight = 23;
            this.cbAnalista.Location = new System.Drawing.Point(506, 16);
            this.cbAnalista.MaxLength = 250;
            this.cbAnalista.Name = "cbAnalista";
            this.cbAnalista.Size = new System.Drawing.Size(134, 29);
            this.cbAnalista.TabIndex = 44;
            this.cbAnalista.UseSelectable = true;
            // 
            // lblAnalista
            // 
            this.lblAnalista.AutoSize = true;
            this.lblAnalista.Location = new System.Drawing.Point(452, 16);
            this.lblAnalista.Name = "lblAnalista";
            this.lblAnalista.Size = new System.Drawing.Size(57, 19);
            this.lblAnalista.TabIndex = 48;
            this.lblAnalista.Text = "Analista:";
            // 
            // txtObservacao
            // 
            // 
            // 
            // 
            this.txtObservacao.CustomButton.Image = null;
            this.txtObservacao.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtObservacao.CustomButton.Name = "";
            this.txtObservacao.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservacao.CustomButton.TabIndex = 1;
            this.txtObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservacao.CustomButton.UseSelectable = true;
            this.txtObservacao.CustomButton.Visible = false;
            this.txtObservacao.Lines = new string[0];
            this.txtObservacao.Location = new System.Drawing.Point(506, 51);
            this.txtObservacao.MaxLength = 250;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.PasswordChar = '\0';
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacao.SelectedText = "";
            this.txtObservacao.SelectionLength = 0;
            this.txtObservacao.SelectionStart = 0;
            this.txtObservacao.Size = new System.Drawing.Size(361, 55);
            this.txtObservacao.TabIndex = 45;
            this.txtObservacao.UseSelectable = true;
            this.txtObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(473, 52);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(36, 19);
            this.lblObservacao.TabIndex = 47;
            this.lblObservacao.Text = "Obs:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(242, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Fone 2:";
            // 
            // txtEmpresa
            // 
            // 
            // 
            // 
            this.txtEmpresa.CustomButton.Image = null;
            this.txtEmpresa.CustomButton.Location = new System.Drawing.Point(349, 1);
            this.txtEmpresa.CustomButton.Name = "";
            this.txtEmpresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpresa.CustomButton.TabIndex = 1;
            this.txtEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpresa.CustomButton.UseSelectable = true;
            this.txtEmpresa.CustomButton.Visible = false;
            this.txtEmpresa.Lines = new string[0];
            this.txtEmpresa.Location = new System.Drawing.Point(72, 51);
            this.txtEmpresa.MaxLength = 80;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.PasswordChar = '\0';
            this.txtEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpresa.SelectedText = "";
            this.txtEmpresa.SelectionLength = 0;
            this.txtEmpresa.SelectionStart = 0;
            this.txtEmpresa.Size = new System.Drawing.Size(371, 23);
            this.txtEmpresa.TabIndex = 41;
            this.txtEmpresa.UseSelectable = true;
            this.txtEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContato
            // 
            // 
            // 
            // 
            this.txtContato.CustomButton.Image = null;
            this.txtContato.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtContato.CustomButton.Name = "";
            this.txtContato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContato.CustomButton.TabIndex = 1;
            this.txtContato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContato.CustomButton.UseSelectable = true;
            this.txtContato.CustomButton.Visible = false;
            this.txtContato.Lines = new string[0];
            this.txtContato.Location = new System.Drawing.Point(112, 22);
            this.txtContato.MaxLength = 50;
            this.txtContato.Name = "txtContato";
            this.txtContato.PasswordChar = '\0';
            this.txtContato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContato.SelectedText = "";
            this.txtContato.SelectionLength = 0;
            this.txtContato.SelectionStart = 0;
            this.txtContato.Size = new System.Drawing.Size(331, 23);
            this.txtContato.TabIndex = 40;
            this.txtContato.UseSelectable = true;
            this.txtContato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(7, 83);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(50, 19);
            this.lblFone.TabIndex = 39;
            this.lblFone.Text = "Fone 1:";
            // 
            // lblNomeDaEmpresa
            // 
            this.lblNomeDaEmpresa.AutoSize = true;
            this.lblNomeDaEmpresa.Location = new System.Drawing.Point(7, 52);
            this.lblNomeDaEmpresa.Name = "lblNomeDaEmpresa";
            this.lblNomeDaEmpresa.Size = new System.Drawing.Size(67, 19);
            this.lblNomeDaEmpresa.TabIndex = 38;
            this.lblNomeDaEmpresa.Text = "Empresa: ";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(7, 22);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(59, 19);
            this.lblContato.TabIndex = 37;
            this.lblContato.Text = "Contato:";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = null;
            this.btnGravar.Location = new System.Drawing.Point(740, 196);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 54;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseSelectable = true;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(821, 196);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(75, 23);
            this.metroTextButton1.TabIndex = 55;
            this.metroTextButton1.Text = "Cancelar";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // frnEditarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 229);
            this.Controls.Add(this.metroTextButton1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frnEditarAgendamento";
            this.Resizable = false;
            this.Text = "Editar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime mtrDate;
        private System.Windows.Forms.MaskedTextBox txtFone2;
        private System.Windows.Forms.MaskedTextBox txtFone1;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroComboBox cbAnalista;
        private MetroFramework.Controls.MetroLabel lblAnalista;
        private MetroFramework.Controls.MetroTextBox txtObservacao;
        private MetroFramework.Controls.MetroLabel lblObservacao;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEmpresa;
        private MetroFramework.Controls.MetroTextBox txtContato;
        private MetroFramework.Controls.MetroLabel lblFone;
        private MetroFramework.Controls.MetroLabel lblNomeDaEmpresa;
        private MetroFramework.Controls.MetroLabel lblContato;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnGravar;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
    }
}