using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace SchoolManagement.Repository.Entities
{
    public class TeacherEntityMapping : EntityTypeConfiguration<Teacher>
    {
        public TeacherEntityMapping()
        {
            this.ToTable("Teacher")
               .HasKey(t => t.TeacherId)
               .Ignore(t => t.FullName)
               .HasMany(t => t.Students)
               .WithMany(s => s.Teachers)
               .Map(m => m.ToTable("StudentTeachers").MapLeftKey("TeacherId").MapRightKey("RollId"));

            this.Property(t => t.TeacherId)
                .HasColumnName("TeacherId")
                .HasColumnOrder(0)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(t => t.FirstName)
                .HasColumnName("FirstName")
                .HasColumnOrder(1)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            this.Property(t => t.LastName)
                .HasColumnName("LastName")
                .HasColumnOrder(2)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsOptional();

            this.Property(t => t.Subject)
                .HasColumnName("Subject")
                .HasColumnOrder(3)
                .HasColumnType("INT")
                .IsOptional();

        }
    }
}
