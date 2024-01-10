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
            Employee[] employees = {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Raen", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),

            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();


            foreach (Employee item in employees)
            {
                employeesDirectory.Add(item.Role, item);
            }
            //how to fetch a single entry in a dictionary
            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory["CEO"];
                Console.WriteLine("This value has been retrived");
                Console.WriteLine($"Employee name: {empl.Name}, Role: {empl.Role}, Age: {empl.Age}, Salary: ${empl.Salary}");
            }
            else {
                Console.WriteLine("This key does not exist");
            }

            Employee result = null;
            //this is the try and get value way of getting data
            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("\nThis value has been retrived");
                Console.WriteLine($"Employee name: {result.Name}, Role: {result.Role}, Age: {result.Age}, Salary: ${result.Salary}");
            }

            //using keyvaluepair to iterate over the dictionaary
            for (int i = 0; i < employeesDirectory.Count; i++) {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine($"\nKey: {keyValuePair.Key}");

                Employee emplValue = keyValuePair.Value;

                Console.WriteLine($"Employee name: {emplValue.Name}, Role:" +
                    $" {emplValue.Role}, Age: {emplValue.Age}, Salary: ${emplValue.Salary}");
            }
           
        }

    }

}



