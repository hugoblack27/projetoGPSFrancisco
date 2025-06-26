using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmUnidades : Form
    {
        public frmUnidades()
        {
            InitializeComponent();
            desabilitarCamposNovo();
        }

        public frmUnidades(string descricao)
        {
            InitializeComponent();
            desabilitarCamposNovo();
            txtDescricao.Text = descricao;
        }

        public void habilitarCamposNovo()
        {

            txtCodigo.Enabled = false;
            txtDescricao.Enabled = true;
            txtUnidade.Enabled = true;

            btnNovo.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = true;
            txtDescricao.Focus();
        }

        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtUnidade.Enabled = false;

            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();


        }

        // cadastrando unidades 
        public int Cadastrarunidade(string descricao, string unidades)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbunidades(descricao,unidade)values(@descricao,@unidade);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao",MySqlDbType.VarChar, 50).Value = descricao ;
            comm.Parameters.Add("@unidade",MySqlDbType.VarChar, 2).Value = unidades ;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        public int Alterarunidade(string descricao, string unidades, int codUnid)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update set tbunidades descricao=@descricao, unidade=@unidade, codUnid=@codUnid;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 50).Value = unidades;
            comm.Parameters.Add("@unidades", MySqlDbType.VarChar, 2).Value = descricao;
            comm.Parameters.Add("@codUnid", MySqlDbType.Int32).Value = codUnid;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        public int Excluirunidade(int codUnid)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbunidades where codUnid=@codUnid";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUnid", MySqlDbType.Int32).Value = codUnid;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        public void limpacampos()
        {
            txtDescricao.Clear();
            txtCodigo.Clear();
            txtUnidade.Clear();

            btnNovo.Enabled = true;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void pesquisarPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbunidade where descricao=@descricao";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
             
            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao",MySqlDbType.VarChar,50).Value = descricao;


            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtDescricao.Text = Convert.ToString(DR.GetString(1));
            txtUnidade.Text = Convert.ToString(DR.GetString(2));

        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Equals("") || txtUnidade.Text.Equals(""))
            {
                MessageBox.Show("Por favor, coloque as informações","Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }
            else
            {
                int resp = Cadastrarunidade(txtDescricao.Text, txtUnidade.Text);
                if (resp == 1) 
                {
                    MessageBox.Show("Cadastrado com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpacampos();
                    desabilitarCamposNovo();
                    btnNovo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpacampos();
            txtDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUnidadesMedida abrir = new frmPesquisarUnidadesMedida();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int resp = Alterarunidade(txtDescricao.Text,txtUnidade.Text, Convert.ToInt32(txtCodigo.Text));
            if (resp == 1)
            {
                MessageBox.Show("Alterado com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpacampos();
                desabilitarCamposNovo();
                btnNovo.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Erro ao Alterar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int resp = Excluirunidade(Convert.ToInt32(txtCodigo.Text));
            if(resp == 1)
            {
                MessageBox.Show("Alterado com Sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpacampos();
                desabilitarCamposNovo();
            }
            else
            {
                MessageBox.Show("Erro ao Alterar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }
    }
}
