using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyCoreLib
{
    public class Analytics
    {
        /// <summary>
        /// Analyzes a list of dates and returns the most popular months sorted by frequency.
        /// </summary>
        /// <param name="dates">List of DateTime objects representing purchase dates.</param>
        /// <returns>List of DateTime objects representing the first day of the most popular months at 00:00.</returns>
        public List<DateTime> PopularMonths(List<DateTime> dates)
        {
            // Temporary list to store tuples of month-start dates and their counts
            var dateTimeWithCounterList = new List<Tuple<DateTime, int>>();

            foreach (DateTime iterDate in dates)
            {
                // Calculate the first day of the month for the current date
                var dateMonthStart = new DateTime(iterDate.Year, iterDate.Month, 1, 0, 0, 0);

                // Find index of the month-start date in the list
                var index = dateTimeWithCounterList.FindIndex(item => item.Item1 == dateMonthStart);

                if (index == -1)
                {
                    // Add new entry for the month if it doesn't exist
                    dateTimeWithCounterList.Add(new Tuple<DateTime, int>(dateMonthStart, 1));
                }
                else
                {
                    // Update the count for the existing month
                    dateTimeWithCounterList[index] = Tuple.Create(dateTimeWithCounterList[index].Item1, dateTimeWithCounterList[index].Item2 + 1);
                }
            }

            // Return the sorted list of months by popularity and date
            return dateTimeWithCounterList
                .OrderByDescending(item => item.Item2) // Sort by popularity (descending)
                .ThenBy(item => item.Item1) // Sort by date (ascending) in case of ties
                .Select(item => item.Item1) // Select only the date part
                .ToList();
        }
    }
}
