namespace SistemaControleCarrosVanderson
{
    partial class BuscarCarro
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
            this.rbPlaca = new System.Windows.Forms.RadioButton();
            this.rbAno = new System.Windows.Forms.RadioButton();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.gdvBusca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(579, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 30);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbPlaca
            // 
            this.rbPlaca.AutoSize = true;
            this.rbPlaca.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.rbPlaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbPlaca.Location = new System.Drawing.Point(147, 37);
            this.rbPlaca.Name = "rbPlaca";
            this.rbPlaca.Size = new System.Drawing.Size(59, 17);
            this.rbPlaca.TabIndex = 1;
            this.rbPlaca.TabStop = true;
            this.rbPlaca.Text = "PLACA";
            this.rbPlaca.UseVisualStyleBackColor = true;
            this.rbPlaca.CheckedChanged += new System.EventHandler(this.rbPlaca_CheckedChanged);
            // 
            // rbAno
            // 
            this.rbAno.AutoSize = true;
            this.rbAno.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.rbAno.ForeColor = System.Drawing.Color.White;
            this.rbAno.Location = new System.Drawing.Point(275, 37);
            this.rbAno.Name = "rbAno";
            this.rbAno.Size = new System.Drawing.Size(48, 17);
            this.rbAno.TabIndex = 2;
            this.rbAno.TabStop = true;
            this.rbAno.Text = "ANO";
            this.rbAno.UseVisualStyleBackColor = true;
            this.rbAno.CheckedChanged += new System.EventHandler(this.rbAno_CheckedChanged);
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.rbMarca.ForeColor = System.Drawing.Color.White;
            this.rbMarca.Location = new System.Drawing.Point(401, 37);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(135, 17);
            this.rbMarca.TabIndex = 3;
            this.rbMarca.TabStop = true;
            this.rbMarca.Text = "MARCA/FABRICANTE";
            this.rbMarca.UseVisualStyleBackColor = true;
            this.rbMarca.CheckedChanged += new System.EventHandler(this.rbMarca_CheckedChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(356, 90);
            this.txtPlaca.Mask = "AAA-9999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 20);
            this.txtPlaca.TabIndex = 4;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(288, 90);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(121, 20);
            this.txtAno.TabIndex = 5;
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(147, 90);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(121, 21);
            this.cbxFabricante.TabIndex = 6;
            this.cbxFabricante.SelectedIndexChanged += new System.EventHandler(this.cbxFabricante_SelectedIndexChanged);
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(429, 90);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Image = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.lblMarca.Location = new System.Drawing.Point(353, 94);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 16);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "MARCA";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.ForeColor = System.Drawing.Color.White;
            this.lblFabricante.Image = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.lblFabricante.Location = new System.Drawing.Point(48, 95);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(93, 16);
            this.lblFabricante.TabIndex = 9;
            this.lblFabricante.Text = "FABRICANTE";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Image = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.lblPlaca.Location = new System.Drawing.Point(288, 91);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(51, 16);
            this.lblPlaca.TabIndex = 11;
            this.lblPlaca.Text = "PLACA";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Image = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.lblAno.Location = new System.Drawing.Point(245, 90);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 16);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "ANO";
            // 
            // gdvBusca
            // 
            this.gdvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvBusca.Location = new System.Drawing.Point(135, 146);
            this.gdvBusca.Name = "gdvBusca";
            this.gdvBusca.Size = new System.Drawing.Size(466, 150);
            this.gdvBusca.TabIndex = 12;
            this.gdvBusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvBusca_CellContentClick);
            // 
            // BuscarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.ClientSize = new System.Drawing.Size(745, 308);
            this.Controls.Add(this.gdvBusca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxFabricante);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.rbMarca);
            this.Controls.Add(this.rbAno);
            this.Controls.Add(this.rbPlaca);
            this.Controls.Add(this.btnBuscar);
            this.Name = "BuscarCarro";
            this.Text = "Buscar Carro";
            this.Load += new System.EventHandler(this.BuscarCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbPlaca;
        private System.Windows.Forms.RadioButton rbAno;
        private System.Windows.Forms.RadioButton rbMarca;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.DataGridView gdvBusca;
    }
}