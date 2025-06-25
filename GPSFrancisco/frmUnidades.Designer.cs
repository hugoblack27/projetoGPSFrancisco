﻿namespace GPSFrancisco
{
    partial class frmUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnidades));
            this.gpbUnidade = new System.Windows.Forms.GroupBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbUnidade.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbUnidade
            // 
            this.gpbUnidade.Controls.Add(this.txtUnidade);
            this.gpbUnidade.Controls.Add(this.lblUnidade);
            this.gpbUnidade.Controls.Add(this.txtDescricao);
            this.gpbUnidade.Controls.Add(this.lblDescricao);
            this.gpbUnidade.Controls.Add(this.txtCodigo);
            this.gpbUnidade.Controls.Add(this.lblCodigo);
            this.gpbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUnidade.Location = new System.Drawing.Point(11, 12);
            this.gpbUnidade.Name = "gpbUnidade";
            this.gpbUnidade.Size = new System.Drawing.Size(452, 230);
            this.gpbUnidade.TabIndex = 2;
            this.gpbUnidade.TabStop = false;
            this.gpbUnidade.Text = "Unidade";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(332, 120);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(69, 20);
            this.lblUnidade.TabIndex = 31;
            this.lblUnidade.Text = "Unidade";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(27, 143);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(256, 26);
            this.txtDescricao.TabIndex = 2;
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
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(27, 66);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(256, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(130, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código de barras";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(336, 143);
            this.txtUnidade.MaxLength = 100;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(101, 26);
            this.txtUnidade.TabIndex = 32;
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
            this.pnlCRUD.Location = new System.Drawing.Point(11, 248);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(452, 247);
            this.pnlCRUD.TabIndex = 19;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(322, 188);
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
            this.btnLimpar.Location = new System.Drawing.Point(161, 103);
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
            this.btnPesquisar.Location = new System.Drawing.Point(322, 103);
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
            this.btnExcluir.Location = new System.Drawing.Point(4, 188);
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
            this.btnAlterar.Location = new System.Drawing.Point(161, 188);
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
            this.btnCadastrar.Location = new System.Drawing.Point(4, 103);
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
            this.btnNovo.Location = new System.Drawing.Point(4, 27);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 42);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // frmUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 496);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbUnidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUnidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUnidades";
            this.gpbUnidade.ResumeLayout(false);
            this.gpbUnidade.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbUnidade;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
    }
}