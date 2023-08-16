using Xunit;

namespace Obermiller.TypeExtensions.Tests.ClassExtensions;

public partial class ClassExtensionsTests
{
	#region ToCsvRow

	[Fact]
	public void ToCsvRow_BaseTest_Converts()
	{
		var underTest = BaseTest.ToCsvRow();
		const string expected = "1,Cleveland Browns,1.23,4.56,True,T";
		
		Assert.Equal(expected, underTest);
	}

	[Fact]
	public void ToCsvRow_CommaTest_EscapesComma()
	{
		var underTest = CommaTest.ToCsvRow();
		const string expected = @"1,Bond\, James Bond,1.23,4.56,True,\,";
		
		Assert.Equal(expected, underTest);
	}
	
	[Fact]
	public void ToCsvRow_SlashTest_EscapesSlash()
	{
		var underTest = SlashTest.ToCsvRow();
		const string expected = @"1,and\or,1.23,4.56,True,\";
		
		Assert.Equal(expected, underTest);
	}
	
	[Fact]
	public void ToCsvRow_QuotationTest_EscapesQuotation()
	{
		var underTest = QuotationTest.ToCsvRow();
		const string expected = "1,\"A world without you isn't meant for me\",1.23,4.56,True,\"";
		
		Assert.Equal(expected, underTest);
	}

	#endregion
	
}