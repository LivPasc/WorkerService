﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkerService1.DbContextInit;

namespace WorkerService1.Migrations
{
    [DbContext(typeof(DataAccessContext))]
    [Migration("20201203203714_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WorkerService1.Models.ValuesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DoorOpen")
                        .HasColumnType("bit");

                    b.Property<float>("Dust")
                        .HasColumnType("real");

                    b.Property<float>("Humidity")
                        .HasColumnType("real");

                    b.Property<int>("MicrocontrollerID")
                        .HasColumnType("int");

                    b.Property<float>("Power")
                        .HasColumnType("real");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("ValuesModels");
                });
#pragma warning restore 612, 618
        }
    }
}
