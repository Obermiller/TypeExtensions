using System.Text.RegularExpressions;

namespace Obermiller.TypeExtensions;

public static class StringExtensions
{
    private static readonly Random Random = new();

    /// <summary>
    /// Join an enumerable of strings with ", "
    /// </summary>
    /// <param name="x">Collection of strings</param>
    /// <typeparam name="T">Type of members in IEnumerable</typeparam>
    /// <returns>String of elements joined by ", "</returns>
    public static string CommaJoin<T>(this IEnumerable<T> x) => string.Join(", ", x);
    
    /// <summary>
    /// Checks if a string equals another while ignoring casing.
    /// </summary>
    /// <param name="x">String to check</param>
    /// <param name="y">String to check against</param>
    /// <returns>Boolean based off equality</returns>
    public static bool EqualsIgnoreCase(this string x, string y) => string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
    
    /// <summary>
    /// Creates a random string of capital letters and numbers
    /// </summary>
    /// <param name="length">Length of string to be generated</param>
    /// <returns>A randomized string of capital letters and numbers</returns>
    public static string GenerateRandomAlphaNumeric(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Range(0, length)
            .Select(_ => chars[Random.Next(chars.Length)])
            .ToArray());
    }
    
    /// <summary>
    /// Sanitize a file name for browser download
    /// </summary>
    /// <param name="fileName">String to be sanitized</param>
    /// <returns>Sanitized string to utilize as file name for browser download</returns>
    public static string SanitizeFilename(this string fileName)
    {
        var invalidString = $"[{Regex.Escape(new string(Path.GetInvalidFileNameChars()))}]+";
        return Regex.Replace(fileName, invalidString, "_").Replace(";", "").Replace(",", "");
    }
    
    /// <summary>
    /// Take a delimited string and split it to an array of generic type.
    /// </summary>
    /// <param name="x">Delimited string</param>
    /// <param name="delimiter">String to split on</param>
    /// <typeparam name="T">Type to return in array</typeparam>
    /// <returns>Array of split string cast to determined type</returns>
    public static T[] SplitToArray<T>(this string x, string delimiter)
    {
        var splitString = x.Split(delimiter);
        var array = new T[splitString.Length];
        
        foreach (var split in splitString.WithIndex())
        {
            try
            {
                var parsedItem = (T)Convert.ChangeType(split.item, typeof(T));
                array[split.index] = parsedItem;
            }
            catch (Exception)
            {
                return Array.Empty<T>();
            }
        }

        return array;
    }
    
    /// <summary>
    /// Take a delimited string and split it to a generic collection of generic type.
    /// </summary>
    /// <param name="x">Delimited string</param>
    /// <param name="delimiter">String to split on</param>
    /// <typeparam name="TCollection">Collection to return</typeparam>
    /// <typeparam name="T">Type to return in collection</typeparam>
    /// <returns>Collection of split string cast to determined type</returns>
    public static TCollection SplitToCollection<TCollection, T>(this string x, string delimiter)
        where TCollection : ICollection<T>, new()
    {
        var splitString = x.Split(delimiter);
        var collection = new TCollection();
        
        foreach (var split in splitString)
        {
            try
            {
                var parsedItem = (T)Convert.ChangeType(split, typeof(T));
                collection.Add(parsedItem);
            }
            catch (Exception)
            {
                return new TCollection();
            }
        }

        return collection;
    }

    #region SplitToCollection - Hardtypes

    /// <summary>
    /// Take a delimited string and split it to a HashSet of generic type.
    /// </summary>
    /// <param name="x">Delimited string</param>
    /// <param name="delimiter">String to split on</param>
    /// <typeparam name="T">Type to return in HashSet</typeparam>
    /// <returns>HashSet of split string cast to determined type</returns>
    public static HashSet<T> SplitToHashSet<T>(this string x, string delimiter) => x.SplitToCollection<HashSet<T>, T>(delimiter);
    
    /// <summary>
    /// Take a delimited string and split it to a List of generic type.
    /// </summary>
    /// <param name="x">Delimited string</param>
    /// <param name="delimiter">String to split on</param>
    /// <typeparam name="T">Type to return in List</typeparam>
    /// <returns>List of split string cast to determined type</returns>
    public static List<T> SplitToList<T>(this string x, string delimiter) => x.SplitToCollection<List<T>, T>(delimiter);

    #endregion
}