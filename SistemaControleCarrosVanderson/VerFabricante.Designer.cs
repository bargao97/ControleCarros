namespace SistemaControleCarrosVanderson
{
    partial class VerFabricante
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
            this.gdvMarcas = new System.Windows.Forms.DataGridView();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.btnAlterarNome = new System.Windows.Forms.Button();
            this.btnCadastrarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvMarcas
            // 
            this.gdvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvMarcas.Location = new System.Drawing.Point(50, 108);
            this.gdvMarcas.Name = "gdvMarcas";
            this.gdvMarcas.Size = new System.Drawing.Size(465, 216);
            this.gdvMarcas.TabIndex = 0;
            this.gdvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvMarcas_CellContentClick);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(50, 35);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(298, 20);
            this.txtFabricante.TabIndex = 1;
            // 
            // btnAlterarNome
            // 
            this.btnAlterarNome.Location = new System.Drawing.Point(363, 35);
            this.btnAlterarNome.Name = "btnAlterarNome";
            this.btnAlterarNome.Size = new System.Drawing.Size(77, 23);
            this.btnAlterarNome.TabIndex = 2;
            this.btnAlterarNome.Text = "Alterar Nome";
            this.btnAlterarNome.UseVisualStyleBackColor = true;
            this.btnAlterarNome.Click += new System.EventHandler(this.btnAlterarNome_Click);
            // 
            // btnCadastrarMarca
            // 
            this.btnCadastrarMarca.Location = new System.Drawing.Point(50, 79);
            this.btnCadastrarMarca.Name = "btnCadastrarMarca";
            this.btnCadastrarMarca.Size = new System.Drawing.Size(103, 23);
            this.btnCadastrarMarca.TabIndex = 3;
            this.btnCadastrarMarca.Text = "Cadastrar Marca";
            this.btnCadastrarMarca.UseVisualStyleBackColor = true;
            this.btnCadastrarMarca.Click += new System.EventHandler(this.btnCadastrarMarca_Click);
            // 
            // VerFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaControleCarrosVanderson.Properties.Resources.roda;
            this.ClientSize = new System.Drawing.Size(583, 336);
            this.Controls.Add(this.btnCadastrarMarca);
            this.Controls.Add(this.btnAlterarNome);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.gdvMarcas);
            this.Name = "VerFabricante";
            this.Text = "Ver Fabricante";
            this.Load += new System.EventHandler(this.VerFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvMarcas;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Button btnAlterarNome;
        private System.Windows.Forms.Button btnCadastrarMarca;
    }
}