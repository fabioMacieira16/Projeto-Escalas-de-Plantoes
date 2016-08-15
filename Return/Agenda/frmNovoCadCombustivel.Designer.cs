namespace Agenda
{
    partial class frmNovoCadCombustivel
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
            this.btnGravar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnCancelar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKm = new MetroFramework.Controls.MetroTextBox();
            this.lblvalor1 = new MetroFramework.Controls.MetroLabel();
            this.lblPlantao1 = new MetroFramework.Controls.MetroLabel();
            this.mtrDate = new MetroFramework.Controls.MetroDateTime();
            this.cbAnalista = new MetroFramework.Controls.MetroComboBox();
            this.lblAnalista = new MetroFramework.Controls.MetroLabel();
            this.txtObservacao = new MetroFramework.Controls.MetroTextBox();
            this.lblObservacao = new MetroFramework.Controls.MetroLabel();
            this.txtEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.lblNomeDaEmpresa = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Image = null;
            this.btnGravar.Location = new System.Drawing.Point(655, 205);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 55;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseSelectable = true;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = null;
            this.btnCancelar.Location = new System.Drawing.Point(736, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.lblvalor1);
            this.groupBox1.Controls.Add(this.lblPlantao1);
            this.groupBox1.Controls.Add(this.mtrDate);
            this.groupBox1.Controls.Add(this.cbAnalista);
            this.groupBox1.Controls.Add(this.lblAnalista);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.lblObservacao);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.lblNomeDaEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(11, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 134);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Por:";
            // 
            // txtKm
            // 
            // 
            // 
            // 
            this.txtKm.CustomButton.Image = null;
            this.txtKm.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txtKm.CustomButton.Name = "";
            this.txtKm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKm.CustomButton.TabIndex = 1;
            this.txtKm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKm.CustomButton.UseSelectable = true;
            this.txtKm.CustomButton.Visible = false;
            this.txtKm.Lines = new string[] {
        "0.00"};
            this.txtKm.Location = new System.Drawing.Point(79, 87);
            this.txtKm.MaxLength = 32767;
            this.txtKm.Name = "txtKm";
            this.txtKm.PasswordChar = '\0';
            this.txtKm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKm.SelectedText = "";
            this.txtKm.SelectionLength = 0;
            this.txtKm.SelectionStart = 0;
            this.txtKm.Size = new System.Drawing.Size(64, 23);
            this.txtKm.TabIndex = 108;
            this.txtKm.Text = "0.00";
            this.txtKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKm.UseSelectable = true;
            this.txtKm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblvalor1
            // 
            this.lblvalor1.AutoSize = true;
            this.lblvalor1.Location = new System.Drawing.Point(42, 87);
            this.lblvalor1.Name = "lblvalor1";
            this.lblvalor1.Size = new System.Drawing.Size(31, 19);
            this.lblvalor1.TabIndex = 106;
            this.lblvalor1.Text = "Km:";
            // 
            // lblPlantao1
            // 
            this.lblPlantao1.AutoSize = true;
            this.lblPlantao1.Location = new System.Drawing.Point(464, 22);
            this.lblPlantao1.Name = "lblPlantao1";
            this.lblPlantao1.Size = new System.Drawing.Size(92, 19);
            this.lblPlantao1.TabIndex = 87;
            this.lblPlantao1.Text = "Data da Visita:";
            // 
            // mtrDate
            // 
            this.mtrDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.mtrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtrDate.Location = new System.Drawing.Point(562, 20);
            this.mtrDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.mtrDate.Name = "mtrDate";
            this.mtrDate.Size = new System.Drawing.Size(229, 25);
            this.mtrDate.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrDate.TabIndex = 50;
            // 
            // cbAnalista
            // 
            this.cbAnalista.FormattingEnabled = true;
            this.cbAnalista.ItemHeight = 23;
            this.cbAnalista.Location = new System.Drawing.Point(79, 17);
            this.cbAnalista.MaxLength = 250;
            this.cbAnalista.Name = "cbAnalista";
            this.cbAnalista.Size = new System.Drawing.Size(371, 29);
            this.cbAnalista.TabIndex = 44;
            this.cbAnalista.UseSelectable = true;
            // 
            // lblAnalista
            // 
            this.lblAnalista.AutoSize = true;
            this.lblAnalista.Location = new System.Drawing.Point(16, 17);
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
            this.txtObservacao.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtObservacao.CustomButton.Name = "";
            this.txtObservacao.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservacao.CustomButton.TabIndex = 1;
            this.txtObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservacao.CustomButton.UseSelectable = true;
            this.txtObservacao.CustomButton.Visible = false;
            this.txtObservacao.Lines = new string[0];
            this.txtObservacao.Location = new System.Drawing.Point(506, 55);
            this.txtObservacao.MaxLength = 250;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.PasswordChar = '\0';
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacao.SelectedText = "";
            this.txtObservacao.SelectionLength = 0;
            this.txtObservacao.SelectionStart = 0;
            this.txtObservacao.Size = new System.Drawing.Size(285, 55);
            this.txtObservacao.TabIndex = 45;
            this.txtObservacao.UseSelectable = true;
            this.txtObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(464, 55);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(36, 19);
            this.lblObservacao.TabIndex = 47;
            this.lblObservacao.Text = "Obs:";
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
            this.txtEmpresa.Location = new System.Drawing.Point(79, 52);
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
            // lblNomeDaEmpresa
            // 
            this.lblNomeDaEmpresa.AutoSize = true;
            this.lblNomeDaEmpresa.Location = new System.Drawing.Point(9, 51);
            this.lblNomeDaEmpresa.Name = "lblNomeDaEmpresa";
            this.lblNomeDaEmpresa.Size = new System.Drawing.Size(67, 19);
            this.lblNomeDaEmpresa.TabIndex = 38;
            this.lblNomeDaEmpresa.Text = "Empresa: ";
            // 
            // frmNovoCadCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 240);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovoCadCombustivel";
            this.Resizable = false;
            this.Text = "Controle de Quilometragem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnGravar;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime mtrDate;
        private MetroFramework.Controls.MetroComboBox cbAnalista;
        private MetroFramework.Controls.MetroLabel lblAnalista;
        private MetroFramework.Controls.MetroTextBox txtObservacao;
        private MetroFramework.Controls.MetroLabel lblObservacao;
        private MetroFramework.Controls.MetroTextBox txtEmpresa;
        private MetroFramework.Controls.MetroLabel lblNomeDaEmpresa;
        private MetroFramework.Controls.MetroLabel lblPlantao1;
        private MetroFramework.Controls.MetroLabel lblvalor1;
        private MetroFramework.Controls.MetroTextBox txtKm;

    }
}