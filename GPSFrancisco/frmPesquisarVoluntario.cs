using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmPesquisarVoluntario : Form
    {
        public frmPesquisarVoluntario()
        {
            InitializeComponent();
            Desabilitarcampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
           string nome = ltbPesquisar.SelectedItem.ToString();

            frmGerenciarVoluntarios abrir = new frmGerenciarVoluntarios(nome);
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked == false && rdbNome.Checked == false)
            {
                MessageBox.Show("Por favor selecionar um item", "Mensagem do sistema");
            }
            else
            {
                if (txtDescricao.Text.Equals("")) {

                    MessageBox.Show("Por favor, colocar o texto escolhido", "Mensagem do Sistema");
                    txtDescricao.Focus();
                }
                else
                {
                    if (rdbCodigo.Checked)
                    {
                        BuscarVoluntarioPorCodigo(Convert.ToInt32(txtDescricao.Text));
                    }
                    if (rdbNome.Checked)
                    {
                        BuscarVoluntarioPorNome(txtDescricao.Text);
                    }
                
                }
            
                    ltbPesquisar.Items.Add(txtDescricao.Text);

            }
        }

        public void BuscarVoluntarioPorCodigo(int codVol)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbvoluntarios WHERE codVol = codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol",MySqlDbType.Int32).Value = codVol;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisar.Items.Clear();
            ltbPesquisar.Items.Add(DR.GetInt32(0));
            Conexao.fecharConexao();


        }

        public void BuscarVoluntarioPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbvoluntarios WHERE nome like '%"+nome+"%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisar.Items.Clear();
            while( DR.Read())
            {

            ltbPesquisar.Items.Add(DR.GetString(1));
            }
            Conexao.fecharConexao();


        }

        public void Limparcampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            ltbPesquisar.Items.Clear();
            txtDescricao.Focus();
        }

        public void Desabilitarcampos()
        {
            txtDescricao.Enabled = false;
            ltbPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = false;
        }

        public void Habilitarcampos()
        {
            txtDescricao.Enabled = true;
            ltbPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtDescricao.Focus();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked == true) 
            { 
                Habilitarcampos();
            }

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked == true)
            {
                Habilitarcampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limparcampos();
        }
    }
}
