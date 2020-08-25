﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sant01.Data;

namespace Sant01.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200825110126_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sant01.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<long>("PersonIdentificationCode")
                        .HasColumnType("bigint");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("Surename")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Tilto g. 2-2",
                            DOB = new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Jonas",
                            PersonIdentificationCode = 30101010001L,
                            Status = (byte)0,
                            Surename = "Jonaitis"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Milto g. 2-2",
                            DOB = new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Petras",
                            PersonIdentificationCode = 30202020002L,
                            Status = (byte)0,
                            Surename = "Petraitis"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Bilto g. 2-2",
                            DOB = new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Kazys",
                            PersonIdentificationCode = 30303030003L,
                            Status = (byte)0,
                            Surename = "Kazaitis"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Silto g. 2-2",
                            DOB = new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Tomas",
                            PersonIdentificationCode = 30404040004L,
                            Status = (byte)1,
                            Surename = "Tomaitis"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Rilto g. 2-2",
                            DOB = new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Arturas",
                            PersonIdentificationCode = 30505050005L,
                            Status = (byte)1,
                            Surename = "Arturaitis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
