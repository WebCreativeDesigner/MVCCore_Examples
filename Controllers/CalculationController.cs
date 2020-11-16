using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Web;
using MVCCore_Examples.Models;
using System.Collections.Immutable;
using ClosedXML.Excel;
using System.Text;

namespace MVCCore_Examples.Controllers
{
    public class CalculationController : Controller
    {
        private List<CalculatedDataModel> CalculatedDataModelList = null;
        private ICalculatedDataRepository repository = null;

        private readonly ILogger<CalculationController> _logger;
        //private static List<CalculatedDataModel> _CalculatedDataList = CreateCalculatedDataList();

        public CalculationController(ILogger<CalculationController> logger, ICalculatedDataRepository _repository)
        {
            _logger = logger;
            this.repository = _repository;
            this.CalculatedDataModelList = new List<CalculatedDataModel>();
        }

        static void ExportDataToFile(List<decimal> DataList, string OutputFilePath)
        {
            try
            {
                for (int i = 0; i < DataList.Count; i++)
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@OutputFilePath, true))
                    {
                        file.WriteLine(DataList[i]);
                    }
                Console.WriteLine("Number of items calculated was " + DataList.Count() + " and exported to " + OutputFilePath + ".");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IActionResult Index()
        {
         
            CalculatedDataModelList = (List<CalculatedDataModel>)repository.GetAllCalculatedDataRepository();
            return View(CalculatedDataModelList.ToList());
        }
        
        public IActionResult Excel()
        {
            // this needs the NUGET package ClosedXML installed.
            CalculatedDataModelList = (List<CalculatedDataModel>)repository.GetAllCalculatedDataRepository();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("CalculatedDataList");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "RawData";
                worksheet.Cell(currentRow, 3).Value = "c";
                worksheet.Cell(currentRow, 4).Value = "m";
                worksheet.Cell(currentRow, 5).Value = "Calculated";
                foreach (var CalculatedData_ in CalculatedDataModelList)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = CalculatedData_.Id;
                    worksheet.Cell(currentRow, 2).Value = CalculatedData_.RawData;
                    worksheet.Cell(currentRow, 3).Value = CalculatedData_.c;
                    worksheet.Cell(currentRow, 4).Value = CalculatedData_.m;
                    worksheet.Cell(currentRow, 5).Value = CalculatedData_.Calculated;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "CalculatedData.xlsx");
                }
            }
        }

        public IActionResult Csv()
        {
            CalculatedDataModelList = (List<CalculatedDataModel>)repository.GetAllCalculatedDataRepository();
            var builder = new StringBuilder();
            builder.AppendLine("Id,RawData,c,m,Calculated");
            foreach (var CalculatedData in CalculatedDataModelList)
            {
                builder.AppendLine($"{CalculatedData.Id},{CalculatedData.RawData},{CalculatedData.c},{CalculatedData.m},{CalculatedData.Calculated}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "CalculatedData.csv");
        }
  
    }
}
