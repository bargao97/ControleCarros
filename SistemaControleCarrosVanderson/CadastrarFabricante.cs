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
    public partial class CadastrarFabricante : Form
    {
        public CadastrarFabricante()
        {
            InitializeComponent();
        }
        public static int idFabricante;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            try
            {
               
                FABRICANTE fab = new FABRICANTE();
                string nomeFabricante = txtNomeFabricante.Text;
                fab.NOMEFABRICANTE = nomeFabricante;
                db.FABRICANTE.Add(fab);
                db.SaveChanges();
                MessageBox.Show("Fabricante Cadastrado com sucesso");
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                txtNomeFabricante.Text = string.Empty;
                gdvFabricantes.DataSource = db.FABRICANTE.Select(S=> new {S.IDFABRICANTE,S.NOMEFABRICANTE }).ToList();
                db.Dispose();
            }
        }

        private void CadastrarFabricante_Load(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            gdvFabricantes.DataSource = db.FABRICANTE.Select(S => new { S.IDFABRICANTE, S.NOMEFABRICANTE }).ToList();
        }

        private void gdvFabricantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = gdvFabricantes.Rows[e.RowIndex].Cells[0].Value;
            idFabricante = (int)item;
            VerFabricante vf = new VerFabricante();
            vf.Show();
            this.Close();
        }
    }
}
