using lab2;
using System;
class Program
{
    static void Task1()
    {
        Person person1 = new Person();
        person1.Input();
        Person person2 = new Person("Petrov", "Petr", new DateTime(1985, 5, 15), 'M');
        Person person3 = new Person("Sidorova", "Maria", new DateTime(1999, 12, 31), 'F');
        person1.Output();
        person2.Output();
        person3.Output();
        string person1String = person1.ToString();
        string person2String = person2.ToString();
        string person3String = person3.ToString();
        int age1 = person1.GetAge();
        int age2 = person2.GetAge();
        int age3 = person3.GetAge();

    }
    static void Task2()
    {
        Console.Write("Введите количество людей: ");
        int count = int.Parse(Console.ReadLine());

        Person[] people = new Person[count];

        for (int i = 0; i < count; i++)
        {
            people[i] = new Person();
            people[i].Input();
        }

        Console.WriteLine("Данные о людях:");

        foreach (Person person in people)
        {
            Console.WriteLine($"{person.LastName} {person.FirstName[0]}. {person.GetAge()} лет, {person.Gender}");
        }
    }
    static void Main(string[] args)
    {
        Task2();
        Task1();
    }
} 