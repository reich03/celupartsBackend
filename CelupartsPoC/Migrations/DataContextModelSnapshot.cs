﻿// <auto-generated />
using System;
using CelupartsPoC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CelupartsPoC.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CelupartsPoC.Courier", b =>
                {
                    b.Property<int>("IdCourier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCourier"), 1L, 1);

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surnames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCourier");

                    b.ToTable("Courier");
                });

            modelBuilder.Entity("CelupartsPoC.Equipment", b =>
                {
                    b.Property<int>("IdEquipment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipment"), 1L, 1);

                    b.Property<string>("EquipmentBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipmentInvoice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imei")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelOrReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RequestIdRequest")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfEquipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEquipment");

                    b.HasIndex("RequestIdRequest");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("CelupartsPoC.HomeService", b =>
                {
                    b.Property<int>("IdHomeService")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHomeService"), 1L, 1);

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCourier")
                        .HasColumnType("int");

                    b.Property<int?>("IdRequest")
                        .HasColumnType("int");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdHomeService");

                    b.HasIndex("IdCourier");

                    b.HasIndex("IdRequest");

                    b.ToTable("HomeService");
                });

            modelBuilder.Entity("CelupartsPoC.Repair", b =>
                {
                    b.Property<int>("IdRepair")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRepair"), 1L, 1);

                    b.Property<string>("DeviceDiagnostic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRequest")
                        .HasColumnType("int");

                    b.Property<int>("IdTechnician")
                        .HasColumnType("int");

                    b.Property<DateTime>("RepairDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RepairQuote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRepair");

                    b.HasIndex("IdRequest");

                    b.HasIndex("IdTechnician");

                    b.ToTable("Repair");
                });

            modelBuilder.Entity("CelupartsPoC.RepairPayment", b =>
                {
                    b.Property<int>("IdRepairPayment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRepairPayment"), 1L, 1);

                    b.Property<string>("BillPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRepair")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRepairPayment");

                    b.HasIndex("IdRepair");

                    b.ToTable("RepairPayment");
                });

            modelBuilder.Entity("CelupartsPoC.Request", b =>
                {
                    b.Property<int>("IdRequest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRequest"), 1L, 1);

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdEquipment")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("PickUpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusQuote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRequest");

                    b.HasIndex("IdEquipment");

                    b.HasIndex("IdUser");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("CelupartsPoC.RequestStatus", b =>
                {
                    b.Property<int>("IdRequestStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRequestStatus"), 1L, 1);

                    b.Property<int>("IdRequest")
                        .HasColumnType("int");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProductReturned")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRequestStatus");

                    b.HasIndex("IdRequest");

                    b.ToTable("RequestStatus");
                });

            modelBuilder.Entity("CelupartsPoC.Technician", b =>
                {
                    b.Property<int>("IdTechnician")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTechnician"), 1L, 1);

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surnames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTechnician");

                    b.ToTable("Technician");
                });

            modelBuilder.Entity("CelupartsPoC.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CelupartsPoC.UserDto", b =>
                {
                    b.Property<int?>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdUser"), 1L, 1);

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternativePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surnames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("UsersDto");
                });

            modelBuilder.Entity("CelupartsPoC.Equipment", b =>
                {
                    b.HasOne("CelupartsPoC.Request", null)
                        .WithMany("Equipments")
                        .HasForeignKey("RequestIdRequest");
                });

            modelBuilder.Entity("CelupartsPoC.HomeService", b =>
                {
                    b.HasOne("CelupartsPoC.Courier", "Courier")
                        .WithMany()
                        .HasForeignKey("IdCourier");

                    b.HasOne("CelupartsPoC.Request", "Request")
                        .WithMany()
                        .HasForeignKey("IdRequest");

                    b.Navigation("Courier");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("CelupartsPoC.Repair", b =>
                {
                    b.HasOne("CelupartsPoC.Request", "Request")
                        .WithMany("Repairs")
                        .HasForeignKey("IdRequest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CelupartsPoC.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("IdTechnician")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");

                    b.Navigation("Technician");
                });

            modelBuilder.Entity("CelupartsPoC.RepairPayment", b =>
                {
                    b.HasOne("CelupartsPoC.Repair", "Repair")
                        .WithMany()
                        .HasForeignKey("IdRepair")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Repair");
                });

            modelBuilder.Entity("CelupartsPoC.Request", b =>
                {
                    b.HasOne("CelupartsPoC.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("IdEquipment");

                    b.HasOne("CelupartsPoC.UserDto", "UserDto")
                        .WithMany("Requests")
                        .HasForeignKey("IdUser");

                    b.Navigation("Equipment");

                    b.Navigation("UserDto");
                });

            modelBuilder.Entity("CelupartsPoC.RequestStatus", b =>
                {
                    b.HasOne("CelupartsPoC.Request", "Request")
                        .WithMany("RequestStatus")
                        .HasForeignKey("IdRequest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");
                });

            modelBuilder.Entity("CelupartsPoC.Request", b =>
                {
                    b.Navigation("Equipments");

                    b.Navigation("Repairs");

                    b.Navigation("RequestStatus");
                });

            modelBuilder.Entity("CelupartsPoC.UserDto", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
