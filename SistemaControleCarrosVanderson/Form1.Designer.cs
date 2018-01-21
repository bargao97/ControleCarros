namespace SistemaControleCarrosVanderson
{
    partial class Form1
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
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnFabricante = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnBuscarCarro = new System.Windows.Forms.Button();
            this.btnCadastrarServiço = new System.Windows.Forms.Button();
            this.btnBuscarServico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarro
            // 
            this.btnCarro.Location = new System.Drawing.Point(280, 34);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(175, 62);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Cadastrar Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // btnFabricante
            // 
            this.btnFabricante.Location = new System.Drawing.Point(21, 34);
            this.btnFabricante.Name = "btnFabricante";
            this.btnFabricante.Size = new System.Drawing.Size(175, 62);
            this.btnFabricante.TabIndex = 1;
            this.btnFabricante.Text = "Cadastrar Fabricante";
            this.btnFabricante.UseVisualStyleBackColor = true;
            this.btnFabricante.Click += new System.EventHandler(this.btnFabricante_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(544, 130);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(175, 62);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Gerar Relatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnBuscarCarro
            // 
            this.btnBuscarCarro.Location = new System.Drawing.Point(21, 130);
            this.btnBuscarCarro.Name = "btnBuscarCarro";
            this.btnBuscarCarro.Size = new System.Drawing.Size(175, 62);
            this.btnBuscarCarro.TabIndex = 4;
            this.btnBuscarCarro.Text = "Buscar Carro";
            this.btnBuscarCarro.UseVisualStyleBackColor = true;
            this.btnBuscarCarro.Click += new System.EventHandler(this.btnBuscarCarro_Click);
            // 
            // btnCadastrarServiço
            // 
            this.btnCadastrarServiço.Location = new System.Drawing.Point(544, 34);
            this.btnCadastrarServiço.Name = "btnCadastrarServiço";
            this.btnCadastrarServiço.Size = new System.Drawing.Size(175, 62);
            this.btnCadastrarServiço.TabIndex = 5;
            this.btnCadastrarServiço.Text = "Cadastrar Serviço";
            this.btnCadastrarServiço.UseVisualStyleBackColor = true;
            this.btnCadastrarServiço.Click += new System.EventHandler(this.btnCadastrarServiço_Click);
            // 
            // btnBuscarServico
            // 
            this.btnBuscarServico.Location = new System.Drawing.Point(280, 130);
            this.btnBuscarServico.Name = "btnBuscarServico";
            this.btnBuscarServico.Size = new System.Drawing.Size(175, 62);
            this.btnBuscarServico.TabIndex = 6;
            this.btnBuscarServico.Text = "Buscar Serviço";
            this.btnBuscarServico.UseVisualStyleBackColor = true;
            this.btnBuscarServico.Click += new System.EventHandler(this.btnBuscarServico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.ferrari_2;
            this.ClientSize = new System.Drawing.Size(731, 295);
            this.Controls.Add(this.btnBuscarServico);
            this.Controls.Add(this.btnCadastrarServiço);
            this.Controls.Add(this.btnBuscarCarro);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnFabricante);
            this.Controls.Add(this.btnCarro);
            this.Name = "Form1";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnFabricante;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnBuscarCarro;
        private System.Windows.Forms.Button btnCadastrarServiço;
        private System.Windows.Forms.Button btnBuscarServico;
    }
}

