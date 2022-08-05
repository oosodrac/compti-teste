using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IronXL;

namespace UIWF
{
    public class ExcelHelper
    {
        public void inserirData()
        {
            WorkBook xlsWorkBook = WorkBook.Load(@"C:\Users\miros\Documents\visual studio 2013\Projects\TesteCompti\UIWF\bin\Debug\NewExcelFile.xlsx");
            xlsWorkBook.Metadata.Author = "Ramiro Cardoso";
            xlsWorkBook.Metadata.Created = DateTime.Now;
            xlsWorkBook.Metadata.Comments = "Teste de Ramiro Cardoso | COMPTI";
            xlsWorkBook.Metadata.Title = "Clientes";
            xlsWorkBook.Metadata.Category = "Teste";


            WorkSheet xlsSheet = xlsWorkBook.GetWorkSheet("main_sheet");
            xlsSheet["A1"].Value = "Nome";
            xlsSheet["A2"].Value = "Ramiro Cardoso";


            xlsWorkBook.SaveAs("NewExcelFile.xlsx");

        }
    }
}
