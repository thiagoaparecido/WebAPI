using System.Linq;

namespace WebAPI.Models
{
    public static class DbInitializer
    {
        public static void Initialize(WebAPIContext context)
        {
            context.Database.EnsureCreated();

            // Look for any entries.
            if (context.Foos.Any())
            {
                return;   // DB has been seeded
            }

            var foos = new Foo[]
            {
                new Foo{Name="Jane Smith", IsActive=true},
                new Foo{Name="John Doe", IsActive=false}
            };
            foreach (Foo f in foos)
            {
                context.Foos.Add(f);
            }
            context.SaveChanges();

        }
    }
}