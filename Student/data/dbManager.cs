using Microsoft.EntityFrameworkCore;
using Student.Models;
using System.Collections.Generic;

namespace Student.data
{
    public class dbManager : DbContext
    {
        public dbManager(DbContextOptions options) : base(options)
        {
        }
       public DbSet<Students>Students { get; set; }
        

       
    }
}
