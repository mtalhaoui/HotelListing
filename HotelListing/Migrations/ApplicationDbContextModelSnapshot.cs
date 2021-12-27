﻿// <auto-generated />
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelListing.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelListing.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Belgium",
                            ShortName = "BE"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Morocco",
                            ShortName = "MA"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United Arab Emirates",
                            ShortName = "UAE"
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Antwerp",
                            CountryId = 1,
                            Name = "Hotel Ibis Antwerpen Centrum",
                            Rating = 3.7000000000000002
                        },
                        new
                        {
                            Id = 2,
                            Address = "Antwerp",
                            CountryId = 1,
                            Name = "Hilton Antwerp Old Town",
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 3,
                            Address = "Rabat",
                            CountryId = 2,
                            Name = "Hotel Le Diwan",
                            Rating = 4.7000000000000002
                        },
                        new
                        {
                            Id = 4,
                            Address = "Casablanca",
                            CountryId = 2,
                            Name = "Four Seasons Hotel",
                            Rating = 4.5999999999999996
                        },
                        new
                        {
                            Id = 5,
                            Address = "Abu Dhabi",
                            CountryId = 3,
                            Name = "InterContinantal",
                            Rating = 4.5999999999999996
                        },
                        new
                        {
                            Id = 6,
                            Address = "Harbour",
                            CountryId = 3,
                            Name = "Four Seasons Hotel",
                            Rating = 4.7000000000000002
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.Data.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}