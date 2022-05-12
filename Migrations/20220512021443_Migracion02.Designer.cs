﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrabajoFinalProem_GalanFlorencia.datos;

#nullable disable

namespace TrabajoFinalProem_GalanFlorencia.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220512021443_Migracion02")]
    partial class Migracion02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TrabajoFinalProem_GalanFlorencia.Models.Cliente", b =>
                {
                    b.Property<int>("codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("codigo"), 1L, 1);

                    b.Property<int>("FacturaId")
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("extraSaldo")
                        .HasColumnType("real");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codigo");

                    b.HasIndex("FacturaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("TrabajoFinalProem_GalanFlorencia.Models.Factura", b =>
                {
                    b.Property<int>("numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("numero"), 1L, 1);

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PagosId")
                        .HasColumnType("int");

                    b.HasKey("numero");

                    b.HasIndex("PagosId");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("TrabajoFinalProem_GalanFlorencia.Models.Pagos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<float?>("importe")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("TrabajoFinalProem_GalanFlorencia.Models.Cliente", b =>
                {
                    b.HasOne("TrabajoFinalProem_GalanFlorencia.Models.Factura", "FacturaIdNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacturaIdNavigation");
                });

            modelBuilder.Entity("TrabajoFinalProem_GalanFlorencia.Models.Factura", b =>
                {
                    b.HasOne("TrabajoFinalProem_GalanFlorencia.Models.Pagos", "PagosIdNavigation")
                        .WithMany("Facturas")
                        .HasForeignKey("PagosId");

                    b.Navigation("PagosIdNavigation");
                });

            modelBuilder.Entity("TrabajoFinalProem_GalanFlorencia.Models.Factura", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("TrabajoFinalProem_GalanFlorencia.Models.Pagos", b =>
                {
                    b.Navigation("Facturas");
                });
#pragma warning restore 612, 618
        }
    }
}
