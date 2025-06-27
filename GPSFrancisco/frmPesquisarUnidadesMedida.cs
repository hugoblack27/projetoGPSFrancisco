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
    public partial class frmPesquisarUnidadesMedida : Form
    {
        public frmPesquisarUnidadesMedida()
        {
            InitializeComponent();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = ltbPesquisar.SelectedItem.ToString();

            frmUnidades abrir = new frmUnidades(descricao);
            abrir.Show();
            this.Hide();


        }
        public void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            ltbPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Items.Add(txtDescricao.Text);

            if (rdbCodigo.Checked == true && rdbNome.Checked == true) 
            {
                MessageBox.Show("Favor selecionar um item",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }else if (txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um valor",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }
            else
            {
                if (rdbCodigo.Checked)
                {
                buscaPorcodigo(Convert.ToInt32(txtDescricao.Text));
                }
                if (rdbNome.Checked) 
                {
                    buscaPorNome(txtDescricao.Text); 
                }
            }
        }

        //criando busca por codigo

        public void buscaPorcodigo(int codUnid)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"select * from tbUnidades where codUnid like '%{codUnid}%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();


            ltbPesquisar.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();
        }

        public void buscaPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"select * from tbUnidades where descricao like '%{descricao}%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();


            ltbPesquisar.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }
    }
}
