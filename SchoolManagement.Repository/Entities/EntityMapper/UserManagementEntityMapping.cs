using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagement.Repository.Entities
{
    public class UserManagementEntityMapping : EntityTypeConfiguration<UserManagement>
    {
        public UserManagementEntityMapping()
        {
            this.ToTable("UserManagement")
                .HasKey(um => um.RegNum);

            this.Property(um => um.RegNum)
                .HasColumnName("RegNum")
                .HasColumnOrder(0)
                .HasColumnType("INT")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(um => um.UserName)
                .HasColumnName("UserName")
                .HasColumnOrder(1)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            this.Property(um => um.Password)
                .HasColumnName("Password")
                .HasColumnOrder(2)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            this.Property(um => um.Role)
                .HasColumnName("Role")
                .HasColumnOrder(3)
                .HasColumnType("INT")
                .IsRequired();
        }
    }
}
