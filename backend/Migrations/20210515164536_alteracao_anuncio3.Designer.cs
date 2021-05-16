﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.data;

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210515164536_alteracao_anuncio3")]
    partial class alteracao_anuncio3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("backend.models.Anuncio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("InvestimentoDiario")
                        .HasColumnType("double");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("ValorTotalInvestido")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Anuncio");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            DataInicio = new DateTime(2021, 5, 15, 13, 45, 36, 339, DateTimeKind.Local).AddTicks(5169),
                            DataTermino = new DateTime(2021, 6, 14, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(4582),
                            InvestimentoDiario = 1.0,
                            Nome = "",
                            ValorTotalInvestido = 0.0
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 2,
                            DataInicio = new DateTime(2021, 5, 16, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7925),
                            DataTermino = new DateTime(2021, 6, 14, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7942),
                            InvestimentoDiario = 2.0,
                            Nome = "",
                            ValorTotalInvestido = 0.0
                        },
                        new
                        {
                            Id = 3,
                            ClienteId = 3,
                            DataInicio = new DateTime(2021, 5, 17, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7947),
                            DataTermino = new DateTime(2021, 6, 14, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7948),
                            InvestimentoDiario = 3.0,
                            Nome = "",
                            ValorTotalInvestido = 0.0
                        },
                        new
                        {
                            Id = 4,
                            ClienteId = 1,
                            DataInicio = new DateTime(2021, 5, 18, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7950),
                            DataTermino = new DateTime(2021, 6, 14, 13, 45, 36, 340, DateTimeKind.Local).AddTicks(7951),
                            InvestimentoDiario = 4.0,
                            Nome = "",
                            ValorTotalInvestido = 0.0
                        });
                });

            modelBuilder.Entity("backend.models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Darlan"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Vanessa"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Nicolas"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Gabriel"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Gengis"
                        });
                });

            modelBuilder.Entity("backend.models.Anuncio", b =>
                {
                    b.HasOne("backend.models.Cliente", "Cliente")
                        .WithMany("Anuncios")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("backend.models.Cliente", b =>
                {
                    b.Navigation("Anuncios");
                });
#pragma warning restore 612, 618
        }
    }
}
