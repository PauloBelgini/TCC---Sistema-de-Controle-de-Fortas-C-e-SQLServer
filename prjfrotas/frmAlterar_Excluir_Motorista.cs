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
    public partial class frmAlterar_Excluir_Motorista : Form
    {
        public frmAlterar_Excluir_Motorista()
        {
            InitializeComponent();
            CarregarGrid();
            formatarGridMotorista();
        }
        private void frmAlterar_Excluir_Motorista_Load(object sender, EventArgs e)
        {

        }

        private void CarregarGrid()
        {
            CarregarGrid(0, "");
        }
        private void CarregarGrid(int tipo, String filtro)
        {
            dgAlterarExcluirMot.AutoGenerateColumns = true;

            if (tipo == 0)
            {
                dgAlterarExcluirMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas");
            }
            else
            {
                if (tipo == 1)
                {
                    dgAlterarExcluirMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motnome like '%" + filtro + "%'");
                }

                else
                {
                    if (tipo == 2)
                    {
                        dgAlterarExcluirMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motcnh like '%" + filtro + "%'");
                    }
                }

                if (tipo == 3)
                {
                    dgAlterarExcluirMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motemail like '%" + filtro + "%'");
                }

                if (tipo == 4)
                {
                    dgAlterarExcluirMot.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motcate like '%" + filtro + "%'");
                }


            }


        }

        private void AtualizarGrid()
        {
            txtCodigo.Text = dgAlterarExcluirMot[0, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgAlterarExcluirMot[1, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgAlterarExcluirMot[2, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgAlterarExcluirMot[3, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtDatAdmis.Text = dgAlterarExcluirMot[4, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtCNH.Text = dgAlterarExcluirMot[5, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtValCNH.Text = dgAlterarExcluirMot[6, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtCategoria.Text = dgAlterarExcluirMot[7, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
        }

        private void dgAlterarExcluirMot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgAlterarExcluirMot[0, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgAlterarExcluirMot[1, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgAlterarExcluirMot[2, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgAlterarExcluirMot[3, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtDatAdmis.Text = dgAlterarExcluirMot[4, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtCNH.Text = dgAlterarExcluirMot[5, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtValCNH.Text = dgAlterarExcluirMot[6, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
            txtCategoria.Text = dgAlterarExcluirMot[7, dgAlterarExcluirMot.CurrentRow.Index].Value.ToString();
        }

        private void dgAlterarExcluirMot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgAlterarExcluirMot.Rows[e.RowIndex];
        }

        private void formatarGridMotorista()
        {
            dgAlterarExcluirMot.ReadOnly = true;

            dgAlterarExcluirMot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgAlterarExcluirMot.Columns[0].HeaderText = "Cód";
            /* dgMotoristas.Columns[1].HeaderText = "Nome";
             dgMotoristas.Columns[2].HeaderText = "Sigla";
             dgMotoristas.Columns[3].HeaderText = "Observações";
            */

            dgAlterarExcluirMot.Columns[0].Width = 35;
            /* dgMotoristas.Columns[1].Width = 110;
             dgMotoristas.Columns[2].Width = 50;
             dgMotoristas.Columns[3].Width = 78;
            */

        }


        private void dgAlterarExcluirMot_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();

            comando.CommandText =
                "UPDATE tblmotoristas " +
                "   SET motnome = @motnome, " +
                "       mottel = @mottel, " +
                "       motemail = @motemail, " +
                "       motdatadmissao = @motdatadmissao, " +
                "       motcnh = @motcnh, " +
                "       motvalcnh = @motvalcnh, " +
                "       motcate = @motcate " +
                " WHERE motid = @motid ";

            comando.Parameters.Add("@motid", SqlDbType.Int).Value = Convert.ToInt32(txtCodigo.Text);
            comando.Parameters.Add("@motnome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@mottel", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@motemail", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@motdatadmissao", SqlDbType.Date).Value = txtDatAdmis.Text;
            comando.Parameters.Add("@motcnh", SqlDbType.Decimal).Value = Decimal.Parse(txtCNH.Text);
            comando.Parameters.Add("@motvalcnh", SqlDbType.Date).Value = txtValCNH.Text;
            comando.Parameters.Add("@motcate", SqlDbType.VarChar).Value = txtCategoria.Text;


            conexao.executarSql(comando);

            MessageBox.Show("Atualizado com sucesso");

            

            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String sql = "DELETE tblmotoristas WHERE (motid)=" +

              "(" + txtCodigo.Text + ")";

            conexao.executarSql(sql);
            MessageBox.Show("Cliente deletado com sucesso!");
            CarregarGrid();
        }
    }
}
