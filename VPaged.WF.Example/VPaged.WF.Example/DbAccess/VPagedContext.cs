using System.Data.Entity;
using VPaged.WF.Example.Entities;

namespace VPaged.WF.Example.DbAccess
{
    public class VPagedContext : DbContext
    {
        public VPagedContext() : base(Connection.ConnectionString)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
