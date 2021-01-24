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
    public partial class frmCadastroMotorista : Form
    {
        public frmCadastroMotorista()
        {
            InitializeComponent();
            CarregarGrid();
            formatarGridMotorista();

        }

        private void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            dgCadastroMot.AutoGenerateColumns = true;

            if (tipo == 0)
            {
                dgCadastroMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas");
            }
            else
            {
                if (tipo == 1)
                {
                    dgCadastroMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motnome like '%" + filtro + "%'");
                }

                else
                {
                    if (tipo == 2)
                    {
                        dgCadastroMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motcnh like '%" + filtro + "%'");
                    }
                }

                if (tipo == 3)
                {
                    dgCadastroMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motemail like '%" + filtro + "%'");
                }

                if (tipo == 4)
                {
                    dgCadastroMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motcate like '%" + filtro + "%'");
                }


            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroMotorista_Load(object sender, EventArgs e)
        {

        }

        private void dgCadastroMot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgCadastroMot.Rows[e.RowIndex];
        }

        private void dgCadastroMot_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            txtCodigo.Text = dgCadastroMot[0, dgCadastroMot.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgCadastroMot[1, dgCadastroMot.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgCadastroMot[2, dgCadastroMot.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgCadastroMot[3, dgCadastroMot.CurrentRow.Index].Value.ToString();
            txtDatAdmis.Text = dgCadastroMot[4, dgCadastroMot.CurrentRow.Index].Value.ToString();
            txtCNH.Text = dgCadastroMot[5, dgCadastroMot.CurrentRow.Index].Value.ToString();
            txtValCNH.Text = dgCadastroMot[6, dgCadastroMot.CurrentRow.Index].Value.ToString();
            txtCategoria.Text = dgCadastroMot[7, dgCadastroMot.CurrentRow.Index].Value.ToString();
        }

        private void dgCadastroMot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarGrid();
        }

        private void formatarGridMotorista()
        {
            dgCadastroMot.ReadOnly = true;

            dgCadastroMot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgCadastroMot.Columns[0].HeaderText = "Cód";
            /* dgMotoristas.Columns[1].HeaderText = "Nome";
             dgMotoristas.Columns[2].HeaderText = "Sigla";
             dgMotoristas.Columns[3].HeaderText = "Observações";
            */

            dgCadastroMot.Columns[0].Width = 35;
            /* dgMotoristas.Columns[1].Width = 110;
             dgMotoristas.Columns[2].Width = 50;
             dgMotoristas.Columns[3].Width = 78;
            */

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Int32 codigo = conexao.obterProximoCodigoMotorista();

            SqlCommand comando = new SqlCommand();

            comando.CommandText =
                "INSERT INTO tblmotoristas (motid, motnome, mottel, motemail, motdatadmissao, motcnh, motvalcnh, motcate ) " +
                " VALUES                 (@motid, @motnome, @mottel, @motemail, @motdatadmissao, @motcnh, @motvalcnh, @motcate ) ";


            //comando.Parameters.Add("@cliid", SqlDbType.Int).Value = Convert.ToInt32(txtcodigo.Text);
            comando.Parameters.Add("@motid", SqlDbType.Int).Value = codigo;
            comando.Parameters.Add("@motnome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@mottel", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@motemail", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@motdatadmissao", SqlDbType.Date).Value = txtDatAdmis.Text;
            comando.Parameters.Add("@motcnh", SqlDbType.Decimal).Value = Decimal.Parse(txtCNH.Text);
            comando.Parameters.Add("@motvalcnh", SqlDbType.VarChar).Value = txtValCNH.Text;
            comando.Parameters.Add("@motcate", SqlDbType.VarChar).Value = txtCategoria.Text;




            conexao.executarSql(comando);

            MessageBox.Show("Cliente cadastrado com sucesso");
            CarregarGrid();

            AtualizarGrid();
        }
    }
}
