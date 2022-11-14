// Milan Murray 2022 Nov 13
// Collections & Generics

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace School;

public enum Gender { Male, Female }

public class Student
{
    public String ID { get; set; }
    public String Name { get; set; }
    public Gender sGender { get; set; }

    public Student(String idIn, String nameIn, Gender genderIn)
    {
        ID = idIn;
        Name = nameIn;
        sGender = genderIn;
    }
}

public class StudentClass : IEnumerable
{
    public String CRN { get; set; }
    public String LecturerName { get; set; }

    List<Student> students;

    public StudentClass(String crnIn, String nameIn)
    {
        this.CRN = crnIn;
        this.LecturerName = nameIn;

        students = new List<Student>();
    }

    public void AddStudent(Student studentIn)
    {
        foreach (Student s in students)
        {
            if (s.ID == studentIn.ID)
            {
                throw new ArgumentException("Duplicate of student number in class");
            }
        }
        students.Add(studentIn);
    }

    // Indexer based on int
    public Student this[int i]
    {
        get
        {
            // validate index values
            if ((i >= 0) && (i < students.Count))
            {
                return students[i];
            }
            else
            {
                throw new ArgumentException("Error: studuent index out of range");
            }
        }
    }

    // Indexer based a String
    public Student this[String idIn]
    {
        get
        {
            // find matching student and return

            Student student = students.FirstOrDefault(s => s.ID == idIn);
            if (student != null)
            {
                return student;
            }
            else
            {
                throw new ArgumentException("no matching student found");
            }

            // alternative to LINQ: iterate using a loop to find matching student based on ID and return
        }
    }

    // iterate over student collection - foreach now possible on a StudentClass
    public IEnumerator GetEnumerator()
    {
        foreach (Student student in students)
        {
            yield return student;                   // iterator
        }
    }

    // public override string ToString()
    // {
    //     String allStudents = "";
    //     if (students.Count !<= 0)
    //     {
    //         for (int i = 0; i < students.Count - 1; i++)
    //         {
    //             allStudents += students[i].Name + " ";
    //         }
    //         allStudents += students.Last().Name + ".";

    //     }

    //     return $"CRN: {CRN}\nLecturer: {LecturerName}\nStudents: {allStudents}";
    // }
}

public class TestClass
{
    public static void Main()
    {
        // See test class


        // Student s = new Student("1234", "John", Gender.Male);
        // StudentClass sc = new StudentClass("tud123", "Jackie");
        // sc.AddStudent(s);
        // Console.WriteLine(sc);
    }
}
