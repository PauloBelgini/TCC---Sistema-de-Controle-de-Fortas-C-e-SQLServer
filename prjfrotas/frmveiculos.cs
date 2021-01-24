
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
    public partial class frmveiculos : Form
    {
        public frmveiculos()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtaniobservacoes_TextChanged(object sender, EventArgs e)
        {

        }


        private void AtualizarGrid()
        {
            txtveiid.Text = dgveiculos[0, dgveiculos.CurrentRow.Index].Value.ToString();
            txtveinome.Text = dgveiculos[1, dgveiculos.CurrentRow.Index].Value.ToString();
            txtmarca.Text = dgveiculos[2, dgveiculos.CurrentRow.Index].Value.ToString();
            txtplaca.Text = dgveiculos[3, dgveiculos.CurrentRow.Index].Value.ToString();
            txtveiculoobs.Text = dgveiculos[4, dgveiculos.CurrentRow.Index].Value.ToString();
            txtchassi.Text = dgveiculos[5, dgveiculos.CurrentRow.Index].Value.ToString();
            cbcombustivel.Text = dgveiculos[6, dgveiculos.CurrentRow.Index].Value.ToString();
            txtkm.Text = dgveiculos[7, dgveiculos.CurrentRow.Index].Value.ToString();
            dgveiculos.Columns[5].Visible = false;

            /* dganimais.Columns[0].DataPropertyName = "Código";
            dganimais.Columns[1].DataPropertyName = "Nome";
            dganimais.Columns[2].DataPropertyName = "Apelido";
            dganimais.Columns[3].DataPropertyName = "Nascimento";
            dganimais.Columns[4].DataPropertyName = "";
            */
        }

        private Boolean ValidacaoOk()
        {
            Boolean resultado = true;
            if (txtmarca.Text == "")
            {
                resultado = false;
            }
            else if (txtveinome.Text == "")
            {
                resultado = false;
            }
            //if (cbespecie.Text == "")
            //{
               // resultado = false;
           // }

            return resultado;
        }

        private void CadastrarVeiculo()
        {
            Int32 codigo = conexao.obterProximoCodigoVeiculo();

            SqlCommand comando = new SqlCommand();

            comando.CommandText =
                "INSERT INTO tblveiculos (veiid, veinome, veiplaca, veimarca, veikm, veichassi, veiobservacoes, tblcombustiveis.combid ) " +
                " VALUES (@veiid, @veinome, @veiplaca, @veimarca, @veikm, @veichassi, @veiobservacoes, @combid) ";


            //comando.Parameters.Add("@cliid", SqlDbType.Int).Value = Convert.ToInt32(txtcodigo.Text);
            comando.Parameters.Add("@veiid", SqlDbType.Int).Value = codigo;
            comando.Parameters.Add("@combid", SqlDbType.Int).Value = cbcombustivel.SelectedValue;
            comando.Parameters.Add("@veinome", SqlDbType.VarChar).Value = (txtveinome.Text);
            comando.Parameters.Add("@veiplaca", SqlDbType.VarChar).Value = (txtplaca.Text);
            comando.Parameters.Add("@veimarca", SqlDbType.VarChar).Value = (txtmarca.Text);
            comando.Parameters.Add("@veichassi", SqlDbType.VarChar).Value = (txtchassi.Text);
            comando.Parameters.Add("@veikm", SqlDbType.Int).Value = (txtkm.Text);
            comando.Parameters.Add("@veiobservacoes", SqlDbType.VarChar).Value = (txtveiculoobs.Text);




            conexao.executarSql(comando);

            MessageBox.Show("Veículo cadastrado com sucesso");

            CarregarGrid();
           





        }

        private void CarregarGrid()
        {
            CarregarGrid(0, "");
        }


        private void CarregarComboCombustiveis()
        {
            cbcombustivel.DataSource = conexao.obterDados("SELECT combid, combnome " +
                                                         "FROM tblcombustiveis " +
                                                         "ORDER by combnome ASC ");
        }

        private void LimparTela()
        {
            txtplaca.Text = "";
            txtchassi.Text = "";
            txtveinome.Text = "";
            txtmarca.Text = String.Empty;
            cbcombustivel.Text = String.Empty;
            txtveiculoobs.Text = String.Empty;
            txtveiid.Text = String.Empty;
            txtkm.Text = String.Empty;

        }

        private void CarregarGrid(int tipo, String filtro)
        {
            dgveiculos.AutoGenerateColumns = true;

            if (tipo == 0)
            {
                dgveiculos.DataSource = conexao.obterDados("SELECT veiid as Código, veinome as Nome,veimarca  as Marca, veiplaca as Placa, veiobservacoes as Obs, veichassi as Chassis, veikm as KM, tblveiculos.combid as CodComb, combnome as Combustivel " +
                                                          "FROM tblveiculos inner join tblcombustiveis on tblveiculos.combid = tblcombustiveis.combid " +
                                                          "ORDER by veiid ASC ");
            }
            else
            {
                if (tipo == 1)
                {
                    dgveiculos.DataSource = conexao.obterDados("select veiid as Codigo, veinome as Nome," +
                                                                "veimarca as Marca, veichassi as Chassis, veikm as KM," +
                                                                "veiobservacoes as Obs from tblveiculos " +
                                                                "where veinome like '%" + filtro + "%'");
                }
                else
                {
                    if (tipo == 2)
                    {
                        dgveiculos.DataSource = conexao.obterDados("select veiid as Codigo, veinome as Nome," +
                                                                "veimarca as Marca, veichassi as Chassis, veikm as KM," +
                                                                "veiobservacoes as Obs from tblveiculos " +
                                                                "where veimarca like '%" + filtro + "%'");
                    }







                }

            }


        }

        private void btncadastrarani_Click(object sender, EventArgs e)
        {
            if (ValidacaoOk() == false)
            {
                MessageBox.Show("Algum dos valores informados está incorreto");
            }
            else
            {


                CadastrarVeiculo();
                AtualizarGrid();



            }





        }

        private void AtualizarVeiculo()
        {
            {
                SqlCommand comando = new SqlCommand();

                comando.CommandText =
                    "UPDATE tblveiculos " +
                    "   SET veinome = @veinome, " +
                    "       veimarca = @veimarca, " +
                    "       veiplaca = @veiplaca, " +
                    "       veichassi = @veichassi, " +
                    "       veikm = @veikm, " +
                    "       veiobservacoes = @veiobservacoes " +                  
                    " WHERE veiid = @veiid ";

                comando.Parameters.Add("@veiid", SqlDbType.Int).Value = Convert.ToInt32(txtveiid.Text);
                comando.Parameters.Add("@veinome", SqlDbType.VarChar).Value = txtveinome.Text;
                comando.Parameters.Add("@veimarca", SqlDbType.VarChar).Value = txtmarca.Text;
                comando.Parameters.Add("@veiplaca", SqlDbType.VarChar).Value = txtplaca.Text;
                comando.Parameters.Add("@veichassi", SqlDbType.VarChar).Value = txtchassi.Text;
                comando.Parameters.Add("@veikm", SqlDbType.Int).Value = txtkm.Text;
                comando.Parameters.Add("@veiobservacoes", SqlDbType.VarChar).Value = txtveiculoobs.Text;
               


                conexao.executarSql(comando);

                MessageBox.Show("Atualizado com sucesso");



                CarregarGrid();
                AtualizarGrid();
            }
        }
        private void DeletarVeiculo()
        {
            String sql = "DELETE tblveiculos WHERE (veiid)=" +

               "(" + txtveiid.Text + ")";

            conexao.executarSql(sql);
            MessageBox.Show("Veículo excluído com sucesso!");
        }

       

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmanimais_Load(object sender, EventArgs e)
        {
            CarregarComboCombustiveis();
            CarregarGrid();
        }

      

        private void btncadastrarvei_Click(object sender, EventArgs e)
        {
            if (ValidacaoOk() == false)
            {
                MessageBox.Show("Algum dos valores informados está incorreto");
            }
            else
            {


                CadastrarVeiculo();
                CarregarGrid();
                AtualizarGrid();


            }
        }

        private void btndeletarvei_Click(object sender, EventArgs e)
        {
            DeletarVeiculo();
            CarregarGrid();
            AtualizarGrid();
        }

        private void btnatualizarvei_Click(object sender, EventArgs e)
        {
            AtualizarVeiculo();
            CarregarGrid();
            AtualizarGrid();
        }

        private void cbcombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgveiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgveiculos.Rows[e.RowIndex];
        }

        private void dgveiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtveiid.Text = dgveiculos[0, dgveiculos.CurrentRow.Index].Value.ToString();
            txtveinome.Text = dgveiculos[1, dgveiculos.CurrentRow.Index].Value.ToString();
            txtmarca.Text = dgveiculos[2, dgveiculos.CurrentRow.Index].Value.ToString();
            txtplaca.Text = dgveiculos[3, dgveiculos.CurrentRow.Index].Value.ToString();
            txtveiculoobs.Text = dgveiculos[4, dgveiculos.CurrentRow.Index].Value.ToString();
            txtchassi.Text = dgveiculos[5, dgveiculos.CurrentRow.Index].Value.ToString();
            cbcombustivel.Text = dgveiculos[6, dgveiculos.CurrentRow.Index].Value.ToString();
            txtkm.Text = dgveiculos[7, dgveiculos.CurrentRow.Index].Value.ToString();
            dgveiculos.Columns[5].Visible = false;
        }

        private void dgveiculos_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnlimpartelavei_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

     
    }
    }

