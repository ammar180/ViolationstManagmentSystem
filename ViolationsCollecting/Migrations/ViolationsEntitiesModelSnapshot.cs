﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ViolationsCollecting.Model;

#nullable disable

namespace ViolationsCollecting.Migrations
{
    [DbContext(typeof(ViolationsEntities))]
    partial class ViolationsEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ViolationsCollecting.Model.Entities.Truck", b =>
                {
                    b.Property<string>("TruckCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("IsExplored")
                        .HasColumnType("bit");

                    b.HasKey("TruckCode");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("ViolationsCollecting.Model.Entities.Violation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ElManfaz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TruckCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ViolationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TruckCode");

                    b.ToTable("Violations");
                });

            modelBuilder.Entity("ViolationsCollecting.Model.Entities.Violation", b =>
                {
                    b.HasOne("ViolationsCollecting.Model.Entities.Truck", "Truck")
                        .WithMany("Violations")
                        .HasForeignKey("TruckCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Truck");
                });

            modelBuilder.Entity("ViolationsCollecting.Model.Entities.Truck", b =>
                {
                    b.Navigation("Violations");
                });
#pragma warning restore 612, 618
        }
    }
}
