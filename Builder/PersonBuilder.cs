using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PersonBuilder
    {
        List<Action<Person>> builderActions = new List<Action<Person>>();
        
        public PersonBuilder AddFirstName(string fname)
        {
            builderActions.Add(p => p.FirstName = fname);
            return this;
        }

        public PersonBuilder AddLastName(string lname)
        {
            builderActions.Add(p => p.Surname = lname);
            return this;
        }

        public PersonBuilder Age(int age)
        {
            builderActions.Add(p => p.Age = age);
            return this;
        }

        public PersonBuilder DateOfBirth(DateTime dob)
        {
            builderActions.Add(p => p.DOB = dob);
            return this;
        }

        public PersonBuilder AddAddress(string addr)
        {
            builderActions.Add(p => p.Address = addr);
            return this;
        }

        public Person Build()
        {
            var person = new Person();
            builderActions.ForEach(ba => ba(person));
            return person;
        }
    }
}
