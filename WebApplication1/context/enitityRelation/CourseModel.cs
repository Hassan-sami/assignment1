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
    internal class CourseModel : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            
                builder.HasKey(e => e.Id);

                builder.ToTable("Course");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Crs_Id");

                builder.Property(e => e.Duration).HasColumnName("Crs_Duration");

                builder.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("Crs_Name");

                builder.Property(e => e.TopicId).HasColumnName("Top_Id");

                builder.HasOne(d => d.Topic)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_Course_Topic");
            
        }
    }
}
