﻿// <auto-generated />
using System;
using Assesment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assesment.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241115134858_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Assesment.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comments")
                        .HasColumnType("longtext")
                        .HasColumnName("comments");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int")
                        .HasColumnName("id_doctor");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int")
                        .HasColumnName("id_patient");

                    b.Property<int>("IdSpecialty")
                        .HasColumnType("int")
                        .HasColumnName("id_specialty");

                    b.Property<string>("ReasonConsultation")
                        .HasColumnType("longtext")
                        .HasColumnName("reason_for_consultation");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time(6)")
                        .HasColumnName("time");

                    b.HasKey("Id");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.HasIndex("IdSpecialty");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("Assesment.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_birth");

                    b.Property<int>("DocumentNumber")
                        .HasColumnType("int")
                        .HasColumnName("document_number");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<int>("IdRole")
                        .HasColumnType("int")
                        .HasColumnName("id_role");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.HasIndex("IdRole");

                    b.ToTable("persons");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Assesment.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Assesment.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("end_time");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("start_time");

                    b.HasKey("Id");

                    b.ToTable("shedules");
                });

            modelBuilder.Entity("Assesment.Models.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("Assesment.Models.Doctor", b =>
                {
                    b.HasBaseType("Assesment.Models.Person");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int")
                        .HasColumnName("id_person");

                    b.Property<int>("IdShedule")
                        .HasColumnType("int")
                        .HasColumnName("id_shedule");

                    b.HasIndex("IdPerson");

                    b.HasIndex("IdShedule");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("Assesment.Models.Patient", b =>
                {
                    b.HasBaseType("Assesment.Models.Person");

                    b.Property<string>("Allergies")
                        .HasColumnType("longtext")
                        .HasColumnName("allergies");

                    b.Property<double>("Height")
                        .HasColumnType("double")
                        .HasColumnName("height");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int")
                        .HasColumnName("id_person");

                    b.Property<double>("Weight")
                        .HasColumnType("double")
                        .HasColumnName("weight");

                    b.HasIndex("IdPerson");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("Assesment.Models.Appointment", b =>
                {
                    b.HasOne("Assesment.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assesment.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assesment.Models.Specialty", "Specialty")
                        .WithMany()
                        .HasForeignKey("IdSpecialty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("Assesment.Models.Person", b =>
                {
                    b.HasOne("Assesment.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Assesment.Models.Doctor", b =>
                {
                    b.HasOne("Assesment.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Assesment.Models.Doctor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assesment.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assesment.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("IdShedule")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Assesment.Models.Patient", b =>
                {
                    b.HasOne("Assesment.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Assesment.Models.Patient", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assesment.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
