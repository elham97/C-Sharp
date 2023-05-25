namespace Enum
{
     
    

        public enum Months
        {
            NotSet = 0,
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        static void Main(string[] args)
        {
            Months months = Months.March;
            Console.WriteLine(months);

            Months months2 = Months.March;
            Console.WriteLine((int)months2);
        }
    }
 