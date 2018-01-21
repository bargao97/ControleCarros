namespace SistemaControleCarrosVanderson
{
    partial class BuscarServico
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.gdvBuscaServico = new System.Windows.Forms.DataGridView();
            this.rbPlaca = new System.Windows.Forms.RadioButton();
            this.rbDataServico = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDataServicoInicio = new System.Windows.Forms.DateTimePicker();
            this.dtPeriodoFim = new System.Windows.Forms.DateTimePicker();
            this.labelPeriodo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscaServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(376, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(172, 77);
            this.txtPlaca.Mask = "AAA-9999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(133, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // gdvBuscaServico
            // 
            this.gdvBuscaServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvBuscaServico.Location = new System.Drawing.Point(56, 131);
            this.gdvBuscaServico.Name = "gdvBuscaServico";
            this.gdvBuscaServico.Size = new System.Drawing.Size(503, 198);
            this.gdvBuscaServico.TabIndex = 2;
            this.gdvBuscaServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvBuscaServico_CellContentClick);
            // 
            // rbPlaca
            // 
            this.rbPlaca.AutoSize = true;
            this.rbPlaca.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.rbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlaca.ForeColor = System.Drawing.Color.White;
            this.rbPlaca.Location = new System.Drawing.Point(212, 37);
            this.rbPlaca.Name = "rbPlaca";
            this.rbPlaca.Size = new System.Drawing.Size(66, 24);
            this.rbPlaca.TabIndex = 3;
            this.rbPlaca.TabStop = true;
            this.rbPlaca.Text = "Placa";
            this.rbPlaca.UseVisualStyleBackColor = true;
            this.rbPlaca.CheckedChanged += new System.EventHandler(this.rbPlaca_CheckedChanged);
            // 
            // rbDataServico
            // 
            this.rbDataServico.AutoSize = true;
            this.rbDataServico.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.rbDataServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDataServico.ForeColor = System.Drawing.Color.White;
            this.rbDataServico.Location = new System.Drawing.Point(311, 37);
            this.rbDataServico.Name = "rbDataServico";
            this.rbDataServico.Size = new System.Drawing.Size(140, 24);
            this.rbDataServico.TabIndex = 4;
            this.rbDataServico.TabStop = true;
            this.rbDataServico.Text = "Data de Serviço";
            this.rbDataServico.UseVisualStyleBackColor = true;
            this.rbDataServico.CheckedChanged += new System.EventHandler(this.rbDataServico_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Forma de Busca:";
            // 
            // dtDataServicoInicio
            // 
            this.dtDataServicoInicio.Location = new System.Drawing.Point(12, 77);
            this.dtDataServicoInicio.Name = "dtDataServicoInicio";
            this.dtDataServicoInicio.Size = new System.Drawing.Size(154, 20);
            this.dtDataServicoInicio.TabIndex = 6;
            // 
            // dtPeriodoFim
            // 
            this.dtPeriodoFim.Location = new System.Drawing.Point(204, 77);
            this.dtPeriodoFim.Name = "dtPeriodoFim";
            this.dtPeriodoFim.Size = new System.Drawing.Size(166, 20);
            this.dtPeriodoFim.TabIndex = 7;
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriodo.ForeColor = System.Drawing.Color.White;
            this.labelPeriodo.Image = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.labelPeriodo.Location = new System.Drawing.Point(168, 75);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(36, 20);
            this.labelPeriodo.TabIndex = 8;
            this.labelPeriodo.Text = "ate:";
            // 
            // BuscarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.ClientSize = new System.Drawing.Size(645, 355);
            this.Controls.Add(this.labelPeriodo);
            this.Controls.Add(this.dtPeriodoFim);
            this.Controls.Add(this.dtDataServicoInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDataServico);
            this.Controls.Add(this.rbPlaca);
            this.Controls.Add(this.gdvBuscaServico);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnBuscar);
            this.Name = "BuscarServico";
            this.Text = "Buscar Servico";
            this.Load += new System.EventHandler(this.BuscarServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscaServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.DataGridView gdvBuscaServico;
        private System.Windows.Forms.RadioButton rbPlaca;
        private System.Windows.Forms.RadioButton rbDataServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDataServicoInicio;
        private System.Windows.Forms.DateTimePicker dtPeriodoFim;
        private System.Windows.Forms.Label labelPeriodo;
    }
}