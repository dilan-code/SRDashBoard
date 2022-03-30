using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SrDashboard_SR.Models
{
    public partial class AteamContext : DbContext
    {
        public AteamContext()
        {
        }

        public AteamContext(DbContextOptions<AteamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountTypes> AccountTypes { get; set; }
        public virtual DbSet<ComputerTypes> ComputerTypes { get; set; }
        public virtual DbSet<ConsultantAccounts> ConsultantAccounts { get; set; }
        public virtual DbSet<ConsultantComputers> ConsultantComputers { get; set; }
        public virtual DbSet<Consultants> Consultants { get; set; }
        public virtual DbSet<EnvironmentTypes> EnvironmentTypes { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Servers> Servers { get; set; }
        public virtual DbSet<SystemTypes> SystemTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Workload> Workload { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountTypes>(entity =>
            {
                entity.ToTable("account_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComputerTypes>(entity =>
            {
                entity.ToTable("computer_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsultantAccounts>(entity =>
            {
                entity.ToTable("consultant_accounts");

                entity.HasIndex(e => e.AccountTypeId)
                    .HasName("fk_consultant_accounts_account_types");

                entity.HasIndex(e => e.ConsultantId)
                    .HasName("fk_consultant_accounts_consultants");

                entity.HasIndex(e => e.EnvironmentTypeId)
                    .HasName("fk_consultant_accounts_environment_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountTypeId).HasColumnName("account_type_id");

                entity.Property(e => e.ConsultantId).HasColumnName("consultant_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.EnvironmentTypeId).HasColumnName("environment_type_id");

                entity.Property(e => e.ExpireAt)
                    .HasColumnName("expire_at")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordExpireAt)
                    .HasColumnName("password_expire_at")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.ConsultantAccounts)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_consultant_accounts_account_types");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.ConsultantAccounts)
                    .HasForeignKey(d => d.ConsultantId)
                    .HasConstraintName("fk_consultant_accounts_consultants");

                entity.HasOne(d => d.EnvironmentType)
                    .WithMany(p => p.ConsultantAccounts)
                    .HasForeignKey(d => d.EnvironmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_consultant_accounts_environment_types");
            });

            modelBuilder.Entity<ConsultantComputers>(entity =>
            {
                entity.ToTable("consultant_computers");

                entity.HasIndex(e => e.ComputerTypeId)
                    .HasName("computer_type_id");

                entity.HasIndex(e => e.ConsultantId)
                    .HasName("consultant_id");

                entity.HasIndex(e => e.EnvironmentTypeId)
                    .HasName("environment_type_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComputerTypeId).HasColumnName("computer_type_id");

                entity.Property(e => e.ConsultantId).HasColumnName("consultant_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.EnvironmentTypeId).HasColumnName("environment_type_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ComputerType)
                    .WithMany(p => p.ConsultantComputers)
                    .HasForeignKey(d => d.ComputerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("consultant_computers_ibfk_1");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.ConsultantComputers)
                    .HasForeignKey(d => d.ConsultantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("consultant_computers_ibfk_2");

                entity.HasOne(d => d.EnvironmentType)
                    .WithMany(p => p.ConsultantComputers)
                    .HasForeignKey(d => d.EnvironmentTypeId)
                    .HasConstraintName("consultant_computers_ibfk_3");
            });

            modelBuilder.Entity<Consultants>(entity =>
            {
                entity.ToTable("consultants");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("fk_consultants_consultant_offices");

                entity.HasIndex(e => e.SystemTypeId)
                    .HasName("fk_consultants_system_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NonDisclosureAgreement)
                    .HasColumnName("non_disclosure_agreement")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NonDisclosureAgreementDate)
                    .HasColumnName("non_disclosure_agreement_date")
                    .HasColumnType("date");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SystemTypeId).HasColumnName("system_type_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Consultants)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_consultants_consultant_offices");

                entity.HasOne(d => d.SystemType)
                    .WithMany(p => p.Consultants)
                    .HasForeignKey(d => d.SystemTypeId)
                    .HasConstraintName("fk_consultants_system_types");
            });

            modelBuilder.Entity<EnvironmentTypes>(entity =>
            {
                entity.ToTable("environment_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Offices>(entity =>
            {
                entity.ToTable("offices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Servers>(entity =>
            {
                entity.ToTable("servers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Ipadress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServerFqdn)
                    .HasColumnName("ServerFQDN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Servername)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemTypes>(entity =>
            {
                entity.ToTable("system_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email)
                    .HasName("users_email_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailVerifiedAt).HasColumnName("email_verified_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RememberToken)
                    .HasColumnName("remember_token")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Workload>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ipadress)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Servername)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
