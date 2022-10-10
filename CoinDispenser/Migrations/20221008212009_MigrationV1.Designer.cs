﻿// <auto-generated />
using CoinDispenser.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoinDispenser.Migrations
{
    [DbContext(typeof(CoinDenominationContext))]
    [Migration("20221008212009_MigrationV1")]
    partial class MigrationV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoinDispenser.Models.CoinDenomination", b =>
                {
                    b.Property<int>("CoinDenominationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("V1")
                        .HasColumnType("int");

                    b.Property<int>("V2")
                        .HasColumnType("int");

                    b.Property<int>("V3")
                        .HasColumnType("int");

                    b.Property<int>("V4")
                        .HasColumnType("int");

                    b.Property<int>("V5")
                        .HasColumnType("int");

                    b.Property<int>("V6")
                        .HasColumnType("int");

                    b.Property<int>("V7")
                        .HasColumnType("int");

                    b.Property<int>("V8")
                        .HasColumnType("int");

                    b.Property<int>("V9")
                        .HasColumnType("int");

                    b.HasKey("CoinDenominationId");

                    b.ToTable("CoinDispense");
                });
#pragma warning restore 612, 618
        }
    }
}