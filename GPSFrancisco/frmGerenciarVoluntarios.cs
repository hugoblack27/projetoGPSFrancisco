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
using MosaicoSolutions.ViaCep;

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

        //criando metodo construtor comparametro
        public frmGerenciarVoluntarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            carregaAtribuicoes();
            txtNome.Text = nome;
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
            limparcampos();

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
            txtComplemento.Enabled = true;
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
            txtComplemento.Enabled = false;
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

        //botão cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("")||txtEmail.Text.Equals("")||mskbTelefone.Text.Equals("(  )      -")|| txtBairro.Text.Equals("")|| txtCidade.Text.Equals("")||txtEndereco.Text.Equals("")||txtNumero.Text.Equals("")||mskbCep.Text.Equals("     -")||cbbEstado.Items.Equals("")||ckbAtivo.Checked == false)
            {
                MessageBox.Show("Por favor preencher os campos ", 
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Voluntario Cadastrado ",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
                limparcampos();
                desabilitarCampos();
            }

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
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;
            txtComplemento.Clear();

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


        //método para buscar o cep
        public void buscaCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            try
            {
            var endereco = viaCEPService.ObterEndereco(cep);

            txtEndereco.Text = endereco.Logradouro.ToString();
            txtCidade.Text = endereco.Localidade.ToString();
            txtBairro.Text = endereco.Bairro.ToString();
            cbbEstado.Text = endereco.UF.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Cep não encontrado", "menssagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                mskbCep.Focus();
                

            }
        }



        private void mskbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                {
                buscaCEP(mskbCep.Text);
                txtNumero.Focus();
                }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarVoluntario abrir = new frmPesquisarVoluntario();
            abrir.Show();
            this.Hide();
        }

        private void btnCarregarfoto_Click(object sender, EventArgs e)
        {
            //pcbFoto.Image = Image.FromFile("C:\\Users\\hugo.hpsantos1\\Documents\\Visual Studio 2022\\GPSFrancisco\\GSFrancisco-CSharp\\imagens\\Tela.JPG");
            //pcbFoto.ImageLocation = @"C:\\Users\\hugo.hpsantos1\\Documents\\Visual Studio 2022\\GPSFrancisco\\GSFrancisco-CSharp\\imagens\\Tela.JPG";
            ofdCarregar.ShowDialog();
            string path = ofdCarregar.FileName;
            pcbFoto.Image = Image.FromFile(path);
        }


        // 
    }
}
