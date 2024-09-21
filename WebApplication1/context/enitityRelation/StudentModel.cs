
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
    internal class StudentModel : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            
                builder.HasKey(e => e.Id);

                builder.ToTable("Student");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("St_Id");

                builder.Property(e => e.DeptId).HasColumnName("Dept_Id");

                builder.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasColumnName("St_Address");

                builder.Property(e => e.Age).HasColumnName("St_Age");

                builder.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("St_Fname");

                builder.Property(e => e.Lname)
                    .HasMaxLength(10)
                    .HasColumnName("St_Lname")
                    .IsFixedLength();

                builder.Property(e => e.StSuperId).HasColumnName("St_super");

                builder.HasOne(d => d.Dept)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_Student_Department");

                builder.HasOne(d => d.StSuper)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StSuperId)
                    .HasConstraintName("FK_Student_Student");
           
        }
    }
}
