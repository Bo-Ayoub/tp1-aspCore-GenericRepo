using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp1_aspcore.Models;
using tp1_aspcore.Repository;

namespace tp1_aspcore.Service
{
    internal class PersonService
    {
        private readonly IRepository<Person> _personRepository;

        
        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

       
        public async Task AddPersonAsync(Person person)
        {
            await _personRepository.AddAsync(person);
            await _personRepository.SaveAsync(); 
        }

       
        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await _personRepository.GetByIdAsync(id);
        }

        
        public async Task<IEnumerable<Person>> GetAllPersonsAsync()
        {
            return await _personRepository.GetAllAsync();
        }

       
        public async Task UpdatePersonAsync(Person person)
        {
            await _personRepository.UpdateAsync(person);
            await _personRepository.SaveAsync();  
        }

       
        public async Task DeletePersonAsync(int id)
        {
            await _personRepository.DeleteAsync(id);
            await _personRepository.SaveAsync();  
        }
    }
}
