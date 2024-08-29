﻿// <auto-generated />
using MetroTickets.DataService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MetroTickets.DataService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240829152156_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MetroTickets.Entities.DbSet.Edge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FirstId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SecondId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FirstId");

                    b.HasIndex("SecondId");

                    b.ToTable("Edges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 1,
                            FirstId = 1,
                            SecondId = 2
                        },
                        new
                        {
                            Id = 2,
                            Cost = 1,
                            FirstId = 2,
                            SecondId = 3
                        },
                        new
                        {
                            Id = 3,
                            Cost = 1,
                            FirstId = 3,
                            SecondId = 4
                        },
                        new
                        {
                            Id = 4,
                            Cost = 1,
                            FirstId = 4,
                            SecondId = 5
                        },
                        new
                        {
                            Id = 5,
                            Cost = 1,
                            FirstId = 5,
                            SecondId = 6
                        },
                        new
                        {
                            Id = 6,
                            Cost = 1,
                            FirstId = 6,
                            SecondId = 7
                        },
                        new
                        {
                            Id = 7,
                            Cost = 1,
                            FirstId = 7,
                            SecondId = 8
                        },
                        new
                        {
                            Id = 8,
                            Cost = 1,
                            FirstId = 8,
                            SecondId = 9
                        },
                        new
                        {
                            Id = 9,
                            Cost = 1,
                            FirstId = 9,
                            SecondId = 10
                        },
                        new
                        {
                            Id = 10,
                            Cost = 1,
                            FirstId = 10,
                            SecondId = 11
                        },
                        new
                        {
                            Id = 11,
                            Cost = 1,
                            FirstId = 11,
                            SecondId = 12
                        },
                        new
                        {
                            Id = 12,
                            Cost = 1,
                            FirstId = 12,
                            SecondId = 13
                        },
                        new
                        {
                            Id = 13,
                            Cost = 1,
                            FirstId = 13,
                            SecondId = 14
                        },
                        new
                        {
                            Id = 14,
                            Cost = 1,
                            FirstId = 14,
                            SecondId = 15
                        },
                        new
                        {
                            Id = 15,
                            Cost = 1,
                            FirstId = 15,
                            SecondId = 16
                        },
                        new
                        {
                            Id = 16,
                            Cost = 1,
                            FirstId = 16,
                            SecondId = 17
                        },
                        new
                        {
                            Id = 17,
                            Cost = 1,
                            FirstId = 17,
                            SecondId = 18
                        },
                        new
                        {
                            Id = 18,
                            Cost = 1,
                            FirstId = 18,
                            SecondId = 19
                        },
                        new
                        {
                            Id = 19,
                            Cost = 1,
                            FirstId = 19,
                            SecondId = 20
                        },
                        new
                        {
                            Id = 20,
                            Cost = 1,
                            FirstId = 20,
                            SecondId = 21
                        },
                        new
                        {
                            Id = 21,
                            Cost = 1,
                            FirstId = 21,
                            SecondId = 22
                        },
                        new
                        {
                            Id = 22,
                            Cost = 1,
                            FirstId = 22,
                            SecondId = 23
                        },
                        new
                        {
                            Id = 23,
                            Cost = 1,
                            FirstId = 23,
                            SecondId = 24
                        },
                        new
                        {
                            Id = 24,
                            Cost = 1,
                            FirstId = 24,
                            SecondId = 25
                        },
                        new
                        {
                            Id = 25,
                            Cost = 1,
                            FirstId = 25,
                            SecondId = 26
                        },
                        new
                        {
                            Id = 26,
                            Cost = 1,
                            FirstId = 26,
                            SecondId = 27
                        },
                        new
                        {
                            Id = 27,
                            Cost = 1,
                            FirstId = 27,
                            SecondId = 28
                        },
                        new
                        {
                            Id = 28,
                            Cost = 1,
                            FirstId = 28,
                            SecondId = 29
                        },
                        new
                        {
                            Id = 29,
                            Cost = 1,
                            FirstId = 29,
                            SecondId = 30
                        },
                        new
                        {
                            Id = 30,
                            Cost = 1,
                            FirstId = 30,
                            SecondId = 31
                        },
                        new
                        {
                            Id = 31,
                            Cost = 1,
                            FirstId = 31,
                            SecondId = 32
                        },
                        new
                        {
                            Id = 32,
                            Cost = 1,
                            FirstId = 32,
                            SecondId = 33
                        },
                        new
                        {
                            Id = 33,
                            Cost = 1,
                            FirstId = 33,
                            SecondId = 34
                        },
                        new
                        {
                            Id = 34,
                            Cost = 1,
                            FirstId = 34,
                            SecondId = 35
                        });
                });

            modelBuilder.Entity("MetroTickets.Entities.DbSet.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Helwan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ain Helwan"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Helwan University"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Wadi Hof"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hadayek Helwan"
                        },
                        new
                        {
                            Id = 6,
                            Name = "El Maasara"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Tora El Asmant"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Kozzika"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tora El Balad"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sakanat El Maadi"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Maadi"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Hadayek El Maadi"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Dar El Salam"
                        },
                        new
                        {
                            Id = 14,
                            Name = "El Zahraa"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Mar Girgis"
                        },
                        new
                        {
                            Id = 16,
                            Name = "El Malek El Saleh"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Al Sayeda Zeinab"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Saad Zaghloul"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Sadat"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Nasser"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Orabi"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Al Shohadaa"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Ghamra"
                        },
                        new
                        {
                            Id = 24,
                            Name = "El Demerdash"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Manshiet El Sadr"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Kobri El Qobba"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Hammamat El Qobba"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Saray El Qobba"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Hadayeq El Zaitoun"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Helmeyet El Zaitoun"
                        },
                        new
                        {
                            Id = 31,
                            Name = "El Matareyya"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Ain Shams"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Ezbet El Nakhl"
                        },
                        new
                        {
                            Id = 34,
                            Name = "El Marg"
                        },
                        new
                        {
                            Id = 35,
                            Name = "New El Marg"
                        });
                });

            modelBuilder.Entity("MetroTickets.Entities.DbSet.Edge", b =>
                {
                    b.HasOne("MetroTickets.Entities.DbSet.Station", "FirstStation")
                        .WithMany()
                        .HasForeignKey("FirstId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MetroTickets.Entities.DbSet.Station", "SecondStation")
                        .WithMany()
                        .HasForeignKey("SecondId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirstStation");

                    b.Navigation("SecondStation");
                });
#pragma warning restore 612, 618
        }
    }
}
