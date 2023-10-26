using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCRUD002.Models;

namespace WebAppCRUD002.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCRUD002.Models.Consulta> Consulta { get; set; } = default!;
    }
}
