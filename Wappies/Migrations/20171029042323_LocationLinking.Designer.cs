﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Wappies.Context;

namespace Wappies.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20171029042323_LocationLinking")]
    partial class LocationLinking
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wappies.Models.Administrator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("Wappies.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ReportID1");

                    b.HasKey("ID");

                    b.HasIndex("ReportID1");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Wappies.Models.Report", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Completed");

                    b.Property<DateTime>("Created");

                    b.HasKey("ID");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Wappies.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PhoneNumber");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Wappies.Models.Location", b =>
                {
                    b.HasOne("Wappies.Models.Report")
                        .WithMany("Locations")
                        .HasForeignKey("ReportID1");
                });
#pragma warning restore 612, 618
        }
    }
}
