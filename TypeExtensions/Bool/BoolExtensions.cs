namespace TypeExtensions.Bool;

public static class BoolExtensions
{
    public static string ToYesNo(this bool x) => x ? "Yes" : "No";
    
    public static string ToYN(this bool x) => x ? "Y" : "N";
}