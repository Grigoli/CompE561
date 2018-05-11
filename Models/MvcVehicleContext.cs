using Microsoft.EntityFrameworkCore;

namespace AutomobilesMvc.Models 
{
    public class MvcVehicleContext : DbContext
    {
        public MvcVehicleContext(DbContextOptions<MvcVehicleContext> options) 
            : base(options)
        {
        }

        public DbSet<AutomobilesMvc.Models.Vehicle> Vehicle { get; set; }
    }
}
