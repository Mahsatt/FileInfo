using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Challenge2.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Challenge2.Data;
using System.Data;
using CsvHelper;
using LumenWorks.Framework.IO.Csv;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Challenge2.Controllers
{

    public class HomeController : Controller
    {
        private readonly FileUploadDbContext _context;
        private readonly FileInforepository _repository;


        public HomeController(FileUploadDbContext context)
        {
            _context = context;
            _repository =new FileInforepository(context);
        }


        public IActionResult Index(string message)
        {
            ViewBag.message = message;
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile fileField)
        {

            if (fileField.Length > 0)
            {
                var filePath = Path.GetTempFileName();

                //StreamReader sr;
                using (var memoryStream = new MemoryStream())
                {
                    // Upload the file if less than 2 MB
                    if (memoryStream.Length < 2097152)
                    {
                        List<FileField> fileFields = new List<FileField>();
                        //
                        var csvTable = new DataTable();
                        using (var csvReader = new LumenWorks.Framework.IO.Csv.CsvReader(new StreamReader(System.IO.File.OpenRead(filePath)), true))
                        {
                            csvTable.Load(csvReader);
                        }

                        //read line by line and bind to model
                        for (int i = 0; i < csvTable.Rows.Count; i++)
                        {
                            fileFields.Add(new FileField
                            {
                                Key = csvTable.Rows[i][0].ToString(),
                                ArtikelCode = csvTable.Rows[i][1].ToString(),
                                ColorCode = csvTable.Rows[i][2].ToString(),
                                Description = csvTable.Rows[i][3].ToString(),
                                Price = Convert.ToInt32(csvTable.Rows[i][4]),
                                DiscountPrice = Convert.ToInt32(csvTable.Rows[i][5]),
                                DeliveredIn = csvTable.Rows[i][6].ToString(),
                                Q1 = csvTable.Rows[i][7].ToString(),
                                Size = Convert.ToInt32(csvTable.Rows[i][8]),
                                Color = csvTable.Rows[i][9].ToString()
                            });
                        }

                        //Save File In Database
                        _context.Files.AddRange(fileFields);
                        _context.SaveChanges();


                        //Convert to Json 

                        _repository.CreateJsonFile(fileField, fileFields);
                    }
                    else
                    {
                        ModelState.AddModelError("File", "The file is too large.");
                    }
                }

            }



            return RedirectToAction("Index", new { message = "The File With Name " + fileField.FileName + ".Json created in D:\\JsonFile" });






        }
    }
}
