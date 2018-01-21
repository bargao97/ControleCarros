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
    public partial class VerServico : Form
    {
        public VerServico()
        {
            InitializeComponent();
        }
        public static int idServicoCadastro;
        public static int idServicoBusca;
        public static int idServicoAlterar;
        private void VerServico_Load(object sender, EventArgs e)
        {
            idServicoCadastro = VerCarro.idServico;
            idServicoBusca = BuscarServico.idServico;
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            txtPlaca.Enabled = false;
            txtAno.Enabled = false;
            cbxFabricante.Enabled = false;
            cbxMarca.Enabled = false;
            dtDataServico.Enabled = false;
            txtDescicao.Enabled = false;
            txtPreco.Enabled = false;
            txtGarantia.Enabled = false;
            cbxGarantia.Enabled = false;
            txtObservacao.Enabled = false;
            cbxGarantia.Items.Add("DIA(S)");
            cbxGarantia.Items.Add("MESE(S)");
            cbxGarantia.Items.Add("ANO(S)");
            if (cbxFabricante.Items.Count != 0)
            {
                cbxFabricante.Items.Clear();
            }
            var fabricante = db.FABRICANTE.OrderBy(s => s.NOMEFABRICANTE).Select(s => s.NOMEFABRICANTE).ToList();
            foreach(var i in fabricante)
            {
                cbxFabricante.Items.Add(i);
            }
            if(idServicoCadastro != 0)
            {
                var servicoEncontrado =db.SERVICOS.Where(s => s.IDSERVICO == idServicoCadastro).FirstOrDefault();
                DateTime data = servicoEncontrado.DATA.Value;
                txtPlaca.Text = servicoEncontrado.PLACA;
                txtAno.Text = Convert.ToString(servicoEncontrado.ANO);
                cbxFabricante.SelectedItem = servicoEncontrado.FABRICANTE1.NOMEFABRICANTE;
                if(cbxMarca.Items.Count != 0)
                {
                    cbxMarca.Items.Clear();
                }
                var marca = db.MARCA.Where(s => s.FABRICANTE == servicoEncontrado.FABRICANTE).OrderBy(s => s.NOMEMARCA).Select(s => s.NOMEMARCA).ToList();
                foreach(var i in marca)
                {
                    cbxMarca.Items.Add(i);
                }
                cbxMarca.SelectedItem = servicoEncontrado.MARCA1.NOMEMARCA;
                dtDataServico.Value = data;
                txtDescicao.Text = servicoEncontrado.DESCRICAO;
                txtPreco.Text = Convert.ToString(servicoEncontrado.PRECO);
                txtGarantia.Text = servicoEncontrado.GARANTIA;
                txtObservacao.Text = servicoEncontrado.OBSERVACOES;
                string[] garantia = servicoEncontrado.GARANTIA.Split(new char[1] { ';' });
                int contstring = 1;
                foreach (var i in garantia)
                {
                    if (contstring == 1)
                    {
                        txtGarantia.Text = i;
                    }
                    if (contstring == 2)
                    {
                        cbxGarantia.SelectedItem = i;
                    }
                    contstring++;
                }
                lbldatagarantia.Text = servicoEncontrado.FINAL_GARANTIA.ToString();
                idServicoAlterar = idServicoCadastro;
                idServicoCadastro = 0;
            }
            if (idServicoBusca != 0)
            {
                var servicoEncontrado = db.SERVICOS.Where(s => s.IDSERVICO == idServicoBusca).FirstOrDefault();
                DateTime data = servicoEncontrado.DATA.Value;
                txtPlaca.Text = servicoEncontrado.PLACA;
                txtAno.Text = Convert.ToString(servicoEncontrado.ANO);
                cbxFabricante.SelectedItem = servicoEncontrado.FABRICANTE1.NOMEFABRICANTE;
                if (cbxMarca.Items.Count != 0)
                {
                    cbxMarca.Items.Clear();
                }
                var marca = db.MARCA.Where(s => s.FABRICANTE == servicoEncontrado.FABRICANTE).OrderBy(s => s.NOMEMARCA).Select(s => s.NOMEMARCA).ToList();
                foreach (var i in marca)
                {
                    cbxMarca.Items.Add(i);
                }
                cbxMarca.SelectedItem = servicoEncontrado.MARCA1.NOMEMARCA;
                dtDataServico.Value = data;
                txtDescicao.Text = servicoEncontrado.DESCRICAO;
                txtPreco.Text = Convert.ToString(servicoEncontrado.PRECO);
                string[] garantia = servicoEncontrado.GARANTIA.Split(new char[1] { ';' });
                int contstring = 1;
                foreach(var i in garantia)
                {
                    if(contstring == 1)
                    {
                        txtGarantia.Text = i;
                    }
                    if (contstring == 2)
                    {
                        cbxGarantia.SelectedItem = i;
                    }
                    contstring++;
                }
                lbldatagarantia.Text = servicoEncontrado.FINAL_GARANTIA.ToString();
                txtObservacao.Text = servicoEncontrado.OBSERVACOES;
                idServicoAlterar = idServicoBusca;
                idServicoBusca = 0;
            }
        }
        private void btnLiberar_Click(object sender, EventArgs e)
        {
            txtPlaca.Enabled = true;
            txtAno.Enabled = true;
            cbxFabricante.Enabled = true;
            cbxMarca.Enabled = true;
            dtDataServico.Enabled = true;
            txtDescicao.Enabled = true;
            txtPreco.Enabled = true;
            txtGarantia.Enabled = true;
            cbxGarantia.Enabled = true;
            txtObservacao.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            try
            { 
                var fabricante = db.FABRICANTE.Where(s => s.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).FirstOrDefault();
                var marca = db.MARCA.Where(s => s.NOMEMARCA == cbxMarca.SelectedItem.ToString()).FirstOrDefault();
                var serv = db.SERVICOS.Where(s => s.IDSERVICO == idServicoAlterar).FirstOrDefault();
                int garantiaVlr = Convert.ToInt32(txtGarantia.Text);
                DateTime dataServico = new DateTime(dtDataServico.Value.Year, dtDataServico.Value.Month, dtDataServico.Value.Day);
                serv.PLACA = txtPlaca.Text.ToUpper();
                serv.ANO = Convert.ToInt32(txtAno.Text);
                serv.FABRICANTE = fabricante.IDFABRICANTE;
                serv.MARCA = marca.IDMARCA;
                serv.DESCRICAO = txtDescicao.Text.ToUpper();
                serv.DATA = dataServico;
                serv.PRECO = Convert.ToDouble(txtPreco.Text);

                if (cbxGarantia.SelectedItem.ToString() == "DIA(S)")
                {
                    DateTime vlrGanatia = dataServico.AddDays(garantiaVlr);
                    serv.FINAL_GARANTIA = vlrGanatia;
                }
                if (cbxGarantia.SelectedItem.ToString() == "MESE(S)")
                {
                    DateTime vlrGanatia = dataServico.AddMonths(garantiaVlr);
                    serv.FINAL_GARANTIA = vlrGanatia;
                }
                if (cbxGarantia.SelectedItem.ToString() == "ANO(S)")
                {
                    DateTime vlrGanatia = dataServico.AddYears(garantiaVlr);
                    serv.FINAL_GARANTIA = vlrGanatia;
                }
                serv.OBSERVACOES = txtObservacao.Text.ToUpper();
                serv.GARANTIA = txtGarantia + ";" + cbxGarantia.SelectedItem.ToString();
                db.SERVICOS.Add(serv);
                db.SaveChanges();
                MessageBox.Show("Serviço Alterado Com sucesso");
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                db.Dispose();
                txtPlaca.Enabled = false;
                txtAno.Enabled = false;
                cbxFabricante.Enabled = false;
                cbxMarca.Enabled = false;
                dtDataServico.Enabled = false;
                txtDescicao.Enabled = false;
                txtPreco.Enabled = false;
                txtGarantia.Enabled = false;
                cbxGarantia.Enabled = false;
                txtObservacao.Enabled = false;
            }
           
        }
        private void txtPreco_Leave(object sender, EventArgs e)
        {
            string preco = txtPreco.Text;
            int qntLet = preco.Length;
            int cents = 2;
            int vlr = qntLet - cents;
            string vlrString = preco.Substring(0, vlr);
            string centsString = preco.Substring(vlr, 2);
            string convertVlrReais = vlrString + "," + centsString;
            txtPreco.Text = convertVlrReais;
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cbxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            int fabselec = db.FABRICANTE.Where(s => s.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).Select(s => s.IDFABRICANTE).FirstOrDefault();
            var marca = db.MARCA.Where(s => s.FABRICANTE == fabselec).OrderBy(s => s.NOMEMARCA).Select(s => s.NOMEMARCA).ToList();
            int contMarca = cbxMarca.Items.Count;
            if (contMarca != 0)
            {
                cbxMarca.Items.Clear();
            }
            foreach (var i in marca)
            {
                cbxMarca.Items.Add(i);
            }
        }
    }
}
