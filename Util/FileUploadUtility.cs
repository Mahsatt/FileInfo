using Challenge2.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge2.Util
{
    public class FileUploadUtility
    {
        public  void FileUpload(IFormFile dataFile)
        {

            List<FileField> fileList = new List<FileField>();
            // fileSize = dataFiles.Sum(f => f.Length);
            var filePaths = new List<string>();
            //foreach (var formFile in dataFiles)
            //{
                if (dataFile.Length > 0)
                {
                    var contentRootPath = (string)AppDomain.CurrentDomain.GetData("ContentRootPath");
                    var webRootPath = (string)AppDomain.CurrentDomain.GetData("WebRootPath");

                    string extension = dataFile.FileName.Split('.')[1];

                    string path = Path.Combine(contentRootPath, "wwwroot/metadata");
                    //or path = Path.Combine(contentRootPath , "wwwroot" ,"CSS" );
                    // full path to file in temp
                    var filePath = String.Concat(path, "/", dataFile.FileName); //we are using Temp file name just for the example. Add your own file path.
                    filePaths.Add(filePath);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                    dataFile.CopyToAsync(stream);
                      //  fileList.Add(new FileField(formFile.FileName.Split('.')[0], extension, fileSize, filePath));
                    }
               }
           // }

           // return dataFile;

            //  return "File Uploaded Successfully";


            
        }



        public static void CreateJsonFile(IFormFile fileField, List<FileField> fileFields)
        {
            var json = JsonConvert.SerializeObject(fileFields);
            string fileName = fileField.FileName.Split('.')[0] + ".json";

            //Create Json File
            System.IO.File.WriteAllText(@"D:\JsonFile\" + fileName, json);

        }
    }
}
