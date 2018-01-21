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
    public partial class BuscarCarro : Form
    {
        public BuscarCarro()
        {
            InitializeComponent();
        }
        public static int idCarro;
        private void BuscarCarro_Load(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            lblFabricante.Visible = false;
            lblMarca.Visible = false;
            lblPlaca.Visible = false;
            lblAno.Visible = false;
            txtAno.Visible = false;
            txtPlaca.Visible = false;
            cbxFabricante.Visible = false;
            cbxMarca.Visible = false;

            var fabricante = db.FABRICANTE.OrderBy(s=>s.NOMEFABRICANTE).ToList();
            foreach(var i in fabricante)
            {
                cbxFabricante.Items.Add(i.NOMEFABRICANTE);
            }
            gdvBusca.DataSource = db.CARROS.Select(s => new
            {
                ID = s.IDCARRO,
                PLACA = s.PLACA,
                ANO = s.ANO,
                FABRICANTE =s.FABRICANTE1.NOMEFABRICANTE,
                MARCA = s.MARCA1.NOMEMARCA
            }).ToList();
        }
        private void rbPlaca_CheckedChanged(object sender, EventArgs e)
        {
            lblPlaca.Visible = true;
            txtPlaca.Visible = true;
            lblAno.Visible = false;
            txtAno.Visible = false;
            lblFabricante.Visible = false;
            lblMarca.Visible = false;
            cbxFabricante.Visible = false;
            cbxMarca.Visible = false;
        }
        private void rbAno_CheckedChanged(object sender, EventArgs e)
        {
            lblAno.Visible = true;
            txtAno.Visible = true;
            lblFabricante.Visible = false;
            lblMarca.Visible = false;
            cbxFabricante.Visible = false;
            cbxMarca.Visible = false;
            lblPlaca.Visible = false;
            txtPlaca.Visible = false;

        }
        private void rbMarca_CheckedChanged(object sender, EventArgs e)
        {
            lblFabricante.Visible = true;
            lblMarca.Visible = true;
            cbxFabricante.Visible = true;
            cbxMarca.Visible = true;
            lblAno.Visible = false;
            txtAno.Visible = false;
            lblPlaca.Visible = false;
            txtPlaca.Visible = false;
        }

        private void cbxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            var marcaSelec = db.MARCA.Where(s => s.FABRICANTE1.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).OrderBy(s=>s.NOMEMARCA).ToList();
            var contMarca = cbxMarca.Items.Count;
            if(contMarca != 0)
            {
                cbxMarca.Items.Clear();
            }
            foreach(var i in marcaSelec)
            {
                cbxMarca.Items.Add(i.NOMEMARCA);
            }
        }

        private void gdvBusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = gdvBusca.Rows[e.RowIndex].Cells[0].Value;
            idCarro = (int)item;
            VerCarro vc = new VerCarro();
            vc.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            if (rbPlaca.Checked == true)
            {
                gdvBusca.ClearSelection();
                var busca = db.CARROS.Where(s => s.PLACA == txtPlaca.Text).Select(s => new
                {
                    ID = s.IDCARRO,
                    PLACA = s.PLACA,
                    ANO = s.ANO,
                    FABRICANTE = s.FABRICANTE1.NOMEFABRICANTE,
                    MARCA = s.MARCA1.NOMEMARCA
                }).ToList();

                gdvBusca.DataSource = busca;
            }
            if (rbAno.Checked == true)
            {
                gdvBusca.ClearSelection();
                int ano = Convert.ToInt32(txtAno.Text);
                var busca = db.CARROS
                    .Where(s => s.ANO ==ano)
                    .OrderBy(s=>s.PLACA)
                    .Select(s => new
                    {
                        ID = s.IDCARRO,
                        PLACA = s.PLACA,
                        ANO = s.ANO,
                        FABRICANTE = s.FABRICANTE1.NOMEFABRICANTE,
                        MARCA = s.MARCA1.NOMEMARCA
                    }).ToList();

                gdvBusca.DataSource = busca;
            }
            if (rbMarca.Checked == true)
            {
                gdvBusca.ClearSelection();
                var fabricante = db.FABRICANTE.Where(s => s.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).FirstOrDefault();
                var marca = db.MARCA.Where(s => s.NOMEMARCA == cbxMarca.SelectedItem.ToString()).FirstOrDefault();
                var busca = db.CARROS
                    .Where(s => s.FABRICANTE == fabricante.IDFABRICANTE && s.MARCA == marca.IDMARCA)
                    .OrderBy(s=>s.PLACA)
                    .Select(s => new
                {
                    ID = s.IDCARRO,
                    PLACA = s.PLACA,
                    ANO = s.ANO,
                    FABRICANTE = s.FABRICANTE1.NOMEFABRICANTE,
                    MARCA = s.MARCA1.NOMEMARCA
                }).ToList();

                gdvBusca.DataSource = busca;
            }
        }
    }
}
