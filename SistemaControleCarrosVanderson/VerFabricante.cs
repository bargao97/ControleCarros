using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaControleCarrosVanderson.Database;

namespace SistemaControleCarrosVanderson
{
    public partial class VerFabricante : Form
    {
        public static int idFabricante;
        public VerFabricante()
        {
            InitializeComponent();
        }

        private void VerFabricante_Load(object sender, EventArgs e)
        {
            idFabricante = CadastrarFabricante.idFabricante;
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            gdvMarcas.DataSource = db.MARCA.Where(s => s.FABRICANTE == idFabricante).Select(s=>new { s.IDMARCA,s.NOMEMARCA }).ToList();
            txtFabricante.Text = db.FABRICANTE.Where(s => s.IDFABRICANTE == idFabricante).Select(s => s.NOMEFABRICANTE).FirstOrDefault();
        }

        private void btnAlterarNome_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            try
            {
                idFabricante = CadastrarFabricante.idFabricante;
                var fabAlterar = db.FABRICANTE.Where(s => s.IDFABRICANTE == idFabricante).FirstOrDefault();
                fabAlterar.NOMEFABRICANTE = txtFabricante.Text;
                db.SaveChanges();
                MessageBox.Show("Fabricante Cadastrado com sucesso");
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                  gdvMarcas.DataSource = db.MARCA.Where(s => s.FABRICANTE == idFabricante).Select(s=>new { s.IDMARCA,s.NOMEMARCA }).ToList();
                db.Dispose();
            }
        }

        private void gdvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            CadastrarMarca cm = new CadastrarMarca();
            cm.Show();
            this.Hide();
        }
    }
}
