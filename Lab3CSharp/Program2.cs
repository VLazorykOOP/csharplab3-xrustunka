using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Student : Person
{
    public int StudentId { get; set; }
    public string Major { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Student ID: {StudentId}, Major: {Major}");
    }
}

class Teacher : Person
{
    public string Department { get; set; }
    public string Subject { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Department: {Department}, Subject: {Subject}");
    }
}

class Staff : Person
{
    public string Position { get; set; }
    public int Salary { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Position: {Position}, Salary: {Salary}");
    }
}

class DepartmentChair : Teacher
{
    public string DepartmentName { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Department Name: {DepartmentName}");
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Person> people = new List<Person>();

        Console.WriteLine("Введіть інформацію про студента:");
        Student student = new Student();
        Console.Write("Ім'я: ");
        student.Name = Console.ReadLine();
        Console.Write("Вік: ");
        student.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write(" ID: ");
        student.StudentId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Статус: ");
        student.Major = Console.ReadLine();
        people.Add(student);

        Console.WriteLine("\nВведіть інформацію про вчителя:");
        Teacher teacher = new Teacher();
        Console.Write("Ім'я: ");
        teacher.Name = Console.ReadLine();
        Console.Write("Вік: ");
        teacher.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Кафедра: ");
        teacher.Department = Console.ReadLine();
        Console.Write("Предмет: ");
        teacher.Subject = Console.ReadLine();
        people.Add(teacher);

        Console.WriteLine("\nВведіть інформацію про персонал:");
        Staff staff = new Staff();
        Console.Write("Ім'я: ");
        staff.Name = Console.ReadLine();
        Console.Write("Вік: ");
        staff.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Статус: ");
        staff.Position = Console.ReadLine();
        Console.Write("Зарплата: ");
        staff.Salary = Convert.ToInt32(Console.ReadLine());
        people.Add(staff);

        Console.WriteLine("\nВведіть інформацію про завідувача кафедри:");
        DepartmentChair chair = new DepartmentChair();
        Console.Write("Ім'я: ");
        chair.Name = Console.ReadLine();
        Console.Write("Вік: ");
        chair.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Кафедра: ");
        chair.Department = Console.ReadLine();
        Console.Write("Предмет: ");
        chair.Subject = Console.ReadLine();
        Console.Write(" Спеціальність: ");
        chair.DepartmentName = Console.ReadLine();
        people.Add(chair);

        Console.WriteLine("\nВідсортований список за назвою:");
        people.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));

        // Виведення інформації про всіх об'єкти масиву
        foreach (var person in people)
        {
            person.Show();
            Console.WriteLine();
        }
    }
}
