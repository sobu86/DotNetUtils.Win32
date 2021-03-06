﻿// <auto-generated />
using System;
using DotNetUtils.Win32.UserActivity.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetUtils.Win32.Migrations
{
    [DbContext(typeof(UserActivityContext))]
    [Migration("20201211101944_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DotNetUtils.Win32.UserActivity.DB.Models.UserActivityMetaInfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LatestMonitoringEventTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserActivityMetaInfoSet");
                });

            modelBuilder.Entity("DotNetUtils.Win32.UserActivity.DB.Models.UserActivitySessionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SessionEndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SessionStartTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserActivityState")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("UserActivitySessionSet");
                });
#pragma warning restore 612, 618
        }
    }
}
