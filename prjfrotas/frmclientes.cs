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


    public partial class frmclientes : Form
    {
        public frmclientes()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Boolean ValidacaoOk()
        {
            Boolean resultado = true;
            if (txtnome.Text.Trim() == "")
            {
                resultado = false;

                MessageBox.Show("Digite o nome do cliente!");
            }
            else if (txtcpf.Text.Trim() == "")
            {
                resultado = false;
                MessageBox.Show("Digite o CPF do cliente");
            }
            if (txtemail.Text.Trim() == "")
            {
                resultado = false;
                MessageBox.Show("Digite o E-Mail do cliente");
            }

            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarGrid()
        {
            txtcodigo.Text = dgClientes[0, dgClientes.CurrentRow.Index].Value.ToString();
            txtnome.Text = dgClientes[1, dgClientes.CurrentRow.Index].Value.ToString();
            txtcpf.Text = dgClientes[2, dgClientes.CurrentRow.Index].Value.ToString();
            txtemail.Text = dgClientes[3, dgClientes.CurrentRow.Index].Value.ToString();
        }

        private void CadastrarCliente()
        {
            Int32 codigo = conexao.obterProximoCodigoCliente();

            SqlCommand comando = new SqlCommand();

            comando.CommandText =
                "INSERT INTO tblclientes (cliid, clinome, cliemail, clicpf, clidatacadastro ) " +
                " VALUES (@cliid, @clinome, @cliemail, @clicpf, @clidatacadastro ) ";


            //comando.Parameters.Add("@cliid", SqlDbType.Int).Value = Convert.ToInt32(txtcodigo.Text);
            comando.Parameters.Add("@cliid", SqlDbType.Int).Value = codigo;
            comando.Parameters.Add("@clinome", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@cliemail", SqlDbType.VarChar).Value = txtemail.Text;
            comando.Parameters.Add("@clicpf", SqlDbType.Decimal).Value = Decimal.Parse(txtcpf.Text);
            comando.Parameters.Add("@clidatacadastro", SqlDbType.Date).Value = txtdatamask.Text;




            conexao.executarSql(comando);

            MessageBox.Show("Cliente cadastrado com sucesso");
        } 
        private void btncadastrarcliente_Click(object sender, EventArgs e)
        {

           
            if (ValidacaoOk() == false)
            {
                MessageBox.Show("Algum dos valores informados está incorreto");
            }
            else
            {

                CadastrarCliente();

                LimparTela();

                CarregarGrid();

                AtualizarGrid();

            }





        }


        private void LimparTela()
        {
            txtcodigo.Text = "";
            txtcpf.Text = "";
            txtdatamask.Text = "";
            txtemail.Text = String.Empty;
            txtnome.Text = String.Empty;

        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletarCliente()
        {
            String sql = "DELETE tblclientes WHERE (cliid)=" +

               "(" + txtcodigo.Text + ")";

            conexao.executarSql(sql);
            MessageBox.Show("Cliente deletado com sucesso!");
        }

        private void btndeletarcli_Click(object sender, EventArgs e)
        {

            DeletarCliente();
            LimparTela();
            CarregarGrid();
            AtualizarGrid();



        }

        private void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            dgClientes.AutoGenerateColumns = true;

            if (tipo == 0)
            {
                dgClientes.DataSource = conexao.obterDados("select cliid as Codigo, clinome as Nome, clicpf as CPF, cliemail as Email, clidatacadastro as Data from tblclientes");
            }
            else
            {
                if(tipo == 1)
                {
                    dgClientes.DataSource = conexao.obterDados("select cliid as Codigo, clinome as Nome," +
                                                                "clicpf as CPF, cliemail as Email," +
                                                                "clidatacadastro as Data from tblclientes " +
                                                                "where clinome like '%" + filtro + "%'");
                }
                else
                {
                    if(tipo == 2)
                    {
                        dgClientes.DataSource = conexao.obterDados("select cliid as Codigo, clinome as Nome," +
                                                                "clicpf as CPF, cliemail as Email," +
                                                                "clidatacadastro as Data from tblclientes " +
                                                                "where clicpf like '%" + filtro + "%'");
                    }
                }

            }
                
            
        }


        private void btncarregar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
        
        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
       
        
        {
           
            txtcodigo.Text = dgClientes[0, dgClientes.CurrentRow.Index].Value.ToString();
            txtnome.Text = dgClientes[1, dgClientes.CurrentRow.Index].Value.ToString();
            txtcpf.Text = dgClientes[2, dgClientes.CurrentRow.Index].Value.ToString();
            txtemail.Text = dgClientes[3, dgClientes.CurrentRow.Index].Value.ToString();
            txtdatamask.Text = dgClientes[4, dgClientes.CurrentRow.Index].Value.ToString();
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
           
            
            SqlCommand comando = new SqlCommand();

            comando.CommandText =
                "UPDATE tblclientes " +
                "   SET clinome = @clinome, " +
                "       clicpf = @clicpf, " +
                "       cliemail = @cliemail " +
                " WHERE cliid = @cliid ";

            comando.Parameters.Add("@cliid", SqlDbType.Int).Value = Convert.ToInt32(txtcodigo.Text);
            comando.Parameters.Add("@clinome", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@cliemail", SqlDbType.VarChar).Value = txtemail.Text;
            comando.Parameters.Add("@clicpf", SqlDbType.Decimal).Value = Decimal.Parse(txtcpf.Text);


            conexao.executarSql(comando);

            MessageBox.Show("Atualizado com sucesso");
            
            LimparTela();

            CarregarGrid();

            


        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgClientes.Rows[e.RowIndex];
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscarcli_Click(object sender, EventArgs e)
        {
            if (cbPesquisaClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma opção de pesquisa!");
                cbPesquisaClientes.Focus();
            }
            else if (cbPesquisaClientes.SelectedIndex == 0)
            {
                CarregarGrid();
            }
            else if(cbPesquisaClientes.SelectedIndex == 1)
            {
                CarregarGrid(1, txtFiltroPesquisaCli.Text);
            }
            else if (cbPesquisaClientes.SelectedIndex == 2)
            {
                CarregarGrid(2, txtFiltroPesquisaCli.Text);
            }
        }

        private void dgClientes_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                
                e.Handled = true;
            }
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {

        }

        private void cbPesquisaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
