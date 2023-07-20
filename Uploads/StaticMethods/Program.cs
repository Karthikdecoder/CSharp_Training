class Student
{
    private int grade = 2;

    public void PrintGrade()
    {
        System.Console.WriteLine(grade);
    }

    public ref int DoWork()
    {
        return ref grade;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.PrintGrade();

        ref int g = ref s.DoWork();

        g = 5;

        s.PrintGrade();

        System.Console.ReadKey();
    }
}
