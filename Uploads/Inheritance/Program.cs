public class Employee
{
    private int _empId;
    private string _empName;
    private string _location;

    public int EmpId
    {
        set
        {
            _empId = value;
        }
        get
        {
            return _empId;
        }
    }

    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }

    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location;
        }
    }
}

public class Manager : Employee
{
    private string _DepartmentName;

    public string DepartmentName
    {
        set { _DepartmentName = value; }
        get { return _DepartmentName; }
    }

    public int GetSaleOfTheYear()
    {
        return 1000;
    }
}

public class SalesMan : Employee
{
    private string _region;

    public string Region
    {
        set { _region = value; }
        get { return _region; }
    }

    public long GetSalesOfTheMonth()
    {
        return 150;
    }
}

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Inheritance implementation");
        System.Console.WriteLine();

        Employee e = new Employee();
        e.EmpId = 1;
        e.EmpName = "Daniel";
        e.Location = "Mumbai";
        System.Console.WriteLine("Object of parent class");
        System.Console.WriteLine(e.EmpId);
        System.Console.WriteLine(e.EmpName);
        System.Console.WriteLine(e.Location);
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}
