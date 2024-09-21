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
    internal class StudCourseModel : IEntityTypeConfiguration<StudCourse>
    {
        public void Configure(EntityTypeBuilder<StudCourse> builder)
        {
            
                builder.HasKey(e => new { e.CrsId, e.StId });

                builder.ToTable("Stud_Course");

                builder.Property(e => e.CrsId).HasColumnName("Crs_Id");

                builder.Property(e => e.StId).HasColumnName("St_Id");

                builder.HasOne(d => d.Crs)
                    .WithMany(p => p.StudCourses)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stud_Course_Course");

                builder.HasOne(d => d.St)
                    .WithMany(p => p.StudCourses)
                    .HasForeignKey(d => d.StId)
                    .HasConstraintName("FK_Stud_Course_Student");
            
        }
    }
}
