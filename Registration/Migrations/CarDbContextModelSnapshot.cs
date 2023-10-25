﻿// <auto-generated />
using Carcollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carcollection.Migrations
{
    [DbContext(typeof(CarDbContext))]
    partial class CarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("carcollection.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("RegNo")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("TotalRunning")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
