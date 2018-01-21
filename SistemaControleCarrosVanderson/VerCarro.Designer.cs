namespace SistemaControleCarrosVanderson
{
    partial class VerCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCarro));
            this.btnLiberar = new System.Windows.Forms.Button();
            this.gdvServicos = new System.Windows.Forms.DataGridView();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarCarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(693, 32);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(108, 23);
            this.btnLiberar.TabIndex = 0;
            this.btnLiberar.Text = "Liberar Campos";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // gdvServicos
            // 
            this.gdvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvServicos.Location = new System.Drawing.Point(17, 205);
            this.gdvServicos.Name = "gdvServicos";
            this.gdvServicos.Size = new System.Drawing.Size(789, 210);
            this.gdvServicos.TabIndex = 3;
            this.gdvServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvServicos_CellContentClick);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(110, 74);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(200, 20);
            this.txtAno.TabIndex = 17;
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(451, 32);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(200, 21);
            this.cbxFabricante.TabIndex = 18;
            this.cbxFabricante.SelectedIndexChanged += new System.EventHandler(this.cbxFabricante_SelectedIndexChanged);
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(451, 73);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(200, 21);
            this.cbxMarca.TabIndex = 19;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(110, 34);
            this.txtPlaca.Mask = "AAA-9999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(200, 20);
            this.txtPlaca.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(368, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "MARCA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(334, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "FABRICANTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(12, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "ANO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "PLACA";
            // 
            // btnAlterarCarro
            // 
            this.btnAlterarCarro.Location = new System.Drawing.Point(693, 71);
            this.btnAlterarCarro.Name = "btnAlterarCarro";
            this.btnAlterarCarro.Size = new System.Drawing.Size(108, 23);
            this.btnAlterarCarro.TabIndex = 26;
            this.btnAlterarCarro.Text = "Alterar Carro";
            this.btnAlterarCarro.UseVisualStyleBackColor = true;
            this.btnAlterarCarro.Click += new System.EventHandler(this.btnAlterarCarro_Click);
            // 
            // VerCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.ClientSize = new System.Drawing.Size(818, 440);
            this.Controls.Add(this.btnAlterarCarro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxFabricante);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.gdvServicos);
            this.Controls.Add(this.btnLiberar);
            this.Name = "VerCarro";
            this.Text = "Ver Carro";
            this.Load += new System.EventHandler(this.VerCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.DataGridView gdvServicos;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarCarro;
    }
}