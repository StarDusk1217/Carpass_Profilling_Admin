﻿// <auto-generated />
using System;
using Carpass_Profilling.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carpass_Profilling.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241209183337_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Carpass_Profilling.Models.Applicant", b =>
                {
                    b.Property<int>("kiosk_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("kiosk_Id"));

                    b.Property<byte[]>("Doc1")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc2")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc3")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc4")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc5")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc6")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc7")
                        .HasColumnType("longblob");

                    b.Property<string>("app_Contact")
                        .HasColumnType("longtext");

                    b.Property<string>("app_Relation")
                        .HasColumnType("longtext");

                    b.Property<string>("course_Grade")
                        .HasColumnType("longtext");

                    b.Property<DateOnly?>("facefile_Date")
                        .HasColumnType("date");

                    b.Property<string>("fullName")
                        .HasColumnType("longtext");

                    b.Property<string>("home_Ad")
                        .HasColumnType("longtext");

                    b.Property<string>("name_Student")
                        .HasColumnType("longtext");

                    b.Property<string>("schoolyear")
                        .HasColumnType("longtext");

                    b.Property<string>("type_Applicant")
                        .HasColumnType("longtext");

                    b.Property<string>("type_Carpass")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Color")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Owner")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_PlateNO")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Relation")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Series")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Type")
                        .HasColumnType("longtext");

                    b.HasKey("kiosk_Id");

                    b.ToTable("Applicants");

                    b.HasData(
                        new
                        {
                            kiosk_Id = 1,
                            app_Contact = "09456544096",
                            app_Relation = "Student",
                            course_Grade = "BSCS-3",
                            facefile_Date = new DateOnly(2024, 5, 28),
                            fullName = "Allen Miguel L. Vargas",
                            home_Ad = "Mandurriao",
                            schoolyear = "2023-2024",
                            type_Applicant = "CPU Student",
                            ve_Brand = "Toyota",
                            ve_Color = "Orange",
                            ve_Owner = "Allen Miguel L. Vargas",
                            ve_PlateNO = "FAJ9228",
                            ve_Relation = "Owner",
                            ve_Series = "Wigo",
                            ve_Type = "Hatchback"
                        });
                });

            modelBuilder.Entity("Carpass_Profilling.Models.Central_Data", b =>
                {
                    b.Property<int>("central_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("central_Id"));

                    b.Property<byte[]>("Doc1")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc2")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc3")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc4")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc5")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc6")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc7")
                        .HasColumnType("longblob");

                    b.Property<DateOnly?>("app_Date")
                        .HasColumnType("date");

                    b.Property<string>("app_contact")
                        .HasColumnType("longtext");

                    b.Property<string>("app_relation")
                        .HasColumnType("longtext");

                    b.Property<string>("carpass_no")
                        .HasColumnType("longtext");

                    b.Property<string>("course_grade")
                        .HasColumnType("longtext");

                    b.Property<DateOnly?>("expiration_Date")
                        .HasColumnType("date");

                    b.Property<string>("fullname")
                        .HasColumnType("longtext");

                    b.Property<string>("home_ad")
                        .HasColumnType("longtext");

                    b.Property<string>("issued_by")
                        .HasColumnType("longtext");

                    b.Property<string>("name_student")
                        .HasColumnType("longtext");

                    b.Property<int?>("pending_ID")
                        .HasColumnType("int");

                    b.Property<string>("ref_number")
                        .HasColumnType("longtext");

                    b.Property<string>("schoolyear")
                        .HasColumnType("longtext");

                    b.Property<DateOnly?>("sub_Date")
                        .HasColumnType("date");

                    b.Property<string>("type_applicant")
                        .HasColumnType("longtext");

                    b.Property<string>("type_carpass")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_brand")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_color")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_owner")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_plateno")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_relation")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_series")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_type")
                        .HasColumnType("longtext");

                    b.HasKey("central_Id");

                    b.HasIndex("pending_ID");

                    b.ToTable("Central_Datas");

                    b.HasData(
                        new
                        {
                            central_Id = 1,
                            app_Date = new DateOnly(2023, 1, 1),
                            app_contact = "123-456-7890",
                            app_relation = "Self",
                            course_grade = "BSCS-3",
                            expiration_Date = new DateOnly(2024, 1, 1),
                            fullname = "John Doe",
                            home_ad = "123 Main St",
                            pending_ID = 1,
                            schoolyear = "2023-2024",
                            sub_Date = new DateOnly(2023, 1, 1),
                            type_applicant = "CPU Student",
                            ve_brand = "Toyota",
                            ve_color = "Blue",
                            ve_owner = "John Doe",
                            ve_plateno = "ABC123",
                            ve_relation = "Owner",
                            ve_series = "Corolla",
                            ve_type = "Sedan"
                        });
                });

            modelBuilder.Entity("Carpass_Profilling.Models.Pending", b =>
                {
                    b.Property<int>("pending_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("pending_ID"));

                    b.Property<byte[]>("Doc1")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc2")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc3")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc4")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc5")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc6")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("Doc7")
                        .HasColumnType("longblob");

                    b.Property<bool>("IsDoc1Submitted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDoc2Submitted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDoc3Submitted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDoc4Submitted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDoc5Submitted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDoc6Submitted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDoc7Submitted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("app_Contact")
                        .HasColumnType("longtext");

                    b.Property<string>("app_Relation")
                        .HasColumnType("longtext");

                    b.Property<string>("course_Grade")
                        .HasColumnType("longtext");

                    b.Property<DateOnly?>("facefile_Date")
                        .HasColumnType("date");

                    b.Property<string>("fullName")
                        .HasColumnType("longtext");

                    b.Property<string>("home_Ad")
                        .HasColumnType("longtext");

                    b.Property<int?>("kiosk_Id")
                        .HasColumnType("int");

                    b.Property<string>("name_Student")
                        .HasColumnType("longtext");

                    b.Property<string>("schoolyear")
                        .HasColumnType("longtext");

                    b.Property<string>("type_Applicant")
                        .HasColumnType("longtext");

                    b.Property<string>("type_Carpass")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Color")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Owner")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_PlateNO")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Relation")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Series")
                        .HasColumnType("longtext");

                    b.Property<string>("ve_Type")
                        .HasColumnType("longtext");

                    b.HasKey("pending_ID");

                    b.HasIndex("kiosk_Id");

                    b.ToTable("Pendings");

                    b.HasData(
                        new
                        {
                            pending_ID = 1,
                            IsDoc1Submitted = false,
                            IsDoc2Submitted = false,
                            IsDoc3Submitted = false,
                            IsDoc4Submitted = false,
                            IsDoc5Submitted = false,
                            IsDoc6Submitted = false,
                            IsDoc7Submitted = false,
                            app_Contact = "09454564096",
                            app_Relation = "Student",
                            course_Grade = "BSCS-3",
                            facefile_Date = new DateOnly(2024, 5, 28),
                            fullName = "Allen Miguel L. Vargas",
                            home_Ad = "Mandurriao",
                            schoolyear = "2023-2024",
                            type_Applicant = "CPU Student",
                            ve_Brand = "Toyota",
                            ve_Color = "Orange",
                            ve_Owner = "Allen Miguel L. Vargas",
                            ve_PlateNO = "FAJ9117",
                            ve_Relation = "Owner",
                            ve_Series = "Wigo",
                            ve_Type = "Hatchback"
                        });
                });

            modelBuilder.Entity("Carpass_Profilling.Models.Schoolyear", b =>
                {
                    b.Property<int>("Sy_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Sy_ID"));

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Sy_ID");

                    b.ToTable("Syear");
                });

            modelBuilder.Entity("Carpass_Profilling.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("longblob");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Email");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Email = "admin@cpu.edu.ph",
                            Birthday = "1980-01-01",
                            Gender = "Male",
                            Name = "CPU Admin",
                            Password = "admin123",
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("Carpass_Profilling.Models.Central_Data", b =>
                {
                    b.HasOne("Carpass_Profilling.Models.Pending", "Pending")
                        .WithMany()
                        .HasForeignKey("pending_ID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Pending");
                });

            modelBuilder.Entity("Carpass_Profilling.Models.Pending", b =>
                {
                    b.HasOne("Carpass_Profilling.Models.Applicant", "Applicant")
                        .WithMany("Pendings")
                        .HasForeignKey("kiosk_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Applicant");
                });

            modelBuilder.Entity("Carpass_Profilling.Models.Applicant", b =>
                {
                    b.Navigation("Pendings");
                });
#pragma warning restore 612, 618
        }
    }
}
