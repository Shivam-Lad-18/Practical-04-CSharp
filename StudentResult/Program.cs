namespace StudentResult
{
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.Write("Enter student name : ");
            student1.Name = Console.ReadLine();
            Console.WriteLine("Enter student marks : ");
            for (int i = 0; i < student1.Marks.Length; i++)
            {
                Console.Write($"Enter marks of subject {i + 1} : ");
                student1.Marks[i] = Convert.ToDecimal(Console.ReadLine());
            }
            int choice;
            do{
                Console.WriteLine($"Enter choice : \n" +
                    $"1 - Aggregate: Displays the Name: Average marks \r\n2 - MinMark: Displays the minimum marks of the student\r\n3 - " +
                    $"MaximumMark: Displays the maximum mark\r\n4 - Grade: Displays grade\r\n0 - Exit Application ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch ((Options)choice)
                {
                    case Options.Aggregate:
                        Console.WriteLine($"{student1.Name} : {student1.CalculateAverageMarks()}");
                        break;
                    case Options.MinMark:
                        Console.WriteLine($"{student1.Name} : {student1.Marks.Min()}");
                        break;
                    case Options.MaximumMark:
                        Console.WriteLine($"{student1.Name} : {student1.Marks.Max()}");
                        break;
                    case Options.Grade:
                        Console.WriteLine($"{student1.Name} : {student1.CalculateGrade(student1.CalculateAverageMarks())}");
                        break;
                    default:
                        if(choice!=0)
                        Console.WriteLine("Enter a valid choice !!!!");
                        break;
                }  
            }while (choice != 0);
        }
    }
}