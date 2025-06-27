namespace GPSFrancisco
{
    partial class frmGerenciarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarProdutos));
            this.gpbInformacoesVoluntario = new System.Windows.Forms.GroupBox();
            this.lblImagemcodigodebarras = new System.Windows.Forms.Label();
            this.pcbcodigodebarras = new System.Windows.Forms.PictureBox();
            this.btnVerificaunidade = new System.Windows.Forms.Button();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblHoradeEntrada = new System.Windows.Forms.Label();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.cbbUnidades = new System.Windows.Forms.ComboBox();
            this.lbllote = new System.Windows.Forms.Label();
            this.dtpHoradeEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDatadeEntrada = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigodeBarras = new System.Windows.Forms.TextBox();
            this.lblCodigodeBarras = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.opfdCarregaProduto = new System.Windows.Forms.OpenFileDialog();
            this.gpbInformacoesVoluntario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcodigodebarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInformacoesVoluntario
            // 
            this.gpbInformacoesVoluntario.Controls.Add(this.lblImagemcodigodebarras);
            this.gpbInformacoesVoluntario.Controls.Add(this.pcbcodigodebarras);
            this.gpbInformacoesVoluntario.Controls.Add(this.btnVerificaunidade);
            this.gpbInformacoesVoluntario.Controls.Add(this.lblDataEntrada);
            this.gpbInformacoesVoluntario.Controls.Add(this.lblValidade);
            this.gpbInformacoesVoluntario.Controls.Add(this.lblHoradeEntrada);
            this.gpbInformacoesVoluntario.Controls.Add(this.dtpValidade);
            this.gpbInformacoesVoluntario.Controls.Add(this.lblquantidade);
            this.gpbInformacoesVoluntario.Controls.Add(this.textBox2);
            this.gpbInformacoesVoluntario.Controls.Add(this.lblUnidade);
            this.gpbInformacoesVoluntario.Controls.Add(this.cbbUnidades);
            this.gpbInformacoesVoluntario.Controls.Add(this.lbllote);
            this.gpbInformacoesVoluntario.Controls.Add(this.dtpHoradeEntrada);
            this.gpbInformacoesVoluntario.Controls.Add(this.dtpDatadeEntrada);
            this.gpbInformacoesVoluntario.Controls.Add(this.textBox1);
            this.gpbInformacoesVoluntario.Controls.Add(this.btnInserir);
            this.gpbInformacoesVoluntario.Controls.Add(this.pcbFoto);
            this.gpbInformacoesVoluntario.Controls.Add(this.txtNome);
            this.gpbInformacoesVoluntario.Controls.Add(this.lblDescricao);
            this.gpbInformacoesVoluntario.Controls.Add(this.txtCodigodeBarras);
            this.gpbInformacoesVoluntario.Controls.Add(this.lblCodigodeBarras);
            this.gpbInformacoesVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoesVoluntario.Location = new System.Drawing.Point(12, 12);
            this.gpbInformacoesVoluntario.Name = "gpbInformacoesVoluntario";
            this.gpbInformacoesVoluntario.Size = new System.Drawing.Size(867, 432);
            this.gpbInformacoesVoluntario.TabIndex = 1;
            this.gpbInformacoesVoluntario.TabStop = false;
            this.gpbInformacoesVoluntario.Text = "Informações do voluntário";
            // 
            // lblImagemcodigodebarras
            // 
            this.lblImagemcodigodebarras.AutoSize = true;
            this.lblImagemcodigodebarras.Location = new System.Drawing.Point(324, 25);
            this.lblImagemcodigodebarras.Name = "lblImagemcodigodebarras";
            this.lblImagemcodigodebarras.Size = new System.Drawing.Size(189, 20);
            this.lblImagemcodigodebarras.TabIndex = 42;
            this.lblImagemcodigodebarras.Text = "Imagem código de barras";
            // 
            // pcbcodigodebarras
            // 
            this.pcbcodigodebarras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbcodigodebarras.Location = new System.Drawing.Point(325, 49);
            this.pcbcodigodebarras.Name = "pcbcodigodebarras";
            this.pcbcodigodebarras.Size = new System.Drawing.Size(339, 57);
            this.pcbcodigodebarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbcodigodebarras.TabIndex = 41;
            this.pcbcodigodebarras.TabStop = false;
            // 
            // btnVerificaunidade
            // 
            this.btnVerificaunidade.FlatAppearance.BorderSize = 0;
            this.btnVerificaunidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificaunidade.Image = ((System.Drawing.Image)(resources.GetObject("btnVerificaunidade.Image")));
            this.btnVerificaunidade.Location = new System.Drawing.Point(624, 137);
            this.btnVerificaunidade.Name = "btnVerificaunidade";
            this.btnVerificaunidade.Size = new System.Drawing.Size(40, 39);
            this.btnVerificaunidade.TabIndex = 40;
            this.btnVerificaunidade.UseVisualStyleBackColor = true;
            this.btnVerificaunidade.Click += new System.EventHandler(this.btnVerificaunidade_Click);
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(23, 281);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblDataEntrada.TabIndex = 39;
            this.lblDataEntrada.Text = "Data de Entrada";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(345, 281);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(71, 20);
            this.lblValidade.TabIndex = 38;
            this.lblValidade.Text = "Validade";
            // 
            // lblHoradeEntrada
            // 
            this.lblHoradeEntrada.AutoSize = true;
            this.lblHoradeEntrada.Location = new System.Drawing.Point(182, 281);
            this.lblHoradeEntrada.Name = "lblHoradeEntrada";
            this.lblHoradeEntrada.Size = new System.Drawing.Size(127, 20);
            this.lblHoradeEntrada.TabIndex = 37;
            this.lblHoradeEntrada.Text = "Hora de Entrada";
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(349, 304);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(107, 26);
            this.dtpValidade.TabIndex = 35;
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Location = new System.Drawing.Point(23, 202);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(92, 20);
            this.lblquantidade.TabIndex = 34;
            this.lblquantidade.Text = "Quantidade";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 225);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 26);
            this.textBox2.TabIndex = 32;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(495, 120);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(69, 20);
            this.lblUnidade.TabIndex = 31;
            this.lblUnidade.Text = "Unidade";
            // 
            // cbbUnidades
            // 
            this.cbbUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUnidades.FormattingEnabled = true;
            this.cbbUnidades.Location = new System.Drawing.Point(497, 143);
            this.cbbUnidades.Name = "cbbUnidades";
            this.cbbUnidades.Size = new System.Drawing.Size(121, 28);
            this.cbbUnidades.TabIndex = 30;
            // 
            // lbllote
            // 
            this.lbllote.AutoSize = true;
            this.lbllote.Location = new System.Drawing.Point(324, 120);
            this.lbllote.Name = "lbllote";
            this.lbllote.Size = new System.Drawing.Size(41, 20);
            this.lbllote.TabIndex = 29;
            this.lbllote.Text = "Lote";
            // 
            // dtpHoradeEntrada
            // 
            this.dtpHoradeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoradeEntrada.Location = new System.Drawing.Point(186, 304);
            this.dtpHoradeEntrada.Name = "dtpHoradeEntrada";
            this.dtpHoradeEntrada.Size = new System.Drawing.Size(97, 26);
            this.dtpHoradeEntrada.TabIndex = 28;
            // 
            // dtpDatadeEntrada
            // 
            this.dtpDatadeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatadeEntrada.Location = new System.Drawing.Point(27, 304);
            this.dtpDatadeEntrada.Name = "dtpDatadeEntrada";
            this.dtpDatadeEntrada.Size = new System.Drawing.Size(107, 26);
            this.dtpDatadeEntrada.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 143);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 26;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(682, 175);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(150, 29);
            this.btnInserir.TabIndex = 25;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // pcbFoto
            // 
            this.pcbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbFoto.Location = new System.Drawing.Point(682, 25);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(150, 144);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 21;
            this.pcbFoto.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 143);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(27, 120);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtCodigodeBarras
            // 
            this.txtCodigodeBarras.Location = new System.Drawing.Point(27, 66);
            this.txtCodigodeBarras.MaxLength = 15;
            this.txtCodigodeBarras.Name = "txtCodigodeBarras";
            this.txtCodigodeBarras.Size = new System.Drawing.Size(256, 26);
            this.txtCodigodeBarras.TabIndex = 1;
            this.txtCodigodeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigodeBarras_KeyDown);
            // 
            // lblCodigodeBarras
            // 
            this.lblCodigodeBarras.AutoSize = true;
            this.lblCodigodeBarras.Location = new System.Drawing.Point(27, 38);
            this.lblCodigodeBarras.Name = "lblCodigodeBarras";
            this.lblCodigodeBarras.Size = new System.Drawing.Size(130, 20);
            this.lblCodigodeBarras.TabIndex = 0;
            this.lblCodigodeBarras.Text = "Código de barras";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(12, 450);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(867, 65);
            this.pnlCRUD.TabIndex = 18;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(744, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(121, 42);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(621, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 42);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(497, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 42);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(374, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 42);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(252, 11);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(121, 42);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(129, 11);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 42);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(4, 11);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 42);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmGerenciarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 515);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbInformacoesVoluntario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarProdutos";
            this.gpbInformacoesVoluntario.ResumeLayout(false);
            this.gpbInformacoesVoluntario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcodigodebarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInformacoesVoluntario;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigodeBarras;
        private System.Windows.Forms.Label lblCodigodeBarras;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DateTimePicker dtpHoradeEntrada;
        private System.Windows.Forms.DateTimePicker dtpDatadeEntrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.ComboBox cbbUnidades;
        private System.Windows.Forms.Label lbllote;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblHoradeEntrada;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Button btnVerificaunidade;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.OpenFileDialog opfdCarregaProduto;
        private System.Windows.Forms.Label lblImagemcodigodebarras;
        private System.Windows.Forms.PictureBox pcbcodigodebarras;
    }
}