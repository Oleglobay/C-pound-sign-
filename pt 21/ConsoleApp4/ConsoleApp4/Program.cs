using System;

class Man
{
    protected string name;
    protected int age;

    public Man(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    public void SetAge(int newAge)
    {
        age = newAge;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Ім'я: {name}, Вік: {age}");
    }
}

class Student : Man
{
    private string speciality;

    public Student(string name, int age, string speciality)
        : base(name, age)
    {
        this.speciality = speciality;
    }

    public void SetSpeciality(string newSpeciality)
    {
        speciality = newSpeciality;
    }

    public void ChangeSpeciality(string newSpeciality)
    {
        SetSpeciality(newSpeciality);
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Спеціальність: {speciality}");
    }
}

class Program
{
    static void Main()
    {
        Man person = new Man("John", 25);
        Console.WriteLine("Інформація про людину:");
        person.DisplayInfo();

        person.SetName("Jane");
        person.SetAge(30);
        Console.WriteLine("Інформація про людину після змін:");
        person.DisplayInfo();

        Student student = new Student("Bob", 22, "Computer Science");
        Console.WriteLine("\nІнформація про студента:");
        student.DisplayInfo();

        student.ChangeSpeciality("Software Engineering");
        Console.WriteLine("Інформація про студента після змін:");
        student.DisplayInfo();
    }
}
