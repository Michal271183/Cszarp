using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _WorkFramework;

namespace BootProject
{
    public class Program : BaseClass
    {
        static void Main(string[] args)
        {
            BaseClass oNowaInstancjaKlasy = new BaseClass();
            int wynik = oNowaInstancjaKlasy.Dodawanie(2, 2);
            Console.WriteLine("wynik: " +wynik);

            
            var today = DateTime.Today;
            var month1 = new DateTime(today.Year, today.Month, 1);
            //var month = new DateTime(2018,01,1);
            var firstDayPreviousMonth = month1.AddMonths(-1).ToString("yyyy.MM.dd");
            var lastDayPreviusMonth = month1.AddDays(-1).ToString("yyyy.MM.dd");
            int iDaysAtMonth = DateTime.DaysInMonth(today.Year, today.Month);

            //znalzalem na:
            //https://stackoverflow.com/questions/591752/get-the-previous-months-first-and-last-day-dates-in-c-sharp
        }
    }
}
