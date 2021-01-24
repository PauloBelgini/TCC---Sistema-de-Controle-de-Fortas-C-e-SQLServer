namespace prjveterinario
{
    partial class frmclientes
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btncadastrarcliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeletarcli = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.btncarregar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.cbPesquisaClientes = new System.Windows.Forms.ComboBox();
            this.txtFiltroPesquisaCli = new System.Windows.Forms.TextBox();
            this.btnbuscarcli = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdatamask = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(10, 51);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(52, 16);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo";
            this.lblcodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(10, 78);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(45, 16);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(10, 104);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(34, 16);
            this.lblcpf.TabIndex = 2;
            this.lblcpf.Text = "CPF";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(10, 130);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 16);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-Mail";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(10, 153);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(37, 16);
            this.lbldata.TabIndex = 4;
            this.lbldata.Text = "Data";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(66, 43);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(168, 22);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtnome.Location = new System.Drawing.Point(66, 69);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(168, 22);
            this.txtnome.TabIndex = 1;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtcpf.Location = new System.Drawing.Point(66, 95);
            this.txtcpf.MaxLength = 11;
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(168, 22);
            this.txtcpf.TabIndex = 2;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Window;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtemail.Location = new System.Drawing.Point(66, 121);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(168, 22);
            this.txtemail.TabIndex = 3;
            // 
            // btncadastrarcliente
            // 
            this.btncadastrarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btncadastrarcliente.Location = new System.Drawing.Point(281, 43);
            this.btncadastrarcliente.Name = "btncadastrarcliente";
            this.btncadastrarcliente.Size = new System.Drawing.Size(94, 20);
            this.btncadastrarcliente.TabIndex = 5;
            this.btncadastrarcliente.Text = "CADASTRAR";
            this.btncadastrarcliente.UseVisualStyleBackColor = true;
            this.btncadastrarcliente.Click += new System.EventHandler(this.btncadastrarcliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastrar cliente";
            // 
            // btndeletarcli
            // 
            this.btndeletarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletarcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btndeletarcli.Location = new System.Drawing.Point(281, 95);
            this.btndeletarcli.Name = "btndeletarcli";
            this.btndeletarcli.Size = new System.Drawing.Size(94, 21);
            this.btndeletarcli.TabIndex = 7;
            this.btndeletarcli.Text = "DELETAR";
            this.btndeletarcli.UseVisualStyleBackColor = true;
            this.btndeletarcli.Click += new System.EventHandler(this.btndeletarcli_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(12, 183);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(599, 268);
            this.dgClientes.TabIndex = 9;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            this.dgClientes.SelectionChanged += new System.EventHandler(this.dgClientes_SelectionChanged);
            // 
            // btncarregar
            // 
            this.btncarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btncarregar.Location = new System.Drawing.Point(617, 183);
            this.btncarregar.Name = "btncarregar";
            this.btncarregar.Size = new System.Drawing.Size(124, 40);
            this.btncarregar.TabIndex = 10;
            this.btncarregar.Text = "CARREGAR";
            this.btncarregar.UseVisualStyleBackColor = true;
            this.btncarregar.Click += new System.EventHandler(this.btncarregar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnlimpar.Location = new System.Drawing.Point(281, 122);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 23);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnatualizar.Location = new System.Drawing.Point(281, 69);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(94, 20);
            this.btnatualizar.TabIndex = 6;
            this.btnatualizar.Text = "ATUALIZAR";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // cbPesquisaClientes
            // 
            this.cbPesquisaClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPesquisaClientes.FormattingEnabled = true;
            this.cbPesquisaClientes.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "CPF",
            "E-mail"});
            this.cbPesquisaClientes.Location = new System.Drawing.Point(12, 467);
            this.cbPesquisaClientes.Name = "cbPesquisaClientes";
            this.cbPesquisaClientes.Size = new System.Drawing.Size(133, 24);
            this.cbPesquisaClientes.TabIndex = 13;
            this.cbPesquisaClientes.SelectedIndexChanged += new System.EventHandler(this.cbPesquisaClientes_SelectedIndexChanged);
            // 
            // txtFiltroPesquisaCli
            // 
            this.txtFiltroPesquisaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtFiltroPesquisaCli.Location = new System.Drawing.Point(151, 469);
            this.txtFiltroPesquisaCli.Name = "txtFiltroPesquisaCli";
            this.txtFiltroPesquisaCli.Size = new System.Drawing.Size(298, 22);
            this.txtFiltroPesquisaCli.TabIndex = 14;
            // 
            // btnbuscarcli
            // 
            this.btnbuscarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnbuscarcli.Location = new System.Drawing.Point(455, 468);
            this.btnbuscarcli.Name = "btnbuscarcli";
            this.btnbuscarcli.Size = new System.Drawing.Size(94, 24);
            this.btnbuscarcli.TabIndex = 15;
            this.btnbuscarcli.Text = "BUSCAR";
            this.btnbuscarcli.UseVisualStyleBackColor = true;
            this.btnbuscarcli.Click += new System.EventHandler(this.btnbuscarcli_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjveterinario.Properties.Resources.logovet;
            this.pictureBox1.Location = new System.Drawing.Point(438, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtdatamask
            // 
            this.txtdatamask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtdatamask.Location = new System.Drawing.Point(66, 149);
            this.txtdatamask.Mask = "00/00/0000";
            this.txtdatamask.Name = "txtdatamask";
            this.txtdatamask.Size = new System.Drawing.Size(168, 22);
            this.txtdatamask.TabIndex = 24;
            this.txtdatamask.ValidatingType = typeof(System.DateTime);
            // 
            // frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(749, 511);
            this.Controls.Add(this.txtdatamask);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbuscarcli);
            this.Controls.Add(this.txtFiltroPesquisaCli);
            this.Controls.Add(this.cbPesquisaClientes);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncarregar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btndeletarcli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadastrarcliente);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblcodigo);
            this.Name = "frmclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btncadastrarcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeletarcli;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Button btncarregar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.ComboBox cbPesquisaClientes;
        private System.Windows.Forms.TextBox txtFiltroPesquisaCli;
        private System.Windows.Forms.Button btnbuscarcli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtdatamask;
    }
}