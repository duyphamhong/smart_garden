﻿// <auto-generated />
using System;
using Embedded.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Embedded.Api.Migrations
{
    [DbContext(typeof(EmbeddedContext))]
    partial class EmbeddedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Embedded.Api.Model.AirHumidity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime");

                    b.Property<int>("CustomerId");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.ToTable("AirHumidities");
                });

            modelBuilder.Entity("Embedded.Api.Model.AirTemperature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime");

                    b.Property<int>("CustomerId");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.ToTable("AirTemperatures");
                });

            modelBuilder.Entity("Embedded.Api.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Embedded.Api.Model.GroundHumidity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime");

                    b.Property<int>("CustomerId");

                    b.Property<int>("OrderOfBox");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.ToTable("GroundHumidities");
                });
#pragma warning restore 612, 618
        }
    }
}