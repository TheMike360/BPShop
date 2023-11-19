﻿// <auto-generated />
using System;
using BPShop.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BPShop.Migrations
{
    [DbContext(typeof(MYContext))]
    partial class MYContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BPShop.Enities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Count")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeliverDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("HisName")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("OrderStatuses")
                        .HasColumnType("int");

                    b.Property<int>("PayType")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ProductIds")
                        .HasColumnType("text");

                    b.Property<string>("RecipientContact")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RecipientName")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BPShop.Enities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("CountFlowersInBouquet")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int>("FlowersType")
                        .HasColumnType("int");

                    b.Property<string>("ImgRef")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ProductType")
                        .HasColumnType("int");

                    b.Property<string>("SearhPrompt")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("ID");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
