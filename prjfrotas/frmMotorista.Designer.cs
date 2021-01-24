namespace prjveterinario
{
    partial class frmMotorista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgMotoristas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPesquisaMotorista = new System.Windows.Forms.ComboBox();
            this.txtFiltroPesquisaMot = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTelaCadastro = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMotoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo a tela de motoristas";
            // 
            // dgMotoristas
            // 
            this.dgMotoristas.AllowUserToAddRows = false;
            this.dgMotoristas.AllowUserToDeleteRows = false;
            this.dgMotoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMotoristas.Location = new System.Drawing.Point(18, 104);
            this.dgMotoristas.Name = "dgMotoristas";
            this.dgMotoristas.ReadOnly = true;
            this.dgMotoristas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMotoristas.Size = new System.Drawing.Size(827, 234);
            this.dgMotoristas.TabIndex = 1;
            this.dgMotoristas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMotoristas_CellClick);
            this.dgMotoristas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMotoristas_CellContentClick);
            this.dgMotoristas.SelectionChanged += new System.EventHandler(this.dgMotoristas_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe um campo para pesquisa do motrista";
            // 
            // cbPesquisaMotorista
            // 
            this.cbPesquisaMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisaMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.cbPesquisaMotorista.FormattingEnabled = true;
            this.cbPesquisaMotorista.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "CNH",
            "Email",
            "Categoria"});
            this.cbPesquisaMotorista.Location = new System.Drawing.Point(18, 80);
            this.cbPesquisaMotorista.Name = "cbPesquisaMotorista";
            this.cbPesquisaMotorista.Size = new System.Drawing.Size(121, 24);
            this.cbPesquisaMotorista.TabIndex = 3;
            this.cbPesquisaMotorista.SelectedIndexChanged += new System.EventHandler(this.cbPesquisaMotorista_SelectedIndexChanged);
            // 
            // txtFiltroPesquisaMot
            // 
            this.txtFiltroPesquisaMot.Location = new System.Drawing.Point(145, 80);
            this.txtFiltroPesquisaMot.Name = "txtFiltroPesquisaMot";
            this.txtFiltroPesquisaMot.Size = new System.Drawing.Size(460, 20);
            this.txtFiltroPesquisaMot.TabIndex = 4;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnConsulta.Location = new System.Drawing.Point(611, 77);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(91, 23);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cadastrar novo motorista";
            // 
            // btnTelaCadastro
            // 
            this.btnTelaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnTelaCadastro.Location = new System.Drawing.Point(375, 352);
            this.btnTelaCadastro.Name = "btnTelaCadastro";
            this.btnTelaCadastro.Size = new System.Drawing.Size(91, 23);
            this.btnTelaCadastro.TabIndex = 8;
            this.btnTelaCadastro.Text = "Cadastrar";
            this.btnTelaCadastro.UseVisualStyleBackColor = true;
            this.btnTelaCadastro.Click += new System.EventHandler(this.btnTelaCadastro_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnCarregar.Location = new System.Drawing.Point(764, 344);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 9;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alterar ou Excluir motorista";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnAlterar.Location = new System.Drawing.Point(375, 396);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 23);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(892, 479);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnTelaCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtFiltroPesquisaMot);
            this.Controls.Add(this.cbPesquisaMotorista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgMotoristas);
            this.Controls.Add(this.label1);
            this.Name = "frmMotorista";
            this.Text = "Motoristas";
            this.Load += new System.EventHandler(this.frmMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMotoristas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMotoristas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPesquisaMotorista;
        private System.Windows.Forms.TextBox txtFiltroPesquisaMot;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTelaCadastro;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
    }
}