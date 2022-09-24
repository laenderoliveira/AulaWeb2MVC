using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AulaWeb2MVC.Models;

namespace AulaWeb2MVC.Data
{
    public class AulaWeb2MVCContexto : DbContext
    {
        public AulaWeb2MVCContexto (DbContextOptions<AulaWeb2MVCContexto> options)
            : base(options)
        {
        }

        public DbSet<AulaWeb2MVC.Models.FaculdadeModel> FaculdadeModel { get; set; } = default!;
    }
}
