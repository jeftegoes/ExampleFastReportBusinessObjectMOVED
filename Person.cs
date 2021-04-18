using System.Collections.Generic;

namespace ExampleFastReportBusinessObject
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public List<Person> GetPersons()
        {
            var persons = new List<Person>() {
                new Person() { Id = 1, Name = "Bob", Surname = "Marley", Age = 35 },
                new Person() { Id = 2, Name = "Bono", Surname = "Vox", Age = 55 },
                new Person() { Id = 3, Name = "Madonna", Surname = "Louise", Age = 65 },
                new Person() { Id = 3, Name = "Serj", Surname = "Tarkian", Age = 23 }
            };

            return persons;
        }
    }
}