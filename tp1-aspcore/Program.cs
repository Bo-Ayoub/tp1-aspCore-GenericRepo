using Microsoft.EntityFrameworkCore;
using SimpleInjector.Lifestyles;
using SimpleInjector;
using tp1_aspcore.Data;
using tp1_aspcore.Repository;
using tp1_aspcore.Service;
using tp1_aspcore.Models;
using System.Threading.Tasks;

namespace tp1_aspcore
{
    internal class Program
    {
        static async Task Main(string[] args)

        {
        
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();


            container.Register(() => optionsBuilder.Options, Lifestyle.Singleton);


            container.Register<DbContext,ApplicationDbContext>(Lifestyle.Scoped);

           
            container.Register(typeof(IRepository<>), typeof(Repository<>), Lifestyle.Scoped);
            container.Register(typeof(IReadOnlyRepository<>), typeof(ReadOnlyRepository<>), Lifestyle.Scoped);

  
            container.Register<PersonService>(Lifestyle.Scoped);

            container.Register<Program>(Lifestyle.Singleton);


            container.Verify();


            using (AsyncScopedLifestyle.BeginScope(container))  
            {
                var personService = container.GetInstance<PersonService>();
                Person person = new Person();
                person.FirstName="ayoub";
                person.LastName = "test";

                await personService.AddPersonAsync(person);
            }
           
        }
    }
}
