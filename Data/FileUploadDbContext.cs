using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge2.Models;

namespace Challenge2.Data
{
    public class FileUploadDbContext : DbContext
    {
        public FileUploadDbContext()
        {
        }

        public FileUploadDbContext(DbContextOptions<FileUploadDbContext> options)
        : base(options)
        {

        }

        public DbSet<FileField> Files { get; set; }

    }
}
