using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Gym_Tracker;

public partial class GymTrackerDbContext : DbContext
{
    public GymTrackerDbContext()
    {
    }

    public GymTrackerDbContext(DbContextOptions<GymTrackerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerEmail> CustomerEmails { get; set; }

    public virtual DbSet<ExtExercise> ExtExercises { get; set; }

    public virtual DbSet<ExtExerciseApperal> ExtExerciseApperals { get; set; }

    public virtual DbSet<ExtGymOrg> ExtGymOrgs { get; set; }

    public virtual DbSet<ExtUserDatum> ExtUserData { get; set; }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<WeatherDatum> WeatherData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=labH7SR1J;Initial Catalog=GymTrackerDB;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Course__C1F8DC59C27DE464");

            entity.ToTable("Course");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.ClassPrice).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrainerFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrainerLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__8CB286B9A41AE6F7");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(225)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(225)
                .HasColumnName("Last_Name");
        });

        modelBuilder.Entity<CustomerEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer_Email");

            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.Email).HasMaxLength(225);

            entity.HasOne(d => d.Customer).WithMany()
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Customer___Custo__797309D9");
        });

        modelBuilder.Entity<ExtExercise>(entity =>
        {
            entity.HasKey(e => e.ExerciseId).HasName("PK__ext_exer__C121418E3712D7CA");

            entity.ToTable("ext_exercise");

            entity.Property(e => e.ExerciseId).HasColumnName("exercise_id");
            entity.Property(e => e.ExerciseEquipment)
                .HasMaxLength(255)
                .HasColumnName("exercise_equipment");
            entity.Property(e => e.ExerciseMuscleTarget)
                .HasMaxLength(255)
                .HasColumnName("exercise_muscleTarget");
            entity.Property(e => e.ExerciseName)
                .HasMaxLength(255)
                .HasColumnName("exercise_name");
        });

        modelBuilder.Entity<ExtExerciseApperal>(entity =>
        {
            entity.HasKey(e => e.ApperalId).HasName("PK__ext_exer__DAFE00AAD56D7C31");

            entity.ToTable("ext_exercise_apperal");

            entity.Property(e => e.ApperalId).HasColumnName("apperal_id");
            entity.Property(e => e.ApperalBrand)
                .HasMaxLength(255)
                .HasColumnName("apperal_brand");
            entity.Property(e => e.ApperalExercise).HasColumnName("apperal_exercise");
            entity.Property(e => e.ApperalMaterial)
                .HasMaxLength(255)
                .HasColumnName("apperal_material");
            entity.Property(e => e.ApperalType)
                .HasMaxLength(255)
                .HasColumnName("apperal_type");

            entity.HasOne(d => d.ApperalExerciseNavigation).WithMany(p => p.ExtExerciseApperals)
                .HasForeignKey(d => d.ApperalExercise)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ext_exerc__apper__71D1E811");
        });

        modelBuilder.Entity<ExtGymOrg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ext_gym___3213E83F4A8AC0A0");

            entity.ToTable("ext_gym_org");

            entity.HasIndex(e => e.GymName, "UQ__ext_gym___6AEE76E4AE4F7224").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CloseTime).HasColumnName("close_time");
            entity.Property(e => e.GymCity)
                .HasMaxLength(255)
                .HasColumnName("gym_city");
            entity.Property(e => e.GymName)
                .HasMaxLength(255)
                .HasColumnName("gym_name");
            entity.Property(e => e.OpenTime).HasColumnName("open_time");
        });

        modelBuilder.Entity<ExtUserDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ext_user__3213E83F3D7CD368");

            entity.ToTable("ext_user_data");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UserAddress)
                .HasMaxLength(255)
                .HasColumnName("user_address");
            entity.Property(e => e.UserCity)
                .HasMaxLength(255)
                .HasColumnName("user_city");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(255)
                .HasColumnName("user_email");
            entity.Property(e => e.UserJoined).HasColumnName("user_joined");
            entity.Property(e => e.UserLevel)
                .HasMaxLength(255)
                .HasColumnName("user_level");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword).HasColumnName("user_password");
        });

        modelBuilder.Entity<Membership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Membersh__3214EC274E8F8B41");

            entity.ToTable("Membership");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MembershipLevel)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.MembershipMonthPrice).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<WeatherDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WeatherD__3214EC07C8372CE3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
