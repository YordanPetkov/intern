﻿using DPS.Data.Configurations;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorConfiguration());
        }

        public virtual DbSet<AuthorRealName> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<AuthorNickname> Nicknames { get; set; }
    }
}