﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SrDashboard_SR.Models;

namespace SrDashboard_SR.Migrations
{
    [DbContext(typeof(AteamContext))]
    partial class AteamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SrDashboard_SR.Models.AccountTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("account_types");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.ComputerTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("computer_types");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.ConsultantAccounts", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AccountTypeId")
                        .HasColumnName("account_type_id")
                        .HasColumnType("bigint");

                    b.Property<long?>("ConsultantId")
                        .HasColumnName("consultant_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnName("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<long>("EnvironmentTypeId")
                        .HasColumnName("environment_type_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ExpireAt")
                        .HasColumnName("expire_at")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime?>("PasswordExpireAt")
                        .HasColumnName("password_expire_at")
                        .HasColumnType("date");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId")
                        .HasName("fk_consultant_accounts_account_types");

                    b.HasIndex("ConsultantId")
                        .HasName("fk_consultant_accounts_consultants");

                    b.HasIndex("EnvironmentTypeId")
                        .HasName("fk_consultant_accounts_environment_types");

                    b.ToTable("consultant_accounts");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.ConsultantComputers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ComputerTypeId")
                        .HasColumnName("computer_type_id")
                        .HasColumnType("bigint");

                    b.Property<long>("ConsultantId")
                        .HasColumnName("consultant_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnName("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<long?>("EnvironmentTypeId")
                        .HasColumnName("environment_type_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ComputerTypeId")
                        .HasName("computer_type_id");

                    b.HasIndex("ConsultantId")
                        .HasName("consultant_id");

                    b.HasIndex("EnvironmentTypeId")
                        .HasName("environment_type_id");

                    b.ToTable("consultant_computers");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.Consultants", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnName("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<short?>("NonDisclosureAgreement")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("non_disclosure_agreement")
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("NonDisclosureAgreementDate")
                        .HasColumnName("non_disclosure_agreement_date")
                        .HasColumnType("date");

                    b.Property<long>("OfficeId")
                        .HasColumnName("office_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<long?>("SystemTypeId")
                        .HasColumnName("system_type_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .HasName("fk_consultants_consultant_offices");

                    b.HasIndex("SystemTypeId")
                        .HasName("fk_consultants_system_types");

                    b.ToTable("consultants");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.EnvironmentTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("environment_types");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.Offices", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("offices");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.Servers", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("DateTime")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Ipadress")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("ServerFqdn")
                        .HasColumnName("ServerFQDN")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Servername")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("ServiceStatus")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("servers");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.SystemTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnName("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("system_types");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime?>("EmailVerifiedAt")
                        .HasColumnName("email_verified_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("RememberToken")
                        .HasColumnName("remember_token")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("users_email_unique");

                    b.ToTable("users");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.Workload", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Ipadress")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Servername")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Workload");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.ConsultantAccounts", b =>
                {
                    b.HasOne("SrDashboard_SR.Models.AccountTypes", "AccountType")
                        .WithMany("ConsultantAccounts")
                        .HasForeignKey("AccountTypeId")
                        .HasConstraintName("fk_consultant_accounts_account_types")
                        .IsRequired();

                    b.HasOne("SrDashboard_SR.Models.Consultants", "Consultant")
                        .WithMany("ConsultantAccounts")
                        .HasForeignKey("ConsultantId")
                        .HasConstraintName("fk_consultant_accounts_consultants");

                    b.HasOne("SrDashboard_SR.Models.EnvironmentTypes", "EnvironmentType")
                        .WithMany("ConsultantAccounts")
                        .HasForeignKey("EnvironmentTypeId")
                        .HasConstraintName("fk_consultant_accounts_environment_types")
                        .IsRequired();
                });

            modelBuilder.Entity("SrDashboard_SR.Models.ConsultantComputers", b =>
                {
                    b.HasOne("SrDashboard_SR.Models.ComputerTypes", "ComputerType")
                        .WithMany("ConsultantComputers")
                        .HasForeignKey("ComputerTypeId")
                        .HasConstraintName("consultant_computers_ibfk_1")
                        .IsRequired();

                    b.HasOne("SrDashboard_SR.Models.Consultants", "Consultant")
                        .WithMany("ConsultantComputers")
                        .HasForeignKey("ConsultantId")
                        .HasConstraintName("consultant_computers_ibfk_2")
                        .IsRequired();

                    b.HasOne("SrDashboard_SR.Models.EnvironmentTypes", "EnvironmentType")
                        .WithMany("ConsultantComputers")
                        .HasForeignKey("EnvironmentTypeId")
                        .HasConstraintName("consultant_computers_ibfk_3");
                });

            modelBuilder.Entity("SrDashboard_SR.Models.Consultants", b =>
                {
                    b.HasOne("SrDashboard_SR.Models.Offices", "Office")
                        .WithMany("Consultants")
                        .HasForeignKey("OfficeId")
                        .HasConstraintName("fk_consultants_consultant_offices")
                        .IsRequired();

                    b.HasOne("SrDashboard_SR.Models.SystemTypes", "SystemType")
                        .WithMany("Consultants")
                        .HasForeignKey("SystemTypeId")
                        .HasConstraintName("fk_consultants_system_types");
                });
#pragma warning restore 612, 618
        }
    }
}
