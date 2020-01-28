using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SPAFeatures.DTO;

namespace SPAFeatures.Client.BL
{
    public interface IPersonService
    {
        Task<List<PersonDTO>> GetPersons();
        Task<bool> SavePerson(PersonDTO person);
    }
}
