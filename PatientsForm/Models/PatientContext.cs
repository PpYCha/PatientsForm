
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using PatientsForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PatientsForm.models
{
    public class PatientContext : DbContext
    {

    

        public DbSet<PatientInformation> PatientsInformation { get; set; }
        public DbSet<ExaminationTreatment> ExaminationTreatments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlite("Data Source=patients.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           


            modelBuilder.Entity<PatientInformation>().HasKey(k => k.PatientId);
            modelBuilder.Entity<ExaminationTreatment>().HasKey(k => k.ExaminationTreatmentId);
            modelBuilder.Entity<Prescription>().HasKey(k => k.PrescriptionId);
            modelBuilder.Entity<UserAccount>().HasKey(k => k.UserId);

       


        }
    }
}
