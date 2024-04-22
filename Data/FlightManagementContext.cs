using Microsoft.EntityFrameworkCore;
using FlightManagementAPI.Models;

namespace FlightManagementAPI.Data
{
    public class FlightManagementContext : DbContext
    {
        public FlightManagementContext(DbContextOptions<FlightManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
    }
}
