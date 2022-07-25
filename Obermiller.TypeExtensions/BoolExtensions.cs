namespace Obermiller.TypeExtensions;

public static class BoolExtensions
{
    public static bool FromYesNo(this string x) => x.ToLowerInvariant() == "yes";

    public static bool FromYN(this string x) => x.ToLowerInvariant() == "y";
    
    public static string ToYesNo(this bool x) => x ? "Yes" : "No";
    
    public static string ToYN(this bool x) => x ? "Y" : "N";
}