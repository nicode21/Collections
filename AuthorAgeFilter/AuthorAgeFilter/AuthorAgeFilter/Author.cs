using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorAgeFilter
{
    public class Author
    {
        public int Age { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public static List<Author> List = new List<Author>();


        public Author(int age, string name, string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;

        }

        public void GetFilteredAuthor(List<Author> list)
        {
            List = list;

            var result = List.FindAll(m => m.Age > 40);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }


        }
    }
}
