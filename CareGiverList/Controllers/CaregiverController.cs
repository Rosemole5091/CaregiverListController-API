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
        public IEnumerable<CareGiver> Get()
        {
            List<CareGiver> CareGiverList = new List<CareGiver>();
            CareGiver b1 = new CareGiver(lastName: "C", firstName: "Amelia", contactNumber: "216 7989 650", discipline: "Home Health Aide");
            CareGiver b2 = new CareGiver(lastName: "D", firstName: "Olivia", contactNumber: "216 7989 650", discipline: "Home Health Aide");
            CareGiver b3 = new CareGiver(lastName: "T", firstName: "Isla", contactNumber: "216 7989 650", discipline: "Home Health Aide");
            CareGiver b4 = new CareGiver(lastName: "H", firstName: "Olivia", contactNumber: "216 7989 650", discipline: "Home Health Aide");
            CareGiver b5 = new CareGiver(lastName: "B", firstName: "Atticus", contactNumber: "216 7989 650", discipline: "Home Health Aide");

          

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
    public class CareGiver
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string contactNumber { get; set; }
        public string discipline { get; set; }

        public CareGiver(string lastName, string firstName, string contactNumber, string discipline)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.contactNumber = contactNumber;
            this.discipline = discipline;
        }


    }
}
