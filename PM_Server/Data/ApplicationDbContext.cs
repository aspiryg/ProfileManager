using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.GeneInfo;
using PM_DataAccess.PatientClasses;
using PM_DataAccess.Referrer;
using PM_DataAccess.SEA;
using PM_DataAccess.SocialWorker;
using PM_DataAccess.StagesClasses;
using PM_DataAccess.UserProfiles;

namespace PM_Server.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{

    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<UserProfile> UserProfiles { get; set; } = null!;
    public DbSet<Referrer> Referrers { get; set; } = null!;
    public DbSet<SocialWorker> SocialWorkers { get; set; } = null!;
    public DbSet<UserType> UserTypes { get; set; } = null!;
    public DbSet<NGOClass> NGOs { get; set; } = null!;
    public DbSet<Stage> Stages { get; set; } = null!;
    public DbSet<StageStatus> StageStatuses { get; set; } = null!;
    public DbSet<StageTypes> StageTypes { get; set; } = null!;
    public DbSet<SocioeconomicAssessment> SEAssessments { get; set; } = null!;
    public DbSet<Nationality> Nationalities { get; set; } = null!;
    public DbSet<Surgery> Surgeries { get; set; } = null!;
    public DbSet<ScoringSystem> ScoringSystems { get; set; } = null!;
    public DbSet<EmploymentStatus> EmploymentStatuses { get; set; } = null!;
    public DbSet<EmploymentType> EmploymentTypes { get; set; } = null!;


    // pre fill the UserTypes table with the following data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserType>().HasData(
            new UserType { ID = 1, Type = "Referrer", CreatedDate = DateTime.Now, IsDeleted = false },
            new UserType { ID = 2, Type = "Social Worker", CreatedDate = DateTime.Now, IsDeleted = false },
            new UserType { ID = 3, Type = "Medical Examiner", CreatedDate = DateTime.Now, IsDeleted = false },
            new UserType { ID = 4, Type = "HealthCare Service Providers", CreatedDate = DateTime.Now, IsDeleted = false },
            new UserType { ID = 5, Type = "Financial Supporter", CreatedDate = DateTime.Now, IsDeleted = false },
            new UserType { ID = 6, Type = "Medical Missions", CreatedDate = DateTime.Now, IsDeleted = false },
            new UserType { ID = 7, Type = "Medi-financial service provider", CreatedDate = DateTime.Now, IsDeleted = false },
            new UserType { ID = 8, Type = "Admin", CreatedDate = DateTime.Now, IsDeleted = false }
        );

        // pre fill the stage status table with the following data
        modelBuilder.Entity<StageStatus>().HasData(
            new StageStatus { ID = 1, Status = "Pending", CreatedDate = DateTime.Now, Color = "Warning", Icon = "Pending" },
            new StageStatus { ID = 2, Status = "In Progress", CreatedDate = DateTime.Now, Color = "Primary", Icon = "InProgress" },
            new StageStatus { ID = 3, Status = "Completed", CreatedDate = DateTime.Now, Color = "Success", Icon = "Completed" },
            new StageStatus { ID = 4, Status = "Cancelled", CreatedDate = DateTime.Now, Color = "Danger", Icon = "Cancelled" },
            new StageStatus { ID = 5, Status = "Rejected", CreatedDate = DateTime.Now, Color = "Danger", Icon = "Rejected" },
            new StageStatus { ID = 6, Status = "Approved", CreatedDate = DateTime.Now, Color = "Success", Icon = "Approved" },
            new StageStatus { ID = 7, Status = "On Hold", CreatedDate = DateTime.Now, Color = "Warning", Icon = "OnHold" },
            new StageStatus { ID = 8, Status = "Not Started", CreatedDate = DateTime.Now, Color = "Warning", Icon = "NotStarted" },
            new StageStatus { ID = 9, Status = "Not Applicable", CreatedDate = DateTime.Now, Color = "Warning", Icon = "NotApplicable" },
            new StageStatus { ID = 10, Status = "Not Required", CreatedDate = DateTime.Now, Color = "Warning", Icon = "NotRequired" },
            new StageStatus { ID = 11, Status = "Not Available", CreatedDate = DateTime.Now, Color = "Warning", Icon = "NotAvailable" }
        );
        // pre fill the stage types table with the following data
        modelBuilder.Entity<StageTypes>().HasData(
            new StageTypes { StageID = 1, Name = "Intake", Responsible = "Referrer", Duration = 0, DurationUnit = "Day", Color = "Green", Icon = "Intake", IsActive = true, Order = 1 },
            new StageTypes { StageID = 2, Name = "SocioEconomic Assessment", Responsible = "Social Worker", Duration = 7, DurationUnit = "Day", Color = "Green", Icon = "Assessment", IsActive = true, Order = 2 },
            new StageTypes { StageID = 3, Name = "Medical Assessment", Responsible = "Medical Examiner", Duration = 7, DurationUnit = "Day", Color = "Green", Icon = "Medical", IsActive = true , Order = 3},
            new StageTypes { StageID = 4, Name = "Treatment Plan", Responsible = "HealthCare Service Providers", Duration = 7, DurationUnit = "Day", Color = "Green", Icon = "Treatment", IsActive = true, Order = 4 },
            new StageTypes { StageID = 5, Name = "Payment Stage", Responsible = "Medi-financial service provider", Duration = 7, DurationUnit = "Day", Color = "Green", Icon = "Financial", IsActive = true, Order = 5 },
            new StageTypes { StageID = 6, Name = "End the process", Responsible = "Admin", Duration = 0, DurationUnit = "Day", Color = "Green", Icon = "End", IsActive = true, Order = 6}
        );

        // pre fill the Nationality table with the following data
        modelBuilder.Entity<Nationality>().HasData(
            new Nationality { Id = 1, NationalityName = "Afghan", CreatedDate = DateTime.Now },
            new Nationality { Id = 2, NationalityName = "Syrian", CreatedDate = DateTime.Now },
            new Nationality { Id = 3, NationalityName = "Palestinian", CreatedDate = DateTime.Now },
            new Nationality { Id = 4, NationalityName = "Lebanese", CreatedDate = DateTime.Now },
            new Nationality { Id = 5, NationalityName = "Egyptian", CreatedDate = DateTime.Now },
            new Nationality { Id = 6, NationalityName = "Iraqi", CreatedDate = DateTime.Now }
            );

        modelBuilder.Entity<Surgery>().HasData(
            new Surgery { Id = 1, SurgeryName = "Surgery 1", CreatedDate = DateTime.Now },
            new Surgery { Id = 2, SurgeryName = "Surgery 2", CreatedDate = DateTime.Now },
            new Surgery { Id = 3, SurgeryName = "Surgery 3", CreatedDate = DateTime.Now },
            new Surgery { Id = 4, SurgeryName = "Surgery 4", CreatedDate = DateTime.Now },
            new Surgery { Id = 5, SurgeryName = "Surgery 5", CreatedDate = DateTime.Now },
            new Surgery { Id = 6, SurgeryName = "Surgery 6", CreatedDate = DateTime.Now }
            );
    }
}





