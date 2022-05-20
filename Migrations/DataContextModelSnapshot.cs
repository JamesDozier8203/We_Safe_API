﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeSafe.Data;

#nullable disable

namespace wesafe_backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            // modelBuilder.Entity("WeSafe.Models.Address", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<string>("City")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("Kebele")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<double>("Latitude")
            //             .HasColumnType("float");

            //         b.Property<double>("Longtiude")
            //             .HasColumnType("float");

            //         b.Property<string>("Subcity")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.HasKey("Id");

            //         b.ToTable("Addresses");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Attachment", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.HasKey("Id");

            //         b.ToTable("Attachments");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Case", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<int?>("AssignedPoliceId")
            //             .HasColumnType("int");

            //         b.Property<DateTime>("ClosedDate")
            //             .HasColumnType("datetime2");

            //         b.Property<string>("Description")
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<int?>("EvidenceId")
            //             .HasColumnType("int");

            //         b.Property<DateTime>("OpenedDate")
            //             .HasColumnType("datetime2");

            //         b.Property<int>("ReporterAdminId")
            //             .HasColumnType("int");

            //         b.Property<string>("Summary")
            //             .HasColumnType("nvarchar(max)");

            //         b.HasKey("Id");

            //         b.HasIndex("AssignedPoliceId");

            //         b.HasIndex("EvidenceId");

            //         b.HasIndex("ReporterAdminId");

            //         b.ToTable("Cases");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Evidence", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<int?>("AttachmentId")
            //             .HasColumnType("int");

            //         b.Property<string>("Description")
            //             .HasColumnType("nvarchar(max)");

            //         b.HasKey("Id");

            //         b.HasIndex("AttachmentId");

            //         b.ToTable("Evidences");
            //     });

            // modelBuilder.Entity("WeSafe.Models.FilePath", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<int?>("AttachmentId")
            //             .HasColumnType("int");

            //         b.Property<int?>("AttachmentId1")
            //             .HasColumnType("int");

            //         b.Property<int?>("AttachmentId2")
            //             .HasColumnType("int");

            //         b.Property<string>("Url")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.HasKey("Id");

            //         b.HasIndex("AttachmentId");

            //         b.HasIndex("AttachmentId1");

            //         b.HasIndex("AttachmentId2");

                    // b.ToTable("Paths");
                // });

            modelBuilder.Entity("WeSafe.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longtiude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            // modelBuilder.Entity("WeSafe.Models.Person", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<int>("AdedressId")
            //             .HasColumnType("int");

            //         b.Property<string>("FirstName")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("LastName")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("Password")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("Phone")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("Picture")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<int>("RoleId")
            //             .HasColumnType("int");

            //         b.Property<string>("Sex")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.HasKey("Id");

            //         b.HasIndex("AddressId");

            //         b.HasIndex("RoleId");

            //         b.ToTable("Persons");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Police", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<int>("Experiance")
            //             .HasColumnType("int");

            //         b.Property<int>("Level")
            //             .HasColumnType("int");

            //         b.Property<int>("PersonId")
            //             .HasColumnType("int");

            //         b.Property<int>("StationId")
            //             .HasColumnType("int");

            //         b.HasKey("Id");

            //         b.HasIndex("PersonId");

            //         b.HasIndex("StationId");

            //         b.ToTable("Polices");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Report", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<string>("Description")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<int>("EvidenceId")
            //             .HasColumnType("int");

            //         b.Property<DateTime>("ReportDate")
            //             .HasColumnType("datetime2");

            //         b.Property<string>("Summary")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<int>("UserId")
            //             .HasColumnType("int");

            //         b.HasKey("Id");

            //         b.HasIndex("EvidenceId");

            //         b.HasIndex("UserId");

            //         b.ToTable("Reports");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Role", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<string>("RoleName")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.HasKey("Id");

            //         b.ToTable("Roles");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Station", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<string>("City")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("Latitude")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("Longtiude")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("StationName")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<string>("Subcity")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.HasKey("Id");

            //         b.ToTable("Stations");
            //     });

            // modelBuilder.Entity("WeSafe.Models.User", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("int");

            //         SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

            //         b.Property<string>("IdentificationCard")
            //             .IsRequired()
            //             .HasColumnType("nvarchar(max)");

            //         b.Property<int>("PersonId")
            //             .HasColumnType("int");

            //         b.HasKey("Id");

            //         b.HasIndex("PersonId");

            //         b.ToTable("Users");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Case", b =>
            //     {
            //         b.HasOne("WeSafe.Models.Police", "AssignedPolice")
            //             .WithMany()
            //             .HasForeignKey("AssignedPoliceId");

            //         b.HasOne("WeSafe.Models.Evidence", "Evidence")
            //             .WithMany()
            //             .HasForeignKey("EvidenceId");

            //         b.HasOne("WeSafe.Models.Person", "ReporterAdmin")
            //             .WithMany()
            //             .HasForeignKey("ReporterAdminId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.Navigation("AssignedPolice");

            //         b.Navigation("Evidence");

            //         b.Navigation("ReporterAdmin");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Evidence", b =>
            //     {
            //         b.HasOne("WeSafe.Models.Attachment", "Attachment")
            //             .WithMany()
            //             .HasForeignKey("AttachmentId");

            //         b.Navigation("Attachment");
            //     });

           

            // modelBuilder.Entity("WeSafe.Models.Person", b =>
            //     {
            //         b.HasOne("WeSafe.Models.Address", "Address")
            //             .WithMany()
            //             .HasForeignKey("AddressId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.HasOne("WeSafe.Models.Role", "Role")
            //             .WithMany()
            //             .HasForeignKey("RoleId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.Navigation("Address");

            //         b.Navigation("Role");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Police", b =>
            //     {
            //         b.HasOne("WeSafe.Models.Person", "Person")
            //             .WithMany()
            //             .HasForeignKey("PersonId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.HasOne("WeSafe.Models.Station", "Station")
            //             .WithMany()
            //             .HasForeignKey("StationId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.Navigation("Person");

            //         b.Navigation("Station");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Report", b =>
            //     {
            //         b.HasOne("WeSafe.Models.Evidence", "Evidence")
            //             .WithMany()
            //             .HasForeignKey("EvidenceId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.HasOne("WeSafe.Models.User", "ReportedBy")
            //             .WithMany()
            //             .HasForeignKey("UserId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.Navigation("Evidence");

            //         b.Navigation("ReportedBy");
            //     });

            // modelBuilder.Entity("WeSafe.Models.User", b =>
            //     {
            //         b.HasOne("WeSafe.Models.Person", "Person")
            //             .WithMany()
            //             .HasForeignKey("PersonId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();

            //         b.Navigation("Person");
            //     });

            // modelBuilder.Entity("WeSafe.Models.Attachment", b =>
            //     {
            //         b.Navigation("Images");

            //         b.Navigation("Videos");

            //         b.Navigation("Voices");
            //     });
#pragma warning restore 612, 618
        }
    }
}
