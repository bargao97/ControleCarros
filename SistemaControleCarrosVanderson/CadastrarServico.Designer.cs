namespace SistemaControleCarrosVanderson
{
    partial class CadastrarServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarServico));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtDescicao = new System.Windows.Forms.TextBox();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.cbxGarantia = new System.Windows.Forms.ComboBox();
            this.dtDataServico = new System.Windows.Forms.DateTimePicker();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 566);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Alterar Serviço";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(401, 121);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLACA";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(401, 76);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(121, 20);
            this.txtAno.TabIndex = 1;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // txtDescicao
            // 
            this.txtDescicao.Location = new System.Drawing.Point(199, 301);
            this.txtDescicao.Name = "txtDescicao";
            this.txtDescicao.Size = new System.Drawing.Size(448, 20);
            this.txtDescicao.TabIndex = 5;
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(105, 121);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(121, 21);
            this.cbxFabricante.TabIndex = 2;
            this.cbxFabricante.SelectedIndexChanged += new System.EventHandler(this.cbxFabricante_SelectedIndexChanged);
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(105, 376);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(100, 20);
            this.txtGarantia.TabIndex = 7;
            // 
            // cbxGarantia
            // 
            this.cbxGarantia.FormattingEnabled = true;
            this.cbxGarantia.Location = new System.Drawing.Point(218, 375);
            this.cbxGarantia.Name = "cbxGarantia";
            this.cbxGarantia.Size = new System.Drawing.Size(121, 21);
            this.cbxGarantia.TabIndex = 8;
            // 
            // dtDataServico
            // 
            this.dtDataServico.Location = new System.Drawing.Point(168, 264);
            this.dtDataServico.Name = "dtDataServico";
            this.dtDataServico.Size = new System.Drawing.Size(200, 20);
            this.dtDataServico.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(86, 338);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 6;
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(11, 491);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(636, 60);
            this.txtObservacao.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(302, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "MARCA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(302, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ANO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "FABRICANTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(22, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "DATA DO SERVIÇO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(22, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "DESCRIÇÃO DO SERVIÇO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(22, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "PREÇO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(22, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "GARANTIA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(12, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "OBSERVAÇÃO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(132, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(371, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "INFORMAÇÕES DO CARRO";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(105, 79);
            this.txtPlaca.Mask = "AAA-9999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 20);
            this.txtPlaca.TabIndex = 0;
            this.txtPlaca.Leave += new System.EventHandler(this.txtPlaca_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(146, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(336, 31);
            this.label12.TabIndex = 24;
            this.label12.Text = "DETALHES DO SERVIÇO";
            // 
            // CadastrarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.ClientSize = new System.Drawing.Size(659, 601);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.dtDataServico);
            this.Controls.Add(this.cbxGarantia);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.cbxFabricante);
            this.Controls.Add(this.txtDescicao);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "CadastrarServico";
            this.Text = "Cadastrar Servico";
            this.Load += new System.EventHandler(this.CadastrarServico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtDescicao;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.ComboBox cbxGarantia;
        private System.Windows.Forms.DateTimePicker dtDataServico;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label12;
    }
}