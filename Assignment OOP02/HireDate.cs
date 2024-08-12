using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP02
{
    public class HireDate
    {


        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public HireDate(HireDate hireDate)
        {
            Day = hireDate.Day;
            Month = hireDate.Month;
            Year = hireDate.Year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public static HireDate CreateHiringDate()
        {
            string input;
            int day,month, year;

            do
            {
                Console.Write("Enter Day of hirig Date: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out day));

            do
            {
                Console.Write("Enter Month of hirig Date: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out month));

            do
            {
                Console.Write("Enter Year of hirig Date: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out year));

            return new HireDate(day, month, year);
        } 

        public static bool CompartHiringDate(HireDate left, HireDate right)
        {
            if(left.Year >  right.Year)
            {
                return true;
            }else if(left.Year < right.Year)
            {
                return false;
            }else if(left.Month > right.Month)
            {
                return true;
            }else if (left.Month < right.Month)
            {
                return false;
            }else if(left.Day >  right.Day)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
