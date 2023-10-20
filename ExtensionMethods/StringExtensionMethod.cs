using System;
namespace ExtensionMethods
{
	public static class StringExtensionMethod
	{
		public static string Shift(this string s, int shift)
		{
			if (string.IsNullOrEmpty(s))
			{
				return "";
			}

			int length = s.Length;
			shift = shift % length;

            if (shift == 0)
            {
                return s;
            }
			else if (shift > 0)
			{
				return s.Substring(length - shift) + s.Substring(0, length - shift);
			}
			else
			{
				return s.Substring(-shift) + s.Substring(0, -shift);
			}
		}

		public static int Age(this DateTime dt, DateTime date)
		{
			if (dt > date)
			{
				return 0;
			}


			int age = date.Year - dt.Year;

			return age;
		}
	}
}

