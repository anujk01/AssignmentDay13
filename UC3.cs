using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentDay13
{
    public class UC3
    {
        public static string MaximumString(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0 ||
                firststring.CompareTo(secondstring) >= 0 && firststring.CompareTo(thirdstring) > 0 ||
                firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) >= 0)
            {
                return firststring;
            }

            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0 ||
                secondstring.CompareTo(firststring) >= 0 && secondstring.CompareTo(thirdstring) > 0 ||
                secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) >= 0)
            {
                return secondstring;
            }

            if (thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) > 0 ||
                thirdstring.CompareTo(firststring) >= 0 && thirdstring.CompareTo(secondstring) > 0 ||
                thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) >= 0)
            {
                return thirdstring;
            }
            return default;
        }
    }
}