﻿using System;
using CS321_W3D1_ToDoAPI_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CS321_W3D1_ToDoAPI_EF.Data
{
    public class ToDoContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ToDos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ToDo>().HasData(
               new ToDo { Id = 1, Description = "Laundry" },
               new ToDo { Id = 2, Description = "Shopping" },
               new ToDo { Id = 3, Description = "Mow lawn" }
            );
        }

        public DbSet<ToDo> ToDos { get; set; }

    }


}