using TypeExtensions.String;

namespace TypeExtensions.Tests.String;

[TestFixture]
public class StringExtensionTests
{
    [Test]
    [TestCase(new string[] { }, "")]
    [TestCase(new[] { "1" }, "1")]
    [TestCase(new[] { "1", "2" }, "1, 2")]
    [TestCase(new[] { "1", "2", "3" }, "1, 2, 3")]
    [TestCase(new[] { "1", "2", "3", "4" }, "1, 2, 3, 4")]
    [TestCase(new[] { "1", "2", "3", "4", "5" }, "1, 2, 3, 4, 5")]
    public void TestCommaJoin(IEnumerable<string> collection, string expectedResult) => Assert.That(collection.CommaJoin(), Is.EqualTo(expectedResult));
    
    [Test]
    [TestCase("Cleveland Browns", "Cleveland Browns")]
    [TestCase("Warrior", "warrior")]
    [TestCase("Spongebob Squarepants", "SpOnGeBoB sQuArEpAnTs")]
    public void TestEqualsIgnoreCase(string x, string y) => Assert.That(x.EqualsIgnoreCase(y), Is.True);

    [Test]
    [TestCase("Cleveland", "Cleveland Browns")]
    public void TestNotEqualsIgnoreCase(string x, string y) => Assert.That(x.EqualsIgnoreCase(y), Is.False);

    [Test]
    [TestCase(1)]
    [TestCase(5)]
    [TestCase(10)]
    [TestCase(50)]
    public void TestGenerateRandomAlphaNumeric(int length)
    {
        var randomAlphaNumeric = StringExtensions.GenerateRandomAlphaNumeric(length);

        Assert.That(length, Is.EqualTo(randomAlphaNumeric.Length));
    }
}