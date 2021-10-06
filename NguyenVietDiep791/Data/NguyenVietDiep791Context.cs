using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenVietDiep791.Models;

namespace NguyenVietDiep791.Data
{
    public class NguyenVietDiep791Context : DbContext
    {
        public NguyenVietDiep791Context (DbContextOptions<NguyenVietDiep791Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenVietDiep791.Models.PersonNVD791> PersonNVD791 { get; set; }
    }
}
