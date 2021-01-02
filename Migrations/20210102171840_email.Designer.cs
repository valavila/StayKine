﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MillionMealsGoldLeaf.Data;

namespace MillionMealsGoldLeaf.Migrations
{
    [DbContext(typeof(EmailContext))]
    [Migration("20210102171840_email")]
    partial class email
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MillionMealsGoldLeaf.Models.Email", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isSubscribed")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Emails");
                });
#pragma warning restore 612, 618
        }
    }
}
