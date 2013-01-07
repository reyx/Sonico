using Reyx.Web.Sonico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Reyx.Web.Sonico.Mapping
{
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            // Relationships
            this.HasMany(b => b.Users)
                .WithMany(a => a.Groups)
                .Map(m => m.MapLeftKey("GroupId")
                           .MapRightKey("UserId")
                           .ToTable("GroupGroup"));
        }
    }
}