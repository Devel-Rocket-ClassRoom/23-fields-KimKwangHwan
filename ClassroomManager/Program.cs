using System;

ClassroomManager class1 = new ClassroomManager("1반");
class1.AddStudent("홍길동");
class1.AddStudent("김철수");
class1.AddStudent("이영희");
class1.ShowStudents();
Console.WriteLine();

ClassroomManager class2 = new ClassroomManager("2반");
class2.AddStudent("박민수");
class2.AddStudent("정수진");
class2.ShowStudents();
Console.WriteLine();

ClassroomManager.ShowTotalClassrooms();



class ClassroomManager
{
    private const int MaxStudentCont = 5;
    private readonly string class_name;
    private string[] students;
    private int current_student_count = 0;
    private static int ClassroomCount;

    public ClassroomManager(string class_name)
    {
        this.class_name = class_name;
        students = new string[MaxStudentCont];
        ClassroomCount++;
    }

    public void AddStudent(string name)
    {
        if (current_student_count >= MaxStudentCont)
        {
            Console.WriteLine($"{class_name} 교실의 정원이 초과되었습니다.");
            return;
        }
        students[current_student_count++] = name;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {class_name} 학생 목록 ({current_student_count}/{MaxStudentCont}) ===");
        for (int i = 0; i < current_student_count; i++)
        {
            Console.WriteLine($"{i + 1}. {students[i]}");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {ClassroomCount}");
    }
}