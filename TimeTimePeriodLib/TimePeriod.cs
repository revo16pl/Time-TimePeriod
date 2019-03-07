using System;
using System.Linq;

namespace TimeTimePeriod.Lib
{
    public struct TimePeriod : IEquatable<TimePeriod>, IComparable<TimePeriod>
    {
        #region Parameters

        private long PeriodOfTime { get; }

        #endregion

        #region Constructors

        public TimePeriod(int hours, byte minutes, byte seconds)
        {
            if (hours < 0 || minutes < 0 || seconds < 0)
                throw new ArgumentException("Przedział czasu nie może być ujemny.");

            PeriodOfTime = (hours * 3600) + (minutes * 60) + seconds;
        }

        public TimePeriod(int hours, byte minutes)
        {
            if (hours < 0 || minutes < 0)
                throw new ArgumentException("Przedział czasu nie może być ujemny.");

            PeriodOfTime = (hours * 3600) + (minutes * 60);
        }

        public TimePeriod(long seconds)
        {
            if (seconds < 0)
                throw new ArgumentException("Przedział czasu nie może być ujemny.");

            PeriodOfTime = seconds;
        }

        public TimePeriod(Time timeOne, Time timeTwo)
        {
            Time TimeCalculated = timeOne - timeTwo;

            PeriodOfTime = TimeCalculated.ConvertToSeconds();
        }

        public TimePeriod(string other)
        {
            string[] times = other.Split(':');
            if (times[0].All(char.IsDigit) && times[1].All(char.IsDigit) && times[2].All(char.IsDigit))
            {
                long hours = long.Parse(times[0]);
                long minutes = long.Parse(times[1]);
                long seconds = long.Parse(times[2]);

                if (minutes >= 60 || seconds >= 60)
                    throw new ArgumentException("Zbyt duża wartość któregoś z argumentów");

                PeriodOfTime = (hours * 3600) + (minutes * 60) + seconds;
            }
            else
                throw new ArgumentException("Nieprawidłowy ciąg znaków");
        }

        #endregion

        #region Public Methods


        /// <summary>
        /// Returns string from TimePeriod object
        /// </summary>
        public override string ToString()
        {
            string hoursText, minutesText, secondsText;

            long hours = (PeriodOfTime / 3600);
            long minutes = (PeriodOfTime - (hours * 3600)) / 60;
            long seconds = (PeriodOfTime - ((hours * 3600) + (minutes * 60)));

            if (hours < 10) hoursText = "0" + hours.ToString() + ":";
            else hoursText = hours.ToString() + ":";

            if (minutes < 10) minutesText = "0" + minutes.ToString() + ":";
            else minutesText = minutes.ToString() + ":";

            if (seconds < 10) secondsText = "0" + seconds.ToString();
            else secondsText = seconds.ToString();

            return (hoursText + minutesText + secondsText);
        }

        /// <summary>
        /// Sums the two TimePeriod objects and return new one
        /// </summary>
        public TimePeriod Plus(TimePeriod other)
        {
            return new TimePeriod(PeriodOfTime + other.PeriodOfTime);
        }

        /// <summary>
        /// Sums the two TimePeriod objects and return new one
        /// </summary>
        public static TimePeriod Plus(TimePeriod periodOne, TimePeriod periodTwo)
        {
            return new TimePeriod(periodOne.PeriodOfTime + periodTwo.PeriodOfTime);
        }

        #endregion

        #region Operators overloads

        public static bool operator ==(TimePeriod periodOne, TimePeriod periodTwo) => periodOne.Equals(periodTwo);

        public static bool operator !=(TimePeriod periodOne, TimePeriod periodTwo) => !periodOne.Equals(periodTwo);

        public static bool operator <(TimePeriod periodOne, TimePeriod periodTwo) => periodOne.CompareTo(periodTwo) < 0;

        public static bool operator >(TimePeriod periodOne, TimePeriod periodTwo) => periodOne.CompareTo(periodTwo) > 0;

        public static bool operator <=(TimePeriod periodOne, TimePeriod periodTwo) => periodOne.CompareTo(periodTwo) <= 0;

        public static bool operator >=(TimePeriod periodOne, TimePeriod periodTwo) => periodOne.CompareTo(periodTwo) >= 0;

        public static TimePeriod operator +(TimePeriod periodOne, TimePeriod periodTwo)
        {
            return new TimePeriod(periodOne.PeriodOfTime + periodTwo.PeriodOfTime);
        }

        #endregion

        #region Interface Methods Implementation

        public bool Equals(TimePeriod other)
        {
            if (PeriodOfTime == other.PeriodOfTime)
                return true;
            else
                return false;
        }

        public int CompareTo(TimePeriod other)
        {
            return PeriodOfTime.CompareTo(other.PeriodOfTime);
        }

        #endregion
    }
}
