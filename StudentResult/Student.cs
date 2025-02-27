namespace StudentResult
{
    // Student class 
    class Student
    {
        // Fields of Student class
        public string Name;
        public decimal[] Marks = new decimal[5];
        static decimal AverageMarks;
        // Method to calculate average marks that returns decimal 
        public decimal CalculateAverageMarks()
        {
            AverageMarks = Marks.Average();
            return AverageMarks;
        }
        // Method to calculate grade which takes decimal marks as arugments
        public string CalculateGrade(decimal marks)
        {
            string grade;
            // switch case to determine grade
            switch (marks)
            {
                case > 90:
                    grade = "A";
                    break;
                case > 80:
                    grade = "B";
                    break;
                case > 70:
                    grade = "C";
                    break;
                case < 70:
                    grade = "D";
                    break;
                default:
                    grade = "";
                    break;
            }
            return grade;
        }
    }
}
