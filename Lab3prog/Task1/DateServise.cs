using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DateServise
    {
        public string GetDay(string date)
        {
            string[] dmy = date.Split(new char[] { '.' });

            int d = Convert.ToInt32(dmy[0]);
            int m = Convert.ToInt32(dmy[1]);
            int y = Convert.ToInt32(dmy[2]);

            int a = (14 - m) / 12;
            int b = y - a;
            int c = m + 12 * a - 2;

            int dayofweek = (7000 + (d + b + b / 4 - b / 100 + b / 400 + (31 * c) / 12)) % 7;

            string day = "";
            switch(dayofweek)
            {
                case 0:
                    day = "Воскресенье";
                    break;
                case 1:
                    day = "Понедельник";
                    break;
                case 2:
                    day = "Вторник";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Пятница";
                    break;
                case 6:
                    day = "Суббота";
                    break;

            }

            return day;

        }

        public int DateInDays(int day, int month, int year)
        {
            int res1 = day + (month > 2 ? year - 1 : --year) * 365 + year / 4 - year / 100 + year / 400;

            while (month != 0)
            {
                switch (month - 1)
                {
                    case 12:
                        res1 += 31;
                        break;
                    case 11:
                        res1 += 30;
                        break;
                    case 10:
                        res1 += 31;
                        break;
                    case 9:
                        res1 += 30;
                        break;
                    case 8:
                        res1 += 31;
                        break;
                    case 7:
                        res1 += 31;
                        break;
                    case 6:
                        res1 += 30;
                        break;
                    case 5:
                        res1 += 31;
                        break;
                    case 4:
                        res1 += 30;
                        break;
                    case 3:
                        res1 += 31;
                        break;
                    case 2:
                        res1 += 28;
                        break;
                    case 1:
                        res1 += 31;
                        break;
                }

                month--;
            }

            return res1;
        }

        public int GetDaysSpan(int day, int month, int year)
        {
            DateTime dt = DateTime.Now;
            string curDate = dt.ToShortDateString();

            string[] curdmy = curDate.Split(new char[] { '.' });

            int curd = Convert.ToInt32(curdmy[0]);
            int curm = Convert.ToInt32(curdmy[1]);
            int cury = Convert.ToInt32(curdmy[2]);

            return DateInDays(day, month, year) - DateInDays(curd, curm, cury);
        }
    }
}
