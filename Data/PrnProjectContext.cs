﻿using System;
using System.Collections.Generic;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data;

public partial class PrnProjectContext : DbContext
{
    public PrnProjectContext()
    {
    }

    public PrnProjectContext(DbContextOptions<PrnProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Clinic> Clinics { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Dentist> Dentists { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<TimeSlot> TimeSlots { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    private string GetConnectionString()
    {

        var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"../../../../View"));
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", true, true)
            .Build();

        var strCon = config["ConnectionStrings:DefaultConnectionStringDB"];

        return strCon;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Admin__1788CC4C48100467");

            entity.ToTable("Admin");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithOne(p => p.Admin)
                .HasForeignKey<Admin>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admin__UserId__5165187F");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Appointm__3214EC07F123F71B");

            entity.ToTable("Appointment");

            entity.Property(e => e.Available)
                .HasDefaultValue(1)
                .HasColumnName("available");
            entity.Property(e => e.ClinicId).HasColumnName("clinicid");
            entity.Property(e => e.TimeSlotId).HasColumnName("Time_slotId");

            entity.HasOne(d => d.Clinic).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ClinicId)
                .HasConstraintName("fk_clinic");

            entity.HasOne(d => d.Customer).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Appointme__Custo__4BAC3F29");

            entity.HasOne(d => d.Dentist).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.DentistId)
                .HasConstraintName("FK__Appointme__Denti__4CA06362");

            entity.HasOne(d => d.Service).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK__Appointme__Servi__4D94879B");

            entity.HasOne(d => d.TimeSlot).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.TimeSlotId)
                .HasConstraintName("FK__Appointme__Time___4E88ABD4");
        });

        modelBuilder.Entity<Clinic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clinic__3214EC07DE02B697");

            entity.ToTable("Clinic");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Available)
                .HasDefaultValue(1)
                .HasColumnName("available");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Manager).WithMany(p => p.Clinics)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__Clinic__ManagerI__4316F928");

            entity.HasIndex(e => e.Address).IsUnique();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Customer__1788CC4CB2808141");

            entity.ToTable("Customer");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithOne(p => p.Customer)
                .HasForeignKey<Customer>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Customer__UserId__3D5E1FD2");
        });

        modelBuilder.Entity<Dentist>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Dentist__1788CC4C03311E62");

            entity.ToTable("Dentist");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.Clinic).WithMany(p => p.Dentists)
                .HasForeignKey(d => d.ClinicId)
                .HasConstraintName("FK__Dentist__ClinicI__48CFD27E");

            entity.HasOne(d => d.User).WithOne(p => p.Dentist)
                .HasForeignKey<Dentist>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Dentist__UserId__47DBAE45");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Manager__1788CC4C040F6614");

            entity.ToTable("Manager");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithOne(p => p.Manager)
                .HasForeignKey<Manager>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Manager__UserId__403A8C7D");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Service__3214EC0782A7EF1C");

            entity.ToTable("Service");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<TimeSlot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__time_slo__3214EC07FE2606AB");

            entity.ToTable("Time_slot");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC070099FC43");

            entity.ToTable("User");

            entity.Property(e => e.Available)
                .HasDefaultValue(1)
                .HasColumnName("Available");
            entity.Property(e => e.Email)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("Email");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.UserType).HasMaxLength(50);

            entity.HasIndex(e => e.Email).IsUnique();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
