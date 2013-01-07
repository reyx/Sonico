using Reyx.Web.Sonico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Reyx.Web.Sonico.Mapping
{
    public class UserGroupMap : EntityTypeConfiguration<UserGroup>
    {
        public UserGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            // Relationships
            this.HasOptional(t => t.Group)
                .WithMany()
                .HasForeignKey(t => t.GroupId);

            this.HasOptional(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId);
        }
    }
}