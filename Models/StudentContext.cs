using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab_5.Models;

namespace Lab_5.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set;}

        public DbSet<Lab_5.Models.Teacher> Teacher { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
    }
}
