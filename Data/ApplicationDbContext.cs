using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatientRecordManagement.Models.Logic_Models;
using PatientRecordManagement.Models;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Define your DbSets here. For example:
    // public DbSet<PatientRecord> PatientRecords { get; set; }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<User> Users { get; set; }
    //public DbSet<BlockchainTransaction> BlockchainTransactions { get; set; }
   // public DbSet<AIInsight> AIInsights { get; set; }
    public DbSet<Consent> Consents { get; set; }
    public DbSet<AppointmentReminder> AppointmentReminders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>()
            .HasMany(p => p.MedicalRecord)
            .WithOne()
            .HasForeignKey(mr => mr.PatientId);

        modelBuilder.Entity<Patient>()
            .HasMany(p => p.Appointments)
            .WithOne()
            .HasForeignKey(a => a.PatientId);

        modelBuilder.Entity<Patient>()
            .HasMany(p => p.Prescriptions)
            .WithOne()
            .HasForeignKey(p => p.PatientId);

        modelBuilder.Entity<Patient>()
            .HasMany(p => p.Messages)
            .WithOne()
            .HasForeignKey(m => m.Id);

        modelBuilder.Entity<Patient>()
            .HasMany(p => p.Consent)
            .WithOne()
            .HasForeignKey(c => c.PatientId);

        modelBuilder.Entity<Doctor>()
            .HasMany(d => d.Appointments)
            .WithOne()
            .HasForeignKey(a => a.DoctorId);

        modelBuilder.Entity<Doctor>()
            .HasMany(d => d.Presciptions)
            .WithOne()
            .HasForeignKey(p => p.PatientId);

        base.OnModelCreating(modelBuilder);
    }
}
