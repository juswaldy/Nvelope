﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nvelope
{
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Rounding conversion of TimeSpan to Years
        /// </summary>
        public static int RoundToYears(this TimeSpan source)
        {
            return (source.TotalDays / 365).ConvertTo<decimal>().RoundTo().ConvertTo<int>();
        }
    }
}
