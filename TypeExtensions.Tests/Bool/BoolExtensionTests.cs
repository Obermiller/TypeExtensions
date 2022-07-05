using TypeExtensions.Bool;

namespace TypeExtensions.Tests.Bool;

[TestFixture]
public class BoolExtensionTests
{
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void ToYesNo(bool x) => Assert.That(x ? "Yes" : "No", Is.EqualTo(x.ToYesNo()));
    
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void ToYN(bool x) => Assert.That(x ? "Y" : "N", Is.EqualTo(x.ToYN()));
}