﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _3312_CIDM_FINAL_PROJECT;

#nullable disable

namespace _3312_CIDM_FINAL_PROJECT.Migrations
{
    [DbContext(typeof(PlaybookDbContext))]
    partial class PlaybookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("_3312_CIDM_FINAL_PROJECT.Models.Play", b =>
                {
                    b.Property<int>("PlayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlayID");

                    b.ToTable("Plays");
                });
#pragma warning restore 612, 618
        }
    }
}
