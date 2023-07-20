class Sample
{
    public void DisplayMarks(int mark1, int mark2, int mark3)
    {

        System.Console.WriteLine("Mark 1: " + mark1);
        System.Console.WriteLine("Mark 2: " + mark2);
        System.Console.WriteLine("Mark 3: " + mark3);

        System.Console.WriteLine();
        double avgMark = GetAverageMarks();
        System.Console.WriteLine("Average mark: " + avgMark);

        double GetAverageMarks()
        {
            double avg;
            avg = (double)(mark1 + mark2 + mark3) / 3;
            return avg;
        }
    }

}
class Program
{
    static void Main()
    {
        Sample s = new Sample();

        s.DisplayMarks(1, 2, 3);

        System.Console.ReadKey();
    }
}
