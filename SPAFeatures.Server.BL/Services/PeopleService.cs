using SPAFeatures.DAL.Model;
using SPAFeatures.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPAFeatures.Server.BL.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly AppDbContext _context;

        public PeopleService(AppDbContext context)
        {
            _context = context;
        }
        public List<PersonDTO> GetPeople()
        {
            return _context.People.Select(p=>new PersonDTO() {
                ID = p.ID,
                FirstName = p.FirstName,
                LastName = p.LastName
            }).ToList();
        }

        public Person GetPerson(int id)
        {
            return _context.People.Where(p => p.ID == id).FirstOrDefault();
        }

        public bool SavePerson(PersonDTO person)
        {
            if (person.ID > 0)
            {
                Person updatedPerson = GetPerson(person.ID);
                if (updatedPerson != null)
                {
                    updatedPerson.FirstName = person.FirstName;
                    updatedPerson.LastName = person.LastName;
                    _context.People.Update(updatedPerson);
                }
            }
            else
            {
                Person updatedPerson = new Person()
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName
                };
                _context.People.Add(updatedPerson);
            }

            return _context.SaveChanges()>0;
        }
    }
}
