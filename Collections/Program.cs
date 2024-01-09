using System.Collections;
using System.Threading.Channels;
using System.Formats.Asn1;
using System;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        //Key - Value
        //Auto - Car
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            //creating students to put in a hash table
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            //store data in hashtable
            studentsTable.Add(stud1.Id,stud1);
            studentsTable.Add(stud2.Id,stud2);
            studentsTable.Add(stud3.Id,stud3);
            studentsTable.Add(stud4.Id,stud4);

            //this will retrive an individual item
            Student storeStudent1 = (Student)studentsTable[1];

            //this will retrieve all items from the dictionaryentry way
            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;

                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", temp.Id, temp.Name, temp.GPA);
            }
            Console.WriteLine("\nStudent ID: {0}, Name: {1}, GPA: {2}",storeStudent1.Id,storeStudent1.Name,storeStudent1.GPA);

            //this is a more simplfied version of what we did on getting the data
            Console.WriteLine("\nSimplified version ");
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", value.Id, value.Name, value.GPA);

            }
        }

    }
    class Student { 
    
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }

    }
}
