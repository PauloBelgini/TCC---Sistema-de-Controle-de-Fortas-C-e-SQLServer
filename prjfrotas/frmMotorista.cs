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
    public partial class frmMotorista : Form
    {
        public frmMotorista()
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
            dgMotoristas.AutoGenerateColumns = true;

            if (tipo == 0)
            {
                dgMotoristas.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas");
            }
            else
            {
                if (tipo == 1)
                {
                    dgMotoristas.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motnome like '%" + filtro + "%'");
                }

                else
                    {
                    if (tipo == 2)
                    {
                        dgMotoristas.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motcnh like '%" + filtro + "%'");
                    }
                }

                if (tipo == 3)
                {
                    dgMotoristas.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motemail like '%" + filtro + "%'");
                }

                if (tipo == 4)
                {
                    dgMotoristas.DataSource = conexao.obterDados("select motid as Codigo, motnome as Nome, mottel as Telefone, motemail as Email, motdatadmissao as DataAdmissao, motcnh as CNH, motvalcnh as CNHValidade, motcate as Categoria from tblmotoristas where motcate like '%" + filtro + "%'");
                }


            }


        }

        private void formatarGridMotorista()
        {
            dgMotoristas.ReadOnly = true;

            dgMotoristas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgMotoristas.Columns[0].HeaderText = "Cód";
           /* dgMotoristas.Columns[1].HeaderText = "Nome";
            dgMotoristas.Columns[2].HeaderText = "Sigla";
            dgMotoristas.Columns[3].HeaderText = "Observações";
           */

            dgMotoristas.Columns[0].Width = 35;
           /* dgMotoristas.Columns[1].Width = 110;
            dgMotoristas.Columns[2].Width = 50;
            dgMotoristas.Columns[3].Width = 78;
           */

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            if (cbPesquisaMotorista.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma opção de pesquisa!");
                cbPesquisaMotorista.Focus();
            }
            else if (cbPesquisaMotorista.SelectedIndex == 0)
            {
                CarregarGrid();
            }
            else if (cbPesquisaMotorista.SelectedIndex == 1)
            {
                CarregarGrid(1, txtFiltroPesquisaMot.Text);
            }
            else if (cbPesquisaMotorista.SelectedIndex == 2)
            {
                CarregarGrid(2, txtFiltroPesquisaMot.Text);
            }
            else if (cbPesquisaMotorista.SelectedIndex == 3)
            {
                CarregarGrid(3, txtFiltroPesquisaMot.Text);
            }
            else if (cbPesquisaMotorista.SelectedIndex == 4)
            {
                CarregarGrid(4, txtFiltroPesquisaMot.Text);
            }

        }


        private void dgMotoristas_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgMotoristas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgMotoristas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbPesquisaMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTelaCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroMotorista frmMot = new frmCadastroMotorista();

            frmMot.ShowDialog();
        }

        private void frmMotorista_Load(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterar_Excluir_Motorista frmMot = new frmAlterar_Excluir_Motorista();

            frmMot.ShowDialog();
        }
    }
}
