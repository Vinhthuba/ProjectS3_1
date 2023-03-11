using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectS3.Models;

public partial class DbJobContext : DbContext
{
    public DbJobContext()
    {
    }

    public DbJobContext(DbContextOptions<DbJobContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cadidate> Cadidates { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Literacy> Literacies { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Manage> Manages { get; set; }

    public virtual DbSet<Page> Pages { get; set; }

    public virtual DbSet<Register> Registers { get; set; }

    public virtual DbSet<Static> Statics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-C38JTHI\\SQLEXPRESS;Integrated Security=True;Database=dbJob;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cadidate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cadidate__3213E83FB508AB79");

            entity.ToTable("cadidate");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.City)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Email)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("full_name");
            entity.Property(e => e.LiteracyId).HasColumnName("literacy_id");
            entity.Property(e => e.PageId).HasColumnName("page_id");
            entity.Property(e => e.Password)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Residence)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("residence");
            entity.Property(e => e.StaticId).HasColumnName("static_id");
            entity.Property(e => e.Vacancy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("vacancy");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__category__3213E83F168BC2C6");

            entity.ToTable("category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Following).HasColumnName("following");
            entity.Property(e => e.Levers).HasColumnName("levers");
            entity.Property(e => e.SchemaMarkup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("schema_markup");
            entity.Property(e => e.Title)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Literacy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__literacy__3213E83F334866F3");

            entity.ToTable("literacy");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Graduate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("graduate");
            entity.Property(e => e.Majors)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("majors");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__login__3213E83F2CF413F3");

            entity.ToTable("login");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Manage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Manage__3213E83FF9CD1285");

            entity.ToTable("Manage");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.FullName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("full_name");
            entity.Property(e => e.PageId).HasColumnName("page_id");
            entity.Property(e => e.StaticId).HasColumnName("static_id");
            entity.Property(e => e.WorkExperience)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("work_experience");
        });

        modelBuilder.Entity<Page>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__page__3213E83F1E979A6E");

            entity.ToTable("page");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Company)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.DateCreate).HasColumnName("date_create");
            entity.Property(e => e.DateSubmitted).HasColumnName("date_submitted");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.JobDescription)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("job_description");
            entity.Property(e => e.Modification)
                .HasColumnType("date")
                .HasColumnName("modification");
            entity.Property(e => e.Tag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tag");
            entity.Property(e => e.Title)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Vacancy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("vacancy");
            entity.Property(e => e.Wage).HasColumnName("wage");
        });

        modelBuilder.Entity<Register>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__register__3213E83F4490CFEF");

            entity.ToTable("register");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Email)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("full_name");
            entity.Property(e => e.Password)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<Static>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__static__3213E83F9B55EB03");

            entity.ToTable("static");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.InterviewTime)
                .HasColumnType("date")
                .HasColumnName("interview_time");
            entity.Property(e => e.Interviewer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("interviewer");
            entity.Property(e => e.StaticName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("static_name");
            entity.Property(e => e.StaticNotification)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("static_notification");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
