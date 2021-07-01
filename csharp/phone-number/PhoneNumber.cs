using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var digits = Regex.Replace(phoneNumber, "[^0-9]", "");
        digits = digits.StartsWith("1") ? digits[1..] : digits;
        if (digits.Length != 10
            || "01".Contains(digits[0])
            || "01".Contains(digits[3]))
            throw new ArgumentException();
        return digits;
    }
}