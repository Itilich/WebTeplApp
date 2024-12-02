﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTeplApp.Data;

#nullable disable

namespace WebTeplApp.Migrations
{
    [DbContext(typeof(TeplAppContext))]
    partial class TeplAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("WebTeplApp.Data.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Num1")
                        .HasColumnType("REAL");

                    b.Property<double>("Num2")
                        .HasColumnType("REAL");

                    b.Property<double>("Num3")
                        .HasColumnType("REAL");

                    b.Property<double>("Num4")
                        .HasColumnType("REAL");

                    b.Property<double>("Num5")
                        .HasColumnType("REAL");

                    b.Property<double>("Num6")
                        .HasColumnType("REAL");

                    b.Property<double>("Num7")
                        .HasColumnType("REAL");

                    b.Property<double>("Num8")
                        .HasColumnType("REAL");

                    b.Property<double>("Num9")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}