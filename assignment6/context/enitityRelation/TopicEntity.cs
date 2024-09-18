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
    internal class TopicEntity : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            
                builder.HasKey(e => e.TopId);

                builder.ToTable("Topic");

                builder.Property(e => e.TopId)
                    .ValueGeneratedNever()
                    .HasColumnName("Top_Id");

                builder.Property(e => e.TopName)
                    .HasMaxLength(50)
                    .HasColumnName("Top_Name");
            
        }
    }
}
