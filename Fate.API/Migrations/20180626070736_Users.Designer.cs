﻿// <auto-generated />
using Fate.EfContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace Fate.API.Migrations
{
    [DbContext(typeof(EntityDbContext))]
    [Migration("20180626070736_Users")]
    partial class Users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("Models.Users.UserInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnName("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .HasColumnName("UserName")
                        .HasMaxLength(20);

                    b.Property<string>("UserPassword")
                        .HasColumnName("UserPassword")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("UserInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
