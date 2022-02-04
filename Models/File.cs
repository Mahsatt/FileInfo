using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge2.Models
{
    public class FileField
    {
        [Key]
        public string Key { get; set; }
        public string ArtikelCode  { get; set; }
        public string ColorCode { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int DiscountPrice { get; set; }
        public string DeliveredIn { get; set; }
        public string Q1 { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }


        public FileField()
        {

        }
    }
}
