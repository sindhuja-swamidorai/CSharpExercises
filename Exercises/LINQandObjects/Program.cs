// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using System.Reflection;
using People;

Console.WriteLine("Hello, World!");

List<Person> people = GetPeople();

//GetMalesUnder25(people);
AveregeAgePerGender(people);


void GetMalesUnder25(List<Person> people)
{
    List<Person> result = (from p in people where p.Gender == "Male" && p.Age < 25 select p).ToList();

    Console.WriteLine("List of males under 25:");
    foreach (Person p in result)
    {
        p.DisplayPerson();
    }
}

void AveregeAgePerGender(List<Person> people)
{
    List<IGrouping <string,int>> result ;

    result = (from p in people group p.Age by p.Gender).ToList();

    Console.WriteLine("Average age of males and females in the group:");

    for(int i=0; i < result.Count; i++)
    {
        Console.WriteLine($"{result[i].Key}: {result[i].Average()}");
    }
}


static List<Person> GetPeople()
{
    List<Person> persons = new List<Person>();

    for (int i = 0; i < 20; i++)
    {
        Person singlePerson = new Person();
        singlePerson.Name = $"Name{i}";
        singlePerson.Age = new Random().Next(10, 60);
        singlePerson.Gender = (i % 3 == 0) ? "Male" : "Female";
        singlePerson.DisplayPerson();
        persons.Add(singlePerson);
    }

    return persons;
}


namespace People
{
    public class Person
    {
        private string name;
        private string gender;
        private int age;
        private string homeTown;

        public string Name { get { return name; } set { name = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public int Age { get { return age; } set { age = value; } }

        public string HomeTown { get { return homeTown; } set { homeTown = value; } }

        public Person()
        {
            name = "xyz";
            gender = "male";
            age = 60;
            homeTown = "Bengaluru";
        }

        public void DisplayPerson()
        {
                Console.WriteLine(name);
                Console.WriteLine(gender);
                Console.WriteLine(age);
                Console.WriteLine(homeTown);
        }

    }

}
