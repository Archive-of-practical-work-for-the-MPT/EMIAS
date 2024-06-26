using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pr10.Models;

public partial class EmiasContext : DbContext
{
    public EmiasContext()
    {
    }

    public EmiasContext(DbContextOptions<EmiasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AnalysDocument> AnalysDocuments { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<AppointmentDocument> AppointmentDocuments { get; set; }

    public virtual DbSet<Direction> Directions { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<ResearchDocument> ResearchDocuments { get; set; }

    public virtual DbSet<Speciality> Specialities { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__Admin__4C3F97F4E4695280");

            entity.ToTable("Admin");

            entity.Property(e => e.EnterPassword).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<AnalysDocument>(entity =>
        {
            entity.HasKey(e => e.IdAppointment).HasName("PK__AnalysDo__ECE24AAB4457162B");

            entity.ToTable("AnalysDocument");

            entity.Property(e => e.IdAppointment).ValueGeneratedNever();

        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.IdAppointment).HasName("PK__Appointm__ECE24AAB8A9688D0");

            entity.Property(e => e.Oms).HasColumnName("OMS");

        });

        modelBuilder.Entity<AppointmentDocument>(entity =>
        {
            entity.HasKey(e => e.IdAppointment).HasName("PK__Appointm__ECE24AAB04C6C14A");

            entity.ToTable("AppointmentDocument");

            entity.Property(e => e.IdAppointment).ValueGeneratedNever();

           
        });

        modelBuilder.Entity<Direction>(entity =>
        {
            entity.HasKey(e => e.IdDirection).HasName("PK__Directio__7780E2B2D519F84D");

            entity.Property(e => e.Oms).HasColumnName("OMS");

            
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.IdDoctor).HasName("PK__Doctor__F838DB3EEF82E4F3");

            entity.ToTable("Doctor");

            entity.Property(e => e.EnterPassword).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
            entity.Property(e => e.WorkAddress).HasMaxLength(50);

        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Oms).HasName("PK__Patient__CB396B8B9A3F251C");

            entity.ToTable("Patient");

            entity.Property(e => e.Oms)
                .ValueGeneratedNever()
                .HasColumnName("OMS");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.LivingAddress).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Nickname).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(18);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<ResearchDocument>(entity =>
        {
            entity.HasKey(e => e.IdAppointment).HasName("PK__Research__ECE24AAB829820EC");

            entity.ToTable("ResearchDocument");

            entity.Property(e => e.IdAppointment).ValueGeneratedNever();
            entity.Property(e => e.Attachment)
                .HasMaxLength(1)
                .IsFixedLength();

           
        });

        modelBuilder.Entity<Speciality>(entity =>
        {
            entity.HasKey(e => e.IdSpeciality).HasName("PK__Speciali__5C8D4E68A7DA76FF");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__Status__B450643A5C85B794");

            entity.ToTable("Status");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
