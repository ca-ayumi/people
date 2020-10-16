using System.Collections.Generic;
using Exemplo.Model;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo.Controller

{
    [Route ("[controller]")]
    public class PeopleController {
        public List<People> peoples = new List<People> ();

        [HttpGet]
        public List<People> Get () { return peoples; }

        [HttpPost]
        public List<People> Post ([FromBody] People people) {
            peoples.Add (people);
            return peoples;
        }

        [HttpPut]
        public List<People> Put ([FromBody] People people) {
            var index = peoples.FindIndex (x => x.id == people.id);
            if (index != -1) {
                return null; //simulação 2
            }
        
            return peoples;
        }

        [HttpDelete]
        public List<People> Delete ([FromBody] People people){
            return null; 
        }

    }

}
