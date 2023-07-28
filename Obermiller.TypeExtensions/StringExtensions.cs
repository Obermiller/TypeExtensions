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
}