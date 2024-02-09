﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Student: Sophia Johnson

        //Course Grade   Credit Hours
        //English 101         4       3
        //Algebra 101         3       3
        //Biology 101         3       4
        //Computer Science I  3       4
        //Psychology 101      4       3

        //Final GPA:          3.35

        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;


        //Console.WriteLine($"{course1Name} {course1Grade}");
        //Console.WriteLine($"{course2Name} {course2Grade}");
        //Console.WriteLine($"{course3Name} {course3Grade}");
        //Console.WriteLine($"{course4Name} {course4Grade}");
        //Console.WriteLine($"{course5Name} {course5Grade}");

        //Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
        //Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
        //Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
        //Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
        //Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

        int totalCreditHours = 0;
        totalCreditHours += course1Credit;
        totalCreditHours += course2Credit;
        totalCreditHours += course3Credit;
        totalCreditHours += course4Credit;
        totalCreditHours += course5Credit;

        int totalGradePoints = 0;
        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        //Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

        //Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
        //Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
        //Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
        //Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
        //Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

        //Console.WriteLine($"{totalGradePoints} {totalCreditHours}");



        //decimal gradePointAverage = totalGradePoints / totalCreditHours;
        decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

        //Console.WriteLine($"Final GPA: {gradePointAverage}");

        int leadingDigit = (int)gradePointAverage;
        int firstDigit = (int)(gradePointAverage * 10) % 10;
        int secondDigit = (int)(gradePointAverage * 100) % 10;

        //Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
        //Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
        //Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
        //Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
        //Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

        //Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");

        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

        Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
        Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
        Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
        Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
        Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

        Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

       // Console.WriteLine($"Student: {studentName}\n");



    }
}
