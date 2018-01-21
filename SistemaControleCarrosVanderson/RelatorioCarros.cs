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
using ClosedXML.Excel;

namespace SistemaControleCarrosVanderson
{
    public partial class RelatorioCarros : Form
    {
        public RelatorioCarros()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                BancoCarrosEntities1 db = new BancoCarrosEntities1();
                saveFileDialog1.InitialDirectory = "c:";
                saveFileDialog1.Title = "Relatorio Geral de Serviços";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel (2007)|*.xlsx";
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    var carros = db.SERVICOS.Where(s => s.DATA >= dtInicio.Value && s.DATA <= dtFIm.Value).ToList();
                    var wb = new XLWorkbook();
                    //Cria a Planilha com o Nome
                    var ws = wb.Worksheets.Add("RELATORIO GERAL");

                    ws.Cell("A1").Value = "RELATORIO GERAL DE SERVIÇOS:";
                    ws.Cell("C1").Value = "Total Efetuado:";
                    var range = ws.Range("A1:J2");
                    range.Merge().Style.Font.SetBold().Font.FontSize = 33;
                    // Cabeçalhos do Relatório
                    ws.Cell("A4").Value = "IDSERVIÇO";
                    ws.Cell("B4").Value = "PLACA";
                    ws.Cell("C4").Value = "ANO";
                    ws.Cell("D4").Value = "FABRICANTE";
                    ws.Cell("E4").Value = "MARCA";
                    ws.Cell("F4").Value = "DESCRÇÃO";
                    ws.Cell("G4").Value = "GARANTIA";
                    ws.Cell("H4").Value = "DATA DE TERMINO DA GARANTIA";
                    ws.Cell("I4").Value = "PREÇO";
                    ws.Cell("J4").Value = "OBSERVAÇÕES";
                    //Variavel que ira delimitar de quando ira começar o relatorio
                    var linha = 5;
                    Double? vlrtotal = 0;
                    //Corppo do relatorio
                    foreach (var c in carros)
                    {
                        ws.Cell("A" + linha.ToString()).Value = c.IDSERVICO.ToString();
                        if (c.PLACA != null) { ws.Cell("B" + linha.ToString()).Value = c.PLACA.ToString(); }
                        if (c.ANO != null) { ws.Cell("C" + linha.ToString()).Value = c.ANO.ToString(); }
                        if (c.FABRICANTE != null) { ws.Cell("D" + linha.ToString()).Value = c.FABRICANTE1.NOMEFABRICANTE.ToString(); }
                        if (c.MARCA != null) { ws.Cell("E" + linha.ToString()).Value = c.MARCA1.NOMEMARCA.ToString(); }
                        if (c.DESCRICAO != null) { ws.Cell("F" + linha.ToString()).Value = c.DESCRICAO.ToString(); }
                        if (c.GARANTIA != null) { ws.Cell("G" + linha.ToString()).Value = c.GARANTIA.ToString(); }
                        if (c.GARANTIA != null) { ws.Cell("H" + linha.ToString()).Value = c.FINAL_GARANTIA.ToString(); }
                        if (c.PRECO != null) { ws.Cell("I" + linha.ToString()).Value = c.PRECO.ToString(); }
                        if (c.OBSERVACOES != null) { ws.Cell("J" + linha.ToString()).Value = c.OBSERVACOES.ToString(); }
                        linha++;
                        vlrtotal = vlrtotal+ c.PRECO;
                    }
                    ws.Cell("A" + linha.ToString()).Value = "Total Efetuado:";
                    ws.Cell("B" + linha.ToString()).Value = "R$"+vlrtotal.ToString();


                    // Crio uma Tabela para ativar os Filtros
                    range = ws.Range("A4:J" + linha.ToString());
                    range.CreateTable();

                    // Ajusto o tamanho da coluna com o conteúdo da coluna
                    ws.Columns("1-8").AdjustToContents();


                    // Salvar o arquivo em Disco
                    wb.SaveAs(saveFileDialog1.FileName.ToString());

                    //Liberar Objetos
                    ws.Dispose();
                }
                MessageBox.Show("Relatorio gerado com sucesso");

            }
            catch(Exception er )
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
