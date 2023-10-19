using System;
using System.Collections.Generic;

// Абстрактный класс
abstract class JobApplicant
{
    public string Name { get; }
    public int Age { get; }

    // Конструктор
    public JobApplicant(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Абстрактный метод
    public abstract void ApplyForJob(string position);

    // Виртуальный метод
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Applicant: {Name}, Age: {Age}");
    }
}

// Наследник 1
class FreshGraduate : JobApplicant
{
    public string University { get; }

    // Конструктор
    public FreshGraduate(string name, int age, string university) : base(name, age)
    {
        University = university;
    }

    // Переопределение абстрактного метода
    public override void ApplyForJob(string position)
    {
        Console.WriteLine($"Fresh Graduate {Name} is applying for the position of {position}.");
    }

    // Переопределение виртуального метода
    public override void DisplayInfo()
    {
        Console.WriteLine($"Fresh Graduate: {Name}, Age: {Age}, University: {University}");
    }
}

// Наследник 2
class ExperiencedCandidate : JobApplicant
{
    public string PreviousCompany { get; }

    // Конструктор 1
    public ExperiencedCandidate(string name, int age) : base(name, age)
    {
        PreviousCompany = "Unknown";
    }

    // Конструктор 2
    public ExperiencedCandidate(string name, int age, string previousCompany) : base(name, age)
    {
        PreviousCompany = previousCompany;
    }

    // Переопределение абстрактного метода
    public override void ApplyForJob(string position)
    {
        Console.WriteLine($"Experienced Candidate {Name} from {PreviousCompany} is applying for the position of {position}.");
    }

    // Переопределение виртуального метода
    public override void DisplayInfo()
    {
        Console.WriteLine($"Experienced Candidate: {Name}, Age: {Age}, Previous Company: {PreviousCompany}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов классов
        FreshGraduate graduate = new FreshGraduate("John", 22, "ABC University");
        ExperiencedCandidate candidate1 = new ExperiencedCandidate("Jane", 30);
        ExperiencedCandidate candidate2 = new ExperiencedCandidate("Mark", 28, "XYZ Company");

        // Вызов методов
        graduate.ApplyForJob("Software Developer");
        candidate1.ApplyForJob("Project Manager");
        candidate2.ApplyForJob("Sales Executive");

        // Вызов методов для отображения информации
        graduate.DisplayInfo();
        candidate1.DisplayInfo();
        candidate2.DisplayInfo();
    }
   // В этой программе есть абстрактный класс JobApplicant, являющийся базовым классом для двух
   // наследников: FreshGraduate и ExperiencedCandidate.У каждого класса есть свои уникальные
   // свойства и конструкторы.Класс JobApplicant имеет абстрактный метод ApplyForJob, который
   // каждый наследник переопределяет под свои нужды.Есть также виртуальный метод DisplayInfo,
   // который также может быть переопределен в каждом наследнике.
   // В методе Main создаются объекты классов и вызываются их методы.
   // Каждый объект представляет соискателя на работу - выпускника, кандидата с опытом работы и т.д.
   // Они применяются для определенных должностей и отображают свою информацию.
   // Таким образом, программа демонстрирует использование абстрактных классов,
   // наследования, методов и свойств на чтение-запись, а также использование
   // конструкторов для создания объектов в контексте бюро по трудоустройству.
}
