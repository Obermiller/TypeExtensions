namespace TypeExtensions.String;

public static class StringExtensions
{
    private static readonly Random Random = new();
    
    public static string CommaJoin(this IEnumerable<string> x) => string.Join(", ", x);
    
    public static bool EqualsIgnoreCase(this string x, string y) => string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
    
    public static string GenerateRandomAlphaNumeric(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Range(0, length)
            .Select(_ => chars[Random.Next(chars.Length)])
            .ToArray());
    }
}