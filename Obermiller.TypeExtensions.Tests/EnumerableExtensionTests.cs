namespace Obermiller.TypeExtensions.Tests;

[TestFixture]
public class EnumerableExtensionTests
{
    private static readonly object[] SourceLists = 
    {
        new object[] { new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 } },
        new object[] { new List<string> { "blue", "red", "purple", "green", "purple" } }
    };
    
    [Test]
    [TestCaseSource(nameof(SourceLists))]
    public void WithIndexTest<T>(IEnumerable<T> enumerable)
    {
        var indexed = enumerable.WithIndex().ToArray();

        for (var i = 0; i < indexed.Length; i++)
        {
            Assert.That(indexed[i].index, Is.EqualTo(i));
        }
    }
}