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
    internal class InstructorModel : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            
                builder.HasKey(e => e.Id);

                builder.ToTable("Instructor");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Ins_Id");

                builder.Property(e => e.DeptId).HasColumnName("Dept_Id");

                builder.Property(e => e.Degree)
                    .HasMaxLength(50)
                    .HasColumnName("Ins_Degree");

                builder.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("Ins_Name");

                builder.Property(e => e.Salary).HasColumnType("money");

                builder.HasOne(d => d.Dept)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_Instructor_Department");
            
        }
    }
}
