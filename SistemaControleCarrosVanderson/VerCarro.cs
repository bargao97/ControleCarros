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
    public partial class VerCarro : Form
    {
        public static int idCarroCadastro;
        public static int idCarroBusca;
        public static int idServico;
        public VerCarro()
        {
            InitializeComponent();
        }

        private void VerCarro_Load(object sender, EventArgs e)
        {
            idCarroBusca = BuscarCarro.idCarro;
            idCarroCadastro = CadastrarCarro.idCarro;

            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            var fabricantes = db.FABRICANTE.ToList();
            foreach (var i in fabricantes)
            {
                cbxFabricante.Items.Add(i.NOMEFABRICANTE);
            }
            idCarroCadastro = CadastrarCarro.idCarro;
            if (idCarroCadastro != 0)
            {
                var carroSelecionado = db.CARROS.Where(s => s.IDCARRO == idCarroCadastro).FirstOrDefault();
                txtPlaca.Text = carroSelecionado.PLACA.ToString();
                txtAno.Text = carroSelecionado.ANO.ToString();
                var fabselec = db.FABRICANTE.Where(s => s.IDFABRICANTE == carroSelecionado.FABRICANTE).FirstOrDefault();
                cbxFabricante.SelectedItem = carroSelecionado.FABRICANTE1.NOMEFABRICANTE;
                var marca = db.MARCA.Where(s => s.FABRICANTE == carroSelecionado.FABRICANTE).OrderBy(s => s.NOMEMARCA).ToList();
                foreach(var i in marca)
                {
                    cbxMarca.Items.Add(i.NOMEMARCA);
                }
                cbxMarca.SelectedItem = carroSelecionado.MARCA1.NOMEMARCA;
                gdvServicos.DataSource = db.SERVICOS.Where(s => s.CARRO == carroSelecionado.IDCARRO)
                                        .OrderByDescending(s => s.IDSERVICO)
                                        .Select(s=>new {
                                            ID = s.IDSERVICO,
                                            DATA=s.DATA,
                                            DESCRIÇÃO = s.DESCRICAO,
                                            valor = s.PRECO
                                        }).ToList();

                CadastrarCarro.idCarro = 0;
            }
            if (idCarroBusca != 0)
            {
               var carroSelecionado = db.CARROS.Where(s => s.IDCARRO == idCarroBusca).FirstOrDefault();
                txtPlaca.Text = carroSelecionado.PLACA.ToString();
                txtAno.Text = carroSelecionado.ANO.ToString();
                var fabselec = db.FABRICANTE.Where(s => s.IDFABRICANTE == carroSelecionado.FABRICANTE).FirstOrDefault();
                cbxFabricante.SelectedItem = carroSelecionado.FABRICANTE1.NOMEFABRICANTE;
                var marca = db.MARCA.Where(s => s.FABRICANTE == carroSelecionado.FABRICANTE).OrderBy(s => s.NOMEMARCA).ToList();
                foreach (var i in marca)
                {
                    cbxMarca.Items.Add(i.NOMEMARCA);
                }
                cbxMarca.SelectedItem=carroSelecionado.MARCA1.NOMEMARCA;
                gdvServicos.DataSource = db.SERVICOS.Where(s => s.CARRO == carroSelecionado.IDCARRO)
                        .OrderByDescending(s => s.IDSERVICO)
                        .Select(s => new {
                            ID = s.IDSERVICO,
                            DATA = s.DATA,
                            DESCRIÇÃO = s.DESCRICAO,
                            valor = s.PRECO
                        }).ToList();
                BuscarCarro.idCarro = 0;
            }
            txtAno.Enabled = false;
            txtPlaca.Enabled = false;
            cbxMarca.Enabled = false;
            cbxFabricante.Enabled = false;
            
        }
        private void cbxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int comboitem = cbxMarca.Items.Count;
                if (comboitem > 0)
                {
                    cbxMarca.Items.Clear();
                }

                BancoCarrosEntities1 db = new BancoCarrosEntities1();
                var fab = db.FABRICANTE.Where(s => s.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).FirstOrDefault();
                var mar = db.MARCA.Where(s => s.FABRICANTE == fab.IDFABRICANTE).OrderBy(s => s.NOMEMARCA).ToList();
                foreach (var i in mar)
                {
                    cbxMarca.Items.Add(i.NOMEMARCA);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            txtAno.Enabled = true;
            txtPlaca.Enabled = true;
            cbxMarca.Enabled = true;
            cbxFabricante.Enabled = true;
        }

        private void btnAlterarCarro_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            try
            {
                int idcar = 0;
                if (idCarroCadastro != 0)
                {
                    idcar = idCarroCadastro;
                }
                if (idCarroBusca != 0)
                {
                    idcar = idCarroBusca;
                }
                var selecCarro = db.CARROS.Where(s => s.IDCARRO == idcar).FirstOrDefault();
                selecCarro.PLACA = txtPlaca.Text;
                selecCarro.ANO = Convert.ToInt32(txtAno.Text);
                selecCarro.FABRICANTE = db.FABRICANTE.Where(s => s.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).Select(s => s.IDFABRICANTE).FirstOrDefault();
                selecCarro.FABRICANTE = db.MARCA.Where(s => s.NOMEMARCA == cbxMarca.SelectedItem.ToString()).Select(s => s.IDMARCA).FirstOrDefault();
                db.SaveChanges();
                MessageBox.Show("Informações do carro alteradas com sucesso");
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);

            }
        }

        private void gdvServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = gdvServicos.Rows[e.RowIndex].Cells[0].Value;

        }
    }
}
