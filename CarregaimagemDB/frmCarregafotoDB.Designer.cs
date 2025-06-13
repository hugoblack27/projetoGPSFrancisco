namespace CarregaimagemDB
{
    partial class frmCarregafotoDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pcbFotos = new System.Windows.Forms.PictureBox();
            this.txtxBuscarfoto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvarFotos = new System.Windows.Forms.Button();
            this.btnInserirFotos = new System.Windows.Forms.Button();
            this.ofdInserirFotos = new System.Windows.Forms.OpenFileDialog();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(195, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 26);
            this.txtNome.TabIndex = 14;
            // 
            // pcbFotos
            // 
            this.pcbFotos.Location = new System.Drawing.Point(223, 76);
            this.pcbFotos.Name = "pcbFotos";
            this.pcbFotos.Size = new System.Drawing.Size(318, 271);
            this.pcbFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFotos.TabIndex = 13;
            this.pcbFotos.TabStop = false;
            // 
            // txtxBuscarfoto
            // 
            this.txtxBuscarfoto.Location = new System.Drawing.Point(83, 353);
            this.txtxBuscarfoto.Name = "txtxBuscarfoto";
            this.txtxBuscarfoto.Size = new System.Drawing.Size(634, 20);
            this.txtxBuscarfoto.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(482, 409);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 36);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(340, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 36);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvarFotos
            // 
            this.btnSalvarFotos.Location = new System.Drawing.Point(182, 409);
            this.btnSalvarFotos.Name = "btnSalvarFotos";
            this.btnSalvarFotos.Size = new System.Drawing.Size(108, 36);
            this.btnSalvarFotos.TabIndex = 9;
            this.btnSalvarFotos.Text = "Salvar Fotos";
            this.btnSalvarFotos.UseVisualStyleBackColor = true;
            this.btnSalvarFotos.Click += new System.EventHandler(this.btnSalvarFotos_Click);
            // 
            // btnInserirFotos
            // 
            this.btnInserirFotos.Location = new System.Drawing.Point(41, 409);
            this.btnInserirFotos.Name = "btnInserirFotos";
            this.btnInserirFotos.Size = new System.Drawing.Size(108, 36);
            this.btnInserirFotos.TabIndex = 8;
            this.btnInserirFotos.Text = "Inserir fotos";
            this.btnInserirFotos.UseVisualStyleBackColor = true;
            this.btnInserirFotos.Click += new System.EventHandler(this.btnInserirFotos_Click);
            // 
            // ofdInserirFotos
            // 
            this.ofdInserirFotos.FileName = "openFileDialog1";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(619, 409);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 36);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCarregafotoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pcbFotos);
            this.Controls.Add(this.txtxBuscarfoto);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvarFotos);
            this.Controls.Add(this.btnInserirFotos);
            this.Name = "frmCarregafotoDB";
            this.Text = "Carregar foto";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pcbFotos;
        private System.Windows.Forms.TextBox txtxBuscarfoto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvarFotos;
        private System.Windows.Forms.Button btnInserirFotos;
        private System.Windows.Forms.OpenFileDialog ofdInserirFotos;
        private System.Windows.Forms.Button btnSair;
    }
}