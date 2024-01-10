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

            //how to update a key in a dictionary
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR","Eleka",26,18);
                Console.WriteLine($"Employee/Role {keyToUpdate} was updated");
            }

            //how to remove a key
            string keyToRemove = "Intern";
            if (employeesDirectory.ContainsKey(keyToRemove))
            {
                employeesDirectory.Remove(keyToRemove);
                Console.WriteLine($"Employee/Role {keyToRemove} has been deleted");
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine($"\nKey: {keyValuePair.Key}");

                Employee emplValue = keyValuePair.Value;

                Console.WriteLine($"Employee name: {emplValue.Name}, Role:" +
                    $" {emplValue.Role}, Age: {emplValue.Age}, Salary: ${emplValue.Salary}");
            }

        }

    }

}



