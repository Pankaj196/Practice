using System;
namespace Practice
{
    public class PracticeTest
    {
        int eid;
        string ename;
        string dept;
        public int _sal { get; set; }
        public void Accept()
        {
            Console.WriteLine("Enter Eid: ");
            eid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ename : ");
            ename=(Console.ReadLine());
            Console.WriteLine("Enter Department: ");
            dept=(Console.ReadLine());
            Console.WriteLine("Enter Salary: ");
            _sal=Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Employee Details :");
            Console.WriteLine(eid + " " + ename + " " + dept+" "+_sal);
        }
    }
    public class WeeklyEmp : PracticeTest
    {
        int nooddays;
        int salperday;
        int totsal;
        public void Accept1()
        {
            Accept();
            Console.WriteLine("Enter Number of days:");
            nooddays=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SAlary per day:");
            salperday=Convert.ToInt32(Console.ReadLine());
        }
        public void Cal()
        {
            totsal =_sal+ (nooddays * salperday);
        }
        public void Display1()
        {
            Cal();
            Display();
            Console.WriteLine(nooddays + " " + salperday + " " + totsal);
        }
    }
public class HourlyEmp:PracticeTest
    {
        int noofhrs;
        int salperhr;
        int calsal;
        public void Accept2()
        {
            Accept();
            Console.WriteLine("Enetr no of hrs:");
            noofhrs=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entere Salary per hrs");
            salperhr=Convert.ToInt32(Console.ReadLine());
        }
        public void Cal1()
        {
            calsal = _sal + (noofhrs * salperhr);
        }
        public void Display2()
        {
            Cal1();
            Display();
            Console.WriteLine(noofhrs + " " + salperhr + " " + calsal);
        }
    }
    public class Final
    {
        public static void Main(String[] ar)
        {
            WeeklyEmp we =new WeeklyEmp();
            we.Accept1();
            
            we.Display1();
            HourlyEmp he=new HourlyEmp();
            he.Accept2();
            he.Display2();
        }
    }
}
