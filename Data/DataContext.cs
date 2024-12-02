﻿using DattingApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DattingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> User { get; set; }
    }
}
