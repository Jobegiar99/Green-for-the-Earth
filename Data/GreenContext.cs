﻿using Green_for_the_Earth.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_for_the_Earth.Data
{
    public class GreenContext : DbContext
    {
        public DbSet<Use> Uses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Green.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}