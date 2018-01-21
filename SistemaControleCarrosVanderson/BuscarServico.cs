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
    public partial class BuscarServico : Form
    {
        public BuscarServico()
        {
            InitializeComponent();
        }
        public static int idServico;
        private void BuscarServico_Load(object sender, EventArgs e)
        {
            dtDataServicoInicio.Visible = false;
            dtPeriodoFim.Visible = false;
            labelPeriodo.Visible = false;
            rbPlaca.Checked = true;
            
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            gdvBuscaServico.DataSource = db.SERVICOS.Select(s => new
            {
                ID = s.IDSERVICO,
                PLACA = s.PLACA,
                DATA_SERVICO = s.DATA,
                DESCRIÇÃO = s.DESCRICAO
            }).ToList();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BancoCarrosEntities1 db = new BancoCarrosEntities1();
            
            try
            {
                if (rbPlaca.Checked)
                {
                    string placa = txtPlaca.Text;
                    var servico = db.SERVICOS.Where(s => s.PLACA == placa).Select(s => new
                    {
                        ID = s.IDSERVICO,
                        PLACA = s.PLACA,
                        DATA_SERVICO = s.DATA,
                        DESCRIÇÃO = s.DESCRICAO
                    }).ToList();
                    if (servico == null)
                    {
                        MessageBox.Show("Serviço não encontrado");
                    }
                    else
                    {
                        gdvBuscaServico.ClearSelection();
                        gdvBuscaServico.DataSource = servico;
                    }
                }else if (rbDataServico.Checked)
                {
                    DateTime dataservicoInicio = new DateTime(dtDataServicoInicio.Value.Year, dtDataServicoInicio.Value.Month, dtDataServicoInicio.Value.Day);
                    DateTime dataservicoFim = new DateTime(dtPeriodoFim.Value.Year, dtPeriodoFim.Value.Month, dtPeriodoFim.Value.Day);
                    var servico = db.SERVICOS.Where(s => s.DATA.Value >= dataservicoInicio && s.DATA<= dataservicoFim).Select(s => new
                    {
                        ID = s.IDSERVICO,
                        PLACA = s.PLACA,
                        DATA_SERVICO = s.DATA,
                        DESCRIÇÃO = s.DESCRICAO
                    }).ToList();
                    if (servico == null)
                    {
                        MessageBox.Show("Serviço não encontrado");
                    }
                    else
                    {
                        gdvBuscaServico.ClearSelection();
                        gdvBuscaServico.DataSource = servico;
                    }
                }
                
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                db.Dispose();
            }
        }

        private void gdvBuscaServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = gdvBuscaServico.Rows[e.RowIndex].Cells[0].Value;
            idServico = (int)item;
            if (Application.OpenForms["VerServico"] == null)
            {
                VerServico vs = new VerServico();
                vs.Show();
            }else
            {
                MessageBox.Show("A tela de visualizar servico está aberta, feche a tela");
            }
        }

        private void rbDataServico_CheckedChanged(object sender, EventArgs e)
        {
            txtPlaca.Visible = false;
            dtDataServicoInicio.Visible=true;
            dtPeriodoFim.Visible = true;
            labelPeriodo.Visible = true;
        }

        private void rbPlaca_CheckedChanged(object sender, EventArgs e)
        {

            dtDataServicoInicio.Visible = false;
            dtPeriodoFim.Visible = false;
            labelPeriodo.Visible = false;
            txtPlaca.Visible = true;
        }
    }
}
