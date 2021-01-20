using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using stud_evid_pin_seminar.Models;

namespace stud_evid_pin_seminar.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<stud_evid_pin_seminar.Models.Student> Student { get; set; }
    }
}
