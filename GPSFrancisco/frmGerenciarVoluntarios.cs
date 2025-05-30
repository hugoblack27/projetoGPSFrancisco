using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class frmGerenciarVoluntarios : Form
    {
        public frmGerenciarVoluntarios()
        {
            InitializeComponent();
            desabilitarCampos();
            carregaAtribuicoes();
        }



        public int cadastrarVoluntarios(string nome, string email, string tecCel, string endereco, string numero,
               string cep, string bairro, string cidade, string estado, 
                DateTime data, DateTime hora, int status)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntarios(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status)values(@nome,@email,@telCel,@endereco,@numero,@cep,@bairro,@cidade,@estado,@codAtr,@data,@hora,@status);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = tecCel;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = numero;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@codAtr", MySqlDbType.Int32).Value = codigoatribuicao;
            comm.Parameters.Add("@data", MySqlDbType.Date, 100).Value = data;
            comm.Parameters.Add("@hora", MySqlDbType.Time, 100).Value = hora;
            comm.Parameters.Add("@status", MySqlDbType.Bit, 100).Value = status;


            comm.Connection = Conexao.obterConexao();
            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }
        public void carregaAtribuicoes()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbAtribuicoes order by nome;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbAtribuicoes.Items.Add(DR.GetString(1));
            }
            Conexao.fecharConexao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {


        }
        public void habilitarCamposNovo()
        {
            txtNome.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            cbbEstado.Enabled = true;
            mskbCep.Enabled = true;
            mskbTelefone.Enabled = true;
            cbbAtribuicoes.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;
            ckbAtivo.Enabled = true;

        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtCodigo.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            cbbEstado.Enabled = false;
            mskbCep.Enabled = false;
            mskbTelefone.Enabled = false;
            cbbAtribuicoes.Enabled = false;
            dtpData.Enabled = false;
            dtpHora.Enabled = false;
            ckbAtivo.Enabled = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você realmente deseja excluir?", "mensagem do sistema");
            if (true){ }
        }

        public void buscaCodigoAtribuicoes(string nome) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codAtr from tbatribuicoes where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            lblCodatribuicoes.Text = Convert.ToString(DR.GetInt32(0));

            Conexao.fecharConexao();

            
        }

        int codigoatribuicao;

        private void cbbAtribuicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscaCodigoAtribuicoes(cbbAtribuicoes.SelectedItem.ToString());
        }

        //botão cadastras
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
        // limpar campos
        public void limparcampos()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtCodigo.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();    
            txtNumero.Clear();
            ckbAtivo.Checked = false;
            mskbCep.Clear();
            mskbTelefone.Clear();
            cbbAtribuicoes.Text = "";
            cbbEstado.Text = "";
            dtpData.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = false;


        }


        //criando o excluir
        public int Excluirvoluntario(int codVol)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbUsuarios where codUsu = @codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;

            comm.Connection = Conexao.obterConexao();
            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            desabilitarCampos();


            return resp;
        }

        //criando o alterar

        public void Alterarvoluntario() 
        {

        }

    }
}
