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
    public partial class CadastrarMarca : Form
    {
        public CadastrarMarca()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            int idFabricante = VerFabricante.idFabricante;
            try
            {
                var FabSelect = db.FABRICANTE.Where(s => s.IDFABRICANTE == idFabricante).FirstOrDefault();
                MARCA marca = new MARCA();
                marca.NOMEMARCA = txtMarca.Text;
                marca.FABRICANTE = FabSelect.IDFABRICANTE;
                db.MARCA.Add(marca);
                db.SaveChanges();
                MessageBox.Show("Marca Cadastrada com sucesso");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                int id = idFabricante;
                db.Dispose();
                VerFabricante vf = new VerFabricante();
                vf.Show();
                this.Close();
            }
        }

        private void CadastrarMarca_Load(object sender, EventArgs e)
        {
            

        }
    }
}
