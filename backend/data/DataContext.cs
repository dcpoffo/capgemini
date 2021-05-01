using System;
using System.Collections.Generic;
using backend.models;
using Microsoft.EntityFrameworkCore;

namespace backend.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Pessoa> Pessoa { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
          {
               builder.Entity<Pessoa>()
                   .HasData(new List<Pessoa>(){
                   new Pessoa(1, "Darlan","Poffo"),
                   new Pessoa(2, "Vanessa","Tanaka"),
                   new Pessoa(3, "Nicolas","Poffo"),
                   new Pessoa(4, "Gabriel","Poffo"),
                   new Pessoa(5, "Gengis","khan"),
                   });              
          }
    }
}