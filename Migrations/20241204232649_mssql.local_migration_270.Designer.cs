﻿// <auto-generated />
using System;
using DogAdoptionProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DogAdoptionProject.Migrations
{
    [DbContext(typeof(DogAdoptionProjectContext))]
    [Migration("20241204232649_mssql.local_migration_270")]
    partial class mssqllocal_migration_270
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DogAdoptionProject.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Dependents")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("House")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("dogId")
                        .HasColumnType("int");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId")
                        .IsUnique()
                        .HasFilter("[userId] IS NOT NULL");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("DogAdoptionProject.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Dog");
                });

            modelBuilder.Entity("DogAdoptionProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("applicationNumber")
                        .HasColumnType("int");

                    b.Property<int?>("currentDogIdId")
                        .HasColumnType("int");

                    b.Property<int?>("dogNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("currentDogIdId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DogAdoptionProject.Models.Application", b =>
                {
                    b.HasOne("DogAdoptionProject.Models.User", null)
                        .WithOne("currentAppId")
                        .HasForeignKey("DogAdoptionProject.Models.Application", "userId");
                });

            modelBuilder.Entity("DogAdoptionProject.Models.User", b =>
                {
                    b.HasOne("DogAdoptionProject.Models.Dog", "currentDogId")
                        .WithMany()
                        .HasForeignKey("currentDogIdId");

                    b.Navigation("currentDogId");
                });

            modelBuilder.Entity("DogAdoptionProject.Models.User", b =>
                {
                    b.Navigation("currentAppId");
                });
#pragma warning restore 612, 618
        }
    }
}