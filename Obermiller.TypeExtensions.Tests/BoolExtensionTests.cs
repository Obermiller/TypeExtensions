namespace Obermiller.TypeExtensions.Tests;

[TestFixture]
public class BoolExtensionTests
{
    [Test]
    [TestCase("yes")]
    [TestCase("Yes")]
    [TestCase("yEs")]
    [TestCase("yeS")]
    [TestCase("YEs")]
    [TestCase("YeS")]
    [TestCase("yES")]
    [TestCase("YES")]
    public void TestFromYesNoTrue(string x) => Assert.That(x.FromYesNo(), Is.EqualTo(true));
    
    [Test]
    [TestCase("no")]
    [TestCase("No")]
    [TestCase("nO")]
    [TestCase("NO")]
    [TestCase("blue")]
    [TestCase("purple")]
    [TestCase("Anything but some version of yes")]
    public void TestFromYesNoFalse(string x) => Assert.That(x.FromYesNo(), Is.EqualTo(false));
    
    [Test]
    [TestCase("y")]
    [TestCase("Y")]
    public void TestFromYNTrue(string x) => Assert.That(x.FromYN(), Is.EqualTo(true));
    
    [Test]
    [TestCase("n")]
    [TestCase("N")]
    [TestCase("yes")]
    [TestCase("red")]
    [TestCase("yellow")]
    [TestCase("Anything but some version of y")]
    public void TestFromYNFalse(string x) => Assert.That(x.FromYN(), Is.EqualTo(false));
    
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void TestToYesNo(bool x) => Assert.That(x ? "Yes" : "No", Is.EqualTo(x.ToYesNo()));
    
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void TestToYN(bool x) => Assert.That(x ? "Y" : "N", Is.EqualTo(x.ToYN()));
}