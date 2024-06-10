using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PharmacyApp.Models;

//using PharmacyApp.Models;

namespace PharmacyApp.Data;

public partial class DrugStoreContext : DbContext
{
    public DrugStoreContext()
    {
    }

    public DrugStoreContext(DbContextOptions<DrugStoreContext> options)
        : base(options)
    {
    }


    public DbSet<Doctor> Doctors { get; set; }    
    public DbSet<Patient> Patients { get; set; }

    public DbSet<Prescription> Prescriptions { get; set; }

    public DbSet<Medicament> Medicaments { get; set; }

    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Doctor>().HasData(new List<Doctor>()
        {
            new() { IdDoctor = 1, FirstName = "John", LastName = "Doe",Email = "john@example.com"},
            new() { IdDoctor = 2, FirstName = "Ann", LastName = "Smith", Email = "annn@example.com"},
            new() { IdDoctor = 3, FirstName = "Jack", LastName = "Taylor" , Email = "jack@example.com"},
            new() { IdDoctor = 4, FirstName = "Billy", LastName = "Butcher" , Email = "billy@example.com"}
        });


        modelBuilder.Entity<Patient>().HasData(new List<Patient>()
        {

            new (){IdPatient = 3 , FirstName = "Anthony" , LastName = "Star" , Birthdate = Convert.ToDateTime("1-11-1"), },
            new (){IdPatient = 4 , FirstName = "Eminem" , LastName = "Marshall" , Birthdate = Convert.ToDateTime("17-12-1"), },
            new (){IdPatient = 2 , FirstName = "Krzysztof" , LastName = "Brzeczyszczykiewicz" , Birthdate = Convert.ToDateTime("17-12-1"), }
            
        });

        
        modelBuilder.Entity<Medicament>().HasData(new List<Medicament>()
        {
            new () { IdMedicament = 1, Name = "Amoxil", Description = "Antibiotic", Type = "Capsule"},
            new () { IdMedicament = 2, Name = "Panadol", Description = "Pain reliever", Type = "Tablet"}
        });

        modelBuilder.Entity<Prescription>().HasData(new List<Prescription>()
        {
            new () { IdPrescription = 1, Date = DateTime.Today, DueDate = DateTime.Today.AddDays(30), IdPatient = 1, IdDoctor = 1},
            new () { IdPrescription = 2, Date = DateTime.Today.AddDays(-10), DueDate = DateTime.Today.AddDays(20), IdPatient = 2, IdDoctor = 2}
        });

        modelBuilder.Entity<PrescriptionMedicament>().HasData(new List<PrescriptionMedicament>()
        {
            new () { IdPrescription = 1, IdMedicament = 1, Dose = 250, Details = "Take one tablet twice a day"},
            new () { IdPrescription = 2, IdMedicament = 2, Dose = 500, Details = "Take two tablets every six hours"}
        });
        

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
    
}
