using Collections.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region HomeWork
            //DateTime startDate = DateTime.Now.AddDays(-2);
            //DateTime endDate = DateTime.Now.AddDays(25);

            //double salary = 2000;

            //double salary = 2000;

            //IEmployeeService employeeService = new EmployeeService();

            //int result = employeeService.GetFilteredEmployeesCount(startDate,endDate,salary);

            //Console.WriteLine(result);


            //var result = GetEmployeeCount(startDate,endDate,salary);

            //Console.WriteLine("Persont count: " + result);


            //Celcius celcius = new Celcius(36);

            //Kelvin kelvin = celcius;

            //Console.WriteLine(kelvin.Degree);
            #endregion

            #region Lists
            //int [] arr = { 1,2,3,4};

            //Console.WriteLine(arr.Length);


            //List<int> nums = new List<int>() { 200,300,400,500};

            //List<int> numbers = new List<int>();

            //numbers.Add(5);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(3);

            //numbers.AddRange(nums);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = numbers.Contains(5);

            //var result = numbers.Find(m=>m>100);

            //var result = numbers.FindAll(m => m > 100);

            //var result = numbers.FindIndex(m => m > 100);

            //Console.WriteLine(result);

            //numbers.Sort();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers.ToArray();

            //var result2 = result.ToList();

            //var result = numbers.BinarySearch(9);
            //var result2 = numbers.FindIndex(m=>m==100);

            //Console.WriteLine(result);

            //if (result)
            //{
            //    Console.WriteLine("Yes");
            //}

            //Console.WriteLine(result);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(numbers[2]);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}



            //var result = names.FindAll(m => m == "Nicat");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var searchText = Console.ReadLine();

            //var result = Search( searchText);

            //if (result.Count==0)
            //{
            //    Console.WriteLine("Not found");
            //}
            //else
            //{
            //    Console.WriteLine(result.Count);

            //}



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> people = new List<Person>();

            //people.Add(new Person{ FullName= "Qoshqar Nerimanli" , Birthday = DateTime.Now.AddDays(-10), Salary = 1500});
            //people.Add(new Person{ FullName= "Ramil Allahverdiyev" , Birthday = DateTime.Now.AddDays(10), Salary = 1700});
            //people.Add(new Person{ FullName= "Nihad Veliyev" , Birthday = DateTime.Now.AddDays(12), Salary = 1800});
            //people.Add(new Person{ FullName= "Gultac Ceferova" , Birthday = DateTime.Now.AddDays(10), Salary = 2500});

            //var result = people.FindAll(m=>m.Salary>1500 && m.FullName.StartsWith("R"));

            //foreach (var person in result)
            //{
            //    Console.WriteLine("Fullname : {0} , Birthday : {1} , Salary : {2}" , person.FullName,person.Birthday,person.Salary);
            //}
            #endregion


            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1,"Resul");
            //hashtable.Add(2,"Nicat");
            //hashtable.Add(3,"Vugar");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList sortedList = new SortedList();

            //sortedList.Add(1, "Resul");
            //sortedList.Add(2, "Nicat");
            //sortedList.Add(3, "Vugar");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}


            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("salam");
            //arrayList.Add(155);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //SortedList<string,string> list = new SortedList<string, string>();

            ////list.Add(1,"adsd"); 
            //list.Add("Admin","Qoshqar"); 
            //list.Add("Member","Test");

            //foreach (/*DictionaryEntry*/KeyValuePair<string,string> item in list)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}


            //Dictionary <string,string> dictionaryList = new Dictionary<string, string>();

            //dictionaryList.Add("Admin","Ramil");

            //foreach (/*DictionaryEntry*/KeyValuePair<string, string> item in dictionaryList)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Console.WriteLine(dictionaryList["Admin"]);


            //Queue<int> queue  = new Queue<int>();

            //queue.Enqueue(5);
            //queue.Enqueue(10);
            //queue.Enqueue(3);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}



            //Stack<int> stack = new Stack<int>();

            //stack.Push(11);
            //stack.Push(22);
            //stack.Push(3);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

        }



        private static List<string> Search(string str)
        {
            List<string> names = new List<string>() { "Resul", "Nicat", "Novreste", "Gultac", "Lale" };

            return names.FindAll(m => m.ToLower().Contains(str.ToLower()));
        }

        //public static int GetEmployeeCount(DateTime start,DateTime end,double salary)
        //{

        //    Person person1 = new Person(DateTime.Now.AddDays(5), 3000);
        //    Person person2 = new Person(DateTime.Now.AddDays(15), 6000);
        //    Person person3 = new Person(DateTime.Now.AddDays(10), 1000);
        //    Person person4 = new Person(DateTime.Now.AddDays(25), 2500);

        //    Person[] people = { person1, person2, person3, person4 };
                
        //    int empCount = 0;

        //    foreach (Person emp in people)
        //    {
        //        if ((emp.Birthday > start && emp.Birthday < end) && emp.Salary > salary)
        //        {
        //            empCount++;
        //        }

        //    }
        //    return empCount;
        //}
    }
}
