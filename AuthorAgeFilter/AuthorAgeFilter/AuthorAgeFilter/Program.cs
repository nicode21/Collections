using System;
using System.Collections.Generic;

namespace AuthorAgeFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> list = new List<Author>();

            Author aut1 = new Author(20, "Nicat", "Novruzzade");
            Author aut2 = new Author(50, "Hesen", "Hesenli");
            Author aut3 = new Author(60, "Murad", "Muradov");


            list.Add(aut1);
            list.Add(aut2);
            list.Add(aut3);


            aut3.GetFilteredAuthor(list);
        }
    }
}
