﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThatSky.Model;

namespace ThatSky.Data.Access.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<NGUOI_DUNG> db_NGUOI_DUNG { get; set; }
        public DbSet<SAN_PHAM> db_SAN_PHAM { get; set; }
        public DbSet<DANH_MUC> db_DANH_MUC { get; set; }
        public DbSet<DS_HINH_ANH> db_DS_MEDIA_HINH_ANH { get; set; }
        public DbSet<GIO_HANG> db_GIO_HANG { get; set; }
        public DbSet<CHI_TIET_GIO_HANG> db_CHI_TIET_GIO_HANG { get; set; }
        public DbSet<HOA_DON> db_HOA_DON { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DS_HINH_ANH>()
                .HasOne(m => m.SAN_PHAM)
                .WithMany(s => s.db_DS_HINH_ANH)
                .HasForeignKey(m => m.MaSP);
        }
    }
    
}
