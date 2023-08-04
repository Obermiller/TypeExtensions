using System.Text.RegularExpressions;
using Xunit;

namespace Obermiller.TypeExtensions.Tests.StringExtensions;

public partial class StringExtensionsTests
{
	#region CommaJoin

	[Fact]
	public void CommaJoin_Empty_Empty() => Assert.Empty(Empty.CommaJoin());

	[Fact]
	public void CommaJoin_LengthOne_Equal() => Assert.Equal("1", LengthOne.CommaJoin());
	
	[Fact]
	public void CommaJoin_LengthTwo_Joins() => Assert.Equal("1, 2", LengthTwo.CommaJoin());
	
	[Fact]
	public void CommaJoin_LengthThree_Joins() => Assert.Equal("1, 2, 3", LengthThree.CommaJoin());

	[Fact]
	public void CommaJoin_NonString_Joins() => Assert.Equal("1, 2, 3", ExpectedList.CommaJoin());

	#endregion

	#region EqualsIgnoreCase

	[Fact]
	public void EqualsIgnoreCase_Same_True() => Assert.True(ClevelandBrowns.EqualsIgnoreCase(ClevelandBrowns));

	[Fact]
	public void EqualsIgnoreCase_ToLower_True() => Assert.True(ClevelandBrowns.EqualsIgnoreCase(ClevelandBrowns.ToLower()));
	
	[Fact]
	public void EqualsIgnoreCase_ToUpper_True() => Assert.True(ClevelandBrowns.EqualsIgnoreCase(ClevelandBrowns.ToUpper()));
	
	[Fact]
	public void EqualsIgnoreCase_Different_False() => Assert.False(ClevelandBrowns.EqualsIgnoreCase("Baltimore Ravens"));

	#endregion

	#region GenerateRandomAlphaNumeric

	[Fact]
	public void GenerateRandomAlphaNumeric_LengthZero_Empty()
	{
		var underTest = TypeExtensions.StringExtensions.GenerateRandomAlphaNumeric(0);
		
		Assert.Equal(string.Empty, underTest);
	}
	
	[Fact]
	public void GenerateRandomAlphaNumeric_One_EqualLength()
	{
		var underTest = TypeExtensions.StringExtensions.GenerateRandomAlphaNumeric(1);
		
		Assert.Equal(1, underTest.Length);
	}
	
	[Fact]
	public void GenerateRandomAlphaNumeric_OneHundred_EqualLength()
	{
		var underTest = TypeExtensions.StringExtensions.GenerateRandomAlphaNumeric(100);
		
		Assert.Equal(100, underTest.Length);
	}
	
	[Fact]
	public void GenerateRandomAlphaNumeric_IsAlphaNumeric_True()
	{
		var underTest = TypeExtensions.StringExtensions.GenerateRandomAlphaNumeric(100);
		var regex = new Regex("^[A-Z0-9]*$");
		
		Assert.Matches(regex, underTest);
	}

	#endregion
	
	#region SplitToArray

	[Fact]
	public void SplitToArray_Empty_Empty() => Assert.Empty(string.Empty.SplitToArray<int>(string.Empty));
	
	[Fact]
	public void SplitToArray_NoDelimiter_Empty() => Assert.Empty(Commas.SplitToArray<int>(string.Empty));
	
	[Fact]
	public void SplitToArray_InconsistentInput_Empty() => Assert.Empty(Inconsistent.SplitToArray<int>(string.Empty));
	
	[Fact]
	public void SplitToArray_Single_Splits() => Assert.Equal(new[] { 1 }, One.SplitToArray<int>(string.Empty));
	
	[Fact]
	public void SplitToArray_Commas_Splits() => Assert.Equal(ExpectedArray, Commas.SplitToArray<int>(","));

	[Fact]
	public void SplitToArray_CommaSpaces_Splits() => Assert.Equal(ExpectedArray, CommaSpaces.SplitToArray<int>(", "));
	
	[Fact]
	public void SplitToArray_Pipes_Splits() => Assert.Equal(ExpectedArray, Pipes.SplitToArray<int>("|"));

	#endregion

	#region SplitToCollection

	[Fact]
	public void SplitToCollection_Empty_Empty() => Assert.Empty(string.Empty.SplitToCollection<List<int>, int>(string.Empty));
	
	[Fact]
	public void SplitToCollection_NoDelimiter_Empty() => Assert.Empty(Commas.SplitToCollection<List<int>, int>(string.Empty));
	
	[Fact]
	public void SplitToCollection_InconsistentInput_Empty() => Assert.Empty(Inconsistent.SplitToCollection<List<int>, int>(string.Empty));
	
	[Fact]
	public void SplitToCollection_Single_Splits() => Assert.Equal(new List<int> { 1 }, One.SplitToCollection<List<int>, int>(string.Empty));
	
	[Fact]
	public void SplitToCollection_Commas_Splits() => Assert.Equal(ExpectedList, Commas.SplitToCollection<List<int>, int>(","));

	[Fact]
	public void SplitToCollection_CommaSpaces_Splits() => Assert.Equal(ExpectedList, CommaSpaces.SplitToCollection<List<int>, int>(", "));
	
	[Fact]
	public void SplitToCollection_Pipes_Splits() => Assert.Equal(ExpectedList, Pipes.SplitToCollection<List<int>, int>("|"));

	#endregion

	#region SplitToHashSet

	[Fact]
	public void SplitToHashSet_Commas_ReturnsHashSet() => Assert.IsType<HashSet<int>>(Commas.SplitToHashSet<int>(","));

	#endregion
	
	#region SplitToList

	[Fact]
	public void SplitToList_Commas_ReturnsList() => Assert.IsType<List<int>>(Commas.SplitToList<int>(","));

	#endregion
}