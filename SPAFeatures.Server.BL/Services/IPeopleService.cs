using SPAFeatures.DAL.Model;
using SPAFeatures.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPAFeatures.Server.BL.Services
{
    public interface IPeopleService
    {
        List<PersonDTO> GetPeople();
        Person GetPerson(int id);
        bool SavePerson(PersonDTO person);
    }
}
