namespace StudentResult
{
    // Enum to determine the avaialable options in menu
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }
    // Class Program 
    class Program
    {
        // main method to create objects and execute methods
        static void Main(string[] args)
        {
            // student object to store marks and grade it
            Student student1 = new Student();
            // choice varaible to store users latest choice
            int choice;
            // Tag for invalid name
            NameInput:
            // Taking input for student name
            Console.Write("Enter student name : ");
            student1.Name = Console.ReadLine();
            // Check for invalid name and calling tag if it is invalid
            if (student1.Name == "")
            {
                Console.WriteLine("\tEnter a valid name. ");
                goto NameInput;
            }
            // Taking input for student marks
            Console.WriteLine("Enter student marks : ");
            for (int i = 0; i < student1.Marks.Length; i++)
            {
                // Tag for invalid marks
            MarksInput:
                Console.Write($"Enter marks of subject {i + 1} : ");
                string mark = Console.ReadLine();
                // Check if entered string can be converted to decimal
                if (decimal.TryParse(mark, out _))
                {
                    student1.Marks[i] = Convert.ToDecimal(mark);
                    // Check for marks not between 0-100
                    if((student1.Marks[i] <0 ) || (student1.Marks[i] > 100))
                    {
                        Console.WriteLine("\tEnter marks between 0-100.");
                        goto MarksInput;
                    }
                }
                else
                {
                    Console.WriteLine("\tEnter valid marks.");
                    goto MarksInput;
                }
            }
            // Loop to ask user choice 
            do{
                // Printing user menu and asking for choice 
                Console.Write($"\n\t1 - Aggregate: Displays the Name: Average marks \r\n\t2 - MinMark: Displays the minimum marks of the student\r\n\t3 - " +
                    $"MaximumMark: Displays the maximum mark\r\n\t4 - Grade: Displays grade\r\n\t0 - Exit Application\n Enter choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                // Switch case to handle different choices
                switch ((Options)choice)
                {
                    // Aggregate case to calculate average marks
                    case Options.Aggregate:
                        Console.WriteLine($"\n\tAverage marks of {student1.Name} : {student1.CalculateAverageMarks()}");
                        break;
                    // MinMark case to get minimum marks
                    case Options.MinMark:
                        Console.WriteLine($"\n\tMinimum marks of {student1.Name} : {student1.Marks.Min()}");
                        break;
                    // MaximumMark case to get maximum marks.
                    case Options.MaximumMark:
                        Console.WriteLine($"\n\tMaximum marks of {student1.Name} : {student1.Marks.Max()}");
                        break;
                    // Grade case to grade average marks
                    case Options.Grade:
                        Console.WriteLine($"\n\tGrade of {student1.Name} : {student1.CalculateGrade(student1.CalculateAverageMarks())}");
                        break;
                    // Default case to handle exit and false choice 
                    default:
                        if(choice!=0)
                        Console.WriteLine("\n\tEnter a valid choice.");
                        break;
                }  
            }while (choice != 0);
        }
    }
}