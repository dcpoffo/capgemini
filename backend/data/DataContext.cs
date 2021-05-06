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

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Anuncio> Anuncio { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
          {
               builder.Entity<Cliente>()
                   .HasData(new List<Cliente>(){
                   new Cliente(1, "Darlan"),
                   new Cliente(2, "Vanessa"),
                   new Cliente(3, "Nicolas"),
                   new Cliente(4, "Gabriel"),
                   new Cliente(5, "Gengis"),
                });

                builder.Entity<Anuncio>()
                   .HasData(new List<Anuncio>(){
                   new Anuncio(1,"Anuncio1",1,DateTime.Now,DateTime.Now.AddDays(30),1.00),
                   new Anuncio(2,"Anuncio 2",1,DateTime.Now.AddDays(1),DateTime.Now.AddDays(30),2.00),                   
                   new Anuncio(3,"Anuncio 3",1,DateTime.Now.AddDays(2),DateTime.Now.AddDays(30),3.00),                   
                   new Anuncio(4,"Anuncio 2",1,DateTime.Now.AddDays(3),DateTime.Now.AddDays(30),1.00),                   
                });
          }
    }
}