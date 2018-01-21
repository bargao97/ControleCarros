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
    public partial class CadastrarCarro : Form
    {
        public CadastrarCarro()
        {
            InitializeComponent();
        }
        public static int idCarro;
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            string placa = txtPlaca.Text;
            var carroSelecionado = db.CARROS.Where(s => s.PLACA == placa).FirstOrDefault();
            if(carroSelecionado!= null)
            {
                DialogResult MensagemCarroCadastrado = MessageBox.Show("Este Carro ja esta cadastrado.Deseja ver as informações do carro cadastrado ?", "Aviso", MessageBoxButtons.YesNo);
                if(MensagemCarroCadastrado == DialogResult.Yes)
                {
                    idCarro = carroSelecionado.IDCARRO;
                    VerCarro vc = new VerCarro();
                    vc.Show();
                    this.Close();
                }
            }
        }
        private void CadastrarCarro_Load(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            var fabricantes = db.FABRICANTE.OrderBy(s=>s.NOMEFABRICANTE).ToList();
            foreach(var i in fabricantes)
            {
                cbxFabricante.Items.Add(i.NOMEFABRICANTE);
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            CARROS car = new CARROS();
            try
            {
                car.PLACA = txtPlaca.Text;
                car.ANO = Convert.ToInt32(txtAno.Text);
                int fabricante = db.FABRICANTE.Where(s => s.NOMEFABRICANTE == cbxFabricante.SelectedItem.ToString()).Select(s => s.IDFABRICANTE).FirstOrDefault();
                int marca = db.MARCA.Where(s => s.NOMEMARCA == cbxMarca.SelectedItem.ToString()).Select(s => s.IDMARCA).FirstOrDefault();
                car.FABRICANTE = fabricante;
                car.MARCA = marca;
                db.CARROS.Add(car);
                db.SaveChanges();
                MessageBox.Show("Carro cadastrado com sucesso");
            }
            catch(DbEntityValidationException er)
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
        private void cbxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int comboitem =cbxMarca.Items.Count;
                if(comboitem > 0)
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
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
