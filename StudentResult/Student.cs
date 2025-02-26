namespace StudentResult
{
    class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        static decimal AverageMarks;
        public decimal CalculateAverageMarks()
        {
            AverageMarks = Marks.Average();
            return AverageMarks;
        }
        public string CalculateGrade(decimal marks)
        {
            string grade;
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
