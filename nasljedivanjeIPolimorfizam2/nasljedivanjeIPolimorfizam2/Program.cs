using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanjeIPolimorfizam2
{
    public class Dessert
    {
        private string name;
        private double weight;
        private int calories;
        }
    public class Cake : Dessert
    {
        private bool containsGluten;
        private string cakeType;
        }
    public class IceCream : Dessert
    {
        private string flavour;
        private string color;
        }
    public class Person
    {
        private string name;
        private string surname;
        private int age;
        }
    public class Student : Person
    {
        private string studentId;
        private short academicYear;
        }
    public class Teacher : Person
    {
        private string email;
        private string subject;
        private double salary;
        }
    public class CompetitionEntry
    {
        private Teacher teacher;
        private Dessert dessert;
        private List<Student> students = new List<Student>();
        private List<int> ratings = new List<int>();
        }
    public class UniMasterChef
    {
        private CompetitionEntry[] entries;
        private int count = 0;
        }
    public static void Main(string[] args)
    {
        Dessert genericDessert = new Dessert("Chocolate Mousse", 120, 300);
        Cake cake = new Cake("Raspberry chocolate cake #3", 350.5, 400, false, "birthday");
        Teacher t1 = new Teacher("Dario", "Tušek", 42, "dario.tusek@fer.hr", "OOP", 10000);
        Teacher t2 = new Teacher("Doris", "Bezmalinović", 43, "doris.bezmalinovic@fer.hr", "OOP", 10000);
        Student s1 = new Student("Janko", "Horvat", 18, "0036312123", 1);
        Student s2 = new Student("Ana", "Kovač", 19, "0036387656", 2);
        Student s3 = new Student("Ivana", "Stanić", 19, "0036392357", 1);
        UniMasterChef competition = new UniMasterChef(2);
        CompetitionEntry e1 = new CompetitionEntry(t1, genericDessert);
        competition.AddEntry(e1);
        Console.WriteLine("Entry 1 rating: " + e1.GetRating());
        e1.AddRating(s1, 4);
        e1.AddRating(s2, 5);
        Console.WriteLine("Entry 1 rating: " + e1.GetRating());
        CompetitionEntry e2 = new CompetitionEntry(t2, cake);
        e2.AddRating(s1, 4);
        e2.AddRating(s3, 5);
        e2.AddRating(s2, 5);
        competition.AddEntry(e2);
        Console.WriteLine("Entry 2 rating: " + e2.GetRating());
        Console.WriteLine("Best dessert is: " + competition.GetBestDessert().Name);
        Person[] e2persons = UniMasterChef.GetInvolvedPeople(e2);

        foreach (Person p in e2persons)
        {
            Console.WriteLine(p);
        }
    }

}
