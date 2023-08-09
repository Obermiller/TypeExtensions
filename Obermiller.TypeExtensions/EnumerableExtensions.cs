using System.Text;

namespace Obermiller.TypeExtensions;

public static class EnumerableExtensions
{
    /// <summary>
    /// Joins an IEnumerable to a string delimited by a custom value
    /// </summary>
    /// <param name="x">IEnumerable to be joined</param>
    /// <param name="delimiter">Delimiter to use between elements</param>
    /// <typeparam name="T">Generic type of elements in IEnumerable</typeparam>
    /// <returns></returns>
    public static string JoinToString<T>(this IEnumerable<T> x, string delimiter)
    {
        try
        {
            var joined = new StringBuilder().AppendJoin(delimiter, x);
            return joined.ToString();
        }
        catch (Exception)
        {
            return string.Empty;
        }
    }
    
    /// <summary>
    /// Provide the items along with their index.
    /// </summary>
    /// <param name="x">IEnumerable</param>
    /// <typeparam name="T">Type of items in IEnumerable</typeparam>
    /// <returns>IEnumerable of the items in original IEnumerable coupled with their index</returns>
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> x) => x.Select((item, index) => (item, index));
}