using EmployeeOOP.Exceptions;


namespace EmployeeOOP.Classes
{
    public class Date
    {
        #region Fields
        private int _year;
        private int _month;
        private int _day; // 06/05/2023
        #endregion

        #region Methods
        public Date(int day, int month, int year) //ctor generar constructor
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day, month, year);
        }

        private int ValidateDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            else
            {
                throw new DayException(String.Format("El dia {0} no es válido para el mes {1}.", day, month));
            }
        }

        private void IsLeapYearException(bool isLeapYear, int year)
        {
            if (!isLeapYear)
            {
                throw new YearException(String.Format("El año {0} no es bisiesto.", year));
            }

        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                throw new YearException(String.Format("El año {0} no es válido.", year));
            }

        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12) //month 13
            {
                return month;
            }
            else
            {
                throw new MonthException(String.Format("El mes {0} no es válido.", month));
            }
        }

        public override string ToString()
        {
            //dia/mes/año
            //var dateConcatenated1 = _day + "/" + _month + "/" + _year; //la mas vieja y fea  
            //var dateConcatenated2 = $"{_day}/{_month}/{_year}";
            var dateConcatenated3 = String.Format("{0}{1}{2}", _day, _month, _year);

            return dateConcatenated3;
        }
        #endregion
    }
}
