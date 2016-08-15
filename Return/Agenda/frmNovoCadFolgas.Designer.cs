namespace Agenda
{
    partial class frmNovoCadFolgas
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtrDtaFolga = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbAnalista = new MetroFramework.Controls.MetroComboBox();
            this.lblAnalista = new MetroFramework.Controls.MetroLabel();
            this.lblPlantao1 = new MetroFramework.Controls.MetroLabel();
            this.mtrDtaTrabalhada = new MetroFramework.Controls.MetroDateTime();
            this.txtObservacao = new MetroFramework.Controls.MetroTextBox();
            this.lblObservacao = new MetroFramework.Controls.MetroLabel();
            this.btnGravar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnCancelar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroPanel1);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.lblObservacao);
            this.groupBox1.Location = new System.Drawing.Point(5, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 164);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escala de plantão";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.mtrDtaFolga);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.cbAnalista);
            this.metroPanel1.Controls.Add(this.lblAnalista);
            this.metroPanel1.Controls.Add(this.lblPlantao1);
            this.metroPanel1.Controls.Add(this.mtrDtaTrabalhada);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 22);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(695, 48);
            this.metroPanel1.TabIndex = 49;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mtrDtaFolga
            // 
            this.mtrDtaFolga.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.mtrDtaFolga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtrDtaFolga.Location = new System.Drawing.Point(571, 10);
            this.mtrDtaFolga.MinimumSize = new System.Drawing.Size(0, 25);
            this.mtrDtaFolga.Name = "mtrDtaFolga";
            this.mtrDtaFolga.Size = new System.Drawing.Size(111, 25);
            this.mtrDtaFolga.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrDtaFolga.TabIndex = 89;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(514, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 88;
            this.metroLabel1.Text = "Folga:";
            // 
            // cbAnalista
            // 
            this.cbAnalista.FormattingEnabled = true;
            this.cbAnalista.ItemHeight = 23;
            this.cbAnalista.Location = new System.Drawing.Point(61, 6);
            this.cbAnalista.MaxLength = 250;
            this.cbAnalista.Name = "cbAnalista";
            this.cbAnalista.Size = new System.Drawing.Size(207, 29);
            this.cbAnalista.TabIndex = 44;
            this.cbAnalista.UseSelectable = true;
            // 
            // lblAnalista
            // 
            this.lblAnalista.AutoSize = true;
            this.lblAnalista.Location = new System.Drawing.Point(-2, 10);
            this.lblAnalista.Name = "lblAnalista";
            this.lblAnalista.Size = new System.Drawing.Size(57, 19);
            this.lblAnalista.TabIndex = 48;
            this.lblAnalista.Text = "Analista:";
            // 
            // lblPlantao1
            // 
            this.lblPlantao1.AutoSize = true;
            this.lblPlantao1.Location = new System.Drawing.Point(274, 10);
            this.lblPlantao1.Name = "lblPlantao1";
            this.lblPlantao1.Size = new System.Drawing.Size(114, 19);
            this.lblPlantao1.TabIndex = 86;
            this.lblPlantao1.Text = "Data Trabalahada:";
            // 
            // mtrDtaTrabalhada
            // 
            this.mtrDtaTrabalhada.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.mtrDtaTrabalhada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtrDtaTrabalhada.Location = new System.Drawing.Point(394, 10);
            this.mtrDtaTrabalhada.MinimumSize = new System.Drawing.Size(0, 25);
            this.mtrDtaTrabalhada.Name = "mtrDtaTrabalhada";
            this.mtrDtaTrabalhada.Size = new System.Drawing.Size(111, 25);
            this.mtrDtaTrabalhada.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrDtaTrabalhada.TabIndex = 85;
            // 
            // txtObservacao
            // 
            // 
            // 
            // 
            this.txtObservacao.CustomButton.Image = null;
            this.txtObservacao.CustomButton.Location = new System.Drawing.Point(598, 1);
            this.txtObservacao.CustomButton.Name = "";
            this.txtObservacao.CustomButton.Size = new System.Drawing.Size(77, 77);
            this.txtObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservacao.CustomButton.TabIndex = 1;
            this.txtObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservacao.CustomButton.UseSelectable = true;
            this.txtObservacao.CustomButton.Visible = false;
            this.txtObservacao.Lines = new string[0];
            this.txtObservacao.Location = new System.Drawing.Point(42, 76);
            this.txtObservacao.MaxLength = 150;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.PasswordChar = '\0';
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacao.SelectedText = "";
            this.txtObservacao.SelectionLength = 0;
            this.txtObservacao.SelectionStart = 0;
            this.txtObservacao.Size = new System.Drawing.Size(676, 79);
            this.txtObservacao.TabIndex = 45;
            this.txtObservacao.UseSelectable = true;
            this.txtObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(0, 73);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(36, 19);
            this.lblObservacao.TabIndex = 47;
            this.lblObservacao.Text = "Obs:";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = null;
            this.btnGravar.Location = new System.Drawing.Point(567, 228);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 56;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseSelectable = true;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = null;
            this.btnCancelar.Location = new System.Drawing.Point(648, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNovoCadFolgas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 259);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovoCadFolgas";
            this.Resizable = false;
            this.Text = "Agendamento de Folgas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cbAnalista;
        private MetroFramework.Controls.MetroLabel lblAnalista;
        private MetroFramework.Controls.MetroLabel lblPlantao1;
        private MetroFramework.Controls.MetroDateTime mtrDtaTrabalhada;
        private MetroFramework.Controls.MetroTextBox txtObservacao;
        private MetroFramework.Controls.MetroLabel lblObservacao;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnGravar;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnCancelar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime mtrDtaFolga;
    }
}