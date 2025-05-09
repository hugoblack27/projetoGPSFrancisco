using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace GPSFrancisco
{

    public partial class frmGerenciarUsuarios : Form
    {
        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            desabilitarcampos();
        }

        public void desabilitarcampos()
        {
            txtCodigo.Enabled = false;
            txtsenha.Enabled = false;
            txtValidaSenha.Enabled = false;
            txtusuario.Enabled = false;
            btnLimpar.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        public void habilitarcampos()
        {
            txtCodigo.Enabled = false;
            txtsenha.Enabled = true;
            txtValidaSenha.Enabled = true;
            txtusuario.Enabled = true;
            btnLimpar.Enabled = true;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            txtusuario.Focus();
        }

        public void desabilitarcamposCadastrar()
        {
            txtCodigo.Enabled = false;
            txtsenha.Enabled = false;
            txtValidaSenha.Enabled = false;
            btnLimpar.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            txtusuario.Clear();
            txtsenha.Clear();
            txtValidaSenha.Clear();

        }

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal();
            voltar.Show();
            this.Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            limparcampos();

        }

        public void limparcampos()
        {
            txtCodigo.Clear();
            txtsenha.Clear();
            txtusuario.Clear();
            txtValidaSenha.Clear();
            txtusuario.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarcampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text.Equals("") || txtsenha.Text.Equals("") || txtValidaSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor Inserir valores", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {

                    if(txtsenha.Text.Length < 12 || txtValidaSenha.Text.Length < 12)
                    {
                    
                        MessageBox.Show("Senha com poucos caracteres, coloque 12 caracteres", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    desabilitarcampos();
                    }else
                    {
                if (txtsenha.Text.Equals(txtValidaSenha.Text)) 
                {
                
                        MessageBox.Show("Cadastrado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    MessageBox.Show("Senha invalida, colocar a mesma senha", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtsenha.Clear();
                    txtValidaSenha.Clear();    
                    txtusuario.Focus();

                    }
                }

            }
            limparcampos();
        }
    }
}
