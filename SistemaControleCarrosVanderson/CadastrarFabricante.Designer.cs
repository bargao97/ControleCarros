namespace SistemaControleCarrosVanderson
{
    partial class CadastrarFabricante
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeFabricante = new System.Windows.Forms.TextBox();
            this.gdvFabricantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFabricantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(494, 56);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 40);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeFabricante
            // 
            this.txtNomeFabricante.Location = new System.Drawing.Point(198, 56);
            this.txtNomeFabricante.Multiline = true;
            this.txtNomeFabricante.Name = "txtNomeFabricante";
            this.txtNomeFabricante.Size = new System.Drawing.Size(252, 40);
            this.txtNomeFabricante.TabIndex = 1;
            // 
            // gdvFabricantes
            // 
            this.gdvFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvFabricantes.Location = new System.Drawing.Point(47, 126);
            this.gdvFabricantes.Name = "gdvFabricantes";
            this.gdvFabricantes.Size = new System.Drawing.Size(591, 160);
            this.gdvFabricantes.TabIndex = 2;
            this.gdvFabricantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvFabricantes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Image = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.label1.Location = new System.Drawing.Point(44, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do fabricante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CadastrarFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.ClientSize = new System.Drawing.Size(674, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdvFabricantes);
            this.Controls.Add(this.txtNomeFabricante);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "CadastrarFabricante";
            this.Text = "Cadastrar Fabricante";
            this.Load += new System.EventHandler(this.CadastrarFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvFabricantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeFabricante;
        private System.Windows.Forms.DataGridView gdvFabricantes;
        private System.Windows.Forms.Label label1;
    }
}