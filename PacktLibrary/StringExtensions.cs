using System.Text.RegularExpressions;

namespace Packt.Shared;

public static class StringExtensions 
    // Adding static here and this in the methods tell the compiler to treat
    // the method as one that extends the string type
{
    public static bool IsValidEmail(this string input)
    {
        // Use simple regular expression to check
        // that the input string is a valid email.
        return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+"); // some string + @ + some string
    }
}