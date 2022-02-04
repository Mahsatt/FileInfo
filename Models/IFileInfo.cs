using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge2.Models
{
  public  interface IFileInfo
    {
        public void CreateJsonFile(IFormFile fileField, List<FileField> fileFields);
    }
}
