﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Robocam_FullSolution.Database;

namespace Robocam_FullSolution.Migrations
{
    [DbContext(typeof(RobocamDbContext))]
    partial class RobocamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Robocam_FullSolution.Database.Command", b =>
                {
                    b.Property<long>("CommandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommandId");

                    b.ToTable("Commands");
                });

            modelBuilder.Entity("Robocam_FullSolution.Database.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "emir.hasagic@gmail.com",
                            PasswordHash = "/E4FQ09EcgXx8LWTjfKuJNtw6n0=",
                            PasswordSalt = "YbejCDm54OvG/p3yHVO+uQ==",
                            Username = "Streamer"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "emir.hasagic@gmail.com",
                            PasswordHash = "/E4FQ09EcgXx8LWTjfKuJNtw6n0=",
                            PasswordSalt = "YbejCDm54OvG/p3yHVO+uQ==",
                            Username = "Commander"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
