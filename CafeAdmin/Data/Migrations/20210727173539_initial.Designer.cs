﻿// <auto-generated />
using CafeAdmin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CafeAdmin.Data.Migrations
{
    [DbContext(typeof(CafeAdminDbContext))]
    [Migration("20210727173539_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Cafe.Models.ClientTable", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("DS");

                    b.Property<decimal>("Summ")
                        .HasPrecision(10, 4)
                        .HasColumnType("TEXT")
                        .HasComment("Це тестова сумма");

                    b.Property<string>("TestLenght")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Name", "Id");

                    b.ToTable("ClientTables");
                });

            modelBuilder.Entity("Cafe.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ivan Gardin",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Petro Stepanov",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mirko Shuher",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Peter Hugert",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ruzhena Stefanic",
                            Password = "12345"
                        });
                });

            modelBuilder.Entity("Cafe.Models.UserAccesLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserAccesLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessLevel = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccessLevel = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            AccessLevel = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            AccessLevel = 2,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            AccessLevel = 3,
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            AccessLevel = 3,
                            UserId = 6
                        },
                        new
                        {
                            Id = 7,
                            AccessLevel = 2,
                            UserId = 6
                        });
                });

            modelBuilder.Entity("Cafe.Models.UserAccesLevel", b =>
                {
                    b.HasOne("Cafe.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}