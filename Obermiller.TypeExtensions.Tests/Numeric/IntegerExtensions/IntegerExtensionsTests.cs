using Xunit;

namespace Obermiller.TypeExtensions.Tests.Numeric.IntegerExtensions;

public partial class IntegerExtensionsTests
{
	#region SplitToArray

	[Fact]
	public void SplitToArray_Empty_Empty() => Assert.Empty(TypeExtensions.Numeric.IntegerExtensions.SplitToArray(string.Empty, string.Empty));
	
	[Fact]
	public void SplitToArray_NoDelimiter_Empty() => Assert.Empty(TypeExtensions.Numeric.IntegerExtensions.SplitToArray(Commas, string.Empty));
	
	[Fact]
	public void SplitToArray_InconsistentInput_Empty() => Assert.Empty(TypeExtensions.Numeric.IntegerExtensions.SplitToArray(Inconsistent, string.Empty));
	
	[Fact]
	public void SplitToArray_Single_Splits() => Assert.Equal(new[] { 1 }, TypeExtensions.Numeric.IntegerExtensions.SplitToArray(One, string.Empty));
	
	[Fact]
	public void SplitToArray_Commas_Splits() => Assert.Equal(ExpectedArray, TypeExtensions.Numeric.IntegerExtensions.SplitToArray(Commas, ","));

	[Fact]
	public void SplitToArray_CommaSpaces_Splits() => Assert.Equal(ExpectedArray, TypeExtensions.Numeric.IntegerExtensions.SplitToArray(CommaSpaces, ", "));
	
	[Fact]
	public void SplitToArray_Pipes_Splits() => Assert.Equal(ExpectedArray, TypeExtensions.Numeric.IntegerExtensions.SplitToArray(Pipes, "|"));

	#endregion

	#region SplitToList

	[Fact]
	public void SplitToList_Empty_Empty() => Assert.Empty(TypeExtensions.Numeric.IntegerExtensions.SplitToList(string.Empty, string.Empty));
	
	[Fact]
	public void SplitToList_NoDelimiter_Empty() => Assert.Empty(TypeExtensions.Numeric.IntegerExtensions.SplitToList(Commas, string.Empty));
	
	[Fact]
	public void SplitToList_InconsistentInput_Empty() => Assert.Empty(TypeExtensions.Numeric.IntegerExtensions.SplitToList(Inconsistent, string.Empty));
	
	[Fact]
	public void SplitToList_Single_Splits() => Assert.Equal(new List<int> { 1 }, TypeExtensions.Numeric.IntegerExtensions.SplitToList(One, string.Empty));
	
	[Fact]
	public void SplitToList_Commas_Splits() => Assert.Equal(ExpectedList, TypeExtensions.Numeric.IntegerExtensions.SplitToList(Commas, ","));

	[Fact]
	public void SplitToList_CommaSpaces_Splits() => Assert.Equal(ExpectedList, TypeExtensions.Numeric.IntegerExtensions.SplitToList(CommaSpaces, ", "));
	
	[Fact]
	public void SplitToList_Pipes_Splits() => Assert.Equal(ExpectedList, TypeExtensions.Numeric.IntegerExtensions.SplitToList(Pipes, "|"));

	#endregion
}