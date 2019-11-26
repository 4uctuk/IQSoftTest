﻿// <auto-generated />
using System;
using IQSoftTestApi.Features.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IQSoftTestApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191125151100_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IQSoftTestApi.Features.DataContext.Model.FirstTestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Col10Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col11Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col12Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col13Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col14Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col15Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col16Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col17Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col18Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col19Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col20Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col2Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col3Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col4Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col5Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col6Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col7Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col8Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col9Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FirstTestEntities");
                });

            modelBuilder.Entity("IQSoftTestApi.Features.DataContext.Model.SecondTestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Col10Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col11Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col12Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col13Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col14Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col15Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col16Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col17Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col18Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col19Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col20Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col2Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col3Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col4Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col5Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col6Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col7Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col8Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col9Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SecondTestEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
