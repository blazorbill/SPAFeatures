using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SPAFeatures.DAL.Model;
using SPAFeatures.DTO;
using SPAFeatures.Server.BL.Services;

namespace SPAFeatures.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController: Controller
    {
        private IPeopleService _peopleService;
        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }
        [HttpGet]
        public ActionResult<List<PersonDTO>> GetPeople()
        {
            return _peopleService.GetPeople();
        }
        [HttpPost]
        public ActionResult<bool> SavePerson(PersonDTO person)
        {
            return _peopleService.SavePerson(person);
        }
    }
}
