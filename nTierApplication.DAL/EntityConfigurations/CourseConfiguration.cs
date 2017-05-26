using nTierApplication.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTierApplication.DAL.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(2000);

            Property(c => c.Credits)
                .IsRequired();
            
        }
    }
}