using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("пол должен быть  'M' or 'F'.");
                }
            }
        }

        public Person() { }

        public Person(string lastName, string firstName, DateTime dateOfBirth, char gender)
        {
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public Person(Person person)
        {
            LastName = person.LastName;
            FirstName = person.FirstName;
            DateOfBirth = person.DateOfBirth;
            Gender = person.Gender;
        }

        public void Input()
        {
            Console.WriteLine("Введите данные пользователя:");
            Console.Write("фамилия: ");
            LastName = Console.ReadLine();
            Console.Write("имя: ");
            FirstName = Console.ReadLine();
            Console.Write("Дата рождения (ММ/дд/гггг): ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("пол (M/F): ");
            Gender = Console.ReadLine().ToUpper()[0];
        }

        public void Output()
        {
            Console.WriteLine($"имя: {FirstName} {LastName}");
            Console.WriteLine($"день рождение: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"пол: {Gender}");
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}, {DateOfBirth.ToShortDateString()}, {Gender}";
        }

        public int GetAge()
        {
            int age = DateTime.Today.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }
    }
}

