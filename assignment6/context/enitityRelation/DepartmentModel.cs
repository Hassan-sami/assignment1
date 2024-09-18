using assignment6.context.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace assignment6.context.enitityRelation
{
    internal class DepartmentModel : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            
                builder.HasKey(e => e.DeptId);

                builder.ToTable("Department");

                builder.HasIndex(e => e.ManagerHiredate, "hireIndex");

                builder.Property(e => e.DeptId)
                    .ValueGeneratedNever()
                    .HasColumnName("Dept_Id");

                builder.Property(e => e.DeptDesc)
                    .HasMaxLength(100)
                    .HasColumnName("Dept_Desc");

                builder.Property(e => e.DeptLocation)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Location");

                builder.Property(e => e.DeptManagerId).HasColumnName("Dept_Manager");

                builder.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Name");

                builder.Property(e => e.ManagerHiredate)
                    .HasColumnType("date")
                    .HasColumnName("Manager_hiredate");

                builder.HasOne(d => d.DeptManager)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.DeptManagerId)
                    .HasConstraintName("FK_Department_Instructor");
            
        }
    }
}
