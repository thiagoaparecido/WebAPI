using System;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext(DbContextOptions<WebAPIContext> options)
            : base(options){}

        public DbSet<Foo> Foos { get; set; }
    }
}
