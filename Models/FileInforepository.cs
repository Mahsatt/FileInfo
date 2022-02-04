using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge2.Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Challenge2.Models
{
    public class FileInforepository : IFileInfo
    {
        private readonly FileUploadDbContext _context;

        public FileInforepository(FileUploadDbContext context)
        {
            _context = context;
        }


        public void CreateJsonFile(IFormFile fileField, List<FileField> fileFields)
        {
            var json = JsonConvert.SerializeObject(fileFields);
            string fileName = fileField.FileName.Split('.')[0] + ".json";

            //Create Json File
            System.IO.File.WriteAllText(@"D:\JsonFile\" + fileName, json);
        }
    }
}
