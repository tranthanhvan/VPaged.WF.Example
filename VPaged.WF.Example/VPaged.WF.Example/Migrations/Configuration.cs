namespace VPaged.WF.Example.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Diagnostics;
    using System.Linq;
    using VPaged.WF.Example.DbAccess;

    internal sealed class Configuration : DbMigrationsConfiguration<VPaged.WF.Example.DbAccess.VPagedContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VPaged.WF.Example.DbAccess.VPagedContext context)
        {
            Configuration configuration = new Configuration();
            configuration.ContextType = typeof(VPagedContext);
            var migrator = new DbMigrator(configuration);

            //This will get the SQL script which will update the DB and write it to debug
            var scriptor = new MigratorScriptingDecorator(migrator);
            string script = scriptor.ScriptUpdate(sourceMigration: null, targetMigration: null).ToString();
            Debug.Write(script);

            //This will run the migration update script and will run Seed() method
            migrator.Update();
        }
    }
}
