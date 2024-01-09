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

           

            List<Student> students = new List<Student>();

            students.Add(new Student(1, "Raen", 3.9f));
            students.Add(new Student(2, "Nicole", 4.5f));
            students.Add(new Student(3, "Carmen", 3.4f));
            students.Add(new Student(4, "Victor", 1.9f));
            students.Add(new Student(1, "Liam", 3.7f));

            for (int i = 0; i < students.Count; i++)
            {
                if (!studentsTable.ContainsKey(students[i].Id))
                {
                    studentsTable.Add(students[i].Id, students[i]);
                }
                else
                {
                    Console.WriteLine("Sorry this student is already in the table");
                }
            }
            foreach (Student item in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}",item.Id,item.Name,item.GPA);
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
