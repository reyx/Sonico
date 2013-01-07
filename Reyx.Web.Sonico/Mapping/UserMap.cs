using Reyx.Web.Sonico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Reyx.Web.Sonico.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            // Relationships
            this.HasMany(b => b.Groups)
                .WithMany(a => a.Users)
                .Map(m => m.MapLeftKey("UserId")
                           .MapRightKey("GroupId")
                           .ToTable("UserGroup"));
        }
    }
}