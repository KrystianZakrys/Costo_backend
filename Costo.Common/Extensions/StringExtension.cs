using System;
using System.Collections.Generic;
using System.Text;

namespace Costo.Common.Extensions
{
    public static class StringExtension
    {
        public static T ParseEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
