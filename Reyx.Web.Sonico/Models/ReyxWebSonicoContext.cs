using System.Data.Entity;

namespace Reyx.Web.Sonico.Models
{
    public class ReyxWebSonicoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Reyx.Web.Sonico.Models.ReyxWebSonicoContext>());

        public ReyxWebSonicoContext()
            : base("SonicoDatabase")
        {

        }

        public DbSet<Reyx.Web.Sonico.Models.Group> Groups { get; set; }
        public DbSet<Reyx.Web.Sonico.Models.Module> Modules { get; set; }
        public DbSet<Reyx.Web.Sonico.Models.Permission> Permissions { get; set; }
        public DbSet<Reyx.Web.Sonico.Models.Task> Tasks { get; set; }
        public DbSet<Reyx.Web.Sonico.Models.User> Users { get; set; }
        public DbSet<Reyx.Web.Sonico.Models.UserGroup> UserGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Reyx.Web.Sonico.Mapping.GroupMap());
            modelBuilder.Configurations.Add(new Reyx.Web.Sonico.Mapping.ModuleMap());
            modelBuilder.Configurations.Add(new Reyx.Web.Sonico.Mapping.PermissionMap());
            modelBuilder.Configurations.Add(new Reyx.Web.Sonico.Mapping.TaskMap());
            modelBuilder.Configurations.Add(new Reyx.Web.Sonico.Mapping.UserMap());
            modelBuilder.Configurations.Add(new Reyx.Web.Sonico.Mapping.UserGroupMap());
        }
    }
}