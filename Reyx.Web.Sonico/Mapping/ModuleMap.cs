using Reyx.Web.Sonico.Models;
using System.Data.Entity.ModelConfiguration;

namespace Reyx.Web.Sonico.Mapping
{
    public class ModuleMap : EntityTypeConfiguration<Module>
    {
        public ModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            // Relationships
        }
    }
}