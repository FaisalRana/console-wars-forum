﻿// <auto-generated />
using System;
using ConsoleWarsForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleWarsForum.Migrations
{
    [DbContext(typeof(ConsoleWarsForumContext))]
    partial class ConsoleWarsForumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ConsoleWarsForum.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAndTimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ThreadId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ConsoleWarsForum.Models.Thread", b =>
                {
                    b.Property<int>("ThreadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateAndTimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ThreadId");

                    b.ToTable("Threads");

                    b.HasData(
                        new
                        {
                            ThreadId = 1,
                            Body = "Everyone knows that Sega does with NintenDON'T",
                            DateAndTimeStamp = new DateTime(2021, 6, 28, 20, 14, 39, 557, DateTimeKind.Local).AddTicks(160),
                            Title = "Sega Genesis vs Super Nintendo Entertainment System"
                        },
                        new
                        {
                            ThreadId = 2,
                            Body = "PlayStation was the clear winner",
                            DateAndTimeStamp = new DateTime(2021, 6, 28, 20, 14, 39, 557, DateTimeKind.Local).AddTicks(2810),
                            Title = "Nintendo 64 vs Sony PlayStation vs Sega Saturn"
                        },
                        new
                        {
                            ThreadId = 3,
                            Body = "The Xbox was the best because it had Halo",
                            DateAndTimeStamp = new DateTime(2021, 6, 28, 20, 14, 39, 557, DateTimeKind.Local).AddTicks(2830),
                            Title = "PlayStation 2 vs Nintendo GameCube vs Microsoft Xbox vs Sega Dreamcast"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
