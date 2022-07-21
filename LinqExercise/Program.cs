using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("The sum of the numbers:");
            Console.WriteLine(numbers.Sum(num => num));

            //TODO: Print the Average of numbers
            Console.WriteLine("The average of the numbers:");
            Console.WriteLine(numbers.Average(num => num));

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order:");
            var ascendingNums = numbers.OrderBy(x => x).ToArray();
            foreach (var num in ascendingNums)
            {
                Console.WriteLine(num);
            }

            //TODO: Order numbers in decsending order adn print to the console
            Console.WriteLine("Numbers in descending order:");
            var descendingNums = numbers.OrderByDescending(x => x).ToArray();
            foreach (var num in descendingNums)
            {
                Console.WriteLine(num);
            }

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Only the numbers greater than 6:");
            var numsOverSix = numbers.Where(num => num > 6).ToArray();
            foreach (var num in numsOverSix)
            {
                Console.WriteLine(num);
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Only the first four numbers:");
            var firstFourNumbers = numbers.Where(num => num < 4).ToArray();
            foreach (var num in firstFourNumbers)
            {
                Console.WriteLine(num);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Numbers in descending order with my age in the 4th index:");
            numbers[4] = 23;
            numbers.OrderByDescending(num => num).ToArray();
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("Printing employee names starting with C or an S:");
            var employeesFilteredByNames = employees.Where(person => person.FirstName[0] == 'C' || person.FirstName[0] == 'S');
            foreach(var employee in employeesFilteredByNames)
            {
                Console.WriteLine(employee.FullName);
            }


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Printing every employee who is over the age of 26:");
            var employeesOlderThan26 = employees.Where(person => person.Age > 26);
            foreach(var employee in employeesOlderThan26)
            {
                Console.WriteLine($"{employee.FullName}. Age: {employee.Age}");
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("Printing the sum and average of employees years of experience if less than or equal to 10 and their age is greater than 35.");
            var filteredEmployees = employees.Where(person => person.YearsOfExperience <= 10 && person.Age > 35);
            Console.WriteLine($"The average of these employees years of experience is {filteredEmployees.Average(person => person.YearsOfExperience)}" +
                $" and the sum is {filteredEmployees.Sum(person => person.YearsOfExperience)}.");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("We've got a new hire! Here's our updated list of employees:");
            var updatedList = employees.Append(new Employee { Age = 20, FirstName = "Bilbo", LastName = "Baggins", YearsOfExperience = 0});
            foreach(var employee in updatedList)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
