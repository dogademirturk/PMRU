﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMRU.Domain.Entities;
using PMRU.Persistence.Context;

#nullable disable

namespace PMRU.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231227233906_InitMigration")]
    partial class InitMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PMRU.Domain.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AppointmentHour")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.HasIndex("DoctorID", "AppointmentDate", "AppointmentHour")
                        .IsUnique();

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("DoctorID", "Day", "StartTime", "EndTime")
                        .IsUnique();

                    b.ToTable("Availabilities");
                    b.HasData(
                       new
                       {
                           Id = 1,
                           CreatedDate = new DateTime(2024, 7, 20, 9, 0, 0),
                           Day = "Cuma",
                           DeletedDate = "",
                           DoctorID = 3,
                           EndTime = new DateTime(2024, 12, 28, 2, 39, 6, 136, DateTimeKind.Local).AddTicks(5085),
                           IsActive = true,
                           IsDeleted = false,
                           LastModifiedDate = new DateTime(2024, 12, 28, 2, 39, 6, 136, DateTimeKind.Local).AddTicks(5085),
                           StartTime = new DateTime(2024, 12, 28, 2, 39, 6, 136, DateTimeKind.Local).AddTicks(5085),
                       });
                       
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentDescription = "Güvenlik",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            DepartmentDescription = "Üretim",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            DepartmentDescription = "Finans",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            DepartmentDescription = "İnsan Kaynakları",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            DepartmentDescription = "Satış Pazarlama",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            DepartmentDescription = "IT",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 7,
                            DepartmentDescription = "Sağlık",
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("LocationID");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "aylin.gunes@email.com",
                            IdentityNumber = "12345678901",
                            IsActive = true,
                            IsDeleted = false,
                            LocationID = 35,
                            Name = "Aylin",
                            Password = "Password",
                            Phone = "5556123456",
                            RegistrationNumber = "102",
                            Surname = "Güneş"
                        },
                        new
                        {
                            Id = 2,
                            Email = "eren.akcay@email.com",
                            IdentityNumber = "12345678923",
                            IsActive = true,
                            IsDeleted = false,
                            LocationID = 41,
                            Name = "Eren",
                            Password = "Password",
                            Phone = "5556234567",
                            RegistrationNumber = "103",
                            Surname = "Akçay"
                        });
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("LocationID");

                    b.HasIndex("PositionID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentId = 0,
                            CreatedDate = new DateTime(2023, 12, 28, 2, 39, 6, 136, DateTimeKind.Local).AddTicks(5085),
                            DepartmentID = 4,
                            Email = "ahmet.yilmaz@email.com",
                            IdentityNumber = "5555123456",
                            IsActive = true,
                            IsDeleted = false,
                            LocationID = 34,
                            Name = "Ahmet",
                            Phone = "(555) 512-3456",
                            PositionID = 4,
                            RegistrationNumber = "100",
                            Surname = "Yılmaz"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentId = 0,
                            CreatedDate = new DateTime(2023, 12, 28, 2, 39, 6, 136, DateTimeKind.Local).AddTicks(5089),
                            DepartmentID = 4,
                            Email = "ayse.kaya@email.com",
                            IdentityNumber = "5555234567",
                            IsActive = true,
                            IsDeleted = false,
                            LocationID = 41,
                            Name = "Ayşe",
                            Phone = "(555) 523-4567",
                            PositionID = 3,
                            RegistrationNumber = "101",
                            Surname = "Kaya"
                        });
                });

            modelBuilder.Entity("PMRU.Domain.Entities.LocalAdmin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("LocalAdmins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "cem.yildirim@email.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Cem",
                            Password = "password123",
                            Phone = "5556456789",
                            Surname = "Yıldırım"
                        });
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLocationCenter")
                        .HasColumnType("bit");

                    b.Property<string>("LocationDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 34,
                            IsActive = true,
                            IsDeleted = false,
                            IsLocationCenter = true,
                            LocationDescription = "Genel Müdürlük"
                        },
                        new
                        {
                            Id = 35,
                            IsActive = true,
                            IsDeleted = false,
                            IsLocationCenter = false,
                            LocationDescription = "İzmir"
                        },
                        new
                        {
                            Id = 41,
                            IsActive = true,
                            IsDeleted = false,
                            IsLocationCenter = false,
                            LocationDescription = "İzmit"
                        },
                        new
                        {
                            Id = 72,
                            IsActive = true,
                            IsDeleted = false,
                            IsLocationCenter = false,
                            LocationDescription = "Batman"
                        },
                        new
                        {
                            Id = 71,
                            IsActive = true,
                            IsDeleted = false,
                            IsLocationCenter = false,
                            LocationDescription = "Kırıkkale"
                        });
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PositionDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Güvenlik Şefi"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Güvenlik Görevlisi"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Elektrik Mühendisi"
                        },
                        new
                        {
                            Id = 4,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Makine Mühendisi"
                        },
                        new
                        {
                            Id = 5,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Muhasebe Uzmanı"
                        },
                        new
                        {
                            Id = 6,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Personel Uzmanı"
                        },
                        new
                        {
                            Id = 7,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "İnsan Kaynakları Uzmanı"
                        },
                        new
                        {
                            Id = 8,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Yazılım Geliştirici"
                        },
                        new
                        {
                            Id = 9,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Test Uzmanı"
                        },
                        new
                        {
                            Id = 10,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Finans Uzmanı"
                        },
                        new
                        {
                            Id = 11,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Pazarlama Uzmanı"
                        },
                        new
                        {
                            Id = 12,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Doktor"
                        },
                        new
                        {
                            Id = 13,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Hemşire"
                        },
                        new
                        {
                            Id = 14,
                            IsActive = true,
                            IsDeleted = false,
                            PositionDescription = "Satış Temsilcisi"
                        });
                });

            modelBuilder.Entity("PMRU.Domain.Entities.SystemAdmin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("SystemAdmins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "elif.ersoy@email.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Elif",
                            Password = "adminpassword",
                            Phone = "5555890123",
                            Surname = "Ersoy"
                        });
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Appointment", b =>
                {
                    b.HasOne("PMRU.Domain.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PMRU.Domain.Entities.Employee", "Employee")
                        .WithOne("Appointment")
                        .HasForeignKey("PMRU.Domain.Entities.Appointment", "EmployeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Availability", b =>
                {
                    b.HasOne("PMRU.Domain.Entities.Doctor", "Doctor")
                        .WithMany("Availabilities")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Doctor", b =>
                {
                    b.HasOne("PMRU.Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Employee", b =>
                {
                    b.HasOne("PMRU.Domain.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PMRU.Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PMRU.Domain.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Location");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Availabilities");
                });

            modelBuilder.Entity("PMRU.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Appointment");
                });
#pragma warning restore 612, 618
        }
    }
}
