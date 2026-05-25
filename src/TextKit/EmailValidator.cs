using System.Text.RegularExpressions;

namespace TextKit;

public static class EmailValidator
{
    public static bool IsValid(string email)
    {
        var rx = new Regex(".+@.+");
        return rx.IsMatch(email);
    }
}
