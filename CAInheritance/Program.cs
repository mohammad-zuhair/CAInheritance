public class Program
{
    public static void Main(string[] args)
    {

        Manager mg = new Manager(1000, "mohammad", 180, 10);
        Maintanence mt = new Maintanence(1001, "salim .", 182, 8);
        Sales sa = new Sales(1002, "sally N.", 176, 9, 0.05m, 10000m);
        Developer d = new Developer(1003, "mohammad", 186, 15, true);
        Employee[] employees = { mg, mt, sa, d };

        foreach (var employee in employees)
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine(employee);
        }
        //Manager mg = new Manager
        //{
        //    Id = 1000,
        //    Name = "mohammad",
        //    LoggedHours = 180,
        //    Wage = 10
        //};

        //Maintanence mt = new Maintanence
        //{
        //    Id = 1001,
        //    Name = "salim .",
        //    LoggedHours = 182,
        //    Wage = 8
        //};


        //Sales sa = new Sales
        //{
        //    Id = 1002,
        //    Name = "sally N.",
        //    LoggedHours = 176,
        //    Wage = 9,
        //    Commission = 0.05m,
        //    SalesVolume = 10000m
        //};

        //Developer d = new Developer
        //{
        //    Id = 1003,
        //    Name = "Mohammad",
        //    LoggedHours = 186,
        //    Wage = 15,
        //    TaskCompleted = true

        //};


        //Employee[] employees = { mg, mt, sa, d };

        //foreach (var employee in employees)
        //{
        //    Console.WriteLine("\n----------------------------------");
        //    Console.WriteLine(employee);
        //}
    }
}
