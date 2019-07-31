using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareGiverList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaregiverController : ControllerBase
    {
        // GET: api/Caregiver
        [HttpGet]
        public IEnumerable<Caregivermodel> Get()
        {
            List<Caregivermodel> CareGiverList = new List<Caregivermodel>();
            Caregivermodel b1 = new Caregivermodel(lastName: "C", firstName: "Amelia", contactNumber: "216 7989 650", discipline: "Home Health Aide");
            Caregivermodel b2 = new Caregivermodel(lastName: "D", firstName: "Olivia", contactNumber: "216 7989 650", discipline: "Home Health Aide");
            Caregivermodel b3 = new Caregivermodel(lastName: "T", firstName: "Isla", contactNumber: "216 7989 650", discipline: "Home Health Aide");
            Caregivermodel b4 = new Caregivermodel(lastName: "H", firstName: "Olivia", contactNumber: "216 7989 650", discipline: "Home Health Aide");
            Caregivermodel b5 = new Caregivermodel(lastName: "B", firstName: "Atticus", contactNumber: "216 7989 650", discipline: "Home Health Aide");



            CareGiverList.Add(b1);
            CareGiverList.Add(b2);
            CareGiverList.Add(b3);
            CareGiverList.Add(b4);
            CareGiverList.Add(b5);


            return CareGiverList;
        }

        // GET: api/Caregiver/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Caregiver
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Caregiver/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class Caregivermodel
    {
        public PersonalInfo personalInfo { get; set; }
        public Contact contact { get; set; }
        public string discipline { get; set; }

        
       
        public Caregivermodel(string lastName, string firstName, string contactNumber, string discipline)
        {
            this.personalInfo= new PersonalInfo(lastName,firstName);
            this.contact = new Contact(contactNumber);
            this.discipline = discipline;
        }

        public class PersonalInfo
        {
            public PersonalInfo(string lastName, string firstName)
            {
                this.lastName = lastName;
                this.firstName = firstName;
            }

            public string lastName { get; set; }
            public string firstName { get; set; }
        }
        public class Contact
        {
        

            public Contact(string contactNumber)
            {
                this.contactNumber = contactNumber;
            }

            public string contactNumber { get; set; }
        }
    }
}
