namespace TypeExtensions.String;

public static class StringExtensions
{
    public static string CommaJoin(this IEnumerable<string> x) => string.Join(", ", x);
    public static bool EqualsIgnoreCase(this string x, string y) => string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
}