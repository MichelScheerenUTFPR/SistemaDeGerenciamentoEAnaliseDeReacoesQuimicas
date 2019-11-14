using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace Teste_EmguCV.Modelo
{
    class GeradorPlanilha
    {
        ExcelPackage excel = new ExcelPackage();

        public void gerarPlanilha(IEnumerable<object[]> dados, string path)
        {
            excel.Workbook.Worksheets.Add("Planilha1");

            var linhaCabecalho = new List<string[]>()
            {
                new string[] {"R", "G", "B", "Sinal"}
            };

            string tamanhoCabecalho = "A1:" + Char.ConvertFromUtf32(linhaCabecalho[0].Length + 64) + "1";

            var worksheet = excel.Workbook.Worksheets["Planilha1"];

            worksheet.Cells[tamanhoCabecalho].LoadFromArrays(linhaCabecalho);

            worksheet.Cells[2, 1].LoadFromArrays(dados);

            FileInfo excelFile = new FileInfo(path);
            excel.SaveAs(excelFile);
        }
    }
}
