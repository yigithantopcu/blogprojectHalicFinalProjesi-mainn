using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using data.tables;

namespace data {
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
            DbPath = System.IO.Path.Join("/Users/gokhanmerden/Public/Halic/blog", "blogdb.db");
        }
        public string DbPath { get; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Krediler> Krediler { get; set; }
        public DbSet<Hava_Durumu> Hava_Durumu { get; set; }
        public DbSet<Sehirler> Sehirler { get; set; }
        public DbSet<Sözlük> Sözlük { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}