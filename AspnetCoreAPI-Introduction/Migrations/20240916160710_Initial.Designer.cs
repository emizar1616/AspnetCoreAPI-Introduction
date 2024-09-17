﻿// <auto-generated />
using AspnetCoreAPI_Introduction.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspnetCoreAPI_Introduction.Migrations
{
    [DbContext(typeof(CityDbContext))]
    [Migration("20240916160710_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspnetCoreAPI_Introduction.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = 34,
                            Name = "Istanbul",
                            Region = "Marmara"
                        },
                        new
                        {
                            Id = 2,
                            Code = 35,
                            Name = "Izmir",
                            Region = "Ege"
                        },
                        new
                        {
                            Id = 3,
                            Code = 6,
                            Name = "Ankara",
                            Region = "İç Anadolu"
                        },
                        new
                        {
                            Id = 4,
                            Code = 7,
                            Name = "Antalya",
                            Region = "Akdeniz"
                        },
                        new
                        {
                            Id = 5,
                            Code = 1,
                            Name = "Adana",
                            Region = "Akdeniz"
                        },
                        new
                        {
                            Id = 6,
                            Code = 22,
                            Name = "Edirne",
                            Region = "Marmara"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
