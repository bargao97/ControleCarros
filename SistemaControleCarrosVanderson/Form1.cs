using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControleCarrosVanderson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Today;
            DateTime periodo = new DateTime(2017, 12, 18);
            if (hoje >= periodo)
            {
                MessageBox.Show("Periodo de teste ja encerrado");
                this.Close();
            }           
        }

        private void btnFabricante_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CadastrarFabricante"] == null)
            {
                CadastrarFabricante cf = new CadastrarFabricante();
                cf.Show();
            }
            else
            {
                MessageBox.Show("A tela de Cadastrar Fabricante está aberta, feche a tela");
            }
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CadastrarCarro"] == null)
            {
                CadastrarCarro cc = new CadastrarCarro();
                cc.Show();
            }
            else
            {
                MessageBox.Show("A tela de Cadastrar Carro está aberta, feche a tela");
            }
        }

        private void btnCadastrarServiço_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CadastrarServico"] == null)
            {
                CadastrarServico cs = new CadastrarServico();
                cs.Show();
            }
            else
            {
                MessageBox.Show("A tela de Cadastrar Servico está aberta, feche a tela");
            }
        }

        private void btnBuscarCarro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BuscarCarro"] == null)
            {
                BuscarCarro bc = new BuscarCarro();
                bc.Show();
            }
            else
            {
                MessageBox.Show("A tela de Buscar carro está aberta, feche a tela");
            }

        }

        private void btnBuscarServico_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BuscarCarro"] == null)
            {
                BuscarServico bs = new BuscarServico();
                bs.Show();
            }
            else
            {
                MessageBox.Show("A tela de Buscar Serviço está aberta, feche a tela");
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BuscarCarro"] == null)
            {
                RelatorioCarros rc = new RelatorioCarros();
                rc.Show();
            }
            else
            {
                MessageBox.Show("A tela de Buscar Serviço está aberta, feche a tela");
            }
        }
    }
}
