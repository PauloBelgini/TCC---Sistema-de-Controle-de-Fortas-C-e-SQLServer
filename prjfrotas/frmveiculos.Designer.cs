namespace prjveterinario
{
    partial class frmveiculos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblobs = new System.Windows.Forms.Label();
            this.txtveiid = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtveiculoobs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.MaskedTextBox();
            this.txtchassi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtkm = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtveinome = new System.Windows.Forms.TextBox();
            this.btnatualizarvei = new System.Windows.Forms.Button();
            this.btndeletarvei = new System.Windows.Forms.Button();
            this.btnlimpartelavei = new System.Windows.Forms.Button();
            this.btncadastrarvei = new System.Windows.Forms.Button();
            this.cbcombustivel = new System.Windows.Forms.ComboBox();
            this.dgveiculos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgveiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(1, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MARCA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(320, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CHASSIS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblcodigo.Location = new System.Drawing.Point(1, 68);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(60, 16);
            this.lblcodigo.TabIndex = 3;
            this.lblcodigo.Text = "CODIGO";
            // 
            // lblobs
            // 
            this.lblobs.AutoSize = true;
            this.lblobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblobs.Location = new System.Drawing.Point(-1, 212);
            this.lblobs.Name = "lblobs";
            this.lblobs.Size = new System.Drawing.Size(110, 16);
            this.lblobs.TabIndex = 4;
            this.lblobs.Text = "OBSERVAÇÕES";
            this.lblobs.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtveiid
            // 
            this.txtveiid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtveiid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtveiid.Location = new System.Drawing.Point(108, 62);
            this.txtveiid.Name = "txtveiid";
            this.txtveiid.ReadOnly = true;
            this.txtveiid.Size = new System.Drawing.Size(100, 22);
            this.txtveiid.TabIndex = 1;
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtmarca.Location = new System.Drawing.Point(107, 120);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(190, 22);
            this.txtmarca.TabIndex = 3;
            // 
            // txtveiculoobs
            // 
            this.txtveiculoobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtveiculoobs.Location = new System.Drawing.Point(108, 206);
            this.txtveiculoobs.Name = "txtveiculoobs";
            this.txtveiculoobs.Size = new System.Drawing.Size(324, 22);
            this.txtveiculoobs.TabIndex = 6;
            this.txtveiculoobs.TextChanged += new System.EventHandler(this.txtaniobservacoes_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(1, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "COMBUSTÍVEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(1, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "PLACA";
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtplaca.Location = new System.Drawing.Point(107, 148);
            this.txtplaca.Mask = "aaa0000";
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 22);
            this.txtplaca.TabIndex = 4;
            // 
            // txtchassi
            // 
            this.txtchassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtchassi.Location = new System.Drawing.Point(386, 87);
            this.txtchassi.MaxLength = 17;
            this.txtchassi.Name = "txtchassi";
            this.txtchassi.Size = new System.Drawing.Size(190, 22);
            this.txtchassi.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(320, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "KM";
            // 
            // txtkm
            // 
            this.txtkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtkm.Location = new System.Drawing.Point(386, 120);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(190, 22);
            this.txtkm.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(1, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "NOME";
            // 
            // txtveinome
            // 
            this.txtveinome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtveinome.Location = new System.Drawing.Point(107, 90);
            this.txtveinome.Name = "txtveinome";
            this.txtveinome.Size = new System.Drawing.Size(190, 22);
            this.txtveinome.TabIndex = 2;
            // 
            // btnatualizarvei
            // 
            this.btnatualizarvei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatualizarvei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizarvei.Location = new System.Drawing.Point(212, 235);
            this.btnatualizarvei.Name = "btnatualizarvei";
            this.btnatualizarvei.Size = new System.Drawing.Size(99, 23);
            this.btnatualizarvei.TabIndex = 10;
            this.btnatualizarvei.Text = "ATUALIZAR";
            this.btnatualizarvei.UseVisualStyleBackColor = true;
            this.btnatualizarvei.Click += new System.EventHandler(this.btnatualizarvei_Click);
            // 
            // btndeletarvei
            // 
            this.btndeletarvei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletarvei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletarvei.Location = new System.Drawing.Point(323, 235);
            this.btndeletarvei.Name = "btndeletarvei";
            this.btndeletarvei.Size = new System.Drawing.Size(99, 23);
            this.btndeletarvei.TabIndex = 11;
            this.btndeletarvei.Text = "DELETAR";
            this.btndeletarvei.UseVisualStyleBackColor = true;
            this.btndeletarvei.Click += new System.EventHandler(this.btndeletarvei_Click);
            // 
            // btnlimpartelavei
            // 
            this.btnlimpartelavei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpartelavei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpartelavei.Location = new System.Drawing.Point(428, 235);
            this.btnlimpartelavei.Name = "btnlimpartelavei";
            this.btnlimpartelavei.Size = new System.Drawing.Size(99, 23);
            this.btnlimpartelavei.TabIndex = 12;
            this.btnlimpartelavei.Text = "LIMPAR";
            this.btnlimpartelavei.UseVisualStyleBackColor = true;
            this.btnlimpartelavei.Click += new System.EventHandler(this.btnlimpartelavei_Click);
            // 
            // btncadastrarvei
            // 
            this.btncadastrarvei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrarvei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarvei.Location = new System.Drawing.Point(107, 235);
            this.btncadastrarvei.Name = "btncadastrarvei";
            this.btncadastrarvei.Size = new System.Drawing.Size(99, 23);
            this.btncadastrarvei.TabIndex = 9;
            this.btncadastrarvei.Text = "CADASTRAR";
            this.btncadastrarvei.UseVisualStyleBackColor = true;
            this.btncadastrarvei.Click += new System.EventHandler(this.btncadastrarvei_Click);
            // 
            // cbcombustivel
            // 
            this.cbcombustivel.DisplayMember = "combnome";
            this.cbcombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcombustivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.cbcombustivel.FormattingEnabled = true;
            this.cbcombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol",
            "Diesel"});
            this.cbcombustivel.Location = new System.Drawing.Point(108, 177);
            this.cbcombustivel.Name = "cbcombustivel";
            this.cbcombustivel.Size = new System.Drawing.Size(100, 24);
            this.cbcombustivel.TabIndex = 5;
            this.cbcombustivel.ValueMember = "combid";
            this.cbcombustivel.SelectedIndexChanged += new System.EventHandler(this.cbcombustivel_SelectedIndexChanged);
            // 
            // dgveiculos
            // 
            this.dgveiculos.AllowUserToAddRows = false;
            this.dgveiculos.AllowUserToDeleteRows = false;
            this.dgveiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveiculos.Location = new System.Drawing.Point(4, 264);
            this.dgveiculos.Name = "dgveiculos";
            this.dgveiculos.ReadOnly = true;
            this.dgveiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgveiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgveiculos.Size = new System.Drawing.Size(939, 201);
            this.dgveiculos.TabIndex = 36;
            this.dgveiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgveiculos_CellClick);
            this.dgveiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgveiculos_CellContentClick);
            this.dgveiculos.SelectionChanged += new System.EventHandler(this.dgveiculos_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjveterinario.Properties.Resources._55283;
            this.pictureBox1.Location = new System.Drawing.Point(610, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmveiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(947, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgveiculos);
            this.Controls.Add(this.cbcombustivel);
            this.Controls.Add(this.btncadastrarvei);
            this.Controls.Add(this.btnlimpartelavei);
            this.Controls.Add(this.btndeletarvei);
            this.Controls.Add(this.btnatualizarvei);
            this.Controls.Add(this.txtveinome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtchassi);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtveiculoobs);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtveiid);
            this.Controls.Add(this.lblobs);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmveiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculos";
            this.Load += new System.EventHandler(this.frmanimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgveiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblobs;
        private System.Windows.Forms.TextBox txtveiid;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtveiculoobs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtplaca;
        private System.Windows.Forms.TextBox txtchassi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtkm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtveinome;
        private System.Windows.Forms.Button btnatualizarvei;
        private System.Windows.Forms.Button btndeletarvei;
        private System.Windows.Forms.Button btnlimpartelavei;
        private System.Windows.Forms.Button btncadastrarvei;
        private System.Windows.Forms.ComboBox cbcombustivel;
        private System.Windows.Forms.DataGridView dgveiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}