namespace Obermiller.TypeExtensions;

public static class BoolExtensions
{
    /// <summary>
    /// Generate bool from int value.
    /// </summary>
    /// <param name="x">Int to be analyzed</param>
    /// <returns>Bool keyed on 1</returns>
    public static bool FromOneZero(this int x) => x == 1;

    /// <summary>
    /// Generate int from bool value.
    /// </summary>
    /// <param name="x">Bool to be analyzed</param>
    /// <returns>1 or 0</returns>
    public static int ToOneZero(this bool x) => x ? 1 : 0;
    
    /// <summary>
    /// Generate bool from string value.
    /// Casts to lower invariant.
    /// </summary>
    /// <param name="x">String to be analyzed</param>
    /// <returns>Bool keyed on "yes"</returns>
    public static bool FromYesNo(this string x) => x.ToLowerInvariant() == "yes";

    /// <summary>
    /// Generate bool from string value.
    /// Casts to lower invariant.
    /// </summary>
    /// <param name="x">String to be analyzed</param>
    /// <returns>Bool keyed on "y"</returns>
    public static bool FromYN(this string x) => x.ToLowerInvariant() == "y";
    
    /// <summary>
    /// Generate Yes or No from bool value.
    /// </summary>
    /// <param name="x">Bool to be analyzed</param>
    /// <returns>"Yes" or "No"</returns>
    public static string ToYesNo(this bool x) => x ? "Yes" : "No";
    
    /// <summary>
    /// Generate Y or N from bool value.
    /// </summary>
    /// <param name="x">Bool to be analyzed</param>
    /// <returns>"Y" or "N"</returns>
    public static string ToYN(this bool x) => x ? "Y" : "N";
}