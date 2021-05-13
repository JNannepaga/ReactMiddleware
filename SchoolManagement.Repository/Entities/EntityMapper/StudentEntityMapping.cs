using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace SchoolManagement.Repository.Entities
{
    public class StudentEntityMapping : EntityTypeConfiguration<Student>
    {
        public StudentEntityMapping()
        {
            this.ToTable("Student")
                .HasKey(s => s.RollId)
                .Ignore(s => s.FullName)
                .HasMany(s => s.Teachers)
                .WithMany(t => t.Students)
                .Map(m => m.ToTable("StudentTeachers").MapLeftKey("RollId").MapRightKey("TeacherId"));

            this.Property(s => s.RollId)
                .HasColumnName("RollId")
                .HasColumnOrder(0)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(s => s.FirstName)
                .HasColumnName("FirstName")
                .HasColumnOrder(1)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            this.Property(s => s.LastName)
                .HasColumnName("LastName")
                .HasColumnOrder(2)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsOptional();

            this.Property(s => s.Standard)
                .HasColumnName("Standard")
                .HasColumnOrder(3)
                .HasColumnType("INT")
                .IsOptional();

        }
    }
}
