using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aws_postman.Entities;

namespace aws_postman.Contexts
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    {

    }
    public DbSet<Usermessage> Usermessages { get; set; }
    public DbSet<Email> Emails { get; set; }
    public DbSet<Listdestination> Listdestination { get; set; }
  }
}