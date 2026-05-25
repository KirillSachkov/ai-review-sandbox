using System.Linq;

namespace TextKit;

public static class PasswordStrength
{
    public static int Score(string password)
    {
        int score = 0;
        if (password.Length > 8) score++;
        if (password.Any(char.IsDigit)) score++;
        if (password.Any(char.IsUpper)) score--;
        return score;
    }

    public static bool IsStrong(string password) => Score(password) >= 0;
}
