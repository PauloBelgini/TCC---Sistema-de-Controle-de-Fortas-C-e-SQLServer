using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Windows.Forms;
using dal;


namespace prjveterinario
{
    public partial class frmViagens : Form
    {
        public frmViagens()
        {
            InitializeComponent();
        }

        private void frmViagens_Load(object sender, EventArgs e)
        {   
           CarregarComboMotorista();
            CarregarGrid(0, "");
            formatarGridViagem();


        }


        private void CarregarComboMotorista()
        {
            cbMotorista.DataSource = conexao.obterDados("SELECT motid, motnome " +
                                                         "FROM tblmotoristas " +
                                                         "ORDER by motnome ASC ");
        }

      

        private void CarregarGrid(int tipo, String filtro)
        {
            dgViagens.AutoGenerateColumns = true;

            if (tipo == 0)
            {
                dgViagens.DataSource = conexao.obterDados("SELECT viaid, motnome, viadest, viadatasaida, viahorasaida, viachegadata, viachegadahora, viaobs, viavei, tblmotoristas.motid FROM tblviagensv inner join tblmotoristas on tblviagensv.motid = tblmotoristas.motid");
                

            }
            else
            {
                if (tipo == 1)
                {
                    dgViagens.DataSource = conexao.obterDados("select veiid as Codigo, veinome as Nome," +
                                                                "aniapelido as Apelido, anidatanasc as Nascimento," +
                                                                "aniobservacoes as Obs from tblanimais " +
                                                                "where aniinome like '%" + filtro + "%'");
                }
                else
                { 
                    if (tipo == 2)
                    {
                        dgViagens.DataSource = conexao.obterDados("select aniid as Codigo, aninome as Nome," +
                                                                "aniapelido as Apelido, anidatanasc as Nascimento," +
                                                                "aniobservacoes as Obs from tblanimais " +
                                                                "where aniapelido like '%" + filtro + "%'");
                    }

                }

            }
        }

        private void formatarGridViagem()
        {
            dgViagens.ReadOnly = true;

            dgViagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgViagens.Columns[0].HeaderText = "Cód";
            dgViagens.Columns[1].HeaderText = "Nome";
            dgViagens.Columns[2].HeaderText = "Destino";
            dgViagens.Columns[3].HeaderText = "Data Saída";
            dgViagens.Columns[4].HeaderText = "Hora Saída";
            dgViagens.Columns[5].HeaderText = "Data Chegada";
            dgViagens.Columns[6].HeaderText = "Hora Chegada";
            dgViagens.Columns[7].HeaderText = "Observação";
            dgViagens.Columns[8].HeaderText = "Veiculo";
            dgViagens.Columns[9].HeaderText = "ID Motorista";


            dgViagens.Columns[0].Width = 35;
            dgViagens.Columns[1].Width = 60;
            dgViagens.Columns[2].Width = 100;
            dgViagens.Columns[3].Width = 78;
            

        }


        private void CadastrarViagem()
        {
            Int32 codigo = conexao.obterProximoCodigoViagem();

            SqlCommand comando = new SqlCommand();

            comando.CommandText =
                "INSERT INTO tblviagensv (viaid, viadest, viadatasaida, viahorasaida, viachegadata, viachegadahora, viaobs, viavei, tblmotoristas.motid ) " +
                " VALUES (@viaid, @viadest, @viadatasaida, @viahorasaida, @viachegadata, @viachegadahora, @viaobs, @viavei, @motid) ";


            comando.Parameters.Add("@viaid", SqlDbType.Int).Value = codigo;
            comando.Parameters.Add("@motid", SqlDbType.Int).Value = cbMotorista.SelectedValue;
            comando.Parameters.Add("@viadest", SqlDbType.VarChar).Value = (txtDestino.Text);
            comando.Parameters.Add("@viadatasaida", SqlDbType.Date).Value = (txtSaidaData.Text);
            comando.Parameters.Add("@viahorasaida", SqlDbType.VarChar).Value = (txtSaidaHora.Text);
            comando.Parameters.Add("@viachegadata", SqlDbType.Date).Value = (txtChegadaData.Text);
            comando.Parameters.Add("@viachegadahora", SqlDbType.VarChar).Value = (txtChegadaHora.Text);
            comando.Parameters.Add("@viaobs", SqlDbType.VarChar).Value = (txtObs.Text);
            comando.Parameters.Add("@viavei", SqlDbType.VarChar).Value = (txtVeiculo.Text);





            conexao.executarSql(comando);

            MessageBox.Show("Veículo cadastrado com sucesso");

            CarregarGrid(0,"");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastrarViagem();
        }

        private void dgViagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgViagens.Rows[e.RowIndex];
        }

        private void dgViagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }



        private void dgViagens_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            txtCodigo.Text = dgViagens[0, dgViagens.CurrentRow.Index].Value.ToString();
            txtDestino.Text = dgViagens[2, dgViagens.CurrentRow.Index].Value.ToString();
            txtSaidaData.Text = dgViagens[3, dgViagens.CurrentRow.Index].Value.ToString();
            txtSaidaHora.Text = dgViagens[4, dgViagens.CurrentRow.Index].Value.ToString();
            txtChegadaData.Text = dgViagens[5, dgViagens.CurrentRow.Index].Value.ToString();
            txtChegadaHora.Text = dgViagens[6, dgViagens.CurrentRow.Index].Value.ToString();
            txtObs.Text = dgViagens[7, dgViagens.CurrentRow.Index].Value.ToString();
            txtVeiculo.Text = dgViagens[8, dgViagens.CurrentRow.Index].Value.ToString();
        }

        private void cbMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand();

            comando.CommandText =
                        "UPDATE tblviagensv " +
                        "   SET viaid = @viaid, " +
                        "       viadest = @viadest, " +
                        "       viadatasaida = @viadatasaida, " +
                        "       viahorasaida = @viahorasaida, " +
                        "       viachegadata = @viachegadata, " +
                        "       viachegadahora = @viachegadahora, " +
                        "       viaobs = @viaobs, " +
                        "       viavei = @viavei ," +
                        "       motid = @motid " +
                        " WHERE viaid = @viaid ";

            comando.Parameters.Add("@viaid", SqlDbType.Int).Value = Convert.ToInt32(txtCodigo.Text);
            comando.Parameters.Add("@viadest", SqlDbType.VarChar).Value = txtDestino.Text;
            comando.Parameters.Add("@viadatasaida", SqlDbType.Date).Value = txtSaidaData.Text;
            comando.Parameters.Add("@viahorasaida", SqlDbType.VarChar).Value = txtSaidaHora.Text;
            comando.Parameters.Add("@viachegadata", SqlDbType.Date).Value = txtChegadaData.Text;
            comando.Parameters.Add("@viachegadahora", SqlDbType.VarChar).Value = txtChegadaHora.Text;
            comando.Parameters.Add("@viaobs", SqlDbType.VarChar).Value = txtObs.Text;
            comando.Parameters.Add("@viavei", SqlDbType.VarChar).Value = txtVeiculo.Text;
            comando.Parameters.Add("@motid", SqlDbType.VarChar).Value = cbMotorista.SelectedValue;



            conexao.executarSql(comando);

            MessageBox.Show("Atualizado com sucesso");



            CarregarGrid(0, "");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String sql = "DELETE tblviagensv WHERE (viaid)=" +

           "(" + txtCodigo.Text + ")";

            conexao.executarSql(sql);
            MessageBox.Show("Viagem deletada com sucesso!");
            CarregarGrid(0,"");
        }

        /*SqlCommand comando = new SqlCommand();

        comando.CommandText =
                    "UPDATE tblviagensv " +
                    "   SET viaid = @viaid, " +
                    "       viadest = @viadest, " +
                    "       viadatasaida = @viadatasaida, " +
                    "       viahorasaida = @viahorasaida, " +
                    "       viachegadata = @viachegadata, " +
                    "       viachegadahora = @viachegadahora, " +
                    "       viaobs = @viaobs " +
                    "       viavei = @viavei " +
                    " WHERE viaid = @viaid ";

                comando.Parameters.Add("@viaid", SqlDbType.Int).Value = Convert.ToInt32(txtCodigo.Text);
                comando.Parameters.Add("@viadest", SqlDbType.VarChar).Value = txtDestino.Text;
                comando.Parameters.Add("@viadatasaida", SqlDbType.Date).Value = txtSaidaData.Text;
                comando.Parameters.Add("@viahorasaida", SqlDbType.VarChar).Value = txtSaidaHora.Text;
                comando.Parameters.Add("@viachegadata", SqlDbType.Date).Value = txtChegadaData.Text;
                comando.Parameters.Add("@viachegadahora", SqlDbType.VarChar).Value = txtChegadaHora;
                comando.Parameters.Add("@viaobs", SqlDbType.VarChar).Value = txtObs.Text;
                comando.Parameters.Add("@viavei", SqlDbType.VarChar).Value = txtVeiculo.Text;


                conexao.executarSql(comando);

                MessageBox.Show("Atualizado com sucesso");



            CarregarGrid(0,"");
        */





    }
}
