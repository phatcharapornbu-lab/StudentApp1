using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// คลาสนักศึกษา
class Student

{
    public string Name { get; set; } = "";
    public string StudentID { get; set; } = "";
    public int Score { get; set; }

    public string GetGrade()
    {
        if (Score >= 80) return "A";
        else if (Score >= 75) return "B+";
        else if (Score >= 70) return "B";
        else if (Score >= 65) return "C+";
        else if (Score >= 60) return "C";
        else if (Score >= 55) return "D+";
        else if (Score >= 50) return "D";
        else return "F";
    }
}


class Course
{
    public int GetMinScore()
    {
        return Students.Count > 0 ? Students.Min(s => s.Score) : 0;
    }
    public string CourseName { get; set; } = "";
    public string CourseID { get; set; } = "";
    public List<Student> Students { get; set; } = new List<Student>();

   
    public void AddStudent(Student s)
    {
        Students.Add(s);
    }

    
    public int GetMaxScore()
    {
        return Students.Count > 0 ? Students.Max(s => s.Score) : 0;
    }

    public double GetAverageScore()
    {
        return Students.Count > 0 ? Students.Average(s => s.Score) : 0;
    }

    
    public void ShowStudents()
    {
        foreach (var s in Students)
        {
            Console.WriteLine($"{s.Name} ({s.StudentID}) Score: {s.Score} Grade: {s.GetGrade()}");
        }
    }
}


class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("1. เพิ่มนักศึกษา");
        Console.WriteLine("2. แสดงข้อมูล");
        Console.WriteLine("3. ออกจากโปรแกรม");
        {
            Course course = new Course
            {
                CourseName = "OOP Programming",
                CourseID = "CS101"
            };

            while (true)
            {
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("กรุณาใส่ตัวเลขใหม่: ");
                }

                if (choice == 1)
                {
                    Student s = new Student
                    {
                        Name = "",
                        StudentID = ""
                    };

                    Console.Write("ชื่อ: ");
                    string input = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(input))
                    {
                        Console.Write("กรุณาใส่ชื่อ: ");
                        input = Console.ReadLine();
                    }

                    s.Name = input;

                    Console.Write("รหัส: ");
                    s.StudentID = Console.ReadLine() ?? "";

                    Console.Write("คะแนน: ");
                    int score;
                    string inputScore = Console.ReadLine();

                    while (!int.TryParse(inputScore, out score))
                    {
                        Console.Write("กรุณาใส่คะแนนเป็นตัวเลข: ");
                        inputScore = Console.ReadLine();
                    }
                    s.Score = score;

                    course.AddStudent(s);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n--- ข้อมูลนักศึกษาทั้งหมด ---");
                    course.ShowStudents(); // เรียกใช้ Method สำหรับแสดงชื่อ เกรด และคะแนน

                    // (ทางเลือกเพิ่มเติม) แสดงสถิติคะแนน
                    if (course.Students.Count > 0)
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine($"คะแนนสูงสุด: {course.GetMaxScore()}");
                        Console.WriteLine($"คะแนนต่ำสุด: {course.GetMinScore()}");
                        Console.WriteLine($"คะแนนเฉลี่ย: {course.GetAverageScore():F2}");
                        Console.WriteLine("-------------------------");
                    }
                }
                else if (choice == 3)
                {
                    break;
                }
            }
        }
    }
}