﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HumansOfNewYork.Models;

namespace HumansOfNewYork.Migrations
{
    [DbContext(typeof(HumansContext))]
    partial class HumansContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HumansOfNewYork.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("HumansOfNewYork.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("Zip");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("HumansOfNewYork.Models.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Original");

                    b.Property<int>("PersonId");

                    b.HasKey("PictureId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("HumansOfNewYork.Models.Interest", b =>
                {
                    b.HasOne("HumansOfNewYork.Models.Person")
                        .WithMany("Interests")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HumansOfNewYork.Models.Picture", b =>
                {
                    b.HasOne("HumansOfNewYork.Models.Person")
                        .WithOne("Picture")
                        .HasForeignKey("HumansOfNewYork.Models.Picture", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}