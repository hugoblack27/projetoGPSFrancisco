using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPSFrancisco;
using MySql.Data.MySqlClient;

namespace CarregaimagemDB
{
    public partial class frmCarregafotoDB : Form
    {
        public frmCarregafotoDB()
        {
            InitializeComponent();
            Desabilitarcampos();
        }

        private void btnInserirFotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jgp)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
            string foto = dialog.FileName.ToString();
            txtxBuscarfoto.Text = foto;
            pcbFotos.ImageLocation = foto;
            }
                habilitarCampos();
        }

        private void btnSalvarFotos_Click(object sender, EventArgs e)
        {
            if (pcbFotos.Image != null) {

                byte[] imagem_byte = null;

                FileStream fs = new FileStream(this.txtxBuscarfoto.Text, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fs);

                imagem_byte = br.ReadBytes((int)fs.Length);

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbfoto(nome,campo_imagem)values(@nome,@campo_imagem)";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@campo_imagem", MySqlDbType.LongBlob).Value = imagem_byte;
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;

                comm.Connection = Conexao.obterConexao();

                int resp = comm.ExecuteNonQuery();

                MessageBox.Show("Foto salva no banco de dados!!!" + resp);

                Conexao.fecharConexao();

            }
            else
            {
                MessageBox.Show("Favor inserir um texto ou uma imagem", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                
                
            }
            limparCamposSalvar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtxBuscarfoto.Clear();
            pcbFotos.Image = null;
 
        }

        public void limparCamposSalvar()
        {
            txtNome.Clear();
            txtxBuscarfoto.Clear();
            pcbFotos.Image = null;

        }

        public void Desabilitarcampos() 
        {
            txtNome.Enabled = false;
            txtxBuscarfoto.Enabled = false;
            pcbFotos.Enabled = false;
            btnLimpar.Enabled = false;
            btnSalvarFotos.Enabled = false;
            btnPesquisar.Enabled = false;
            btnInserirFotos.Focus();

        }

        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtxBuscarfoto.Enabled = true;
            pcbFotos.Enabled = true;
            btnLimpar.Enabled = true;
            btnSalvarFotos.Enabled = true;
            btnPesquisar.Enabled = true;
            btnInserirFotos.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRecuperarImagem abrir = new frmRecuperarImagem();
            abrir.Show();
            this.Hide();
        }
    }
}
