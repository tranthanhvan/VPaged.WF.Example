using System.Data.Entity;
using VPaged.Example.Entities;

namespace VPaged.Example.DbAccess
{
    public class VPagedContext : DbContext
    {
        public VPagedContext() : base(Connection.ConnectionString)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
