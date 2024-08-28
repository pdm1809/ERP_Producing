﻿using SampleProject.Shared.Constants;
using System;

namespace SampleProject.Shared.Extensions
{
    public static class DateTimeExtension
    {
        public static DateTime ConvertVNTimeToUtc(this DateTime dateTime)
        {
            return DateTime.SpecifyKind(dateTime.AddHours(-Common.VietnamTimeZoneOffset), DateTimeKind.Utc);
        }

        public static DateTime ConvertUtcToVNTime(this DateTime dateTime)
        {
            return DateTime.SpecifyKind(dateTime.AddHours(Common.VietnamTimeZoneOffset), DateTimeKind.Local);
        }
    }
}
