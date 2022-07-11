using TypeExtensions.Bool;

namespace TypeExtensions.Tests.Bool;

[TestFixture]
public class BoolExtensionTests
{
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void TestToYesNo(bool x) => Assert.That(x ? "Yes" : "No", Is.EqualTo(x.ToYesNo()));
    
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void TestToYN(bool x) => Assert.That(x ? "Y" : "N", Is.EqualTo(x.ToYN()));
}