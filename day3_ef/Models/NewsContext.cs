using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace day3_ef.Models
{
    class NewsContext : DbContext
    {
        public virtual DbSet<News> News { get; set; }

        public virtual DbSet<Catalog> Catalogs {  get; set; }
        
        public virtual DbSet<Auther> Authers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=DESKTOP-9PT8N4J\\MSSQLSERVER1;Database=PressNews;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True");
            // Server=(localdb)\\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True;
        }
    }
}
