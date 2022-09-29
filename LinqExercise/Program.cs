using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

            //DONE: Print the Sum of numbers
                        
            Console.WriteLine("---------Sum of Numbers-------------------");
            Console.WriteLine();
            var sumOfNumbers = numbers.Sum(numbers => numbers);
            Console.WriteLine(sumOfNumbers);
            Console.WriteLine();

            //DONE: Print the Average of numbers

            Console.WriteLine("---------Average of Numbers-------------------");
            Console.WriteLine();
            var avgOfNumbers = numbers.Average(numbers => numbers);
            Console.WriteLine(avgOfNumbers);
            Console.WriteLine();

            //DONE: Order numbers in ascending order and print to the console

            Console.WriteLine("---------Asending Numbers-------------------");
            Console.WriteLine();
            var ascendingNumbers = numbers.OrderBy(numbers => numbers);
            foreach (var num in ascendingNumbers)
            {
                Console.Write($"{num}   ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Order numbers in descending order adn print to the console

            Console.WriteLine("---------Descending Numbers-------------------");
            Console.WriteLine();
            var descendingNumbers = numbers.OrderByDescending(numbers => numbers);
            foreach (var num in descendingNumbers)
            {
                Console.Write($"{num}   ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //DONE: Print to the console only the numbers greater than 6

            Console.WriteLine("---------Numbers Greater Than 6-------------------");
            Console.WriteLine();
            var numsOver6 = numbers.Where(x => x > 6);
            foreach (var num in numsOver6)
            {
                Console.Write($"{num}   ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //DONE: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("---------Return First 4 Numbers-------------------");
            Console.WriteLine();            
            foreach (var num in numbers.Take(4))
            {
                Console.Write($"{num}   ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //DONE: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("---------Insert My Age and Descend List-------------------");
            Console.WriteLine();
            numbers[4] = 36;
            var myAge = numbers.OrderByDescending(x => x);
            foreach (var num in myAge)
            {
                Console.Write($"{num}   ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            Console.WriteLine("---------Full Employee List By First Name With Age and YOE-------------------");
            Console.WriteLine();
            foreach (var item in employees)
            {
                Console.WriteLine($"Name: {item.FullName} - Age: {item.Age} - YOE: {item.YearsOfExperience}");                
            }
            Console.WriteLine();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S
            //and order this in acesnding order by FirstName.

            Console.WriteLine("---------Alphabetical Employee's with C or S First Initial-------------------");
            Console.WriteLine();
            var firstNameCorS = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName);
            foreach (var item in firstNameCorS)
            {
                Console.WriteLine($"Name: {item.FullName} - Age: {item.Age} - YOE: {item.YearsOfExperience}");
            }
            Console.WriteLine();

            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first
            //and then by FirstName in the same result.

            Console.WriteLine("---------Ordered By Age Then First Name-------------------");
            Console.WriteLine();
            var orderedEmployees = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var item in orderedEmployees)
            {
                Console.WriteLine($"Name: {item.FullName} - Age: {item.Age} - YOE: {item.YearsOfExperience}");
            }
            Console.WriteLine();

            //DONE: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to
            //10 AND Age is greater than 35

            Console.WriteLine("---------Combined Years of Experience Metrics for Employees Over 35 with Less Than 10 YOE-------------------");
            Console.WriteLine();
            var combinedYOE = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Sum(x => x.YearsOfExperience);
            var avgYOE = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Average(x => x.YearsOfExperience);
            Console.WriteLine($"Combined Years of Experience: {combinedYOE}");
            Console.WriteLine($"Average Years of Experience: {avgYOE}");
            Console.WriteLine();

            //DONE: Add an employee to the end of the list without using employees.Add()

            Console.WriteLine("---------New Employee Added-------------------");
            Console.WriteLine();
            var newEmployee = new Employee("Jacob", "Phillips", 36, 0);
            var newEmployeeList = employees.Append(newEmployee);
            foreach (var item in newEmployeeList)
            {
                Console.WriteLine($"Name: {item.FullName} - Age: {item.Age} - YOE: {item.YearsOfExperience}");
            }
            Console.WriteLine();

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
