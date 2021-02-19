﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"\\Server:(localdb)MSSQLLocalDB;DataBase=ReCap;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }//8.video  1:41:53
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        //veritabanı tablolarımız ile projedeki class'ları bağladık.

    }
}
