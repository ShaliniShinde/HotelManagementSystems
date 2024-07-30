using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystems.Models;

namespace HotelManagementSystems.Data
{
    public class HotelManagementSystemsContext : DbContext
    {
        public HotelManagementSystemsContext (DbContextOptions<HotelManagementSystemsContext> options)
            : base(options)
        {
        }

        public DbSet<HotelManagementSystems.Models.Hotel> Hotel { get; set; } = default!;
    }
}
