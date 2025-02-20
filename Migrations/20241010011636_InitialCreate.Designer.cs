﻿// <auto-generated />
using System;
using Microondas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace microondasAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241010011636_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Microondas.Data.Programado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alimento")
                        .HasColumnType("longtext");

                    b.Property<string>("Instrucao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int?>("Potencia")
                        .HasColumnType("int");

                    b.Property<string>("Tempo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Programados");
                });
#pragma warning restore 612, 618
        }
    }
}
