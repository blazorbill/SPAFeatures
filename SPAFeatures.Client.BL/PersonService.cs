using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SPAFeatures.DTO;

namespace SPAFeatures.Client.BL
{
    public class PersonService:IPersonService
    {
        private string _baseUrl = "";
        public PersonService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public async Task<List<PersonDTO>> GetPersons()
        {
            return await HTTPHelper.HttpGet<List<PersonDTO>>(_baseUrl,"people");
        }

        public async Task<bool> SavePerson(PersonDTO person)
        {
            return await HTTPHelper.HttpPost<PersonDTO>(_baseUrl,"people", person);
        }
    }
}
