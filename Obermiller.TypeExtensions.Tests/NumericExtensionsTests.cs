namespace Obermiller.TypeExtensions.Tests;

[TestFixture]
public class NumericExtensionsTests
{
    [Test]
    [TestCase("1,2,3", ",", new[] { 1, 2, 3 })]
    [TestCase("23|325|437673743|3", "|", new[] { 23, 325, 437673743, 3 })]
    [TestCase("1, 2, 3,4", ", ", new int[] { })]
    public void SplitToIntArrayTest(string toBeParsed, string delimiter, int[] expectedResult) => Assert.That(NumericExtensions.SplitToIntArray(toBeParsed, delimiter), Is.EqualTo(expectedResult));
}