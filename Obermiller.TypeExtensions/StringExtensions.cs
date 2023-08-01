namespace Obermiller.TypeExtensions;

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