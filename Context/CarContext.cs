using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorADS.Context
{
    public class CarContext:DbContext
    {
        public CarContext(DbContextOptions<CarContext> options):base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}

