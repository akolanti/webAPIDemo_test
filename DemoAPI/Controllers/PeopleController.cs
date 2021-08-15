using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {

        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "ak", LastName = "nk", Id = 1 });

            people.Add(new Person { FirstName = "kaushik", LastName = "mehta", Id = 2 });

            people.Add(new Person { FirstName = "sam", LastName = "souza", Id = 3 });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
             return people.Where(x=>x.Id==id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public string Delete(int id)
        {
            Person p = people.Where(x => x.Id.Equals(id)).FirstOrDefault();
            if (people.Remove(p))
            {
                return "success";
            } else return "fail";


        }
    }
}
