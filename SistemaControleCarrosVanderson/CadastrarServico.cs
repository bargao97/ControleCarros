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
using System.Data.Entity.Validation;

namespace SistemaControleCarrosVanderson
{
    public partial class CadastrarServico : Form
    {
        public CadastrarServico()
        {
            InitializeComponent();
        }
        public static int idCarro;
        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            try
            {
                string placa = txtPlaca.Text;
                var carroSelecionado = db.CARROS.Where(s => s.PLACA == placa).FirstOrDefault();
                if (carroSelecionado != null)
                {
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
                    var marca = db.MARCA.Where(s => s.FABRICANTE == carroSelecionado.FABRICANTE).OrderBy(s => s.NOMEMARCA).Select(s => s.NOMEMARCA).ToList();
                    int contMarca = cbxMarca.Items.Count;
                    if (contMarca != 0)
                    {
                        cbxMarca.Items.Clear();
                    }
                    foreach (var i in marca)
                    {
                        cbxMarca.Items.Add(i);
                    }
                    if (carroSelecionado.PLACA != null) { txtPlaca.Text = carroSelecionado.PLACA; }
                    if (carroSelecionado.ANO != null) { txtAno.Text = carroSelecionado.ANO.ToString(); }
                    if (carroSelecionado.FABRICANTE != null)
                    {
                        var fabsele = db.FABRICANTE.Where(s => s.IDFABRICANTE == carroSelecionado.FABRICANTE).FirstOrDefault();
                        cbxFabricante.SelectedItem = fabsele.NOMEFABRICANTE;
                    }
                    if (carroSelecionado.MARCA != null)
                    {
                        var marcasele = db.MARCA.Where(s => s.IDMARCA == carroSelecionado.MARCA).FirstOrDefault();
                        cbxMarca.SelectedItem =marcasele.NOMEMARCA;
                    }
                    idCarro = carroSelecionado.IDCARRO;
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
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                db.Dispose();
            }
            
        }

        private void CadastrarServico_Load(object sender, EventArgs e)
        {
            txtAno.CharacterCasing = CharacterCasing.Upper;
            txtDescicao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            var fabricante =  db.FABRICANTE.OrderBy(s => s.NOMEFABRICANTE).Select(s => s.NOMEFABRICANTE).ToList();
            foreach(var i in fabricante)
            {
                cbxFabricante.Items.Add(i);
            }
            cbxGarantia.Items.Add("DIA(S)");
            cbxGarantia.Items.Add("MESE(S)");
            cbxGarantia.Items.Add("ANO(S)");
        }

        private void cbxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            int fabselec = db.FABRICANTE.Where(s => s.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).Select(s=>s.IDFABRICANTE).FirstOrDefault();
            var marca = db.MARCA.Where(s => s.FABRICANTE ==fabselec).OrderBy(s => s.NOMEMARCA).Select(s => s.NOMEMARCA).ToList();
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

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtPreco_Leave(object sender, EventArgs e)
        {
            try
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
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            try
            {
                var fabricante = db.FABRICANTE.Where(s => s.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).FirstOrDefault();
                var marca = db.MARCA.Where(s => s.NOMEMARCA == cbxMarca.SelectedItem.ToString()).FirstOrDefault();
                int garantiaVlr = Convert.ToInt32(txtGarantia.Text);
                DateTime dataServico = new DateTime(dtDataServico.Value.Year, dtDataServico.Value.Month, dtDataServico.Value.Day);
                SERVICOS serv = new SERVICOS();
                serv.PLACA = txtPlaca.Text.ToUpper();
                serv.ANO = Convert.ToInt32(txtAno.Text);
                serv.FABRICANTE = fabricante.IDFABRICANTE;
                serv.MARCA = marca.IDMARCA;

                serv.DESCRICAO = txtDescicao.Text.ToUpper();
                serv.DATA = dataServico;
                serv.PRECO = Convert.ToDouble(txtPreco.Text);
                
                if(cbxGarantia.SelectedItem.ToString() == "DIA(S)")
                {
                     DateTime vlrGanatia= dataServico.AddDays(garantiaVlr);
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
                if (idCarro != 0)
                {
                    serv.CARRO = idCarro;
                    idCarro = 0;
                }
                serv.GARANTIA = txtGarantia.Text + ";" + cbxGarantia.SelectedItem.ToString();
                serv.OBSERVACOES = txtObservacao.Text.ToUpper();
                db.SERVICOS.Add(serv);
                db.SaveChanges();
                MessageBox.Show("Serviço cadastrado com sucesso");
            }
            catch (DbEntityValidationException er)
            {
                foreach (var eve in er.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            finally
            {
                db.Dispose();
                this.Close();
            }
        }

        
    }
}
