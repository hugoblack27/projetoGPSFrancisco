using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using GenCode128;

namespace GPSFrancisco
{
    public partial class frmGerenciarProdutos : Form
    {
        public frmGerenciarProdutos()
        {
            InitializeComponent();
            carregarUnidadedemedida();
        }

        public void carregarUnidadedemedida()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbunidades order by unidade;";
            comm.CommandType = CommandType.Text;


            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbUnidades.Items.Add(DR.GetString(2));
            }

            Conexao.fecharConexao();
        }

        private void txtCodigodeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
            Image imgcodBarras = Code128Rendering.MakeBarcodeImage(txtCodigodeBarras.Text, 2, true);
                pcbcodigodebarras.Image = imgcodBarras;
            }
        }

        private void btnVerificaunidade_Click(object sender, EventArgs e)
        {
            frmUnidades abrir = new frmUnidades();
            abrir.Show();
            this.Hide();
        }

        int codigodaUnidade;
        // carregar produtos
        public int cadastrarProduto(int codBarras, string descricao, int quantidade, string lote,int codigodaUnidade,  DateTime dataEntrada, DateTime horaEntrada, DateTime validade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbprodutos(codBarras,descricao,quantidade,lote,dataEntr,horaEntr,validade,codUnid)values(codBarras=@codBarras, descricao=@descricao,quantidade=@quantidade,lote=@lote,dataEntr=@dataEntr,horaEntr=@horaEntr,validade=@validade,codUnid=@codUnid);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codBarras",MySqlDbType.Int32).Value = codBarras;
            comm.Parameters.Add("@descricao",MySqlDbType.VarString, 100).Value = descricao;
            comm.Parameters.Add("@quantidade",MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@lote",MySqlDbType.VarString).Value = lote;
            comm.Parameters.Add("@codUnid",MySqlDbType.VarString).Value = codigodaUnidade;
            comm.Parameters.Add("@dataEntr",MySqlDbType.DateTime).Value = dataEntrada;
            comm.Parameters.Add("@horaEntr",MySqlDbType.DateTime).Value = horaEntrada;
            comm.Parameters.Add("@validade",MySqlDbType.VarString).Value = validade;
            comm.Connection = Conexao.obterConexao();

            Conexao.fecharConexao();
             
            int resp = comm.ExecuteNonQuery();

            return resp;
        }

        // excluir produto
        public int ExcluirProduto(int codBarras)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "Delete from tbprodutos whre codBarras = @codBarras";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codBarras", MySqlDbType.Int32).Value = codBarras;
       
            comm.Connection = Conexao.obterConexao();

            Conexao.fecharConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;
        }

        public int AlterarProduto(int codBarras, string descricao, int quantidade, string lote, int codigodaUnidade, DateTime dataEntrada, DateTime horaEntrada, DateTime validade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbprodutos set codBarras=@codBarras, descricao=@descricao,quantidade=@quantidade,lote=@lote,dataEntr=@dataEntr,horaEntr=@horaEntr,validade=@validade,codUnid=@codUnid where codBarras=@codBarras;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codBarras", MySqlDbType.Int32).Value = codBarras;
            comm.Parameters.Add("@descricao", MySqlDbType.VarString, 100).Value = descricao;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@lote", MySqlDbType.VarString).Value = lote;
            comm.Parameters.Add("@codUnid", MySqlDbType.VarString).Value = codigodaUnidade;
            comm.Parameters.Add("@dataEntr", MySqlDbType.DateTime).Value = dataEntrada;
            comm.Parameters.Add("@horaEntr", MySqlDbType.DateTime).Value = horaEntrada;
            comm.Parameters.Add("@validade", MySqlDbType.VarString).Value = validade;
            comm.Connection = Conexao.obterConexao();

            Conexao.fecharConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;
        }
    }
}
