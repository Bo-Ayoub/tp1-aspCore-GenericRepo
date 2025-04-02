using Microsoft.EntityFrameworkCore;
using tp1_aspcore.Data;

namespace tp1_aspcore
{
    internal class Program
    {
        static void Main(string[] args)

        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            ApplicationDbContext dbContext = new ApplicationDbContext(optionsBuilder.Options);
            Console.WriteLine("Hello, World!");
        }
    }
}
