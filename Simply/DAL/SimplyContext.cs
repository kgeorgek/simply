
namespace Simply.DAL
{

    using Simply.Models;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class SimplyContext : DbContext
    {

        public SimplyContext() : base("SimplyContext")
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<ReferralCustomer> ReferralCustomer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}