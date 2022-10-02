using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateAndTime
{
    internal class App
    {
        public void Run()
        {
            Datum7();

        }
        public void Datum1()
        {
            var currentDateAndTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            var currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            Console.WriteLine($"Complete date: {currentDateAndTime}");
            Console.WriteLine($"Short date: {currentDate}");

        }
        public void Datum2()
        {
            var currentDateAndTime = DateTime.Now;            
            Console.WriteLine($@"Year = {currentDateAndTime.Year} 
Month = {currentDateAndTime.Month}
Day = {currentDateAndTime.Day}
Hours = {currentDateAndTime.Hour}
Minutes = {currentDateAndTime.Minute}
Seconds = {currentDateAndTime.Second}
Milliseconds = {currentDateAndTime.Millisecond}");

            var svMonthName = "";
            switch (currentDateAndTime.Month)
            {
                case 1:
                    svMonthName = "Januari";
                    break;
                case 2:
                    svMonthName = "Februari";
                    break;
                case 3:
                    svMonthName = "Mars";
                    break;
                case 4:
                    svMonthName = "April";
                    break;
                case 5:
                    svMonthName = "Maj";
                    break;
                case 6:
                    svMonthName = "Juni";
                    break;
                case 7:
                    svMonthName = "Juli";
                    break;
                case 8:
                    svMonthName = "Augusti";
                    break;
                case 9:
                    svMonthName = "September";
                    break;
                case 10:
                    svMonthName = "Oktober";
                    break;
                case 11:
                    svMonthName = "November";
                    break;
                case 12:
                    svMonthName = "December";
                    break;
            }
            Console.WriteLine($"Månad Namn: {svMonthName}");

            var svDayName = "";
            switch (currentDateAndTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    svDayName = "Måndag";
                    break;
                case DayOfWeek.Tuesday:
                    svDayName = "Tisdag";
                    break;
                case DayOfWeek.Wednesday:
                    svDayName = "Onsdag";
                    break;
                case DayOfWeek.Thursday:
                    svDayName = "Torsdag";
                    break;
                case DayOfWeek.Friday:
                    svDayName = "Fredag";
                    break;
                case DayOfWeek.Saturday:
                    svDayName = "Lördag";
                    break;
                case DayOfWeek.Sunday:
                    svDayName = "Söndag";
                    break;
            }
            Console.WriteLine($"Dag Namn: {svDayName}");
        }
        public void Datum3()
        {
            var Date = DateTime.Now;

            var svDayName = "";
            switch (Date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    svDayName = "Måndag";
                    break;
                case DayOfWeek.Tuesday:
                    svDayName = "Tisdag";
                    break;
                case DayOfWeek.Wednesday:
                    svDayName = "Onsdag";
                    break;
                case DayOfWeek.Thursday:
                    svDayName = "Torsdag";
                    break;
                case DayOfWeek.Friday:
                    svDayName = "Fredag";
                    break;
                case DayOfWeek.Saturday:
                    svDayName = "Lördag";
                    break;
                case DayOfWeek.Sunday:
                    svDayName = "Söndag";
                    break;
            }
            var svMonthName = "";
            switch (Date.Month)
            {
                case 1:
                    svMonthName = "Januari";
                    break;
                case 2:
                    svMonthName = "Februari";
                    break;
                case 3:
                    svMonthName = "Mars";
                    break;
                case 4:
                    svMonthName = "April";
                    break;
                case 5:
                    svMonthName = "Maj";
                    break;
                case 6:
                    svMonthName = "Juni";
                    break;
                case 7:
                    svMonthName = "Juli";
                    break;
                case 8:
                    svMonthName = "Augusti";
                    break;
                case 9:
                    svMonthName = "September";
                    break;
                case 10:
                    svMonthName = "Oktober";
                    break;
                case 11:
                    svMonthName = "November";
                    break;
                case 12:
                    svMonthName = "December";
                    break;
            }

            Console.WriteLine($"Idag är {svDayName} {Date.Day} {svMonthName} {Date.Year}");
            Console.Write("Lägg till några dagar: ");
            var addMoreDays = int.Parse(Console.ReadLine());
            var newDate = Date.AddDays(addMoreDays);

            var svensk = new CultureInfo("sv-SE");
            Console.WriteLine($"Idag är {newDate.ToString("dddd", svensk)} {newDate.Day} {newDate.ToString("MMMM", svensk)} {newDate.Year}");

        }
        public void Datum4()
        {
            Console.WriteLine("Ange datum (format: yyyy-mm-dd): ");
            var input = Console.ReadLine();
            Console.WriteLine(DateTime.ParseExact(input, "yyyy-mm-dd", CultureInfo.InvariantCulture));
        }
        public void Datum5()
        {
            Console.Write("Mata in år: ");
            var inputYear = int.Parse(Console.ReadLine());
            
            Console.Write("Mata in månad: ");
            var inputMonth = int.Parse(Console.ReadLine());
                                    
            Console.WriteLine(DateTime.DaysInMonth(inputYear, inputMonth));
        }
        public void Datum6()
        {
            Console.Write($"Mata in datum 1 (yyyy-MM-dd): ");
            var date1 = DateTime.Parse(Console.ReadLine());
            Console.Write($"Mata in datum 2 (yyyy-MM-dd): ");
            var date2 = DateTime.Parse(Console.ReadLine());
            
            if(date1 > date2)
            {
                Console.WriteLine((date1 - date2).TotalDays);                
            }
            else if(date2 > date1)
            {
                Console.WriteLine((date2 - date1).TotalDays);
            }            
        }
        public void Datum7()
        {
            var today = DateTime.Now.Date;

            Console.Write("Mata in År: ");
            var inputYear = int.Parse(Console.ReadLine());
            Console.Write("Mata in Månad: ");
            var inputMonth = int.Parse(Console.ReadLine());
            Console.Write("Mata in Dag: ");
            var inputDay = int.Parse(Console.ReadLine());

            var inputDate = new DateTime(inputYear, inputMonth, inputDay);

            if (inputDate == today.Date)
            {
                Console.WriteLine("Detta är idag");
            }
            else
            {
                Console.WriteLine("Detta är inte idag");
            }
        }
    }
}
    
