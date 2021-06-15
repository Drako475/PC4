using System;
using System.Collections.Generic;
using System.Text;
using PC4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace PC4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Datos> Datos { get; set; }
        public DbSet<Anonimo> Anonimo { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
