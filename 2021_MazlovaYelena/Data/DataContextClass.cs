using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _2021_MazlovaYelena.Data
{
    public class DataContextClass : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContextClass(DbContextOptions<DataContextClass> options): base (options)
        {
        }
    }
}
