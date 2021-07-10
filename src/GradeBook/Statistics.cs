using System;

namespace GradeBook
{
    public class Statistics
    {
        public Statistics()
        {
            High = double.MinValue;
            Low = double.MaxValue;
            Sum = 0.0;
            Count = 0;
        }

        public void Add(double number)
        {
            Sum += number;
            Count++;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch (Average)
                {   
                    case var aGrade when aGrade >= 90.0:
                        return 'A';
                    case var bGrade when bGrade >= 80.0:
                        return 'B';
                    case var cGrade when cGrade >= 70.0:
                        return 'C';
                    case var dGrade when dGrade >= 60.0:
                        return 'D';
                    default:
                        return'F';
                }
            }
        }
        public double Sum;
        public int Count;
    }
}