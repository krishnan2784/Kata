using System;
using System.Globalization;

namespace Kata.Domain
{
    public class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            return $"{seconds / 3600:d2}:{seconds / 60 % 60:d2}:{seconds % 60:d2}";
        }
    }
}