using System;
using System.Linq;

namespace TimeTimePeriod.Lib
{
    public struct Time : IComparable<Time>, IEquatable<Time>
    {
        #region Parameters

        public byte Hours { get; set; }
        public byte Minutes { get; set; }
        public byte Seconds { get; set; }

        #endregion

        #region Constructors

        public Time(byte hours, byte minutes, byte seconds)
        {
            if (hours >= 24 || minutes >= 60 || seconds >= 60)
                throw new ArgumentException("Zbyt duża wartość któregoś z argumentów");

            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time(byte hours, byte minutes)
        {
            if (hours >= 24 || minutes >= 60)
                throw new ArgumentException("Zbyt duża wartość któregoś z argumentów");

            Hours = hours;
            Minutes = minutes;
            Seconds = 0;
        }

        public Time(byte hours)
        {
            if (hours >= 24)
                throw new ArgumentException("Zbyt duża wartość argumentu");

            Hours = hours;
            Minutes = 0;
            Seconds = 0;
        }

        public Time(string other)
        {
            string[] times = other.Split(':');

            if (times[0].All(char.IsDigit) && times[1].All(char.IsDigit) && times[2].All(char.IsDigit))
            {
                Hours = byte.Parse(times[0]);
                Minutes = byte.Parse(times[1]);
                Seconds = byte.Parse(times[2]);

                if (Hours < 0 || Minutes < 0 || Seconds < 0)
                    throw new ArgumentException("Punkt w czasie nie może być ujemny.");

                if (Hours >= 24 || Minutes >= 60 || Seconds >= 60)
                    throw new ArgumentException("Zbyt duża wartość któregoś z argumentów.");
            }
            else
                throw new ArgumentException("Nieprawidłowy ciąg znaków.");
        }

        #endregion

        #region Operators overloads

        public static bool operator ==(Time timeOne, Time timetwo)
        {
            return timeOne.Equals(timetwo);
        }

        public static bool operator !=(Time timeOne, Time timetwo)
        {
            return !timeOne.Equals(timetwo);
        }

        public static bool operator <(Time timeOne, Time timetwo) => timeOne.CompareTo(timetwo) < 0;

        public static bool operator >(Time timeOne, Time timetwo) => timeOne.CompareTo(timetwo) > 0;

        public static bool operator >=(Time timeOne, Time timetwo) => timeOne.CompareTo(timetwo) >= 0;

        public static bool operator <=(Time timeOne, Time timetwo) => timeOne.CompareTo(timetwo) <= 0;

        public static Time operator -(Time timeOne, Time timetwo)
        {
            long timeTwoSec = timetwo.ConvertToSeconds();
            long timeOneSec = timeOne.ConvertToSeconds();

            if (timeOneSec < timeTwoSec)
            {
                throw new ArgumentException("Moment w czasie nie może być ujemny.");
            }

            long result = (timeOneSec - timeTwoSec);

            long hours = (result / 3600);
            long minutes = (result - (hours * 3600)) / 60;
            long seconds = (result - ((hours * 3600) + (minutes * 60)));

            return new Time(hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString());
        }

        public static Time operator +(Time timeOne, Time timetwo)
        {
            long timeTwoSec = timetwo.ConvertToSeconds();
            long timeOneSec = timeOne.ConvertToSeconds();

            long result = (timeOneSec + timeTwoSec);

            long hours = (result / 3600);
            long minutes = (result - (hours * 3600)) / 60;
            long seconds = (result - ((hours * 3600) + (minutes * 60)));

            return new Time(hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString());
        }

        #endregion

        #region Public Methods


        /// <summary>
        /// Generates string from Time object.
        /// </summary>
        public override string ToString()
        {
            string hoursText, minutesText, secondsText;

            if (Hours < 10) hoursText = "0" + Hours.ToString() + ":";
            else hoursText = Hours.ToString() + ":";

            if (Minutes < 10) minutesText = "0" + Minutes.ToString() + ":";
            else minutesText = Minutes.ToString() + ":";

            if (Seconds < 10) secondsText = "0" + Seconds.ToString();
            else secondsText = Seconds.ToString();

            return (hoursText + minutesText + secondsText);


        }

        /// <summary>
        /// Converts Time object to Second, returns long.
        /// </summary>
        public long ConvertToSeconds()
        {
            return (Hours * 3600) + (Minutes * 60) + Seconds;
        }

        #endregion

        #region Interface Methods Implementation

        public int CompareTo(Time other)
        {
            if (Hours == other.Hours && Minutes == other.Minutes)
                return Seconds.CompareTo(other.Seconds);

            else if (Hours == other.Hours)
                return Minutes.CompareTo(other.Minutes);

            else
                return Hours.CompareTo(other.Hours);
        }

        public bool Equals(Time other)
        {
            if (Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds)
                return true;
            else
                return false;
        }

        #endregion
    }
}
