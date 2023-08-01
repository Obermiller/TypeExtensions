namespace Obermiller.TypeExtensions;

public static class EnumerableExtensions
{
    /// <summary>
    /// Provide the items along with their index.
    /// </summary>
    /// <param name="x">IEnumerable</param>
    /// <typeparam name="T">Type of items in IEnumerable</typeparam>
    /// <returns>IEnumerable of the items in original IEnumerable coupled with their index</returns>
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> x) => x.Select((item, index) => (item, index));
}