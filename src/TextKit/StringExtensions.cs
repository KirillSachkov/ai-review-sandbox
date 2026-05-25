namespace TextKit;

/// <summary>Small text helpers used across the catalog.</summary>
public static class StringExtensions
{
    public static bool HasText(this string? value) => !string.IsNullOrWhiteSpace(value);
}
