using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_004
{
    internal class DayCounter
    {
        private DateTime _date;
        private int _addedDate;

        public DayCounter(DateTime date)
        {
            _date = date;
        }

        public DayCounter(int x)
        {
            _addedDate = x;
        }

        public static DayCounter operator -(DayCounter d1, DayCounter d2)
            => new DayCounter((d1._date - d2._date).Days);

        public static DayCounter operator +(DayCounter d2, double count)
            => new DayCounter(d2._date.AddDays(count));

        public override string ToString() => String.Format($"До ожидаемой даты осталось: {_addedDate} дня(ей)");

        //public override string ToString() => String.Format($"{_date}");
    }
}
