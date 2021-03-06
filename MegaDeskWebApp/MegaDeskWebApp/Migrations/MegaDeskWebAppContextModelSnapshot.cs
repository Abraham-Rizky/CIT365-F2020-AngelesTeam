﻿// <auto-generated />
using System;
using MegaDeskWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskWebApp.Migrations
{
    [DbContext(typeof(MegaDeskWebAppContext))]
    partial class MegaDeskWebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDeskWebApp.Models.Quote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Area");

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<int>("Depth");

                    b.Property<string>("DeskMaterial")
                        .IsRequired();

                    b.Property<decimal>("DrawerCost");

                    b.Property<int>("DrawerCount");

                    b.Property<decimal>("MaterialCost");

                    b.Property<decimal>("OversizeCost");

                    b.Property<DateTime>("QuoteDate");

                    b.Property<decimal>("ShippingCost");

                    b.Property<string>("ShippingOption")
                        .IsRequired();

                    b.Property<decimal>("TotalCost");

                    b.Property<int>("Width");

                    b.HasKey("ID");

                    b.ToTable("Quote");
                });
#pragma warning restore 612, 618
        }
    }
}
