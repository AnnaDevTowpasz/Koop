using Koop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Koop.Domain.ValueObjects
{
    public class OrderName : ValueObject
    {
        public DateTime OrderDate { get; set; }

        public override string ToString()
        {
            Calendar cal = new CultureInfo("pl-PL").Calendar;
            int week = cal.GetWeekOfYear(OrderDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            
            return $"{OrderDate.DayOfWeek} {OrderDate.ToShortDateString()}, Tydzień {week}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return OrderDate;
        }
    }
}
