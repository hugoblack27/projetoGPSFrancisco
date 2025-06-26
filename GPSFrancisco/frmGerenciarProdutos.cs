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
    }
}
